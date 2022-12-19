using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.GameServer.Packet.Recorder.Model;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Packet.Recorder
{
    internal class WebsocketHandler
    {
        public static WebSocket WebSocket { get; private set; }

        private const int bufferSize = 1024*4;

        public static readonly Encoding _encoding = Encoding.Default;

        public async Task HandleAsync(HttpContext context)
        {
            if (context.WebSockets.IsWebSocketRequest)
            {
                WebSocket = await context.WebSockets.AcceptWebSocketAsync();

                await HandleWS(WebSocket);
            }
            else
            {
                context.Response.Redirect("/records/index.html");
            }
        }

        public async Task HandleWS(WebSocket WebSocket)
        {
            Logger.DebugWriteLine("WebSocket connected!");

            while (WebSocket.State == WebSocketState.Open)
            {
                var buffer = new byte[bufferSize];
                await WebSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

                var data = JsonConvert.DeserializeObject<FrontedReq>(_encoding.GetString(buffer));

            }
        }

    }
}
