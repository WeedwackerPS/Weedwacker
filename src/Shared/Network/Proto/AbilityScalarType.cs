// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityScalarType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AbilityScalarType.proto</summary>
  public static partial class AbilityScalarTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityScalarType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityScalarTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdBYmlsaXR5U2NhbGFyVHlwZS5wcm90byrtAQoRQWJpbGl0eVNjYWxhclR5",
            "cGUSHwobQUJJTElUWV9TQ0FMQVJfVFlQRV9VTktOT1dOEAASHQoZQUJJTElU",
            "WV9TQ0FMQVJfVFlQRV9GTE9BVBABEhsKF0FCSUxJVFlfU0NBTEFSX1RZUEVf",
            "SU5UEAISHAoYQUJJTElUWV9TQ0FMQVJfVFlQRV9CT09MEAMSHwobQUJJTElU",
            "WV9TQ0FMQVJfVFlQRV9UUklHR0VSEAQSHgoaQUJJTElUWV9TQ0FMQVJfVFlQ",
            "RV9TVFJJTkcQBRIcChhBQklMSVRZX1NDQUxBUl9UWVBFX1VJTlQQBkIiqgIf",
            "V2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.AbilityScalarType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum AbilityScalarType {
    [pbr::OriginalName("ABILITY_SCALAR_TYPE_UNKNOWN")] Unknown = 0,
    [pbr::OriginalName("ABILITY_SCALAR_TYPE_FLOAT")] Float = 1,
    [pbr::OriginalName("ABILITY_SCALAR_TYPE_INT")] Int = 2,
    [pbr::OriginalName("ABILITY_SCALAR_TYPE_BOOL")] Bool = 3,
    [pbr::OriginalName("ABILITY_SCALAR_TYPE_TRIGGER")] Trigger = 4,
    [pbr::OriginalName("ABILITY_SCALAR_TYPE_STRING")] String = 5,
    [pbr::OriginalName("ABILITY_SCALAR_TYPE_UINT")] Uint = 6,
  }

  #endregion

}

#endregion Designer generated code
