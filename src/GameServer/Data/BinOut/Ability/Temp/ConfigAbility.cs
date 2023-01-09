using System.Collections.Concurrent;
using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp
{
    internal class ConfigAbility
    {
        [JsonProperty] public readonly string abilityName;
        [JsonProperty] public readonly Dictionary<string, float>? abilitySpecials;
        [JsonProperty] public readonly BaseAbilityMixin[]? abilityMixins;
        [JsonProperty] public readonly Dictionary<string, AbilityModifier>? modifiers;
        [JsonProperty] public readonly ConfigAbilityAction[]? onAdded;
        [JsonProperty] public readonly ConfigAbilityAction[]? onRemoved;
        [JsonProperty] public readonly ConfigAbilityAction[]? onAbilityStart;
        [JsonProperty] public readonly ConfigAbilityAction[]? onKill;
        [JsonProperty] public readonly ConfigAbilityAction[]? onFieldEnter;
        [JsonProperty] public readonly ConfigAbilityAction[]? onExit;
        [JsonProperty] public readonly ConfigAbilityAction[]? onAttach;
        [JsonProperty] public readonly ConfigAbilityAction[]? onDetach;
        [JsonProperty] public readonly ConfigAbilityAction[]? onAvatarIn;
        [JsonProperty] public readonly ConfigAbilityAction[]? onAvatarOut;
        [JsonProperty] public readonly ConfigAbilityAction[]? onTriggerAvatarRay;
        [JsonProperty] public readonly ConfigAbilityAction[]? onVehicleIn;
        [JsonProperty] public readonly ConfigAbilityAction[]? onVehicleOut;
        [JsonProperty] public readonly bool isDynamicAbility; // if true, disable this ability by default. Enable via ConfigTalent AddAbility     

        [JsonIgnore] public ConcurrentDictionary<uint, IInvocation> LocalIdToInvocationMap;
        [JsonIgnore] public SortedList<uint, AbilityModifier> ModifierList;

        internal async Task Initialize()
        {
            // DO NOT CHANGE THE ORDER
            LocalIdToInvocationMap = new();

            var tasks = new Task[]
            {
                InitializeMixinIds(),
                InitializeModifierIds(),
                InitializeActionIds()
            };

            await Task.WhenAll(tasks);

        }

        private async Task InitializeActionIds()
        {
            await Task.Yield();
            ushort configIndex = 0;
            LocalIdGenerator idGenerator = new(ConfigAbilitySubContainerType.ACTION);
            idGenerator.InitializeActionLocalIds(onAdded, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onRemoved, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onAbilityStart, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onKill, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onFieldEnter, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onExit, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onAttach, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onDetach, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onAvatarIn, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onAvatarOut, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onTriggerAvatarRay, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onVehicleIn, LocalIdToInvocationMap);
            idGenerator.ConfigIndex++;
            idGenerator.InitializeActionLocalIds(onVehicleOut, LocalIdToInvocationMap);
        }

        private async Task InitializeMixinIds()
        {
            if (abilityMixins != null)
            {
                LocalIdGenerator idGenerator = new(ConfigAbilitySubContainerType.MIXIN);
                for (uint i = 0; i < abilityMixins.Length; i++)
                {
                    idGenerator.ConfigIndex = 0;
                    await abilityMixins[i].Initialize(idGenerator, LocalIdToInvocationMap);
                    idGenerator.MixinIndex++;
                }
            }
        }

        private async Task InitializeModifierIds()
        {
            if (modifiers != null)
            {
                ModifierList = new();
                var modifierArray = modifiers.ToArray();
                var tasks = new Task[modifierArray.Length];
                ushort modifierIndex = 0;
                for (uint i = 0; i < modifierArray.Length; i++)
                {
                    LocalIdGenerator idGenerator = new(ConfigAbilitySubContainerType.NONE) { ModifierIndex = modifierIndex };
                    ModifierList[i] = modifierArray[i].Value;
                    tasks[i] = modifierArray[i].Value.Initialize(idGenerator, LocalIdToInvocationMap);
                    modifierIndex++;
                }

                await Task.WhenAll(tasks);
            }
        }
    }
}
