using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using System.Text;
using Weedwacker.Shared.Authentication;
using Weedwacker.Shared.Utils;
using Weedwacker.WebServer.Authentication.Objects;
using Weedwacker.WebServer.Database;

namespace Weedwacker.WebServer.Authentication
{

    /// <summary>
    /// Handles the authentication request from the username and password form.
    /// </summary>
    public class PasswordAuthenticator : IAuthenticator<LoginResultJson>
    {
        public async Task<LoginResultJson> Authenticate(AuthenticationRequest request)
        {
            var response = new LoginResultJson();

            var requestData = request.PasswordRequest;

            bool successfulLogin = false;
            string address = request.Context.Connection.RemoteIpAddress.ToString();
            string responseMessage = "Username not found.";
            string loggerMessage = "";
            string decryptedPasswordMd5 = "";

            if (WebServer.Configuration.Server.Account.UsePassword)
            {
                decryptedPasswordMd5 = Crypto.GetPasswordHash(requestData.password);
            }

            // Get account from database.
            Account? account = await DatabaseManager.GetAccountByNameAsync(requestData.account);
            if (WebServer.Configuration.Server.Account.MaxAccount <= -1)
            {
                // Check if account exists.
                if (account == null && WebServer.Configuration.Server.Account.AutoCreate)
                {
                    // This account has been created AUTOMATICALLY. There will be no permissions added.
                    if (WebServer.Configuration.Server.Account.UsePassword)
                    {
                        account = DatabaseManager.CreateAccountWithUid(requestData.account, decryptedPasswordMd5, "0");
                    }
                    else
                    {
                        account = DatabaseManager.CreateAccountWithUid(requestData.account, "", "0");
                    }

                    // Check if the account was created successfully.
                    if (account == null)
                    {
                        responseMessage = "Username not found, create failed.";
                        Logger.WriteLine($"Client {address} failed to log in: Account create failed.");
                    }
                    else
                    {
                        // Continue with login.
                        successfulLogin = true;

                        // Log the creation.
                        Logger.WriteLine($"Client {address} succeessfully logged in: Account {response.data.account.uid} created.");
                    }
                }
                else if (account != null)
                {
                    if (!WebServer.Configuration.Server.Account.UsePassword)
                    {
                        successfulLogin = true;
                    }
                    else if (string.IsNullOrEmpty(account.Password))
                    {
                        account.Password = decryptedPasswordMd5;
                        DatabaseManager.SaveAccount(account);
                        successfulLogin = true;

                    }
                    else
                    {
                        if (decryptedPasswordMd5 == account.Password)
                        {
                            successfulLogin = true;
                        }
                        else
                        {
                            successfulLogin = false;
                            responseMessage = "Incorrect password!";
                        }
                    }
                }
                else
                    loggerMessage = $"Client {address} failed to log in: Account not found.";
            }
            else
            {
                responseMessage = "Max account limit reached, create failed";
                loggerMessage = $"Client {address} failed to log in: Max account limit reached";
            }

            // Set response data.
            if (successfulLogin)
            {
                response.message = "OK";
                response.data.account.uid = account.Id;
                response.data.account.token = await account.GenerateSessionKey();
                response.data.account.email = account.Email;

                loggerMessage = $"Client {address} logged in as {account.Id}.";
            }
            else
            {
                response.retcode = -201;
                response.message = responseMessage;

            }
            Logger.WriteLine(loggerMessage);

            return response;
        }
    }

    /// <summary>
    /// Handles the authentication request from the game when using a game token.
    /// </summary>
    public class GameTokenAuthenticator : IAuthenticator<LoginResultJson>
    {
        public async Task<LoginResultJson> Authenticate(AuthenticationRequest request)
        {
            var response = new LoginResultJson();

            var requestData = request.TokenRequest;

            bool successfulLogin;
            string address = request.Context.Connection.RemoteIpAddress.ToString();
            string loggerMessage;

            // Log the attempt.
            Logger.WriteLine($"Verifying session key from {address}");

            // Get account from database.
            Account? account = await DatabaseManager.GetAccountByIdAsync(requestData.uid);

            // Check if account exists/token is valid.
            successfulLogin = account != null && account.Token.Equals(requestData.token);

            // Set response data.
            if (successfulLogin)
            {
                response.message = "OK";
                response.data.account.uid = account.Id.ToString();
                response.data.account.token = account.Token;
                response.data.account.email = account.Email;

                // Log the login.
                loggerMessage = $"Successfully Verified session key for uid: {requestData.uid}";
            }
            else
            {
                response.retcode = -111;
                response.message = "Game account cache information error.";
                response.data = null;

                // Log the failure.
                loggerMessage = $"failed verify token from: {address}.";
            }



            Logger.WriteLine(loggerMessage);
            return response;
        }
    }

