﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DungeonType
    {
        DUNGEON_NONE = 0,
        DUNGEON_PLOT = 1,
        DUNGEON_FIGHT = 2,
        DUNGEON_DAILY_FIGHT = 3,
        DUNGEON_WEEKLY_FIGHT = 4,
        DUNGEON_DISCARDED = 5,
        DUNGEON_TOWER = 6,
        DUNGEON_BOSS = 7,
        DUNGEON_THEATRE_MECHANICUS,
        DUNGEON_WIND_FIELD,
        DUNGEON_DREAMLAND,
        DUNGEON_UGC,
        DUNGEON_POTION,
        DUNGEON_SUMO_COMBAT,
        DUNGEON_ROGUELIKE,
        DUNGEON_CRYSTAL_LINK,
        DUNGEON_ELEMENT_CHALLENGE,
        DUNGEON_EFFIGY,
        DUNGEON_FLEUR_FAIR,
        DUNGEON_ACTIVITY,
        DUNGEON_CHANNELLER_SLAB_ONE_OFF,
        DUNGEON_CHANNELLER_SLAB_LOOP,
        DUNGEON_BLITZ_RUSH,
        DUNGEON_MINI_ELDRITCH,
        DUNGEON_HACHI,
        DUNGEON_CHESS,
        DUNGEON_IRODORI_CHESS,
        DUNGEON_ROGUE_DIARY,
        DUNGEON_SUMMER_V2,
        DUNGEON_MUQADAS_POTION,
        DUNGEON_INSTABLE_SPRAY,
    }
}