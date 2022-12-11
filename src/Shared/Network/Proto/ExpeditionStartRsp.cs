// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ExpeditionStartRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ExpeditionStartRsp.proto</summary>
  public static partial class ExpeditionStartRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ExpeditionStartRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExpeditionStartRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhFeHBlZGl0aW9uU3RhcnRSc3AucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG8iiAEKEkV4cGVkaXRpb25TdGFydFJzcBIbChNVbmsz",
            "MzAwX0FJRUpLQURGTEtHGAUgASgNEg8KB3BhdGhfaWQYAyABKA0SDwoHcmV0",
            "Y29kZRgGIAEoBRIWCg5hdmF0YXJfaWRfbGlzdBgEIAMoDRIbChNVbmszMzAw",
            "X0FGR1BHSUlHQUtBGAogASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ExpeditionStartRsp), global::Weedwacker.Shared.Network.Proto.ExpeditionStartRsp.Parser, new[]{ "Unk3300AIEJKADFLKG", "PathId", "Retcode", "AvatarIdList", "Unk3300AFGPGIIGAKA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 2182;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class ExpeditionStartRsp : pb::IMessage<ExpeditionStartRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExpeditionStartRsp> _parser = new pb::MessageParser<ExpeditionStartRsp>(() => new ExpeditionStartRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExpeditionStartRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ExpeditionStartRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExpeditionStartRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExpeditionStartRsp(ExpeditionStartRsp other) : this() {
      unk3300AIEJKADFLKG_ = other.unk3300AIEJKADFLKG_;
      pathId_ = other.pathId_;
      retcode_ = other.retcode_;
      avatarIdList_ = other.avatarIdList_.Clone();
      unk3300AFGPGIIGAKA_ = other.unk3300AFGPGIIGAKA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExpeditionStartRsp Clone() {
      return new ExpeditionStartRsp(this);
    }

    /// <summary>Field number for the "Unk3300_AIEJKADFLKG" field.</summary>
    public const int Unk3300AIEJKADFLKGFieldNumber = 5;
    private uint unk3300AIEJKADFLKG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300AIEJKADFLKG {
      get { return unk3300AIEJKADFLKG_; }
      set {
        unk3300AIEJKADFLKG_ = value;
      }
    }

    /// <summary>Field number for the "path_id" field.</summary>
    public const int PathIdFieldNumber = 3;
    private uint pathId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PathId {
      get { return pathId_; }
      set {
        pathId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "avatar_id_list" field.</summary>
    public const int AvatarIdListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_avatarIdList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> avatarIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AvatarIdList {
      get { return avatarIdList_; }
    }

    /// <summary>Field number for the "Unk3300_AFGPGIIGAKA" field.</summary>
    public const int Unk3300AFGPGIIGAKAFieldNumber = 10;
    private uint unk3300AFGPGIIGAKA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300AFGPGIIGAKA {
      get { return unk3300AFGPGIIGAKA_; }
      set {
        unk3300AFGPGIIGAKA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExpeditionStartRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExpeditionStartRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300AIEJKADFLKG != other.Unk3300AIEJKADFLKG) return false;
      if (PathId != other.PathId) return false;
      if (Retcode != other.Retcode) return false;
      if(!avatarIdList_.Equals(other.avatarIdList_)) return false;
      if (Unk3300AFGPGIIGAKA != other.Unk3300AFGPGIIGAKA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300AIEJKADFLKG != 0) hash ^= Unk3300AIEJKADFLKG.GetHashCode();
      if (PathId != 0) hash ^= PathId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= avatarIdList_.GetHashCode();
      if (Unk3300AFGPGIIGAKA != 0) hash ^= Unk3300AFGPGIIGAKA.GetHashCode();
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
      if (PathId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PathId);
      }
      avatarIdList_.WriteTo(output, _repeated_avatarIdList_codec);
      if (Unk3300AIEJKADFLKG != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300AIEJKADFLKG);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Retcode);
      }
      if (Unk3300AFGPGIIGAKA != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300AFGPGIIGAKA);
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
      if (PathId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PathId);
      }
      avatarIdList_.WriteTo(ref output, _repeated_avatarIdList_codec);
      if (Unk3300AIEJKADFLKG != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300AIEJKADFLKG);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Retcode);
      }
      if (Unk3300AFGPGIIGAKA != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300AFGPGIIGAKA);
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
      if (Unk3300AIEJKADFLKG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300AIEJKADFLKG);
      }
      if (PathId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PathId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += avatarIdList_.CalculateSize(_repeated_avatarIdList_codec);
      if (Unk3300AFGPGIIGAKA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300AFGPGIIGAKA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExpeditionStartRsp other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300AIEJKADFLKG != 0) {
        Unk3300AIEJKADFLKG = other.Unk3300AIEJKADFLKG;
      }
      if (other.PathId != 0) {
        PathId = other.PathId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      avatarIdList_.Add(other.avatarIdList_);
      if (other.Unk3300AFGPGIIGAKA != 0) {
        Unk3300AFGPGIIGAKA = other.Unk3300AFGPGIIGAKA;
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
          case 24: {
            PathId = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            avatarIdList_.AddEntriesFrom(input, _repeated_avatarIdList_codec);
            break;
          }
          case 40: {
            Unk3300AIEJKADFLKG = input.ReadUInt32();
            break;
          }
          case 48: {
            Retcode = input.ReadInt32();
            break;
          }
          case 80: {
            Unk3300AFGPGIIGAKA = input.ReadUInt32();
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
            PathId = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            avatarIdList_.AddEntriesFrom(ref input, _repeated_avatarIdList_codec);
            break;
          }
          case 40: {
            Unk3300AIEJKADFLKG = input.ReadUInt32();
            break;
          }
          case 48: {
            Retcode = input.ReadInt32();
            break;
          }
          case 80: {
            Unk3300AFGPGIIGAKA = input.ReadUInt32();
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
