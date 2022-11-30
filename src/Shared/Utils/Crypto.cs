using System.Security.Cryptography;
using System.Text;

namespace Weedwacker.Shared.Utils
{
    public class Crypto
    {

        public static byte[] DISPATCH_KEY;
        public static byte[] DISPATCH_SEED;


        public static byte[] AUTH_KEY;
        public static byte[] ENCRYPT_KEY;
        public static ulong ENCRYPT_SEED = 0x0;
        public static byte[] ENCRYPT_SEED_BUFFER = new byte[0];

        public static RSA Cur3Encryptor = RSA.Create(); //Public key
        public static RSA Cur2Encryptor = RSA.Create(); // Public Key
        public static RSA Cur4Encryptor = RSA.Create();
        public static RSA Cur5Encryptor = RSA.Create();
        public static RSA CurSigner = RSA.Create(); //Private Key

        public static Dictionary<int, RSA> DispatchEncryptionKeys;

        public static void LoadKeys(string path)
        {
            DispatchEncryptionKeys = new();
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            var keypath = Path.Combine(path, "dispatchKey.bin");
            var seedpath = Path.Combine(path, "dispatchSeed.bin");
            var encryptkeypath = Path.Combine(path, "secretKey.bin");
            var encryptseedbufferpath = Path.Combine(path, "secretKeyBuffer.bin");
            var authkeypath = Path.Combine(path, "auth_private-key.pem");
            if (File.Exists(keypath))
                DISPATCH_KEY = File.ReadAllBytes(keypath);
            if (File.Exists(seedpath))
                DISPATCH_SEED = File.ReadAllBytes(seedpath);
            if (File.Exists(encryptkeypath))
                ENCRYPT_KEY = File.ReadAllBytes(encryptkeypath);
            if (File.Exists(encryptseedbufferpath))
                ENCRYPT_SEED_BUFFER = File.ReadAllBytes(encryptseedbufferpath);
            if (File.Exists(authkeypath))
                AUTH_KEY = File.ReadAllBytes(authkeypath);
            try
            {
                Cur3Encryptor.ImportFromPem(File.ReadAllText(path + "3.pem").ToCharArray());
                var OSparams = Cur3Encryptor.ExportParameters(true);
                DispatchEncryptionKeys[3] = Cur3Encryptor;
                Cur2Encryptor.ImportFromPem(File.ReadAllText(path + "2.pem").ToCharArray());
                DispatchEncryptionKeys[2] = Cur2Encryptor;
                Cur4Encryptor.ImportFromPem(File.ReadAllText(path + "4.pem").ToCharArray());
                DispatchEncryptionKeys[4] = Cur4Encryptor;
                Cur5Encryptor.ImportFromPem(File.ReadAllText(path + "5.pem").ToCharArray());
                DispatchEncryptionKeys[5] = Cur5Encryptor;

                CurSigner.ImportFromPem(File.ReadAllText(path + "SigningKey.pem").ToCharArray());
                var signParams = CurSigner.ExportParameters(true);

            }
            catch (Exception e)
            {
                Logger.WriteErrorLine("An error occurred while loading keys.", e);
            }

        }

        public static RSA GetDispatchEncryptionKey(int key)
        {
            return DispatchEncryptionKeys[key];
        }

        public static void Xor(byte[] packet, byte[] key)
        {
            try
            {
                for (int i = 0; i < packet.Length; i++)
                {
                    packet[i] ^= key[i % key.Length];
                }
            }
            catch (Exception e)
            {
                Logger.WriteErrorLine("Crypto error.", e);
            }
        }

        public static byte[] CreateSessionKey(int length)
        {
            return System.Security.Cryptography.RandomNumberGenerator.GetBytes(length);
        }

        public static string GetPasswordHash(string encryptedpwd)
        {

            string decryptedPasswordHash = "";
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            UTF8Encoding ByteConverter = new UTF8Encoding();

            RSA.ImportFromPem(ByteConverter.GetString(Crypto.AUTH_KEY));
            try
            {
                var decryptedpwd = RSA.Decrypt(Convert.FromBase64String(encryptedpwd), false);
                var ret = new MD5CryptoServiceProvider().ComputeHash(
                    decryptedpwd
                    );

                Logger.DebugWriteWarningLine($"decrypted password:{ByteConverter.GetString(decryptedpwd)}");
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < ret.Length; i++)
                {
                    sb.Append(ret[i].ToString("x2"));
                }
                decryptedPasswordHash = sb.ToString();

            }
            catch (Exception ex)
            {
                Logger.WriteErrorLine(ex.Message);
            }
            
            return decryptedPasswordHash;
        }


        // Mersenne Twister 19937 using uint64 instead of uint32. Used to generate the encryption key for the game session
        public class MT19937
        {
            private const ulong N = 312;
            private const ulong M = 156;
            private const ulong MATRIX_A = 0xB5026F5AA96619E9L;
            private const ulong UPPER_MASK = 0xFFFFFFFF80000000;
            private const ulong LOWER_MASK = 0X7FFFFFFFUL;
            private static ulong[] mt = new ulong[N + 1];
            private static ulong mti = N + 1;

            public MT19937(ulong seed)
            {
                this.Seed(seed);
            }

            public void Seed(ulong seed)
            {
                mt[0] = seed;
                for (mti = 1; mti < N; mti++)
                {
                    mt[mti] = (6364136223846793005L * (mt[mti - 1] ^ (mt[mti - 1] >> 62)) + mti);
                }
            }

            public ulong Int63()
            {
                ulong x = 0;
                ulong[] mag01 = new ulong[2] { 0x0UL, MATRIX_A };

                if (mti >= N)
                {
                    ulong kk;
                    if (mti == N + 1)
                    {
                        Seed(5489UL);
                    }
                    for (kk = 0; kk < (N - M); kk++)
                    {
                        x = (mt[kk] & UPPER_MASK) | (mt[kk + 1] & LOWER_MASK);
                        mt[kk] = mt[kk + M] ^ (x >> 1) ^ mag01[x & 0x1UL];
                    }
                    for (; kk < N - 1; kk++)
                    {
                        x = (mt[kk] & UPPER_MASK) | (mt[kk + 1] & LOWER_MASK);
                        mt[kk] = mt[kk - M] ^ (x >> 1) ^ mag01[x & 0x1UL];
                    }
                    x = (mt[N - 1] & UPPER_MASK) | (mt[0] & LOWER_MASK);
                    mt[N - 1] = mt[M - 1] ^ (x >> 1) ^ mag01[x & 0x1UL];

                    mti = 0;
                }

                x = mt[mti++];
                x ^= (x >> 29) & 0x5555555555555555L;
                x ^= (x << 17) & 0x71D67FFFEDA60000L;
                x ^= (x << 37) & 0xFFF7EEE000000000L;
                x ^= (x >> 43);
                return x;
            }

            public ulong IntN(ulong value)
            {
                return Int63() % value;
            }
        }
    }
}
