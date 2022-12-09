// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VisionType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from VisionType.proto</summary>
  public static partial class VisionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for VisionType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VisionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBWaXNpb25UeXBlLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3Jr",
            "LlByb3RvKq4ECgpWaXNpb25UeXBlEhQKEFZJU0lPTl9UWVBFX05PTkUQABIU",
            "ChBWSVNJT05fVFlQRV9NRUVUEAESFgoSVklTSU9OX1RZUEVfUkVCT1JOEAIS",
            "FwoTVklTSU9OX1RZUEVfUkVQTEFDRRADEh8KG1ZJU0lPTl9UWVBFX1dBWVBP",
            "SU5UX1JFQk9SThAEEhQKEFZJU0lPTl9UWVBFX01JU1MQBRITCg9WSVNJT05f",
            "VFlQRV9ESUUQBhIdChlWSVNJT05fVFlQRV9HQVRIRVJfRVNDQVBFEAcSFwoT",
            "VklTSU9OX1RZUEVfUkVGUkVTSBAIEhkKFVZJU0lPTl9UWVBFX1RSQU5TUE9S",
            "VBAJEhsKF1ZJU0lPTl9UWVBFX1JFUExBQ0VfRElFEAoSIQodVklTSU9OX1RZ",
            "UEVfUkVQTEFDRV9OT19OT1RJRlkQCxIUChBWSVNJT05fVFlQRV9CT1JOEAwS",
            "FgoSVklTSU9OX1RZUEVfUElDS1VQEA0SFgoSVklTSU9OX1RZUEVfUkVNT1ZF",
            "EA4SHgoaVklTSU9OX1RZUEVfQ0hBTkdFX0NPU1RVTUUQDxIcChhWSVNJT05f",
            "VFlQRV9GSVNIX1JFRlJFU0gQEBIeChpWSVNJT05fVFlQRV9GSVNIX0JJR19T",
            "SE9DSxAREh0KGVZJU0lPTl9UWVBFX0ZJU0hfUVRFX1NVQ0MQEhIhCh1WSVNJ",
            "T05fVFlQRV9DQVBUVVJFX0RJU0FQUEVBUhATYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.VisionType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum VisionType {
    [pbr::OriginalName("VISION_TYPE_NONE")] None = 0,
    [pbr::OriginalName("VISION_TYPE_MEET")] Meet = 1,
    [pbr::OriginalName("VISION_TYPE_REBORN")] Reborn = 2,
    [pbr::OriginalName("VISION_TYPE_REPLACE")] Replace = 3,
    [pbr::OriginalName("VISION_TYPE_WAYPOINT_REBORN")] WaypointReborn = 4,
    [pbr::OriginalName("VISION_TYPE_MISS")] Miss = 5,
    [pbr::OriginalName("VISION_TYPE_DIE")] Die = 6,
    [pbr::OriginalName("VISION_TYPE_GATHER_ESCAPE")] GatherEscape = 7,
    [pbr::OriginalName("VISION_TYPE_REFRESH")] Refresh = 8,
    [pbr::OriginalName("VISION_TYPE_TRANSPORT")] Transport = 9,
    [pbr::OriginalName("VISION_TYPE_REPLACE_DIE")] ReplaceDie = 10,
    [pbr::OriginalName("VISION_TYPE_REPLACE_NO_NOTIFY")] ReplaceNoNotify = 11,
    [pbr::OriginalName("VISION_TYPE_BORN")] Born = 12,
    [pbr::OriginalName("VISION_TYPE_PICKUP")] Pickup = 13,
    [pbr::OriginalName("VISION_TYPE_REMOVE")] Remove = 14,
    [pbr::OriginalName("VISION_TYPE_CHANGE_COSTUME")] ChangeCostume = 15,
    [pbr::OriginalName("VISION_TYPE_FISH_REFRESH")] FishRefresh = 16,
    [pbr::OriginalName("VISION_TYPE_FISH_BIG_SHOCK")] FishBigShock = 17,
    [pbr::OriginalName("VISION_TYPE_FISH_QTE_SUCC")] FishQteSucc = 18,
    [pbr::OriginalName("VISION_TYPE_CAPTURE_DISAPPEAR")] CaptureDisappear = 19,
  }

  #endregion

}

#endregion Designer generated code
