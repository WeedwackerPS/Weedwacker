// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonsterBornType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from MonsterBornType.proto</summary>
  public static partial class MonsterBornTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for MonsterBornType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonsterBornTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVNb25zdGVyQm9yblR5cGUucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5l",
            "dHdvcmsuUHJvdG8qagoPTW9uc3RlckJvcm5UeXBlEhoKFk1PTlNURVJfQk9S",
            "Tl9UWVBFX05PTkUQABIdChlNT05TVEVSX0JPUk5fVFlQRV9ERUZBVUxUEAES",
            "HAoYTU9OU1RFUl9CT1JOX1RZUEVfUkFORE9NEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.MonsterBornType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MonsterBornType {
    [pbr::OriginalName("MONSTER_BORN_TYPE_NONE")] None = 0,
    [pbr::OriginalName("MONSTER_BORN_TYPE_DEFAULT")] Default = 1,
    [pbr::OriginalName("MONSTER_BORN_TYPE_RANDOM")] Random = 2,
  }

  #endregion

}

#endregion Designer generated code
