// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneidConstValue.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SceneidConstValue.proto</summary>
  public static partial class SceneidConstValueReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneidConstValue.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneidConstValueReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdTY2VuZWlkQ29uc3RWYWx1ZS5wcm90byrfAQoRU2NlbmVpZENvbnN0VmFs",
            "dWUSHAoYU0NFTkVJRF9DT05TVF9WQUxVRV9OT05FEAASHAoYU0NFTkVJRF9D",
            "T05TVF9WQUxVRV9NQUlOEAMSHgoaU0NFTkVJRF9DT05TVF9WQUxVRV9JU0xB",
            "TkQQBBIiCh5TQ0VORUlEX0NPTlNUX1ZBTFVFX0VOS0FOT01JWUEQBRInCiNT",
            "Q0VORUlEX0NPTlNUX1ZBTFVFX01JQ0hJQUVfTUFUU1VSSRAHEiEKHVNDRU5F",
            "SURfQ09OU1RfVkFMVUVfMjhfSVNMQU5EEAlCIqoCH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.SceneidConstValue), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum SceneidConstValue {
    [pbr::OriginalName("SCENEID_CONST_VALUE_NONE")] None = 0,
    [pbr::OriginalName("SCENEID_CONST_VALUE_MAIN")] Main = 3,
    [pbr::OriginalName("SCENEID_CONST_VALUE_ISLAND")] Island = 4,
    [pbr::OriginalName("SCENEID_CONST_VALUE_ENKANOMIYA")] Enkanomiya = 5,
    [pbr::OriginalName("SCENEID_CONST_VALUE_MICHIAE_MATSURI")] MichiaeMatsuri = 7,
    [pbr::OriginalName("SCENEID_CONST_VALUE_28_ISLAND")] _28Island = 9,
  }

  #endregion

}

#endregion Designer generated code
