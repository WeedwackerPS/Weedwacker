// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EnterReason.proto</summary>
  public static partial class EnterReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFFbnRlclJlYXNvbi5wcm90byr4DgoLRW50ZXJSZWFzb24SFQoRRU5URVJf",
            "UkVBU09OX05PTkUQABIWChJFTlRFUl9SRUFTT05fTE9HSU4QARIfChtFTlRF",
            "Ul9SRUFTT05fRFVOR0VPTl9SRVBMQVkQCxIrCidFTlRFUl9SRUFTT05fRFVO",
            "R0VPTl9SRVZJVkVfT05fV0FZUE9JTlQQDBIeChpFTlRFUl9SRUFTT05fRFVO",
            "R0VPTl9FTlRFUhANEh0KGUVOVEVSX1JFQVNPTl9EVU5HRU9OX1FVSVQQDhIT",
            "Cg9FTlRFUl9SRUFTT05fR00QFRIfChtFTlRFUl9SRUFTT05fUVVFU1RfUk9M",
            "TEJBQ0sQHxIYChRFTlRFUl9SRUFTT05fUkVWSVZBTBAgEh8KG0VOVEVSX1JF",
            "QVNPTl9QRVJTT05BTF9TQ0VORRApEhwKGEVOVEVSX1JFQVNPTl9UUkFOU19Q",
            "T0lOVBAqEiAKHEVOVEVSX1JFQVNPTl9DTElFTlRfVFJBTlNNSVQQKxIgChxF",
            "TlRFUl9SRUFTT05fRk9SQ0VfRFJBR19CQUNLECwSGgoWRU5URVJfUkVBU09O",
            "X1RFQU1fS0lDSxAzEhoKFkVOVEVSX1JFQVNPTl9URUFNX0pPSU4QNBIaChZF",
            "TlRFUl9SRUFTT05fVEVBTV9CQUNLEDUSFQoRRU5URVJfUkVBU09OX01VSVAQ",
            "NhImCiJFTlRFUl9SRUFTT05fRFVOR0VPTl9JTlZJVEVfQUNDRVBUEDcSFAoQ",
            "RU5URVJfUkVBU09OX0xVQRA4EiYKIkVOVEVSX1JFQVNPTl9BQ1RJVklUWV9M",
            "T0FEX1RFUlJBSU4QORInCiNFTlRFUl9SRUFTT05fSE9TVF9GUk9NX1NJTkdM",
            "RV9UT19NUBA6EhgKFEVOVEVSX1JFQVNPTl9NUF9QTEFZEDsSHQoZRU5URVJf",
            "UkVBU09OX0FOQ0hPUl9QT0lOVBA8EhwKGEVOVEVSX1JFQVNPTl9MVUFfU0tJ",
            "UF9VSRA9Eh8KG0VOVEVSX1JFQVNPTl9SRUxPQURfVEVSUkFJThA+Eh8KG0VO",
            "VEVSX1JFQVNPTl9EUkFGVF9UUkFOU0ZFUhA/EhsKF0VOVEVSX1JFQVNPTl9F",
            "TlRFUl9IT01FEEASGgoWRU5URVJfUkVBU09OX0VYSVRfSE9NRRBBEiMKH0VO",
            "VEVSX1JFQVNPTl9DSEFOR0VfSE9NRV9NT0RVTEUQQhIYChRFTlRFUl9SRUFT",
            "T05fR0FMTEVSWRBDEiAKHEVOVEVSX1JFQVNPTl9IT01FX1NDRU5FX0pVTVAQ",
            "RBIeChpFTlRFUl9SRUFTT05fSElERV9BTkRfU0VFSxBFEiYKIkVOVEVSX1JF",
            "QVNPTl9TVU1NRVJfVElNRV9NSVNUX1pPTkUQRhIhCh1FTlRFUl9SRUFTT05f",
            "Rk9SQ0VfUVVJVF9TQ0VORRBHEhwKGEVOVEVSX1JFQVNPTl9IRVJPX0NPVVJT",
            "RRBIEh4KGkVOVEVSX1JFQVNPTl9UUkFOU19DTElNQVRFEEkSKQolRU5URVJf",
            "UkVBU09OX1NVTU1FUl9USU1FX0JPQVRfUkVTVEFSVBBKEiUKIUVOVEVSX1JF",
            "QVNPTl9UU1VSVU1JX01JU1RfQ0xJTUFURRBLEi4KKkVOVEVSX1JFQVNPTl9U",
            "U1VSVU1JX1JFR0lPTkFMX01JU1RfQ0xJTUFURRBMEiQKIEVOVEVSX1JFQVNP",
            "Tl9XSU5URVJfQ0FNUF9SRVNUQVJUEE0SIwofRU5URVJfUkVBU09OX1RBTEtf",
            "RVhFQ19UUkFOU0ZFUhBOEiUKIUVOVEVSX1JFQVNPTl9TRUFMQU1QX0JPQVRf",
            "UkVTVEFSVBBPEiIKHkVOVEVSX1JFQVNPTl9TRUFMQU1QX0JPQVRfQkFDSxBQ",
            "EikKJUVOVEVSX1JFQVNPTl9DSEFMTEVOR0VfSU5URVJSVVBUX0JBQ0sQURIo",
            "CiRFTlRFUl9SRUFTT05fSVJPRE9SSV9NQVNURVJfVFJBTlNGRVIQUhIdChlF",
            "TlRFUl9SRUFTT05fR0FMTEVSWV9CQUNLEFMSLAooRU5URVJfUkVBU09OX1NV",
            "TU1FUl9USU1FX1YyX0JPQVRfUkVTVEFSVBBUEjIKLkVOVEVSX1JFQVNPTl9J",
            "U0xBTkRfUEFSVFlfR0FMTEVSWV9TVEFSVF9GQUlMRUQQVRIuCipFTlRFUl9S",
            "RUFTT05fR1JBVkVOX0lOTk9DRU5DRV9SQUNFX1JFU1RBUlQQVhIpCiVFTlRF",
            "Ul9SRUFTT05fVklOVEFHRV9IVU5USU5HX1RSQU5TRkVSEFcSKAokRU5URVJf",
            "UkVBU09OX0ZVTkdVU19GSUdIVEVSX1RSQU5TRkVSEFgSHgoaRU5URVJfUkVB",
            "U09OX0JSSUNLX0JSRUFLRVIQWRIlCiFFTlRFUl9SRUFTT05fQlJJQ0tfQlJF",
            "QUtFUl9TSU5HTEUQWhIkCiBFTlRFUl9SRUFTT05fVFJBTlNGRVJfR1VBUkRf",
            "U1RPUBBbEiQKIEVOVEVSX1JFQVNPTl9DT0lOX0NPTExFQ1RfU0lOR0xFEFxC",
            "IqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.EnterReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum EnterReason {
    [pbr::OriginalName("ENTER_REASON_NONE")] None = 0,
    [pbr::OriginalName("ENTER_REASON_LOGIN")] Login = 1,
    [pbr::OriginalName("ENTER_REASON_DUNGEON_REPLAY")] DungeonReplay = 11,
    [pbr::OriginalName("ENTER_REASON_DUNGEON_REVIVE_ON_WAYPOINT")] DungeonReviveOnWaypoint = 12,
    [pbr::OriginalName("ENTER_REASON_DUNGEON_ENTER")] DungeonEnter = 13,
    [pbr::OriginalName("ENTER_REASON_DUNGEON_QUIT")] DungeonQuit = 14,
    [pbr::OriginalName("ENTER_REASON_GM")] Gm = 21,
    [pbr::OriginalName("ENTER_REASON_QUEST_ROLLBACK")] QuestRollback = 31,
    [pbr::OriginalName("ENTER_REASON_REVIVAL")] Revival = 32,
    [pbr::OriginalName("ENTER_REASON_PERSONAL_SCENE")] PersonalScene = 41,
    [pbr::OriginalName("ENTER_REASON_TRANS_POINT")] TransPoint = 42,
    [pbr::OriginalName("ENTER_REASON_CLIENT_TRANSMIT")] ClientTransmit = 43,
    [pbr::OriginalName("ENTER_REASON_FORCE_DRAG_BACK")] ForceDragBack = 44,
    [pbr::OriginalName("ENTER_REASON_TEAM_KICK")] TeamKick = 51,
    [pbr::OriginalName("ENTER_REASON_TEAM_JOIN")] TeamJoin = 52,
    [pbr::OriginalName("ENTER_REASON_TEAM_BACK")] TeamBack = 53,
    [pbr::OriginalName("ENTER_REASON_MUIP")] Muip = 54,
    [pbr::OriginalName("ENTER_REASON_DUNGEON_INVITE_ACCEPT")] DungeonInviteAccept = 55,
    [pbr::OriginalName("ENTER_REASON_LUA")] Lua = 56,
    [pbr::OriginalName("ENTER_REASON_ACTIVITY_LOAD_TERRAIN")] ActivityLoadTerrain = 57,
    [pbr::OriginalName("ENTER_REASON_HOST_FROM_SINGLE_TO_MP")] HostFromSingleToMp = 58,
    [pbr::OriginalName("ENTER_REASON_MP_PLAY")] MpPlay = 59,
    [pbr::OriginalName("ENTER_REASON_ANCHOR_POINT")] AnchorPoint = 60,
    [pbr::OriginalName("ENTER_REASON_LUA_SKIP_UI")] LuaSkipUi = 61,
    [pbr::OriginalName("ENTER_REASON_RELOAD_TERRAIN")] ReloadTerrain = 62,
    [pbr::OriginalName("ENTER_REASON_DRAFT_TRANSFER")] DraftTransfer = 63,
    [pbr::OriginalName("ENTER_REASON_ENTER_HOME")] EnterHome = 64,
    [pbr::OriginalName("ENTER_REASON_EXIT_HOME")] ExitHome = 65,
    [pbr::OriginalName("ENTER_REASON_CHANGE_HOME_MODULE")] ChangeHomeModule = 66,
    [pbr::OriginalName("ENTER_REASON_GALLERY")] Gallery = 67,
    [pbr::OriginalName("ENTER_REASON_HOME_SCENE_JUMP")] HomeSceneJump = 68,
    [pbr::OriginalName("ENTER_REASON_HIDE_AND_SEEK")] HideAndSeek = 69,
    [pbr::OriginalName("ENTER_REASON_SUMMER_TIME_MIST_ZONE")] SummerTimeMistZone = 70,
    [pbr::OriginalName("ENTER_REASON_FORCE_QUIT_SCENE")] ForceQuitScene = 71,
    [pbr::OriginalName("ENTER_REASON_HERO_COURSE")] HeroCourse = 72,
    [pbr::OriginalName("ENTER_REASON_TRANS_CLIMATE")] TransClimate = 73,
    [pbr::OriginalName("ENTER_REASON_SUMMER_TIME_BOAT_RESTART")] SummerTimeBoatRestart = 74,
    [pbr::OriginalName("ENTER_REASON_TSURUMI_MIST_CLIMATE")] TsurumiMistClimate = 75,
    [pbr::OriginalName("ENTER_REASON_TSURUMI_REGIONAL_MIST_CLIMATE")] TsurumiRegionalMistClimate = 76,
    [pbr::OriginalName("ENTER_REASON_WINTER_CAMP_RESTART")] WinterCampRestart = 77,
    [pbr::OriginalName("ENTER_REASON_TALK_EXEC_TRANSFER")] TalkExecTransfer = 78,
    [pbr::OriginalName("ENTER_REASON_SEALAMP_BOAT_RESTART")] SealampBoatRestart = 79,
    [pbr::OriginalName("ENTER_REASON_SEALAMP_BOAT_BACK")] SealampBoatBack = 80,
    [pbr::OriginalName("ENTER_REASON_CHALLENGE_INTERRUPT_BACK")] ChallengeInterruptBack = 81,
    [pbr::OriginalName("ENTER_REASON_IRODORI_MASTER_TRANSFER")] IrodoriMasterTransfer = 82,
    [pbr::OriginalName("ENTER_REASON_GALLERY_BACK")] GalleryBack = 83,
    [pbr::OriginalName("ENTER_REASON_SUMMER_TIME_V2_BOAT_RESTART")] SummerTimeV2BoatRestart = 84,
    [pbr::OriginalName("ENTER_REASON_ISLAND_PARTY_GALLERY_START_FAILED")] IslandPartyGalleryStartFailed = 85,
    [pbr::OriginalName("ENTER_REASON_GRAVEN_INNOCENCE_RACE_RESTART")] GravenInnocenceRaceRestart = 86,
    [pbr::OriginalName("ENTER_REASON_VINTAGE_HUNTING_TRANSFER")] VintageHuntingTransfer = 87,
    [pbr::OriginalName("ENTER_REASON_FUNGUS_FIGHTER_TRANSFER")] FungusFighterTransfer = 88,
    [pbr::OriginalName("ENTER_REASON_BRICK_BREAKER")] BrickBreaker = 89,
    [pbr::OriginalName("ENTER_REASON_BRICK_BREAKER_SINGLE")] BrickBreakerSingle = 90,
    [pbr::OriginalName("ENTER_REASON_TRANSFER_GUARD_STOP")] TransferGuardStop = 91,
    [pbr::OriginalName("ENTER_REASON_COIN_COLLECT_SINGLE")] CoinCollectSingle = 92,
  }

  #endregion

}

#endregion Designer generated code
