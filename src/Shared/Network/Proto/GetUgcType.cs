// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetUgcType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GetUgcType.proto</summary>
  public static partial class GetUgcTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for GetUgcType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetUgcTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBHZXRVZ2NUeXBlLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3Jr",
            "LlByb3RvKlQKCkdldFVnY1R5cGUSFQoRR0VUX1VHQ19UWVBFX05PTkUQABIV",
            "ChFHRVRfVUdDX1RZUEVfTUlORRABEhgKFEdFVF9VR0NfVFlQRV9QVUJMSVNI",
            "EAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.GetUgcType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum GetUgcType {
    [pbr::OriginalName("GET_UGC_TYPE_NONE")] None = 0,
    [pbr::OriginalName("GET_UGC_TYPE_MINE")] Mine = 1,
    [pbr::OriginalName("GET_UGC_TYPE_PUBLISH")] Publish = 2,
  }

  #endregion

}

#endregion Designer generated code
