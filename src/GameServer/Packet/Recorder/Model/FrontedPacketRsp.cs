using Google.Protobuf;
using Google.Protobuf.Reflection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Packet.Recorder.Model
{
    internal class FrontedPacketRsp
    {
        public FrontedPacketRsp(IMessage packet,string protoName,long length,string id, bool fromCilent, string cmd = "PacketNotify")
        {
            try
            {
                var rec = new PacketRecord(packet);
                rec.protoName = protoName;
                //rec.length = length;
                rec.packetID = id;

                rec.source = fromCilent;

                this.data = new PacketRecord[] { rec };
                this.cmd = cmd;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string cmd { get; set; }

        public IEnumerable<PacketRecord> data { get; set; }



        public async Task Send()
        {

            Encoding _encoding = Encoding.Default;

            var ws = WebsocketHandler.WebSocket;

            if (ws.State == System.Net.WebSockets.WebSocketState.Open)
            {
                await ws.SendAsync(
                    new ArraySegment<byte>(_encoding.GetBytes(JsonConvert.SerializeObject(this))),
                        WebSocketMessageType.Text,
                        WebSocketMessageFlags.EndOfMessage
                        , CancellationToken.None);
            }
            else
            {
                Logger.DebugWriteLine("WebSocket is closed");
            }
        }
    }

    public class PacketRecord
    {
        public PacketRecord(object obj)
        {
            this.obj = obj;
        }


        public string protoName { get; set; }

        public string packetID { get; set; }

        public byte[]? packet { get; set; }

        public bool source { get; set; }

        [JsonProperty("object")]
        public Object obj { get; set; }
    }
}
