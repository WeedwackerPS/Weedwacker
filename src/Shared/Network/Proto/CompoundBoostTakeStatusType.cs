// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CompoundBoostTakeStatusType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CompoundBoostTakeStatusType.proto</summary>
  public static partial class CompoundBoostTakeStatusTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for CompoundBoostTakeStatusType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompoundBoostTakeStatusTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFDb21wb3VuZEJvb3N0VGFrZVN0YXR1c1R5cGUucHJvdG8q2QEKG0NvbXBv",
            "dW5kQm9vc3RUYWtlU3RhdHVzVHlwZRIoCiRDT01QT1VORF9CT09TVF9UQUtF",
            "X1NUQVRVU19UWVBFX05PTkUQABIuCipDT01QT1VORF9CT09TVF9UQUtFX1NU",
            "QVRVU19UWVBFX0JPT1NUX09OTFkQARIyCi5DT01QT1VORF9CT09TVF9UQUtF",
            "X1NUQVRVU19UWVBFX0JPT1NUX0FORF9UQUtFEAISLAooQ09NUE9VTkRfQk9P",
            "U1RfVEFLRV9TVEFUVVNfVFlQRV9CQUdfRlVMTBADQiKqAh9XZWVkd2Fja2Vy",
            "LlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.CompoundBoostTakeStatusType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum CompoundBoostTakeStatusType {
    [pbr::OriginalName("COMPOUND_BOOST_TAKE_STATUS_TYPE_NONE")] None = 0,
    [pbr::OriginalName("COMPOUND_BOOST_TAKE_STATUS_TYPE_BOOST_ONLY")] BoostOnly = 1,
    [pbr::OriginalName("COMPOUND_BOOST_TAKE_STATUS_TYPE_BOOST_AND_TAKE")] BoostAndTake = 2,
    [pbr::OriginalName("COMPOUND_BOOST_TAKE_STATUS_TYPE_BAG_FULL")] BagFull = 3,
  }

  #endregion

}

#endregion Designer generated code