    /// <summary>
    /// Handles the authentication request from the game when using a registry token.
    /// </summary>
    public class TokenAuthenticator : IAuthenticator<LoginResultJson>
    {
        public async Task<LoginResultJson> Authenticate(AuthenticationRequest request)
        {
            var response = new LoginResultJson();

            var requestData = request.TokenRequest;

            bool successfulLogin;
            string address = request.Context.Connection.RemoteIpAddress.ToString();
            string loggerMessage;

            // Log the attempt.
            Logger.WriteLine($"Verifying session key from {address}");



            // Get account from database.
            Account? account = await DatabaseManager.GetAccountByIdAsync(requestData.uid);

            // Check if account exists/token is valid.
            successfulLogin = account != null && account.SessionKey.Equals(requestData.token);

            // Set response data.
            if (successfulLogin)
            {
                response.message = "OK";
                response.data.account.uid = account.Id.ToString();
                response.data.account.token = account.SessionKey;
                response.data.account.email = account.Email;

                // Log the login.
                loggerMessage = $"Successfully Verified session key for uid: {requestData.uid}";
            }
            else
            {
                response.retcode = -111;
                response.message = "Game account cache information error.";
                response.data = null;

                // Log the failure.
                loggerMessage = $"failed verify token from: {address}.";
            }



            Logger.WriteLine(loggerMessage);
            return response;
        }
    }

    /// <summary>
    /// Handles the authentication request from the game when using a combo token/session key.
    /// </summary>
    public class SessionKeyAuthenticator : IAuthenticator<ComboTokenResJson>
    {
        public async Task<ComboTokenResJson> Authenticate(AuthenticationRequest request)
        {
            var response = new ComboTokenResJson();

            var requestData = request.SessionKeyRequest;
            var loginData = request.SessionKeyData;

            bool successfulLogin;
            string address = request.Context.Connection.RemoteIpAddress.ToString();
            string loggerMessage;

            if (WebServer.Configuration.Server.Account.MaxAccount <= -1)
            {
                // Get account from database.
                Account? account = await DatabaseManager.GetAccountByIdAsync(loginData.uid);

                // Check if account exists/token is valid.
                successfulLogin = account != null && account.SessionKey.Equals(loginData.token);

                // Set response data.
                if (successfulLogin)
                {
                    response.message = "OK";
                    response.data.open_id = account.Id;
                    response.data.combo_id = "157795300";
                    response.data.combo_token = await account.GenerateLoginToken();

                    // Log the login.
                    loggerMessage = $"Client {address} succeed to exchange combo token.";

                }
                else
                {
                    response.retcode = -201;
                    response.message = "Wrong session key.";

                    // Log the failure.
                    loggerMessage = $"Client {address} failed to exchange combo token.";
                }
            }
            else
            {
                response.retcode = -201;
                response.message = "Max account limit reached, create failed";

                loggerMessage = $"Client {address} failed to log in: Max account limit reached";
            }

            Logger.WriteLine(loggerMessage);
            return response;
        }
    }

    /// <summary>
    /// Handles authentication requests from external sources.
    /// </summary>
    public class ExternalAuthentication : IExternalAuthenticator
    {
        public async Task HandleLogin(AuthenticationRequest request)
        {
            await request.Context.Response.WriteAsync("Authentication is not available with the default authentication method.");
        }

        public async Task HandleAccountCreation(AuthenticationRequest request)
        {
            await request.Context.Response.WriteAsync("Authentication is not available with the default authentication method.");
        }

        public async Task HandlePasswordReset(AuthenticationRequest request)
        {
            await request.Context.Response.WriteAsync("Authentication is not available with the default authentication method.");
        }
    }

    /// <summary>
    /// Handles authentication requests from OAuth sources.Zenlith
    /// </summary>
    public class OAuthAuthentication : IOAuthAuthenticator
    {
        public async Task HandleLogin(AuthenticationRequest request)
        {
            await request.Context.Response.WriteAsync("Authentication is not available with the default authentication method.");
        }

        public async Task HandleRedirection(AuthenticationRequest request, IOAuthAuthenticator.ClientType type)
        {
            await request.Context.Response.WriteAsync("Authentication is not available with the default authentication method.");
        }

        public async Task HandleTokenProcess(AuthenticationRequest request)
        {
            await request.Context.Response.WriteAsync("Authentication is not available with the default authentication method.");
        }
    }
}