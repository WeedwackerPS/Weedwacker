using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp
{
    internal class AbilityModifier
    {
        [JsonProperty] public readonly StackingType stacking;
        [JsonProperty] public readonly string modifierName;
        [JsonProperty] public readonly bool? isUnique;
        [JsonProperty] public readonly object duration;
        [JsonProperty] public readonly Dictionary<PropertyModifierType, object> properties;
        [JsonProperty] public readonly bool? isLimitedProperties;
        [JsonProperty] public readonly object elementDurability;
        [JsonProperty] public readonly object thinkInterval;
        [JsonProperty] public readonly BaseAbilityMixin[]? modifierMixins;
        [JsonProperty] public readonly ConfigAbilityAction[]? onAdded;
        [JsonProperty] public readonly ConfigAbilityAction[]? onRemoved;
        [JsonProperty] public readonly ConfigAbilityAction[]? onBeingHit;
        [JsonProperty] public readonly ConfigAbilityAction[]? onAttackLanded;
        [JsonProperty] public readonly ConfigAbilityAction[]? onHittingOther;
        [JsonProperty] public readonly ConfigAbilityAction[]? onThinkInterval;
        [JsonProperty] public readonly ConfigAbilityAction[]? onKill;
        [JsonProperty] public readonly ConfigAbilityAction[]? onCrash;
        [JsonProperty] public readonly ConfigAbilityAction[]? onAvatarIn;
        [JsonProperty] public readonly ConfigAbilityAction[]? onAvatarOut;
        [JsonProperty] public readonly ConfigAbilityAction[]? onReconnect;
        [JsonProperty] public readonly ConfigAbilityAction[]? onChangeAuthority;
        [JsonProperty] public readonly ConfigAbilityAction[]? onVehicleIn;
        [JsonProperty] public readonly ConfigAbilityAction[]? onVehicleOut;
        [JsonProperty] public readonly ConfigAbilityAction[]? onZoneEnter;
        [JsonProperty] public readonly ConfigAbilityAction[]? onZoneExit;
        [JsonProperty] public readonly ConfigAbilityAction[]? onHeal;
        [JsonProperty] public readonly ConfigAbilityAction[]? onBeingHealed;

        internal async Task Initialize(LocalIdGenerator idGenerator, IDictionary<uint, IInvocation> localIdToInvocationMap)
        {
            ushort configIndex = 0;
            // DO NOT CHANGE THE ORDER
            var tasks = new Task[]
                {
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onAdded, localIdToInvocationMap),
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onRemoved, localIdToInvocationMap),
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onBeingHit, localIdToInvocationMap),
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onAttackLanded, localIdToInvocationMap),
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onHittingOther, localIdToInvocationMap),
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onThinkInterval, localIdToInvocationMap),
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onKill, localIdToInvocationMap),
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onCrash, localIdToInvocationMap),
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onAvatarIn, localIdToInvocationMap),
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onAvatarOut, localIdToInvocationMap),
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onReconnect, localIdToInvocationMap),
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onChangeAuthority, localIdToInvocationMap),
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onVehicleIn, localIdToInvocationMap),
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onVehicleOut, localIdToInvocationMap),
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onZoneEnter, localIdToInvocationMap),
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onZoneExit, localIdToInvocationMap),
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onHeal, localIdToInvocationMap),
                    InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onBeingHealed, localIdToInvocationMap),

                };
            await Task.WhenAll(tasks);

            if (modifierMixins == null) return;
            idGenerator.Type = ConfigAbilitySubContainerType.MODIFIER_MIXIN;
            ushort mixinIndex = 0;
            var tasks2 = new List<Task>();
            for (uint i = 0; i < modifierMixins.Length; i++)
            {
                idGenerator = new(ConfigAbilitySubContainerType.MODIFIER_MIXIN) { ConfigIndex = 0, MixinIndex = mixinIndex++ };
                tasks2.Add(modifierMixins[i].Initialize(idGenerator, localIdToInvocationMap));
            }
        }
        private async Task InitializeActionSubCategory(uint modifierIndex, ushort configIndex, ConfigAbilityAction[]? actions, IDictionary<uint, IInvocation> localIdToInvocationMap)
        {
            if (actions == null) return;
            await Task.Yield();
            LocalIdGenerator idGenerator = new(ConfigAbilitySubContainerType.MODIFIER_ACTION) { ConfigIndex = configIndex, ModifierIndex = modifierIndex };
            idGenerator.InitializeActionLocalIds(actions, localIdToInvocationMap);
        }
    }
}
