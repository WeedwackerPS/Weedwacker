// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MatchReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from MatchReason.proto</summary>
  public static partial class MatchReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for MatchReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MatchReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFNYXRjaFJlYXNvbi5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29y",
            "ay5Qcm90byqxAgoLTWF0Y2hSZWFzb24SFQoRTUFUQ0hfUkVBU09OX05PTkUQ",
            "ABIXChNNQVRDSF9SRUFTT05fRklOSVNIEAESHgoaTUFUQ0hfUkVBU09OX1BM",
            "QVlFUl9DQU5DRUwQAhIYChRNQVRDSF9SRUFTT05fVElNRU9VVBADEh8KG01B",
            "VENIX1JFQVNPTl9QTEFZRVJfQ09ORklSTRAEEhcKE01BVENIX1JFQVNPTl9G",
            "QUlMRUQQBRIdChlNQVRDSF9SRUFTT05fU1lTVEVNX0VSUk9SEAYSHAoYTUFU",
            "Q0hfUkVBU09OX0lOVEVSUlVQVEVEEAcSHwobTUFUQ0hfUkVBU09OX01QX1VO",
            "QVZBSUxBQkxFEAgSIAocTUFUQ0hfUkVBU09OX0NPTkZJUk1fVElNRU9VVBAJ",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.MatchReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MatchReason {
    [pbr::OriginalName("MATCH_REASON_NONE")] None = 0,
    [pbr::OriginalName("MATCH_REASON_FINISH")] Finish = 1,
    [pbr::OriginalName("MATCH_REASON_PLAYER_CANCEL")] PlayerCancel = 2,
    [pbr::OriginalName("MATCH_REASON_TIMEOUT")] Timeout = 3,
    [pbr::OriginalName("MATCH_REASON_PLAYER_CONFIRM")] PlayerConfirm = 4,
    [pbr::OriginalName("MATCH_REASON_FAILED")] Failed = 5,
    [pbr::OriginalName("MATCH_REASON_SYSTEM_ERROR")] SystemError = 6,
    [pbr::OriginalName("MATCH_REASON_INTERRUPTED")] Interrupted = 7,
    [pbr::OriginalName("MATCH_REASON_MP_UNAVAILABLE")] MpUnavailable = 8,
    [pbr::OriginalName("MATCH_REASON_CONFIRM_TIMEOUT")] ConfirmTimeout = 9,
  }

  #endregion

}

#endregion Designer generated code
