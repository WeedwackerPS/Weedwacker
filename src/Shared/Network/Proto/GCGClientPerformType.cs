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
            "ChpHQ0dDbGllbnRQZXJmb3JtVHlwZS5wcm90bxIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90byqyAQoUR0NHQ2xpZW50UGVyZm9ybVR5cGUSIwof",
            "R0NHX0NMSUVOVF9QRVJGT1JNX1RZUEVfSU5WQUxJRBAAEikKJUdDR19DTElF",
            "TlRfUEVSRk9STV9UWVBFX0NBUkRfRVhDSEFOR0UQARImCiJHQ0dfQ0xJRU5U",
            "X1BFUkZPUk1fVFlQRV9GSVJTVF9IQU5EEAISIgoeR0NHX0NMSUVOVF9QRVJG",
            "T1JNX1RZUEVfUkVST0xMEANiBnByb3RvMw=="));
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
    [pbr::OriginalName("GCG_CLIENT_PERFORM_TYPE_FIRST_HAND")] FirstHand = 2,
    [pbr::OriginalName("GCG_CLIENT_PERFORM_TYPE_REROLL")] Reroll = 3,
  }

  #endregion

}

#endregion Designer generated code
