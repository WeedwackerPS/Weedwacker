// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerApplyEnterHomeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PlayerApplyEnterHomeNotify.proto</summary>
  public static partial class PlayerApplyEnterHomeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerApplyEnterHomeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerApplyEnterHomeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBQbGF5ZXJBcHBseUVudGVySG9tZU5vdGlmeS5wcm90bxIfV2VlZHdhY2tl",
            "ci5TaGFyZWQuTmV0d29yay5Qcm90bxoWT25saW5lUGxheWVySW5mby5wcm90",
            "byJ8ChpQbGF5ZXJBcHBseUVudGVySG9tZU5vdGlmeRISCgpzcmNfYXBwX2lk",
            "GAggASgNEkoKD3NyY19wbGF5ZXJfaW5mbxgKIAEoCzIxLldlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG8uT25saW5lUGxheWVySW5mb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PlayerApplyEnterHomeNotify), global::Weedwacker.Shared.Network.Proto.PlayerApplyEnterHomeNotify.Parser, new[]{ "SrcAppId", "SrcPlayerInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4486;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class PlayerApplyEnterHomeNotify : pb::IMessage<PlayerApplyEnterHomeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerApplyEnterHomeNotify> _parser = new pb::MessageParser<PlayerApplyEnterHomeNotify>(() => new PlayerApplyEnterHomeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerApplyEnterHomeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PlayerApplyEnterHomeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerApplyEnterHomeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerApplyEnterHomeNotify(PlayerApplyEnterHomeNotify other) : this() {
      srcAppId_ = other.srcAppId_;
      srcPlayerInfo_ = other.srcPlayerInfo_ != null ? other.srcPlayerInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerApplyEnterHomeNotify Clone() {
      return new PlayerApplyEnterHomeNotify(this);
    }

    /// <summary>Field number for the "src_app_id" field.</summary>
    public const int SrcAppIdFieldNumber = 8;
    private uint srcAppId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SrcAppId {
      get { return srcAppId_; }
      set {
        srcAppId_ = value;
      }
    }

    /// <summary>Field number for the "src_player_info" field.</summary>
    public const int SrcPlayerInfoFieldNumber = 10;
    private global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo srcPlayerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo SrcPlayerInfo {
      get { return srcPlayerInfo_; }
      set {
        srcPlayerInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerApplyEnterHomeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerApplyEnterHomeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SrcAppId != other.SrcAppId) return false;
      if (!object.Equals(SrcPlayerInfo, other.SrcPlayerInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SrcAppId != 0) hash ^= SrcAppId.GetHashCode();
      if (srcPlayerInfo_ != null) hash ^= SrcPlayerInfo.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (SrcAppId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SrcAppId);
      }
      if (srcPlayerInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(SrcPlayerInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (SrcAppId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SrcAppId);
      }
      if (srcPlayerInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(SrcPlayerInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (SrcAppId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SrcAppId);
      }
      if (srcPlayerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SrcPlayerInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerApplyEnterHomeNotify other) {
      if (other == null) {
        return;
      }
      if (other.SrcAppId != 0) {
        SrcAppId = other.SrcAppId;
      }
      if (other.srcPlayerInfo_ != null) {
        if (srcPlayerInfo_ == null) {
          SrcPlayerInfo = new global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo();
        }
        SrcPlayerInfo.MergeFrom(other.SrcPlayerInfo);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 64: {
            SrcAppId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (srcPlayerInfo_ == null) {
              SrcPlayerInfo = new global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo();
            }
            input.ReadMessage(SrcPlayerInfo);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 64: {
            SrcAppId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (srcPlayerInfo_ == null) {
              SrcPlayerInfo = new global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo();
            }
            input.ReadMessage(SrcPlayerInfo);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
