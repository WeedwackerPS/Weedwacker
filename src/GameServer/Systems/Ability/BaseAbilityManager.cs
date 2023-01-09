using Google.Protobuf;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Ability
{
    internal abstract class BaseAbilityManager
    {
        protected readonly BaseEntity Owner;
        protected Dictionary<uint, uint> InstanceToAbilityHashMap = new(); // <instancedAbilityId, abilityNameHash>
        protected abstract Dictionary<uint, ConfigAbility> ConfigAbilityHashMap { get; } // <abilityNameHash, configAbility>
        public readonly Dictionary<uint, Dictionary<uint, float>> AbilitySpecialOverrideMap = new(); // <abilityNameHash, <abilitySpecialHash, value>>
        public abstract Dictionary<uint, Dictionary<uint, float>?>? AbilitySpecials { get; }// <abilityNameHash, <abilitySpecialHash, value>>
        public abstract HashSet<string> ActiveDynamicAbilities { get; }
        public abstract Dictionary<string, HashSet<string>> UnlockedTalentParams { get; }

        protected Dictionary<uint, float> GlobalValueHashMap = new(); // <hash, value> TODO map the hashes to variable names
        protected BaseAbilityManager(BaseEntity owner)
        {
            Owner = owner;
        }

        public virtual void Initialize()
        {
            foreach (var ability in AbilitySpecials)
            {
                uint ablHash = ability.Key;
                AbilitySpecialOverrideMap[ablHash] = new();
                if (ability.Value != null)
                {
                    foreach (var special in ability.Value)
                    {
                        AbilitySpecialOverrideMap[ablHash][special.Key] = special.Value;
                    }
                }
            }
        }


        public virtual async Task HandleAbilityInvokeAsync(AbilityInvokeEntry invoke)
        {
            IBufferMessage info = new AbilityMetaModifierChange();
            ByteString data = invoke.AbilityData;
            //TODO add all cases
            switch (invoke.ArgumentType)
            {
                case AbilityInvokeArgument.None:
                    //TODO
                    ConfigAbility ability = ConfigAbilityHashMap[InstanceToAbilityHashMap[invoke.Head.InstancedAbilityId]];
                    if (ability.LocalIdToInvocationMap.TryGetValue((uint)invoke.Head.LocalId, out IInvocation invocation))
                        await invocation.Invoke(ability.abilityName, Owner);
                    else
                        Logger.DebugWriteLine($"Missing localId: {invoke.Head.LocalId}, ability: {invoke.Head.InstancedAbilityId}");
                    info = new AbilityMetaModifierChange(); // just to satisfy the compiler. In this case abilityData is empty anyway.
                    break;
                case AbilityInvokeArgument.MetaModifierChange:
                    info = AbilityMetaModifierChange.Parser.ParseFrom(data);
                    break;
                case AbilityInvokeArgument.MetaSpecialFloatArgument:
                    info = AbilityMetaSpecialFloatArgument.Parser.ParseFrom(data);
                    break;
                case AbilityInvokeArgument.MetaOverrideParam:
                    info = AbilityScalarValueEntry.Parser.ParseFrom(data);
                    var asEntri = info as AbilityScalarValueEntry;
                    AbilitySpecialOverrideMap[InstanceToAbilityHashMap[invoke.Head.InstancedAbilityId]][asEntri.Key.Hash] = asEntri.FloatValue;
                    break;
                case AbilityInvokeArgument.MetaReinitOverridemap:
                    info = AbilityMetaReInitOverrideMap.Parser.ParseFrom(data);
                    ReInitOverrideMap(InstanceToAbilityHashMap[invoke.Head.InstancedAbilityId], info as AbilityMetaReInitOverrideMap);
                    break;
                case AbilityInvokeArgument.MetaGlobalFloatValue:
                    info = AbilityScalarValueEntry.Parser.ParseFrom(data);
                    var asEntry = info as AbilityScalarValueEntry;
                    GlobalValueHashMap[asEntry.Key.Hash] = asEntry.FloatValue;
                    break;
                case AbilityInvokeArgument.MetaAddOrGetAbilityAndTrigger:
                    info = AbilityMetaAddOrGetAbilityAndTrigger.Parser.ParseFrom(data);
                    break;
                case AbilityInvokeArgument.MetaAddNewAbility:
                    info = AbilityMetaAddAbility.Parser.ParseFrom(data);
                    AddAbility((info as AbilityMetaAddAbility).Ability);
                    break;
                case AbilityInvokeArgument.MetaModifierDurabilityChange:
                    info = AbilityMetaModifierDurabilityChange.Parser.ParseFrom(data);
                    break;
                case AbilityInvokeArgument.MetaElementReactionVisual:
                    info = AbilityMetaElementReactionVisual.Parser.ParseFrom(data);
                    break;
                case AbilityInvokeArgument.MetaUpdateBaseReactionDamage:
                    info = AbilityMetaUpdateBaseReactionDamage.Parser.ParseFrom(data);
                    break;
                case AbilityInvokeArgument.MetaTriggerElementReaction:
                    info = AbilityMetaTriggerElementReaction.Parser.ParseFrom(data);
                    break;
                case AbilityInvokeArgument.MetaLoseHp:
                    info = AbilityMetaLoseHp.Parser.ParseFrom(data);
                    break;
                case AbilityInvokeArgument.ActionTriggerAbility:
                    info = AbilityActionTriggerAbility.Parser.ParseFrom(data);
                    break;
                case AbilityInvokeArgument.ActionGenerateElemBall:
                    info = AbilityActionGenerateElemBall.Parser.ParseFrom(data);
                    break;
                case AbilityInvokeArgument.ActionFireAfterImage:
                    info = AbilityActionFireAfterImage.Parser.ParseFrom(data);
                    break;
                case AbilityInvokeArgument.MixinWindZone:
                    info = AbilityMixinWindZone.Parser.ParseFrom(data);
                    break;
                case AbilityInvokeArgument.MixinCostStamina:
                    info = AbilityMixinCostStamina.Parser.ParseFrom(data);
                    break;
                case AbilityInvokeArgument.MixinGlobalShield:
                    info = AbilityMixinGlobalShield.Parser.ParseFrom(data);
                    break;
                case AbilityInvokeArgument.MixinWindSeedSpawner:
                    info = AbilityMixinWindSeedSpawner.Parser.ParseFrom(data);
                    break;
                default:
                    Logger.DebugWriteLine($"Unhandled AbilityInvokeArgument: {invoke.ArgumentType}");
                    info = new AbilityMetaModifierChange(); // should not happen, just to satisfy the compiler
                    break;
            }

#if DEBUG
            if (GameServer.Configuration.Server.LogAbilityInvocations)
            {
                if (!GameServer.Configuration.Server.AbilityInvArgBlacklist.Contains(invoke.ArgumentType))
                {
                    Connection.LogAbilityInvocation("RECV ability invoke: ", invoke, info.GetType(), Owner.EntityId);
                }
            }
#endif
        }

        protected virtual void ReInitOverrideMap(uint abilityNameHash, AbilityMetaReInitOverrideMap? overrideMap)
        {
            foreach (var entry in overrideMap.OverrideMap)
            {
                if (entry.ValueType != AbilityScalarType.Float)
                {
                    Logger.DebugWriteLine($"Unhandled value type {entry.ValueType} in Config {ConfigAbilityHashMap[abilityNameHash].abilityName}");
                    continue;
                }
                try
                {
                    AbilitySpecialOverrideMap[abilityNameHash][entry.Key.Hash] = entry.FloatValue;
                }
                catch
                {
                    AbilitySpecialOverrideMap[abilityNameHash] = new();
                    AbilitySpecialOverrideMap[abilityNameHash][entry.Key.Hash] = entry.FloatValue;
                }
            }
        }

        protected virtual void AddAbility(AbilityAppliedAbility ability)
        {
            uint hash = ability.AbilityName.Hash;
            uint instancedId = ability.InstancedAbilityId;
            InstanceToAbilityHashMap[instancedId] = hash;
            if (ability.OverrideMap.Any())
            {
                foreach (var entry in ability.OverrideMap)
                {
                    switch (entry.ValueType)
                    {
                        case AbilityScalarType.Float:
                            try
                            {
                                AbilitySpecialOverrideMap[hash][entry.Key.Hash] = entry.FloatValue;
                            }
                            catch
                            {
                                //TODO fix missing ability hashes
                                AbilitySpecialOverrideMap[hash] = new();
                                AbilitySpecialOverrideMap[hash][entry.Key.Hash] = entry.FloatValue;
                            }
                            break;
                        default:
                            Logger.WriteErrorLine($"Unhandled value type {entry.ValueType} in Config {ConfigAbilityHashMap[hash].abilityName}");
                            break;
                    }
                }
            }
        }
    }
}
