// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BrickBreakerStageType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BrickBreakerStageType.proto</summary>
  public static partial class BrickBreakerStageTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for BrickBreakerStageType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BrickBreakerStageTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtCcmlja0JyZWFrZXJTdGFnZVR5cGUucHJvdG8qywEKFUJyaWNrQnJlYWtl",
            "clN0YWdlVHlwZRIkCiBCUklDS19CUkVBS0VSX1NUQUdFX1RZUEVfUFJFUEFS",
            "RRAAEiEKHUJSSUNLX0JSRUFLRVJfU1RBR0VfVFlQRV9QSUNLEAESIQodQlJJ",
            "Q0tfQlJFQUtFUl9TVEFHRV9UWVBFX0dBTUUQAhIhCh1CUklDS19CUkVBS0VS",
            "X1NUQUdFX1RZUEVfUExBWRADEiMKH0JSSUNLX0JSRUFLRVJfU1RBR0VfVFlQ",
            "RV9TRVRUTEUQBEIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.BrickBreakerStageType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum BrickBreakerStageType {
    [pbr::OriginalName("BRICK_BREAKER_STAGE_TYPE_PREPARE")] Prepare = 0,
    [pbr::OriginalName("BRICK_BREAKER_STAGE_TYPE_PICK")] Pick = 1,
    [pbr::OriginalName("BRICK_BREAKER_STAGE_TYPE_GAME")] Game = 2,
    [pbr::OriginalName("BRICK_BREAKER_STAGE_TYPE_PLAY")] Play = 3,
    [pbr::OriginalName("BRICK_BREAKER_STAGE_TYPE_SETTLE")] Settle = 4,
  }

  #endregion

}

#endregion Designer generated code
