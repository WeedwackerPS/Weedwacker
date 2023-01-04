using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;

namespace Weedwacker.GameServer.Systems.Player
{
    internal class ResinManager
    {
        private Player Owner;

        public ResinManager(Player owner) { Owner = owner; }
        public async Task<bool> UseResinAsync(int amount)
        {

            int currentResin = Owner.PlayerProperties[PlayerProperty.PROP_PLAYER_RESIN];

            // Check if the player has sufficient resin.
            if (currentResin < amount)
            {
                return false;
            }

            // Deduct the resin from the player.
            int newResin = currentResin - amount;
            await Owner.PropManager.SetPropertyAsync(PlayerProperty.PROP_PLAYER_RESIN, newResin);

            // Check if this has taken the player under the recharge cap,
            // starting the recharging process.
            if (Owner.NextResinRefresh == 0 && newResin < GameServer.Configuration.Server.GameOptions.ResinOptions.Cap)
            {
                int currentTime = (int)(DateTimeOffset.Now.ToUnixTimeMilliseconds() / 1000);
                Owner.NextResinRefresh = currentTime + GameServer.Configuration.Server.GameOptions.ResinOptions.RechargeTime;
            }

            // Send packets.
            await Owner.SendPacketAsync(new PacketResinChangeNotify(Owner));

            // Battle Pass trigger
            Owner.BattlePassManager.TriggerMission(WatcherTriggerType.TRIGGER_COST_MATERIAL, 106, amount); // Resin itemId = 106

            return true;
        }
        public async Task<bool> AddResinAsync(int amount)
        {
            // Check if resin enabled.
            if (!GameServer.Configuration.Server.GameOptions.ResinOptions.ResinUsage)
            {
                return false;
            }

            // Add resin.
            int currentResin = Owner.PlayerProperties.GetValueOrDefault(PlayerProperty.PROP_PLAYER_RESIN);
            int newResin = currentResin + amount;

            if (await Owner.PropManager.SetPropertyAsync(PlayerProperty.PROP_PLAYER_RESIN, newResin))
            {
                // Stop recharging if player is now at or over the cap.
                if (newResin >= GameServer.Configuration.Server.GameOptions.ResinOptions.Cap)
                {
                    Owner.NextResinRefresh = 0;
                }

                // Send packets.
                await Owner.SendPacketAsync(new PacketResinChangeNotify(Owner));
                return true;
            }
            else return false;
        }

        /********************
         * Recharge resin.
         ********************/
        public async Task RechargeResin()
        {
            // Check if resin enabled.
            if (!GameServer.Configuration.Server.GameOptions.ResinOptions.ResinUsage)
            {
                return;
            }

            int currentResin = Owner.PlayerProperties.GetValueOrDefault(PlayerProperty.PROP_PLAYER_RESIN);
            int currentTime = (int)(DateTimeOffset.Now.ToUnixTimeMilliseconds() / 1000);

            // Make sure we are currently in "recharging mode".
            // This is denoted by Player.nextResinRefresh being greater than 0.
            if (Owner.NextResinRefresh <= 0)
            {
                return;
            }

            // Determine if we actually need to recharge yet.
            if (currentTime < Owner.NextResinRefresh)
            {
                return;
            }

            // Calculate how much resin we need to refill and update player.
            // Note that this can be more than one in case the player
            // logged off with uncapped resin and is now logging in again.
            int recharge = 1 + (int)((currentTime - Owner.NextResinRefresh) / GameServer.Configuration.Server.GameOptions.ResinOptions.RechargeTime);
            int newResin = Math.Min(GameServer.Configuration.Server.GameOptions.ResinOptions.Cap, currentResin + recharge);
            int resinChange = newResin - currentResin;

            await Owner.PropManager.SetPropertyAsync(PlayerProperty.PROP_PLAYER_RESIN, newResin);

            // Calculate next recharge time.
            // Set to zero to disable recharge (because on/over cap.)
            if (newResin >= GameServer.Configuration.Server.GameOptions.ResinOptions.Cap)
            {
                Owner.NextResinRefresh = 0;
            }
            else
            {
                int nextRecharge = Owner.NextResinRefresh + resinChange * GameServer.Configuration.Server.GameOptions.ResinOptions.RechargeTime;
                Owner.NextResinRefresh = nextRecharge;
            }

            // Send packets.
            await Owner.SendPacketAsync(new PacketResinChangeNotify(Owner));
        }

        /********************
         * Player login.
         ********************/
        public async Task OnLoginAsync()
        {
            // If resin usage is disabled, set resin to cap.
            if (!GameServer.Configuration.Server.GameOptions.ResinOptions.ResinUsage)
            {
                await Owner.PropManager.SetPropertyAsync(PlayerProperty.PROP_PLAYER_RESIN, GameServer.Configuration.Server.GameOptions.ResinOptions.Cap);
                Owner.NextResinRefresh = 0;
            }
            else
            {
                await RechargeResin();
            }

            // In case server administrators change the resin cap while players are capped,
            // we need to restart recharging here.
            int currentResin = Owner.PlayerProperties.GetValueOrDefault(PlayerProperty.PROP_PLAYER_RESIN);
            int currentTime = (int)(DateTimeOffset.Now.ToUnixTimeMilliseconds() / 1000);

            if (currentResin < GameServer.Configuration.Server.GameOptions.ResinOptions.Cap && Owner.NextResinRefresh == 0)
            {
                Owner.NextResinRefresh = currentTime + GameServer.Configuration.Server.GameOptions.ResinOptions.RechargeTime;
            }
        }
    }
}
