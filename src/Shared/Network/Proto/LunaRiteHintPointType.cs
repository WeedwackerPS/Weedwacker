// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LunaRiteHintPointType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from LunaRiteHintPointType.proto</summary>
  public static partial class LunaRiteHintPointTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for LunaRiteHintPointType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LunaRiteHintPointTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtMdW5hUml0ZUhpbnRQb2ludFR5cGUucHJvdG8SH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8qhAEKFUx1bmFSaXRlSGludFBvaW50VHlwZRIi",
            "Ch5MVU5BX1JJVEVfSElOVF9QT0lOVF9UWVBFX05PTkUQABIiCh5MVU5BX1JJ",
            "VEVfSElOVF9QT0lOVF9UWVBFX1JVTkUQARIjCh9MVU5BX1JJVEVfSElOVF9Q",
            "T0lOVF9UWVBFX0NIRVNUEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.LunaRiteHintPointType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum LunaRiteHintPointType {
    [pbr::OriginalName("LUNA_RITE_HINT_POINT_TYPE_NONE")] None = 0,
    [pbr::OriginalName("LUNA_RITE_HINT_POINT_TYPE_RUNE")] Rune = 1,
    [pbr::OriginalName("LUNA_RITE_HINT_POINT_TYPE_CHEST")] Chest = 2,
  }

  #endregion

}

#endregion Designer generated code
