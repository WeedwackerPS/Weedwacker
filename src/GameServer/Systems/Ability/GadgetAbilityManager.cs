using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp;
using Weedwacker.GameServer.Data.BinOut.Gadget;
using Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Ability
{
    internal class GadgetAbilityManager : BaseAbilityManager
    {
        private ConfigGadget Config => GameData.ConfigGadgetMap[(Owner as BaseGadgetEntity).Data.jsonName];
        private ConfigGadget? ItemConfig => GameData.ConfigGadgetMap.GetValueOrDefault((Owner as BaseGadgetEntity).Data.itemJsonName, null);
        public override Dictionary<uint, Dictionary<uint, float>?>? AbilitySpecials { get; } = new();
        public override HashSet<string> ActiveDynamicAbilities { get; } = new();
        public override Dictionary<string, HashSet<string>> UnlockedTalentParams => throw new NotImplementedException();
        protected override Dictionary<uint, ConfigAbility> ConfigAbilityHashMap { get; } = new();

        public GadgetAbilityManager(BaseGadgetEntity owner) : base(owner)
        {
        }

        public override void Initialize()
        {
            if (Config.abilities != null)
            {
                foreach (ConfigEntityAbilityEntry abilityEntry in Config.abilities)
                {
                    string file = GameData.AbilityPathMap.abilityPaths.Where(w => w.Value.Contains(abilityEntry.abilityName)).First().Key;
                    ConfigAbility ability = GameData.ConfigAbilityGadgetMap[file].Where(w => w.Default.abilityName == abilityEntry.abilityName).First().Default;
                    uint abilityHash = Utils.AbilityHash(abilityEntry.abilityName);
                    ConfigAbilityHashMap.Add(abilityHash, ability);
                    if(ability.abilitySpecials != null)
                    {
                        AbilitySpecials[abilityHash] = new();
                        foreach(var special in ability.abilitySpecials)
                        {
                            AbilitySpecials[abilityHash][Utils.AbilityHash(special.Key)] = special.Value;
                        }
                    }
                }
            }

            if(ItemConfig != null && ItemConfig.abilities != null)
            {
                foreach (ConfigEntityAbilityEntry abilityEntry in ItemConfig.abilities)
                {
                    string file = GameData.AbilityPathMap.abilityPaths.Where(w => w.Value.Contains(abilityEntry.abilityName)).First().Key;
                    ConfigAbility ability = GameData.ConfigAbilityGadgetMap[file].Where(w => w.Default.abilityName == abilityEntry.abilityName).First().Default;
                    uint abilityHash = Utils.AbilityHash(abilityEntry.abilityName);
                    ConfigAbilityHashMap.Add(abilityHash, ability);
                    if (ability.abilitySpecials != null)
                    {
                        AbilitySpecials[abilityHash] = new();
                        foreach (var special in ability.abilitySpecials)
                        {
                            AbilitySpecials[abilityHash][Utils.AbilityHash(special.Key)] = special.Value;
                        }
                    }
                }
            }

            base.Initialize();
        }
    }
}
