﻿using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class TDPlayMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly TowerType towerType;
		[JsonProperty] public readonly int baseCD;
		[JsonProperty] public readonly int baseAttackRange;
		[JsonProperty] public readonly int[] bulletIDs;
		[JsonProperty] public readonly string towerModifierName;
		[JsonProperty] public readonly BaseAction[] onFireActions;
		[JsonProperty] public readonly BaseBornType born;
    }
}
