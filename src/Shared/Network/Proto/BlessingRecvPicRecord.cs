// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BlessingRecvPicRecord.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BlessingRecvPicRecord.proto</summary>
  public static partial class BlessingRecvPicRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for BlessingRecvPicRecord.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BlessingRecvPicRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtCbGVzc2luZ1JlY3ZQaWNSZWNvcmQucHJvdG8SH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8aFFByb2ZpbGVQaWN0dXJlLnByb3RvIusBChVC",
            "bGVzc2luZ1JlY3ZQaWNSZWNvcmQSDwoHaXNfcmVjdhgCIAEoCBIQCghuaWNr",
            "bmFtZRgFIAEoCRIRCglhdmF0YXJfaWQYBiABKA0SSAoPcHJvZmlsZV9waWN0",
            "dXJlGAkgASgLMi8uV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5Q",
            "cm9maWxlUGljdHVyZRIRCglzaWduYXR1cmUYCiABKAkSEwoLcmVtYXJrX25h",
            "bWUYCCABKAkSCwoDdWlkGAMgASgNEg4KBnBpY19pZBgMIAEoDRINCgVpbmRl",
            "eBgLIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ProfilePictureReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BlessingRecvPicRecord), global::Weedwacker.Shared.Network.Proto.BlessingRecvPicRecord.Parser, new[]{ "IsRecv", "Nickname", "AvatarId", "ProfilePicture", "Signature", "RemarkName", "Uid", "PicId", "Index" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BlessingRecvPicRecord : pb::IMessage<BlessingRecvPicRecord>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BlessingRecvPicRecord> _parser = new pb::MessageParser<BlessingRecvPicRecord>(() => new BlessingRecvPicRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BlessingRecvPicRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BlessingRecvPicRecordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlessingRecvPicRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlessingRecvPicRecord(BlessingRecvPicRecord other) : this() {
      isRecv_ = other.isRecv_;
      nickname_ = other.nickname_;
      avatarId_ = other.avatarId_;
      profilePicture_ = other.profilePicture_ != null ? other.profilePicture_.Clone() : null;
      signature_ = other.signature_;
      remarkName_ = other.remarkName_;
      uid_ = other.uid_;
      picId_ = other.picId_;
      index_ = other.index_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlessingRecvPicRecord Clone() {
      return new BlessingRecvPicRecord(this);
    }

    /// <summary>Field number for the "is_recv" field.</summary>
    public const int IsRecvFieldNumber = 2;
    private bool isRecv_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsRecv {
      get { return isRecv_; }
      set {
        isRecv_ = value;
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 5;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 6;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    /// <summary>Field number for the "profile_picture" field.</summary>
    public const int ProfilePictureFieldNumber = 9;
    private global::Weedwacker.Shared.Network.Proto.ProfilePicture profilePicture_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ProfilePicture ProfilePicture {
      get { return profilePicture_; }
      set {
        profilePicture_ = value;
      }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 10;
    private string signature_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Signature {
      get { return signature_; }
      set {
        signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "remark_name" field.</summary>
    public const int RemarkNameFieldNumber = 8;
    private string remarkName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RemarkName {
      get { return remarkName_; }
      set {
        remarkName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 3;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "pic_id" field.</summary>
    public const int PicIdFieldNumber = 12;
    private uint picId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PicId {
      get { return picId_; }
      set {
        picId_ = value;
      }
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 11;
    private uint index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BlessingRecvPicRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BlessingRecvPicRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsRecv != other.IsRecv) return false;
      if (Nickname != other.Nickname) return false;
      if (AvatarId != other.AvatarId) return false;
      if (!object.Equals(ProfilePicture, other.ProfilePicture)) return false;
      if (Signature != other.Signature) return false;
      if (RemarkName != other.RemarkName) return false;
      if (Uid != other.Uid) return false;
      if (PicId != other.PicId) return false;
      if (Index != other.Index) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsRecv != false) hash ^= IsRecv.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
      if (profilePicture_ != null) hash ^= ProfilePicture.GetHashCode();
      if (Signature.Length != 0) hash ^= Signature.GetHashCode();
      if (RemarkName.Length != 0) hash ^= RemarkName.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (PicId != 0) hash ^= PicId.GetHashCode();
      if (Index != 0) hash ^= Index.GetHashCode();
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
      if (IsRecv != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsRecv);
      }
      if (Uid != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Uid);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Nickname);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(AvatarId);
      }
      if (RemarkName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(RemarkName);
      }
      if (profilePicture_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(ProfilePicture);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(Signature);
      }
      if (Index != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Index);
      }
      if (PicId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PicId);
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
      if (IsRecv != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsRecv);
      }
      if (Uid != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Uid);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Nickname);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(AvatarId);
      }
      if (RemarkName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(RemarkName);
      }
      if (profilePicture_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(ProfilePicture);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(Signature);
      }
      if (Index != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Index);
      }
      if (PicId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PicId);
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
      if (IsRecv != false) {
        size += 1 + 1;
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      if (profilePicture_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProfilePicture);
      }
      if (Signature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Signature);
      }
      if (RemarkName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RemarkName);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (PicId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PicId);
      }
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Index);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BlessingRecvPicRecord other) {
      if (other == null) {
        return;
      }
      if (other.IsRecv != false) {
        IsRecv = other.IsRecv;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
      }
      if (other.profilePicture_ != null) {
        if (profilePicture_ == null) {
          ProfilePicture = new global::Weedwacker.Shared.Network.Proto.ProfilePicture();
        }
        ProfilePicture.MergeFrom(other.ProfilePicture);
      }
      if (other.Signature.Length != 0) {
        Signature = other.Signature;
      }
      if (other.RemarkName.Length != 0) {
        RemarkName = other.RemarkName;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.PicId != 0) {
        PicId = other.PicId;
      }
      if (other.Index != 0) {
        Index = other.Index;
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
          case 16: {
            IsRecv = input.ReadBool();
            break;
          }
          case 24: {
            Uid = input.ReadUInt32();
            break;
          }
          case 42: {
            Nickname = input.ReadString();
            break;
          }
          case 48: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 66: {
            RemarkName = input.ReadString();
            break;
          }
          case 74: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::Weedwacker.Shared.Network.Proto.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 82: {
            Signature = input.ReadString();
            break;
          }
          case 88: {
            Index = input.ReadUInt32();
            break;
          }
          case 96: {
            PicId = input.ReadUInt32();
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
          case 16: {
            IsRecv = input.ReadBool();
            break;
          }
          case 24: {
            Uid = input.ReadUInt32();
            break;
          }
          case 42: {
            Nickname = input.ReadString();
            break;
          }
          case 48: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 66: {
            RemarkName = input.ReadString();
            break;
          }
          case 74: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::Weedwacker.Shared.Network.Proto.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 82: {
            Signature = input.ReadString();
            break;
          }
          case 88: {
            Index = input.ReadUInt32();
            break;
          }
          case 96: {
            PicId = input.ReadUInt32();
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
