// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGClientPerformType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGClientPerformType.proto</summary>
  public static partial class GCGClientPerformTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGClientPerformType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGClientPerformTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpHQ0dDbGllbnRQZXJmb3JtVHlwZS5wcm90bypmChRHQ0dDbGllbnRQZXJm",
            "b3JtVHlwZRIjCh9HQ0dfQ0xJRU5UX1BFUkZPUk1fVFlQRV9JTlZBTElEEAAS",
            "KQolR0NHX0NMSUVOVF9QRVJGT1JNX1RZUEVfQ0FSRF9FWENIQU5HRRABQiKq",
            "Ah9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.GCGClientPerformType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum GCGClientPerformType {
    [pbr::OriginalName("GCG_CLIENT_PERFORM_TYPE_INVALID")] Invalid = 0,
    [pbr::OriginalName("GCG_CLIENT_PERFORM_TYPE_CARD_EXCHANGE")] CardExchange = 1,
  }

  #endregion

}

#endregion Designer generated code
