// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CoopChapterState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CoopChapterState.proto</summary>
  public static partial class CoopChapterStateReflection {

    #region Descriptor
    /// <summary>File descriptor for CoopChapterState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CoopChapterStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZDb29wQ2hhcHRlclN0YXRlLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5O",
            "ZXR3b3JrLlByb3RvKkgKEENvb3BDaGFwdGVyU3RhdGUSCQoFQ2xvc2UQABIP",
            "CgtDb25kTm90TWVldBABEgwKCENvbmRNZWV0EAISCgoGQWNjZXB0EANiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.CoopChapterState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum CoopChapterState {
    [pbr::OriginalName("Close")] Close = 0,
    [pbr::OriginalName("CondNotMeet")] CondNotMeet = 1,
    [pbr::OriginalName("CondMeet")] CondMeet = 2,
    [pbr::OriginalName("Accept")] Accept = 3,
  }

  #endregion

}

#endregion Designer generated code
