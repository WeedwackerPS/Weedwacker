// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChallengeFinishType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ChallengeFinishType.proto</summary>
  public static partial class ChallengeFinishTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for ChallengeFinishType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChallengeFinishTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlDaGFsbGVuZ2VGaW5pc2hUeXBlLnByb3RvKpYBChNDaGFsbGVuZ2VGaW5p",
            "c2hUeXBlEh4KGkNIQUxMRU5HRV9GSU5JU0hfVFlQRV9OT05FEAASHgoaQ0hB",
            "TExFTkdFX0ZJTklTSF9UWVBFX0ZBSUwQARIeChpDSEFMTEVOR0VfRklOSVNI",
            "X1RZUEVfU1VDQxACEh8KG0NIQUxMRU5HRV9GSU5JU0hfVFlQRV9QQVVTRRAD",
            "QiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.ChallengeFinishType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ChallengeFinishType {
    [pbr::OriginalName("CHALLENGE_FINISH_TYPE_NONE")] None = 0,
    [pbr::OriginalName("CHALLENGE_FINISH_TYPE_FAIL")] Fail = 1,
    [pbr::OriginalName("CHALLENGE_FINISH_TYPE_SUCC")] Succ = 2,
    [pbr::OriginalName("CHALLENGE_FINISH_TYPE_PAUSE")] Pause = 3,
  }

  #endregion

}

#endregion Designer generated code
