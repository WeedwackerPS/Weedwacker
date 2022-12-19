using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weedwacker.GameServer.Packet.Recorder
{
    internal class PacketRecorder
    {
        public void Start(string WebRoot)
        {
            string WR = Path.GetFullPath(WebRoot);
            var builder = WebApplication.CreateBuilder();
            builder.Services.AddControllers();
            var app = builder.Build();
            var webSocketOptions = new WebSocketOptions
            {
                KeepAliveInterval = TimeSpan.FromMinutes(2)
            };
            app.UseWebSockets(webSocketOptions);

            app.MapGet("/", new WebsocketHandler().HandleAsync);
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(WR),
                RequestPath = "/records"
            });

            Task.Run(() =>
            {
                app.Run("http://localhost:40510");

            });

        }


    }
}
