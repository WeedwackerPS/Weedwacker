// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChangeHpReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ChangeHpReason.proto</summary>
  public static partial class ChangeHpReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for ChangeHpReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeHpReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRDaGFuZ2VIcFJlYXNvbi5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQuTmV0",
            "d29yay5Qcm90byqmCAoOQ2hhbmdlSHBSZWFzb24SGQoVQ0hBTkdFX0hQX1JF",
            "QVNPTl9OT05FEAASHwobQ0hBTkdFX0hQX1JFQVNPTl9TVUJfQVZBVEFSEAES",
            "IAocQ0hBTkdFX0hQX1JFQVNPTl9TVUJfTU9OU1RFUhACEh0KGUNIQU5HRV9I",
            "UF9SRUFTT05fU1VCX0dFQVIQAxIeChpDSEFOR0VfSFBfUkVBU09OX1NVQl9F",
            "TlZJUhAEEh0KGUNIQU5HRV9IUF9SRUFTT05fU1VCX0ZBTEwQBRIeChpDSEFO",
            "R0VfSFBfUkVBU09OX1NVQl9EUkFXThAGEh4KGkNIQU5HRV9IUF9SRUFTT05f",
            "U1VCX0FCWVNTEAcSIAocQ0hBTkdFX0hQX1JFQVNPTl9TVUJfQUJJTElUWRAI",
            "Eh8KG0NIQU5HRV9IUF9SRUFTT05fU1VCX1NVTU1PThAJEh8KG0NIQU5HRV9I",
            "UF9SRUFTT05fU1VCX1NDUklQVBAKEhsKF0NIQU5HRV9IUF9SRUFTT05fU1VC",
            "X0dNEAsSIgoeQ0hBTkdFX0hQX1JFQVNPTl9TVUJfS0lMTF9TRUxGEAwSJQoh",
            "Q0hBTkdFX0hQX1JFQVNPTl9TVUJfQ0xJTUFURV9DT0xEEA0SKAokQ0hBTkdF",
            "X0hQX1JFQVNPTl9TVUJfU1RPUk1fTElHSFROSU5HEA4SKwonQ0hBTkdFX0hQ",
            "X1JFQVNPTl9TVUJfS0lMTF9TRVJWRVJfR0FER0VUEA8SIAocQ0hBTkdFX0hQ",
            "X1JFQVNPTl9TVUJfUkVQTEFDRRAQEiUKIUNIQU5HRV9IUF9SRUFTT05fU1VC",
            "X1BMQVlFUl9MRUFWRRAREiUKIUNIQU5HRV9IUF9SRUFTT05fQVRUQUNLX0JZ",
            "X0VORVJHWRASEiYKIkNIQU5HRV9IUF9SRUFTT05fQVRUQUNLX0JZX1JFQ1lD",
            "TEUQExIbChdDSEFOR0VfSFBfUkVBU09OX0JZX0xVQRAzEiAKHENIQU5HRV9I",
            "UF9SRUFTT05fQUREX0FCSUxJVFkQZRIdChlDSEFOR0VfSFBfUkVBU09OX0FE",
            "RF9JVEVNEGYSHwobQ0hBTkdFX0hQX1JFQVNPTl9BRERfUkVWSVZFEGcSIAoc",
            "Q0hBTkdFX0hQX1JFQVNPTl9BRERfVVBHUkFERRBoEh8KG0NIQU5HRV9IUF9S",
            "RUFTT05fQUREX1NUQVRVRRBpEiMKH0NIQU5HRV9IUF9SRUFTT05fQUREX0JB",
            "Q0tHUk9VTkQQahIbChdDSEFOR0VfSFBfUkVBU09OX0FERF9HTRBrEi4KKkNI",
            "QU5HRV9IUF9SRUFTT05fQUREX1RSSUFMX0FWQVRBUl9BQ1RJVklUWRBsEikK",
            "JUNIQU5HRV9IUF9SRUFTT05fQUREX1JPR1VFTElLRV9TUFJJTkcQbWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.ChangeHpReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ChangeHpReason {
    [pbr::OriginalName("CHANGE_HP_REASON_NONE")] None = 0,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_AVATAR")] SubAvatar = 1,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_MONSTER")] SubMonster = 2,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_GEAR")] SubGear = 3,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_ENVIR")] SubEnvir = 4,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_FALL")] SubFall = 5,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_DRAWN")] SubDrawn = 6,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_ABYSS")] SubAbyss = 7,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_ABILITY")] SubAbility = 8,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_SUMMON")] SubSummon = 9,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_SCRIPT")] SubScript = 10,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_GM")] SubGm = 11,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_KILL_SELF")] SubKillSelf = 12,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_CLIMATE_COLD")] SubClimateCold = 13,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_STORM_LIGHTNING")] SubStormLightning = 14,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_KILL_SERVER_GADGET")] SubKillServerGadget = 15,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_REPLACE")] SubReplace = 16,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_PLAYER_LEAVE")] SubPlayerLeave = 17,
    [pbr::OriginalName("CHANGE_HP_REASON_ATTACK_BY_ENERGY")] AttackByEnergy = 18,
    [pbr::OriginalName("CHANGE_HP_REASON_ATTACK_BY_RECYCLE")] AttackByRecycle = 19,
    [pbr::OriginalName("CHANGE_HP_REASON_BY_LUA")] ByLua = 51,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_ABILITY")] AddAbility = 101,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_ITEM")] AddItem = 102,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_REVIVE")] AddRevive = 103,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_UPGRADE")] AddUpgrade = 104,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_STATUE")] AddStatue = 105,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_BACKGROUND")] AddBackground = 106,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_GM")] AddGm = 107,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_TRIAL_AVATAR_ACTIVITY")] AddTrialAvatarActivity = 108,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_ROGUELIKE_SPRING")] AddRoguelikeSpring = 109,
  }

  #endregion

}

#endregion Designer generated code
