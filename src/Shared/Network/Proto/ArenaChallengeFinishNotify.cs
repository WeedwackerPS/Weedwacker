// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ArenaChallengeFinishNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ArenaChallengeFinishNotify.proto</summary>
  public static partial class ArenaChallengeFinishNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ArenaChallengeFinishNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ArenaChallengeFinishNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBBcmVuYUNoYWxsZW5nZUZpbmlzaE5vdGlmeS5wcm90bxIfV2VlZHdhY2tl",
            "ci5TaGFyZWQuTmV0d29yay5Qcm90bxomQXJlbmFDaGFsbGVuZ2VDaGlsZENo",
            "YWxsZW5nZUluZm8ucHJvdG8iywEKGkFyZW5hQ2hhbGxlbmdlRmluaXNoTm90",
            "aWZ5EhIKCmlzX3N1Y2Nlc3MYCCABKAgSGwoTVW5rMzMwMF9GREZORkxBS09O",
            "RxgDIAEoDRJfChRjaGlsZF9jaGFsbGVuZ2VfbGlzdBgOIAMoCzJBLldlZWR3",
            "YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uQXJlbmFDaGFsbGVuZ2VDaGls",
            "ZENoYWxsZW5nZUluZm8SGwoTVW5rMzMwMF9EQkhBR0hNTUxBSRgKIAEoDWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ArenaChallengeChildChallengeInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ArenaChallengeFinishNotify), global::Weedwacker.Shared.Network.Proto.ArenaChallengeFinishNotify.Parser, new[]{ "IsSuccess", "Unk3300FDFNFLAKONG", "ChildChallengeList", "Unk3300DBHAGHMMLAI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 2164;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class ArenaChallengeFinishNotify : pb::IMessage<ArenaChallengeFinishNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ArenaChallengeFinishNotify> _parser = new pb::MessageParser<ArenaChallengeFinishNotify>(() => new ArenaChallengeFinishNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ArenaChallengeFinishNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ArenaChallengeFinishNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ArenaChallengeFinishNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ArenaChallengeFinishNotify(ArenaChallengeFinishNotify other) : this() {
      isSuccess_ = other.isSuccess_;
      unk3300FDFNFLAKONG_ = other.unk3300FDFNFLAKONG_;
      childChallengeList_ = other.childChallengeList_.Clone();
      unk3300DBHAGHMMLAI_ = other.unk3300DBHAGHMMLAI_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ArenaChallengeFinishNotify Clone() {
      return new ArenaChallengeFinishNotify(this);
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 8;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_FDFNFLAKONG" field.</summary>
    public const int Unk3300FDFNFLAKONGFieldNumber = 3;
    private uint unk3300FDFNFLAKONG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300FDFNFLAKONG {
      get { return unk3300FDFNFLAKONG_; }
      set {
        unk3300FDFNFLAKONG_ = value;
      }
    }

    /// <summary>Field number for the "child_challenge_list" field.</summary>
    public const int ChildChallengeListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ArenaChallengeChildChallengeInfo> _repeated_childChallengeList_codec
        = pb::FieldCodec.ForMessage(114, global::Weedwacker.Shared.Network.Proto.ArenaChallengeChildChallengeInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ArenaChallengeChildChallengeInfo> childChallengeList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ArenaChallengeChildChallengeInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ArenaChallengeChildChallengeInfo> ChildChallengeList {
      get { return childChallengeList_; }
    }

    /// <summary>Field number for the "Unk3300_DBHAGHMMLAI" field.</summary>
    public const int Unk3300DBHAGHMMLAIFieldNumber = 10;
    private uint unk3300DBHAGHMMLAI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300DBHAGHMMLAI {
      get { return unk3300DBHAGHMMLAI_; }
      set {
        unk3300DBHAGHMMLAI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ArenaChallengeFinishNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ArenaChallengeFinishNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsSuccess != other.IsSuccess) return false;
      if (Unk3300FDFNFLAKONG != other.Unk3300FDFNFLAKONG) return false;
      if(!childChallengeList_.Equals(other.childChallengeList_)) return false;
      if (Unk3300DBHAGHMMLAI != other.Unk3300DBHAGHMMLAI) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (Unk3300FDFNFLAKONG != 0) hash ^= Unk3300FDFNFLAKONG.GetHashCode();
      hash ^= childChallengeList_.GetHashCode();
      if (Unk3300DBHAGHMMLAI != 0) hash ^= Unk3300DBHAGHMMLAI.GetHashCode();
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
      if (Unk3300FDFNFLAKONG != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk3300FDFNFLAKONG);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsSuccess);
      }
      if (Unk3300DBHAGHMMLAI != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300DBHAGHMMLAI);
      }
      childChallengeList_.WriteTo(output, _repeated_childChallengeList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Unk3300FDFNFLAKONG != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk3300FDFNFLAKONG);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsSuccess);
      }
      if (Unk3300DBHAGHMMLAI != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300DBHAGHMMLAI);
      }
      childChallengeList_.WriteTo(ref output, _repeated_childChallengeList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (Unk3300FDFNFLAKONG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300FDFNFLAKONG);
      }
      size += childChallengeList_.CalculateSize(_repeated_childChallengeList_codec);
      if (Unk3300DBHAGHMMLAI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300DBHAGHMMLAI);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ArenaChallengeFinishNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      if (other.Unk3300FDFNFLAKONG != 0) {
        Unk3300FDFNFLAKONG = other.Unk3300FDFNFLAKONG;
      }
      childChallengeList_.Add(other.childChallengeList_);
      if (other.Unk3300DBHAGHMMLAI != 0) {
        Unk3300DBHAGHMMLAI = other.Unk3300DBHAGHMMLAI;
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
            Unk3300FDFNFLAKONG = input.ReadUInt32();
            break;
          }
          case 64: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 80: {
            Unk3300DBHAGHMMLAI = input.ReadUInt32();
            break;
          }
          case 114: {
            childChallengeList_.AddEntriesFrom(input, _repeated_childChallengeList_codec);
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
            Unk3300FDFNFLAKONG = input.ReadUInt32();
            break;
          }
          case 64: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 80: {
            Unk3300DBHAGHMMLAI = input.ReadUInt32();
            break;
          }
          case 114: {
            childChallengeList_.AddEntriesFrom(ref input, _repeated_childChallengeList_codec);
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
