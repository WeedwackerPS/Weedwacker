// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FriendOnlineState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FriendOnlineState.proto</summary>
  public static partial class FriendOnlineStateReflection {

    #region Descriptor
    /// <summary>File descriptor for FriendOnlineState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FriendOnlineStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdGcmllbmRPbmxpbmVTdGF0ZS5wcm90bypXChFGcmllbmRPbmxpbmVTdGF0",
            "ZRIiCh5GUklFTkRfT05MSU5FX1NUQVRFX0RJU0NPTk5FQ1QQABIeChpGUklF",
            "TkRfT05MSU5FX1NUQVRFX09OTElORRABQiKqAh9XZWVkd2Fja2VyLlNoYXJl",
            "ZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.FriendOnlineState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum FriendOnlineState {
    [pbr::OriginalName("FRIEND_ONLINE_STATE_DISCONNECT")] Disconnect = 0,
    [pbr::OriginalName("FRIEND_ONLINE_STATE_ONLINE")] Online = 1,
  }

  #endregion

}

#endregion Designer generated code
