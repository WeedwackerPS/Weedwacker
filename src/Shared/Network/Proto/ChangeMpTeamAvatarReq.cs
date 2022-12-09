// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChangeMpTeamAvatarReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ChangeMpTeamAvatarReq.proto</summary>
  public static partial class ChangeMpTeamAvatarReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ChangeMpTeamAvatarReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeMpTeamAvatarReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtDaGFuZ2VNcFRlYW1BdmF0YXJSZXEucHJvdG8SH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8iSgoVQ2hhbmdlTXBUZWFtQXZhdGFyUmVxEhcK",
            "D2N1cl9hdmF0YXJfZ3VpZBgDIAEoBBIYChBhdmF0YXJfZ3VpZF9saXN0GA4g",
            "AygEYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ChangeMpTeamAvatarReq), global::Weedwacker.Shared.Network.Proto.ChangeMpTeamAvatarReq.Parser, new[]{ "CurAvatarGuid", "AvatarGuidList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1645;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class ChangeMpTeamAvatarReq : pb::IMessage<ChangeMpTeamAvatarReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChangeMpTeamAvatarReq> _parser = new pb::MessageParser<ChangeMpTeamAvatarReq>(() => new ChangeMpTeamAvatarReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChangeMpTeamAvatarReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ChangeMpTeamAvatarReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeMpTeamAvatarReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeMpTeamAvatarReq(ChangeMpTeamAvatarReq other) : this() {
      curAvatarGuid_ = other.curAvatarGuid_;
      avatarGuidList_ = other.avatarGuidList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeMpTeamAvatarReq Clone() {
      return new ChangeMpTeamAvatarReq(this);
    }

    /// <summary>Field number for the "cur_avatar_guid" field.</summary>
    public const int CurAvatarGuidFieldNumber = 3;
    private ulong curAvatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong CurAvatarGuid {
      get { return curAvatarGuid_; }
      set {
        curAvatarGuid_ = value;
      }
    }

    /// <summary>Field number for the "avatar_guid_list" field.</summary>
    public const int AvatarGuidListFieldNumber = 14;
    private static readonly pb::FieldCodec<ulong> _repeated_avatarGuidList_codec
        = pb::FieldCodec.ForUInt64(114);
    private readonly pbc::RepeatedField<ulong> avatarGuidList_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<ulong> AvatarGuidList {
      get { return avatarGuidList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChangeMpTeamAvatarReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChangeMpTeamAvatarReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurAvatarGuid != other.CurAvatarGuid) return false;
      if(!avatarGuidList_.Equals(other.avatarGuidList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurAvatarGuid != 0UL) hash ^= CurAvatarGuid.GetHashCode();
      hash ^= avatarGuidList_.GetHashCode();
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
      if (CurAvatarGuid != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(CurAvatarGuid);
      }
      avatarGuidList_.WriteTo(output, _repeated_avatarGuidList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CurAvatarGuid != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(CurAvatarGuid);
      }
      avatarGuidList_.WriteTo(ref output, _repeated_avatarGuidList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (CurAvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(CurAvatarGuid);
      }
      size += avatarGuidList_.CalculateSize(_repeated_avatarGuidList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChangeMpTeamAvatarReq other) {
      if (other == null) {
        return;
      }
      if (other.CurAvatarGuid != 0UL) {
        CurAvatarGuid = other.CurAvatarGuid;
      }
      avatarGuidList_.Add(other.avatarGuidList_);
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
          case 24: {
            CurAvatarGuid = input.ReadUInt64();
            break;
          }
          case 114:
          case 112: {
            avatarGuidList_.AddEntriesFrom(input, _repeated_avatarGuidList_codec);
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
          case 24: {
            CurAvatarGuid = input.ReadUInt64();
            break;
          }
          case 114:
          case 112: {
            avatarGuidList_.AddEntriesFrom(ref input, _repeated_avatarGuidList_codec);
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
