using MongoDB.Driver;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;

namespace Weedwacker.GameServer.Systems.Player
{
    internal class OpenStateManager
    {
        private Player Owner;

        public OpenStateManager(Player owner)
        {
            Owner = owner;
        }

        public async Task OnPlayerCreate()
        {
            foreach (uint openState in DEFAULT_OPEN_STATES)
            {
                await SetOpenStateAsync(openState, 1);
            }
        }

        public async Task OnLoginAsync()
        {
            // Try unlocking open states on player login. This handles accounts where unlock conditions were
            // already met before certain open state unlocks were implemented.
            await TryUnlockOpenStatesAsync(false);

            // Send notify to the client.
            await Owner.SendPacketAsync(new PacketOpenStateUpdateNotify(Owner));

        }

        // Set of open states that are set per default for all accounts.
        public static HashSet<uint> DEFAULT_OPEN_STATES = new HashSet<uint>(GameData.OpenStateDataMap.Where(w => w.Value.defaultState == true).Select(s => s.Key));

        public async Task SetOpenStateAsync(uint openState, int value, bool sendNotify = true)
        {
            int previousValue = Owner.ProgressManager.OpenStates.GetValueOrDefault((OpenStateType)openState, 0);

            if (value != previousValue)
            {
                Owner.ProgressManager.OpenStates.Add((OpenStateType)openState, value);

                // Update Database
                var filter = Builders<ProgressManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                var update = Builders<ProgressManager>.Update.Set($"{nameof(ProgressManager.OpenStates)}.{(OpenStateType)openState}", value);
                await DatabaseManager.UpdateProgressAsync(filter, update);

                if (sendNotify)
                {
                    await Owner.SendPacketAsync(new PacketOpenStateChangeNotify(openState, value));
                }
            }
        }

        /**********
            Condition checking for setting open states.
        **********/
        private bool AreConditionsMet(OpenStateData openState)
        {
            // Check all conditions and test if at least one of them is violated.
            foreach (var condition in openState.cond)
            {
                switch (condition.condType)
                {
                    case OpenStateCondType.NONE:
                        continue;
                    // For level conditions, check if the player has reached the necessary level.
                    case OpenStateCondType.OPEN_STATE_COND_PLAYER_LEVEL:
                        {
                            if (Owner.PlayerProperties[PlayerProperty.PROP_PLAYER_LEVEL] < condition.param)
                            {
                                return false;
                            }
                            else continue;
                        }
                    case OpenStateCondType.OPEN_STATE_COND_QUEST:
                        {
                            // ToDo: Implement.
                            return false;
                        }
                    case OpenStateCondType.OPEN_STATE_COND_PARENT_QUEST:
                        {
                            // ToDo: Implement.
                            return false;
                        }
                    case OpenStateCondType.OPEN_STATE_OFFERING_LEVEL:
                        {
                            // ToDo: Implement.
                            return false;
                        }
                    case OpenStateCondType.OPEN_STATE_CITY_REPUTATION_LEVEL:
                        {
                            // ToDo: Implement.
                            return false;
                        }
                }
            }

            // Done. If we didn't find any violations, all conditions are met.
            return true;
        }

        /**********
            Setting open states from the client (via `SetOpenStateReq`).
        **********/
        public async Task<bool> SetOpenStateFromClientAsync(uint openState, uint value)
        {
            OpenStateData data = GameData.OpenStateDataMap[openState];

            // Make sure that this is an open state that the client is allowed to set,
            // and that it doesn't have any further conditions attached.
            if (data != null && data.allowClientOpen && AreConditionsMet(data))
            {
                // Set.
                await SetOpenStateAsync(openState, (int)value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /**********
            Triggered unlocking of open states (unlock states whose conditions have been met.)
        **********/
        public async Task TryUnlockOpenStatesAsync(bool sendNotify)
        {
            // Get list of open states that are not yet unlocked.
            var lockedStates = GameData.OpenStateDataMap.Where(s => Owner.ProgressManager.OpenStates.GetValueOrDefault((OpenStateType)s.Key, 0) == 0);

            // Try unlocking all of them.
            foreach (var state in lockedStates)
            {
                // To auto-unlock a state, it has to meet three conditions:
                // * it can not be a state that is unlocked by the client,
                // * it has to meet all its unlock conditions
                if (!state.Value.allowClientOpen && AreConditionsMet(state.Value))
                {
                    await SetOpenStateAsync(state.Key, 1, sendNotify);
                }
            }
        }
    }
}

