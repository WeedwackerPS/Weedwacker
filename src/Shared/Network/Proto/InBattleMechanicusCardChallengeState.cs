// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InBattleMechanicusCardChallengeState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from InBattleMechanicusCardChallengeState.proto</summary>
  public static partial class InBattleMechanicusCardChallengeStateReflection {

    #region Descriptor
    /// <summary>File descriptor for InBattleMechanicusCardChallengeState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InBattleMechanicusCardChallengeStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipJbkJhdHRsZU1lY2hhbmljdXNDYXJkQ2hhbGxlbmdlU3RhdGUucHJvdG8q",
            "/QEKJEluQmF0dGxlTWVjaGFuaWN1c0NhcmRDaGFsbGVuZ2VTdGF0ZRIyCi5J",
            "Tl9CQVRUTEVfTUVDSEFOSUNVU19DQVJEX0NIQUxMRU5HRV9TVEFURV9OT05F",
            "EAASNgoySU5fQkFUVExFX01FQ0hBTklDVVNfQ0FSRF9DSEFMTEVOR0VfU1RB",
            "VEVfT05fR09JTkcQARIyCi5JTl9CQVRUTEVfTUVDSEFOSUNVU19DQVJEX0NI",
            "QUxMRU5HRV9TVEFURV9GQUlMEAISNQoxSU5fQkFUVExFX01FQ0hBTklDVVNf",
            "Q0FSRF9DSEFMTEVOR0VfU1RBVEVfU1VDQ0VTUxADQiKqAh9XZWVkd2Fja2Vy",
            "LlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.InBattleMechanicusCardChallengeState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum InBattleMechanicusCardChallengeState {
    [pbr::OriginalName("IN_BATTLE_MECHANICUS_CARD_CHALLENGE_STATE_NONE")] None = 0,
    [pbr::OriginalName("IN_BATTLE_MECHANICUS_CARD_CHALLENGE_STATE_ON_GOING")] OnGoing = 1,
    [pbr::OriginalName("IN_BATTLE_MECHANICUS_CARD_CHALLENGE_STATE_FAIL")] Fail = 2,
    [pbr::OriginalName("IN_BATTLE_MECHANICUS_CARD_CHALLENGE_STATE_SUCCESS")] Success = 3,
  }

  #endregion

}

#endregion Designer generated code
