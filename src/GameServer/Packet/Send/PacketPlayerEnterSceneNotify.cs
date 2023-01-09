using System.Numerics;
using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;
using EnterReason = Weedwacker.GameServer.Enums.EnterReason;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPlayerEnterSceneNotify : BasePacket
    {
        public PacketPlayerEnterSceneNotify(Player target, EnterType type, EnterReason reason, Scene newScene, Vector3 newPos, uint prevSceneId = default, Vector3 prevPos = default) : base(OpCode.PlayerEnterSceneNotify)
        {
            target.SceneLoadState = SceneLoadState.LOADING;
            Random rand = new();
            target.EnterSceneToken = (uint)rand.Next(1000, 99999);

            PlayerEnterSceneNotify proto = new PlayerEnterSceneNotify()
            {
                SceneId = newScene.SceneId,
                Pos = new() { X = newPos.X, Y = newPos.Y, Z = newPos.Z },
                SceneBeginTime = (ulong)DateTimeOffset.Now.ToUnixTimeMilliseconds(),
                Type = type,
                TargetUid = target.GameUid,
                EnterSceneToken = target.EnterSceneToken,
                WorldLevel = (uint)target.World.WorldLevel, // we need to use the world level of the world the player is in, NOT their own world level
                EnterReason = (uint)reason,
                WorldType = 1,
                SceneTransaction = newScene.SceneId + "-" + target.GameUid + "-" + (int)(DateTimeOffset.Now.ToUnixTimeMilliseconds() / 1000) + "-" + 18402
            };

            if (newScene.DungeonData != null) proto.DungeonId = newScene.DungeonData.id;
            if (reason == EnterReason.Login) proto.IsFirstLoginEnterScene = true;
            if (prevSceneId != default)
            {
                proto.PrevSceneId = prevSceneId;
                proto.PrevPos = new() { X = prevPos.X, Y = prevPos.Y, Z = prevPos.Z };
            }
            //TODO SkipUI and SceneTagList

            Data = proto.ToByteArray();
        }
    }
}