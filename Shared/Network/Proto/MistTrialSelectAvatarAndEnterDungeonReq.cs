// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MistTrialSelectAvatarAndEnterDungeonReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from MistTrialSelectAvatarAndEnterDungeonReq.proto</summary>
  public static partial class MistTrialSelectAvatarAndEnterDungeonReqReflection {

    #region Descriptor
    /// <summary>File descriptor for MistTrialSelectAvatarAndEnterDungeonReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MistTrialSelectAvatarAndEnterDungeonReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1NaXN0VHJpYWxTZWxlY3RBdmF0YXJBbmRFbnRlckR1bmdlb25SZXEucHJv",
            "dG8ieAonTWlzdFRyaWFsU2VsZWN0QXZhdGFyQW5kRW50ZXJEdW5nZW9uUmVx",
            "EhAKCHRyaWFsX2lkGAQgASgNEiMKG3NlbGVjdF90cmlhbF9hdmF0YXJfaWRf",
            "bGlzdBgKIAMoDRIWCg5lbnRlcl9wb2ludF9pZBgHIAEoDUIiqgIfV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.MistTrialSelectAvatarAndEnterDungeonReq), global::Weedwacker.Shared.Network.Proto.MistTrialSelectAvatarAndEnterDungeonReq.Parser, new[]{ "TrialId", "SelectTrialAvatarIdList", "EnterPointId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8666
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class MistTrialSelectAvatarAndEnterDungeonReq : pb::IMessage<MistTrialSelectAvatarAndEnterDungeonReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MistTrialSelectAvatarAndEnterDungeonReq> _parser = new pb::MessageParser<MistTrialSelectAvatarAndEnterDungeonReq>(() => new MistTrialSelectAvatarAndEnterDungeonReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MistTrialSelectAvatarAndEnterDungeonReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.MistTrialSelectAvatarAndEnterDungeonReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MistTrialSelectAvatarAndEnterDungeonReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MistTrialSelectAvatarAndEnterDungeonReq(MistTrialSelectAvatarAndEnterDungeonReq other) : this() {
      trialId_ = other.trialId_;
      selectTrialAvatarIdList_ = other.selectTrialAvatarIdList_.Clone();
      enterPointId_ = other.enterPointId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MistTrialSelectAvatarAndEnterDungeonReq Clone() {
      return new MistTrialSelectAvatarAndEnterDungeonReq(this);
    }

    /// <summary>Field number for the "trial_id" field.</summary>
    public const int TrialIdFieldNumber = 4;
    private uint trialId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TrialId {
      get { return trialId_; }
      set {
        trialId_ = value;
      }
    }

    /// <summary>Field number for the "select_trial_avatar_id_list" field.</summary>
    public const int SelectTrialAvatarIdListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_selectTrialAvatarIdList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> selectTrialAvatarIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SelectTrialAvatarIdList {
      get { return selectTrialAvatarIdList_; }
    }

    /// <summary>Field number for the "enter_point_id" field.</summary>
    public const int EnterPointIdFieldNumber = 7;
    private uint enterPointId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EnterPointId {
      get { return enterPointId_; }
      set {
        enterPointId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MistTrialSelectAvatarAndEnterDungeonReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MistTrialSelectAvatarAndEnterDungeonReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TrialId != other.TrialId) return false;
      if(!selectTrialAvatarIdList_.Equals(other.selectTrialAvatarIdList_)) return false;
      if (EnterPointId != other.EnterPointId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TrialId != 0) hash ^= TrialId.GetHashCode();
      hash ^= selectTrialAvatarIdList_.GetHashCode();
      if (EnterPointId != 0) hash ^= EnterPointId.GetHashCode();
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
      if (TrialId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TrialId);
      }
      if (EnterPointId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EnterPointId);
      }
      selectTrialAvatarIdList_.WriteTo(output, _repeated_selectTrialAvatarIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (TrialId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TrialId);
      }
      if (EnterPointId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EnterPointId);
      }
      selectTrialAvatarIdList_.WriteTo(ref output, _repeated_selectTrialAvatarIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (TrialId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TrialId);
      }
      size += selectTrialAvatarIdList_.CalculateSize(_repeated_selectTrialAvatarIdList_codec);
      if (EnterPointId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EnterPointId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MistTrialSelectAvatarAndEnterDungeonReq other) {
      if (other == null) {
        return;
      }
      if (other.TrialId != 0) {
        TrialId = other.TrialId;
      }
      selectTrialAvatarIdList_.Add(other.selectTrialAvatarIdList_);
      if (other.EnterPointId != 0) {
        EnterPointId = other.EnterPointId;
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
          case 32: {
            TrialId = input.ReadUInt32();
            break;
          }
          case 56: {
            EnterPointId = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            selectTrialAvatarIdList_.AddEntriesFrom(input, _repeated_selectTrialAvatarIdList_codec);
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
          case 32: {
            TrialId = input.ReadUInt32();
            break;
          }
          case 56: {
            EnterPointId = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            selectTrialAvatarIdList_.AddEntriesFrom(ref input, _repeated_selectTrialAvatarIdList_codec);
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