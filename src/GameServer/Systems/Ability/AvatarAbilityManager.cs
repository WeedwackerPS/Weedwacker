using Weedwacker.GameServer.Data.BinOut.Ability.Temp;
using Weedwacker.GameServer.Data.BinOut.Talent;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Ability
{
    internal class AvatarAbilityManager : BaseAbilityManager
    {
        private SkillDepot CurDepot => (Owner as AvatarEntity).Avatar.CurSkillDepot;
        private uint CurDepotId => CurDepot.DepotId;
        protected override Dictionary<uint, ConfigAbility> ConfigAbilityHashMap => CurDepot.Abilities;

        public override Dictionary<uint, Dictionary<uint, float>?>? AbilitySpecials => CurDepot.AbilitySpecials;

        public override HashSet<string> ActiveDynamicAbilities => CurDepot.ActiveDynamicAbilities;

        public override Dictionary<string, HashSet<string>> UnlockedTalentParams => CurDepot.UnlockedTalentParams;


        public AvatarAbilityManager(AvatarEntity avatar) : base(avatar)
        {
        }

        public override void Initialize()
        {
            foreach (var proudSkill in CurDepot.InherentProudSkillOpens)
            {
                if (proudSkill.openConfig == null || proudSkill.openConfig == "") continue;
                foreach (BaseConfigTalent config in (Owner as AvatarEntity).Avatar.Data.ConfigTalentMap[(Owner as AvatarEntity).Avatar.CurrentDepotId][proudSkill.openConfig])
                {
                    config.Apply(this, proudSkill.paramList);
                }
            }
            foreach (var skill in CurDepot.Skills)
            {
                AvatarSkillData skillData = (Owner as AvatarEntity).Avatar.Data.SkillData[CurDepotId][skill.Key];
                ProudSkillData proudSkill = (Owner as AvatarEntity).Avatar.Data.ProudSkillData[CurDepotId]
                    .Where(w => w.Value.proudSkillGroupId == skillData.proudSkillGroupId && w.Value.level == skill.Value).First().Value;
                if ((Owner as AvatarEntity).Avatar.Data.ConfigTalentMap.ContainsKey(CurDepotId))
                {
                    foreach (BaseConfigTalent config in (Owner as AvatarEntity).Avatar.Data.ConfigTalentMap[CurDepotId][proudSkill.openConfig])
                    {
                        config.Apply(this, proudSkill.paramList);
                    }
                }
            }
            if (CurDepot.Element != null)
            {
                uint energySkill = CurDepot.EnergySkill;
                uint energySkillLevel = CurDepot.EnergySkillLevel;
                AvatarSkillData skillData = (Owner as AvatarEntity).Avatar.Data.SkillData[CurDepotId][energySkill];
                ProudSkillData proudSkill = (Owner as AvatarEntity).Avatar.Data.ProudSkillData[CurDepotId]
                    .Where(w => w.Value.proudSkillGroupId == skillData.proudSkillGroupId && w.Value.level == energySkillLevel).First().Value;
                foreach (BaseConfigTalent config in (Owner as AvatarEntity).Avatar.Data.ConfigTalentMap[CurDepotId][proudSkill.openConfig])
                {
                    config.Apply(this, proudSkill.paramList);
                }
            }
            base.Initialize();
        }
        protected override void AddAbility(AbilityAppliedAbility ability)
        {
            base.AddAbility(ability);
        }

    }
}
