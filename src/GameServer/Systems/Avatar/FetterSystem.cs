using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;
using FetterState = Weedwacker.GameServer.Enums.FetterState;

namespace Weedwacker.GameServer.Systems.Avatar
{
    internal class FetterSystem
    {
        public const uint DEFAULT_STATE = (uint)FetterState.NOT_OPEN;
        [BsonIgnore] private Player.Player Owner; // Loaded by DatabaseManager
        [BsonIgnore] private Avatar Avatar; // Loaded by DatabaseManager
        [BsonIgnore] public FetterCharacterCardData CardData => GameServer.AvatarInfo[Avatar.AvatarId].CardData;
        [BsonIgnore] public FetterInfoData FetterInfoData => GameServer.AvatarInfo[Avatar.AvatarId].FetterInfoData; // General info
        [BsonIgnore] public SortedList<int, FetterStoryData> FetterStoryData => GameServer.AvatarInfo[Avatar.AvatarId].FetterStoryData; // fetterId
        [BsonIgnore] public SortedList<int, FettersData> FettersData => GameServer.AvatarInfo[Avatar.AvatarId].FettersData; // fetterId
        [BsonIgnore] public SortedList<int, PhotographPosenameData> PhotographPosenameData => GameServer.AvatarInfo[Avatar.AvatarId].PhotographPosenameData; // fetterId
        [BsonIgnore] public SortedList<int, PhotographExpressionData> PhotographExpressionData => GameServer.AvatarInfo[Avatar.AvatarId].PhotographExpressionData; // fetterId
        [BsonIgnore] public SortedList<int, AvatarFetterLevelData> FetterLevelData => GameData.AvatarFetterLevelDataMap; // level Friendship exp breakpoints
        public int FetterLevel { get; private set; } = 1;
        public int FetterExp { get; private set; } = 0;
        [BsonSerializer(typeof(IntSortedListSerializer<FetterData>))]
        public SortedList<int, FetterData> FetterStates { get; private set; } = new();

        public static Task<FetterSystem> CreateAsync(Avatar avatar, Player.Player owner)
        {
            var ret = new FetterSystem(avatar, owner);
            return ret.InitializeAsync();
        }

        private FetterSystem(Avatar avatar, Player.Player owner)
        {
            Owner = owner;
            Avatar = avatar;

            FetterStates.Add(FetterInfoData.fetterId, new FetterData() { FetterId = (uint)FetterInfoData.fetterId, FetterState = DEFAULT_STATE });
            foreach (FetterStoryData storyData in FetterStoryData.Values)
            {
                FetterStates.Add(storyData.fetterId, new FetterData() { FetterId = (uint)storyData.fetterId, FetterState = DEFAULT_STATE });
            }
            foreach (FettersData fettersData in FettersData.Values)
            {
                FetterStates.Add(fettersData.fetterId, new FetterData() { FetterId = (uint)fettersData.fetterId, FetterState = DEFAULT_STATE });
            }
            foreach (PhotographPosenameData poseData in PhotographPosenameData.Values)
            {
                FetterStates.Add(poseData.fetterId, new FetterData() { FetterId = (uint)poseData.fetterId, FetterState = DEFAULT_STATE });
            }
            foreach (PhotographExpressionData expressionData in PhotographExpressionData.Values)
            {
                FetterStates.Add(expressionData.fetterId, new FetterData() { FetterId = (uint)expressionData.fetterId, FetterState = DEFAULT_STATE });
            }
        }

        public async Task OnLoadAsync(Player.Player owner, Avatar avatar)
        {
            Owner = owner;
            Avatar = avatar;
        }

        private async Task<FetterSystem> InitializeAsync()
        {
            var allFetters = FetterStoryData.Values.Concat<FetterBaseClass>(FettersData.Values).Concat(PhotographPosenameData.Values).Concat(PhotographExpressionData.Values).Append(FetterInfoData);
            var notOpen = allFetters.Where(w => FetterStates[w.fetterId].FetterState == 1);
            foreach (var fetter in notOpen)
            {
                if (fetter.openConds != null)
                    await EvaluateFetterState(fetter, true, false);
                else FetterStates[fetter.fetterId].FetterState++;
            }
            var open = allFetters.Where(w => FetterStates[w.fetterId].FetterState == 2);
            foreach (var fetter in open)
            {
                if (fetter.finishConds != null)
                    await EvaluateFetterState(fetter, false, false);
                else FetterStates[fetter.fetterId].FetterState++;
            }

            return this;
        }

        private async Task<uint> EvaluateFetterState(FetterBaseClass fetter, bool openOrFinish, bool notifyPlayer) // Returns: fetterState
        {
            if (openOrFinish ? fetter.openConds.Length == 0 : fetter.finishConds.Length == 0)
            {
                FetterStates[fetter.fetterId] = new FetterData()
                {
                    FetterId = (uint)fetter.fetterId,
                    FetterState = ++FetterStates[fetter.fetterId].FetterState
                };
            }
            else
            {
                var fetterProto = new FetterData() { FetterId = (uint)fetter.fetterId };
                int resultLength = openOrFinish ? fetter.openConds.Length : fetter.finishConds.Length;
                Task<bool>[] condEvaluation = new Task<bool>[resultLength];
                for (int i = 0; i < resultLength; i++)
                {
                    var cond = openOrFinish ? fetter.openConds[i] : fetter.finishConds[i];
                    condEvaluation[i] = EvaluateFetterCond(fetter.fetterId, cond);
                }
                bool[] condResult = await Task.WhenAll(condEvaluation);
                if (condResult.All(b => b == true))
                {
                    fetterProto.FetterState = ++FetterStates[fetter.fetterId].FetterState;
                    FetterStates[FetterInfoData.fetterId] = fetterProto;
                }
                else
                {
                    if (condResult.Contains(true))
                    {
                        for (uint i = 0; i < condResult.Length; i++)
                        {
                            if (condResult[i])
                            {
                                fetterProto.CondIndexList.Add(i);
                            }
                        }
                        if (notifyPlayer) await Owner.SendPacketAsync(new PacketAvatarFetterDataNotify(Avatar));
                    }
                }
            }
            return FetterStates[fetter.fetterId].FetterState;
        }
        private async Task<bool> EvaluateFetterCond(int fetterId, FetterCond cond)
        {
            switch (cond.condType)
            {
                case FetterCondType.FETTER_COND_NONE:
                    //TODO
                    return false;
                case FetterCondType.FETTER_COND_AVATAR_LEVEL:
                    //TODO
                    return false;
                case FetterCondType.FETTER_COND_AVATAR_PROMOTE_LEVEL:
                    //TODO
                    return false;
                case FetterCondType.FETTER_COND_FETTER_LEVEL:
                    //TODO
                    return false;
                case FetterCondType.FETTER_COND_FINISH_PARENT_QUEST:
                    //TODO
                    return false;
                case FetterCondType.FETTER_COND_FINISH_QUEST:
                    //TODO
                    return false;
                case FetterCondType.FETTER_COND_NOT_OPEN:
                    return FetterStates[fetterId].FetterState == (uint)FetterState.NOT_OPEN;
                case FetterCondType.FETTER_COND_PLAYER_BIRTHDAY:
                    //TODO
                    return false;
                case FetterCondType.FETTER_COND_UNLOCK_TRANS_POINT:
                    //TODO
                    return false;
                default:
                    Logger.WriteErrorLine("Unkown fetter condition: " + cond.condType);
                    return false;
            }
        }
    }
}
