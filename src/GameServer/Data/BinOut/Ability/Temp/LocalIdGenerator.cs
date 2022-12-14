using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp
{
    internal class LocalIdGenerator
    {
        public ConfigAbilitySubContainerType Type = ConfigAbilitySubContainerType.NONE;
        public uint ModifierIndex = 0;
        public uint ConfigIndex = 0;
        public uint MixinIndex = 0;
        private uint ActionIndex = 0;

        public LocalIdGenerator(ConfigAbilitySubContainerType type)
        {
            Type = type;
        }

        public void InitializeActionLocalIds(ConfigAbilityAction[]? actions, IDictionary<uint, IInvocation> localIdToInvocationMap)
        {
            if (actions == null) return;
            ActionIndex = 0;
            for (ushort i = 0; i < actions.Length; i++)
            {
                ActionIndex++;
                uint id = GetLocalId();
                localIdToInvocationMap.Add(id, actions[i]);
            }
            ActionIndex = 0;
        }

        public uint GetLocalId()
        {
            switch (Type)
            {
                case ConfigAbilitySubContainerType.ACTION:
                    return (uint)Type + (ConfigIndex << 3) + (ActionIndex << 9);
                case ConfigAbilitySubContainerType.MIXIN:
                    return (uint)Type + (MixinIndex << 3) + (ConfigIndex << 9) + (ActionIndex << 15);
                case ConfigAbilitySubContainerType.MODIFIER_ACTION:
                    return (uint)Type + (ModifierIndex << 3) + (ConfigIndex << 9) + (ActionIndex << 15);
                case ConfigAbilitySubContainerType.MODIFIER_MIXIN:
                    return (uint)Type + (ModifierIndex << 3) + (MixinIndex << 9) + (ConfigIndex << 15) + (ActionIndex << 21);
                default:
                    Logger.WriteErrorLine("Invalid ConfigAbilitySubContainerType");
                    return 0;
            }
        }
    }
}
