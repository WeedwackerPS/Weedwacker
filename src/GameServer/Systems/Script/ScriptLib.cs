using NLua;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Script
{
    public static class ScriptLib
    {
        private static string PrintTable(object table_)
        {
            return "";
        }
        public static int SetGadgetStateByConfigId(ScriptLibContext context, int configId, int gadgetState)
        {
            Logger.DebugWriteLine($"[LUA] Call SetGadgetStateByConfigId with {configId},{gadgetState}");
            IEnumerable<ScriptEntity> entities = context.SceneScriptManager.Scene.ScriptEntities.Values.Where(w => w.GetType() == typeof(ScriptGadgetEntity)).Where(s => s.ConfigId == configId);

            if (entities.Any())
            {
                foreach (var entity in entities)
                    (entity as ScriptGadgetEntity).SetGadgetState(gadgetState);
                return 0;
            }
            else
                return 1;
        }

        public static int SetGroupGadgetStateByConfigId(ScriptLibContext context, int groupId, int configId, int gadgetState)
        {
            Logger.DebugWriteLine($"[LUA] Call SetGroupGadgetStateByConfigId with {groupId},{configId},{gadgetState}");

            IEnumerable<ScriptEntity> entities = context.SceneScriptManager.Scene.ScriptEntities.Values.Where(w => w.GroupId == groupId && w is ScriptGadgetEntity);

            if (entities.Any())
            {
                foreach (var entity in entities)
                    (entity as ScriptGadgetEntity).SetGadgetState(gadgetState);
                return 0;
            }
            else
                return 1;
        }

        public static int SetWorktopOptionsByGroupId(ScriptLibContext context, int groupId, int configId, object options)
        {
            var table = options as LuaTable;
            Logger.DebugWriteLine($"[LUA] Call SetWorktopOptionsByGroupId with {groupId},{configId},{PrintTable(table)}");

            IEnumerable<ScriptEntity> entities = context.SceneScriptManager.Scene.ScriptEntities.Values.Where(w => w.GroupId == groupId && w.ConfigId == configId && w is GadgetWorktop);

            if (entities.Any())
            {
                foreach (var entity in entities)
                {
                    //(entity as GadgetWorktop).WorktopOptions(table);
                    //Task.Run(context.SceneScriptManager.Scene.BroadcastPacketAsync(new PacketWorktopOptionNotify(gadget)));
                }
                return 0;
            }
            else
                return 1;
        }

        public static int SetWorktopOptions(ScriptLibContext context, object table)
        {
            Logger.DebugWriteLine($"[LUA] Call SetWorktopOptions with {PrintTable(table)}");
            // TODO
            return 0;
        }
        public static int DelWorktopOptionByGroupId(ScriptLibContext context, int groupId, int configId, int option)
        {
            Logger.DebugWriteLine($"[LUA] Call DelWorktopOptionByGroupId with {groupId},{configId},{option}");

            IEnumerable<ScriptEntity> gadget = context.SceneScriptManager.Scene.ScriptEntities.Values
                    .Where(w => w.ConfigId == configId && w.GroupId == groupId);

            if (!(gadget is GadgetWorktop worktop))
            {
                return 1;
            }

            //worktop.removeWorktopOption(option);
            //context.SceneScriptManager.Scene.BroadcastPacketAsync(new PacketWorktopOptionNotify(gadget));

            return 0;
        }

        // Some fields are guessed
        public static int AutoMonsterTide(ScriptLibContext context, int challengeIndex, int groupId, object ordersConfigId, int tideCount, int sceneLimit, int param6)
        {
            Logger.DebugWriteLine($"[LUA] Call AutoMonsterTide with {challengeIndex},{groupId},{ordersConfigId},{tideCount},{sceneLimit},{param6}");
            //TODO
            return 0;
        }

        public static int AddExtraGroupSuite(ScriptLibContext context, int groupId, int suite)
        {
            Logger.DebugWriteLine($"[LUA] Call AddExtraGroupSuite with {groupId},{suite}");
            //TODO
            return 0;
        }
        public static int GoToGroupSuite(ScriptLibContext context, int groupId, int suite)
        {
            //TODO
            return 0;
        }
        public static int RemoveExtraGroupSuite(ScriptLibContext context, int groupId, int suite)
        {
            Logger.DebugWriteLine($"[LUA] Call RemoveExtraGroupSuite with {groupId},{suite}");

            return context.SceneScriptManager.RemoveGroupSuite(context.CurrentGroup.BlockId, groupId, suite);
        }
        public static int KillExtraGroupSuite(ScriptLibContext context, int groupId, int suite)
        {
            Logger.DebugWriteLine($"[LUA] Call KillExtraGroupSuite with {groupId},{suite}");

            return context.SceneScriptManager.RemoveGroupSuite(context.CurrentGroup.BlockId, groupId, suite);
        }
        // param3 (probably time limit for timed dungeons)
        public static int ActiveChallenge(ScriptLibContext context, int challengeId, int challengeIndex, int timeLimitOrGroupId, int groupId, int objectiveKills, int param5)
        {
            Logger.DebugWriteLine($"[LUA] Call ActiveChallenge with {challengeId},{challengeIndex},{timeLimitOrGroupId},{groupId},{objectiveKills},{param5}");
            //TODO
            return 0;
        }

        public static int GetGroupMonsterCountByGroupId(ScriptLibContext context, int groupId)
        {
            Logger.DebugWriteLine($"[LUA] Call GetGroupMonsterCountByGroupId with {groupId}");
            return context.SceneScriptManager.Scene.ScriptEntities.Values.Where(w => w is MonsterEntity && w.GroupId == groupId).Count();
        }

        public static int GetGroupVariableValue(ScriptLibContext context, string var)
        {
            Logger.DebugWriteLine($"[LUA] Call GetGroupVariableValue with {var}");
            return context.SceneScriptManager.GetGroupVariable(context.CurrentGroup.BlockId, context.CurrentGroup.group_id, var);
        }

        public static int SetGroupVariableValue(ScriptLibContext context, string var, int value)
        {
            Logger.DebugWriteLine($"[LUA] Call SetGroupVariableValue with {var},{value}");
            context.SceneScriptManager.SetGroupVariable(context.CurrentGroup.group_id, var, value);
            return 0;
        }

        public static int ChangeGroupVariableValue(ScriptLibContext context, string var, int value)
        {
            Logger.DebugWriteLine($"[LUA] Call ChangeGroupVariableValue with {var},{value}");
            int oldVal = context.SceneScriptManager.GetGroupVariable(context.CurrentGroup.BlockId, context.CurrentGroup.group_id, var);
            context.SceneScriptManager.SetGroupVariable(context.CurrentGroup.group_id, var, oldVal + value);
            return 0;
        }

        /*
		 * Set the actions and triggers to designated group
		 */
        public static int RefreshGroup(ScriptLibContext context, object table_)
        {
            var table = table_ as LuaTable;
            // Kill and Respawn?
            int groupId = (int)(long)table["group_id"];
            int suite = (int)(long)table["suite"];
            Logger.DebugWriteLine($"[LUA] Call RefreshGroup with {PrintTable(table)}");

            return context.SceneScriptManager.RefreshGroup(groupId, suite);
        }

        public static int GetRegionEntityCount(ScriptLibContext context, object table_)
        {
            var table = table_ as LuaTable;
            int regionId = (int)(long)table["region_eid"];
            int entityType = (int)(long)table["entity_type"];
            Logger.DebugWriteLine($"[LUA] Call GetRegionEntityCount with {PrintTable(table)}");

            //TODO
            return 0;
        }

        public static void PrintContextLog(ScriptLibContext context, string msg)
        {
            Logger.WriteLine("[LUA] " + msg);
        }

        public static int TowerCountTimeStatus(ScriptLibContext context, int isDone)
        {
            Logger.DebugWriteLine($"[LUA] Call TowerCountTimeStatus with {isDone}");
            // TODO record time
            return 0;
        }
        public static int GetGroupMonsterCount(ScriptLibContext context)
        {
            Logger.DebugWriteLine("[LUA] Call GetGroupMonsterCount ");

            return context.SceneScriptManager.Scene.ScriptEntities.Values
                .Where(w => w is MonsterEntity && w.GroupId == context.CurrentGroup.group_id).Count();
        }
        public static int SetMonsterBattleByGroup(ScriptLibContext context, int var1, int var2)
        {
            Logger.DebugWriteLine($"[LUA] Call SetMonsterBattleByGroup with {var1},{var2}");
            // TODO
            return 0;
        }

        public static int CauseDungeonFail(ScriptLibContext context)
        {
            Logger.DebugWriteLine("[LUA] Call CauseDungeonFail.");

            return 0;
        }

        public static int GetGroupVariableValueByGroup(ScriptLibContext context, string name, int groupId)
        {
            Logger.DebugWriteLine($"[LUA] Call GetGroupVariableValueByGroup with {name},{groupId}");

            return context.SceneScriptManager.GetGroupVariable(context.CurrentGroup.BlockId, (uint)groupId, name);
        }

        public static int SetIsAllowUseSkill(ScriptLibContext context, int canUse)
        {
            Logger.DebugWriteLine($"[LUA] Call SetIsAllowUseSkill with {canUse}");

            //context.SceneScriptManager.Scene.BroadcastPacketAsync(new PacketCanUseSkillNotify(canUse == 1));
            return 0;
        }

        public static int KillEntityByConfigId(ScriptLibContext context, object table_)
        {
            var table = table_ as LuaTable;
            var configId = (int)(long)table["config_id"];
            Logger.DebugWriteLine($"[LUA] Call KillEntityByConfigId with {PrintTable(table)}");
            if (configId == null)
            {
                return 1;
            }

            IEnumerable<ScriptEntity> entities = context.SceneScriptManager.Scene.ScriptEntities.Values.Where(w => w.ConfigId == configId);
            if (!entities.Any())
            {
                return 0;
            }
            else
            {
                foreach (var entity in entities)
                {
                    //await context.SceneScriptManager.Scene.KillEntityAsync(entity, 0);
                }
                return 0;
            }
        }

        public static int SetGroupVariableValueByGroup(ScriptLibContext context, string key, int value, int groupId)
        {
            Logger.DebugWriteLine($"[LUA] Call SetGroupVariableValueByGroup with {key},{value},{groupId}");

            context.SceneScriptManager.SetGroupVariable((uint)groupId, key, value);
            return 0;
        }

        public static int CreateMonster(ScriptLibContext context, object table_)
        {
            var table = table_ as LuaTable;
            var configId = (int)(long)table["config_id"];
            var delayTime = (int)(long)table["delay_time"];
            Logger.DebugWriteLine($"[LUA] Call CreateMonster with {PrintTable(table)}");

            if (context.CurrentGroup == null)
            {
                return 1;
            }

            //context.SceneScriptManager.SpawnMonstersByConfigId(context.CurrentGroup, configId, delayTime);
            return 0;
        }

        public static int TowerMirrorTeamSetUp(ScriptLibContext context, int team)
        {
            Logger.DebugWriteLine($"[LUA] Call TowerMirrorTeamSetUp with {team}");
            /*
            context.SceneScriptManager.UnloadCurrentMonsterTide();
            context.SceneScriptManager.Scene.World.Host.TowerManager.MirrorTeamSetUp(team - 1);
            */
            return 0;
        }

        public static int CreateGadget(ScriptLibContext context, object table_)
        {
            var table = table_ as LuaTable;
            var configId = (int)(long)table["config_id"];
            Logger.DebugWriteLine($"[LUA] Call CreateGadget with {PrintTable(table)}");

            var group = context.CurrentGroup;

            if (group == null)
            {
                return 1;
            }

            var gadget = group.gadgets.Where(w => w.Value.config_id == configId).First();
            /*
            var entity = context.SceneScriptManager.CreateGadget(group.group_id, group.BlockId, gadget);
            context.SceneScriptManager.AddEntity(entity);
            */
            return 0;
        }
        public static int CheckRemainGadgetCountByGroupId(ScriptLibContext context, object table_)
        {
            var table = table_ as LuaTable;
            var groupId = (int)(long)table["group_id"];
            Logger.DebugWriteLine($"[LUA] Call CheckRemainGadgetCountByGroupId with {PrintTable(table)}");

            var count = context.SceneScriptManager.Scene.ScriptEntities.Values.Where(w => w is ScriptGadgetEntity gadget && gadget.GroupId == groupId).Count();
            return count;
        }

        public static int GetGadgetStateByConfigId(ScriptLibContext context, int groupId, int configId)
        {
            Logger.DebugWriteLine($"[LUA] Call GetGadgetStateByConfigId with {groupId},{configId}");

            if (groupId == 0)
            {
                groupId = (int)context.CurrentGroup.group_id;
            }
            int realGroupId = groupId;
            var gadget = context.SceneScriptManager.Scene.ScriptEntities.Values
                .Where(w => w is ScriptGadgetEntity gadget && gadget.GroupId == realGroupId && w.ConfigId == configId).FirstOrDefault();
            if (gadget != null)
            {
                return (int)(gadget as ScriptGadgetEntity).State;
            }
            else
                return 1;

        }

        public static int MarkPlayerAction(ScriptLibContext context, int var2, int var3, int var4)
        {
            Logger.DebugWriteLine($"[LUA] Call MarkPlayerAction with {var2},{var3},{var4}");
            //TODO
            return 0;
        }

        public static int AddQuestProgress(ScriptLibContext context, string var1)
        {
            Logger.DebugWriteLine($"[LUA] Call AddQuestProgress with {var1}");
            /*
            foreach (var player in context.SceneScriptManager.Scene.Players)
            {
                player.QuestManager.TriggerEvent(QuestTrigger.QUEST_COND_LUA_NOTIFY, var1, 0, 0, 0, 0);
                player.QuestManager.TriggerEvent(QuestTrigger.QUEST_CONTENT_LUA_NOTIFY, var1); //missing params[1], paramStr and count
            }*/

            return 0;
        }

        /**
         * change the state of gadget
         */
        public static int ChangeGroupGadget(ScriptLibContext context, object table_)
        {
            var table = table_ as LuaTable;
            var configId = (int)(long)table["config_id"];
            var state = (int)(long)table["state"];

            var entity = context.SceneScriptManager.Scene.ScriptEntities.Values.Where(w => w.ConfigId == configId);
            if (entity == null)
            {
                return 1;
            }

            if (entity is ScriptGadgetEntity gadget)
            {
                gadget.SetGadgetState(state);
                return 0;
            }

            return 1;
        }

        public static int GetEntityType(ScriptLibContext context, int entityId)
        {
            var entity = context.SceneScriptManager.Scene.GetEntityById((uint)entityId);
            if (entity == null)
            {
                return (int)EntityType.None;
            }

            return (int)entity.GetEntityType();
        }
        //Not fully implemented. But most of the usage of this function rely on EntityType.AVATAR.
        public static int GetEntityType(int tid)
        {
            Logger.DebugWriteLine($"[LUA] Call GetEntityType with {tid}");
            return (int)EntityType.Avatar;
        }

        public static int GetQuestState(ScriptLibContext context, int entityId, int questId)
        {
            Logger.DebugWriteLine($"[LUA] Call GetQuestState for entity {entityId} and quest {questId}");
            /*
            var player = context.SceneScriptManager.Scene.World.Host;
            //var quest = player.QuestManager.GetQuestById(questId);
            if (quest == null)
            {
                return (int)QuestState.QUEST_STATE_NONE;
            }

            return (int)quest.State.getValue();*/
            return 0;
        }

        public static int ShowReminder(ScriptLibContext context, int reminderId)
        {
            //context.SceneScriptManager.Scene.BroadcastPacketAsync(new PacketDungeonShowReminderNotify(reminderId));
            return 0;
        }

        public static int ShowReminderRadius(ScriptLibContext context, int reminderID, object location, int var4) // location => Vector3
        {
            Logger.DebugWriteLine($"[LUA] Call ShowReminderRadius {reminderID} {location} {var4}");
            //TODO
            // var4 == distance?
            // e.g. scene3_group133002098.lua action_EVENT_ENTER_REGION_98007 line 247
            return 0;
        }
        public static int BeginCameraSceneLook(ScriptLibContext context, int var2)
        {
            Logger.DebugWriteLine($"[LUA] Call BeginCameraSceneLook {var2}");
            //TODO
            // var2 == cameraSceneProperties
            // cameraSceneProperties:
            // look_pos: Position
            // is_allow_input: bool
            // duration: float
            // is_force: bool
            // is_broadcast: bool
            // is_recover_keep_current: bool
            // delay: int
            // is_set_follow_pos: bool
            // follow_pos: Position
            // is_force_walk: bool
            // is_change_play_mode: bool
            // is_set_screen_XY: bool
            // screen_x int
            // screen_y int
            // e.g. scene3_group133002098.lua action_EVENT_ENTER_REGION_98007 line 247
            return 0;
        }
        public static int SetPlatformRouteId(ScriptLibContext context, int var2, int routeId)
        {
            Logger.DebugWriteLine($"[LUA] Call SetPlatformRouteId {var2} {routeId}");
            //TODO
            // var2 == seelie ID?
            // e.g. scene3_group133003381.lua action_EVENT_ENTER_REGION_381007 line 387
            // or scene3_group133001159.lua action_EVENT_ENTER_REGION_159007 line 387
            return 0;
        }
        public static int CreateGroupTimerEvent(ScriptLibContext context, int unk, string unk2, int unk3)
        {
            Logger.DebugWriteLine($"[LUA] Call CreateGroupTimerEvent {unk} {unk2} {unk3}");
            //TODO
            // e.g. scene3_group133003002.lua action_EVENT_ANY_MONSTER_LIVE_529 line 177
            // maybe groupID, timer type/abilityTimer?, time in sec?
            return 0;
        }
        public static int SetGroupReplaceable(ScriptLibContext context, int unk, bool unk2)
        {
            Logger.DebugWriteLine($"[LUA] Call SetGroupReplaceable {unk} {unk2}");
            //TODO
            // e.g. scene3_group133003136.lua action_EVENT_ANY_MONSTER_DIE_511 line 445
            // maybe groupID, timer type/abilityTimer?, time in sec?
            return 0;
        }
        public static int PrintLog(ScriptLibContext context, string message)
        {
            Logger.WriteLine($"[LUA] PrintLog: {message}");
            return 0;
        }

        public static int RemoveEntityByConfigId(ScriptLibContext context, int groupId, int entityType, int configId)
        {
            Logger.DebugWriteLine($"[LUA] Call RemoveEntityByConfigId");

            IEnumerable<ScriptEntity> entities = context.SceneScriptManager.Scene.ScriptEntities.Values
                .Where(w => w.GroupId == groupId && w.ConfigId == configId && w.GetEntityType() == entityType);

            if (entities.Any())
            {
                foreach (var entity in entities)
                    context.SceneScriptManager.Scene.RemoveEntityAsync(entity);

                return 0;
            }
            else
            {
                return 1;
            }


        }

    }
}
