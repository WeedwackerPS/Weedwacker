// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FoundationInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FoundationInfo.proto</summary>
  public static partial class FoundationInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FoundationInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FoundationInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRGb3VuZGF0aW9uSW5mby5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQuTmV0",
            "d29yay5Qcm90bxoWRm91bmRhdGlvblN0YXR1cy5wcm90byKZAQoORm91bmRh",
            "dGlvbkluZm8SQQoGc3RhdHVzGAEgASgOMjEuV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90by5Gb3VuZGF0aW9uU3RhdHVzEhAKCHVpZF9saXN0GAIg",
            "AygNEhsKE2N1cnJlbnRfYnVpbGRpbmdfaWQYAyABKA0SFQoNbG9ja2VkX2J5",
            "X3VpZBgEIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.FoundationStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FoundationInfo), global::Weedwacker.Shared.Network.Proto.FoundationInfo.Parser, new[]{ "Status", "UidList", "CurrentBuildingId", "LockedByUid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FoundationInfo : pb::IMessage<FoundationInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FoundationInfo> _parser = new pb::MessageParser<FoundationInfo>(() => new FoundationInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FoundationInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FoundationInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FoundationInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FoundationInfo(FoundationInfo other) : this() {
      status_ = other.status_;
      uidList_ = other.uidList_.Clone();
      currentBuildingId_ = other.currentBuildingId_;
      lockedByUid_ = other.lockedByUid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FoundationInfo Clone() {
      return new FoundationInfo(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::Weedwacker.Shared.Network.Proto.FoundationStatus status_ = global::Weedwacker.Shared.Network.Proto.FoundationStatus.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.FoundationStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "uid_list" field.</summary>
    public const int UidListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_uidList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> uidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UidList {
      get { return uidList_; }
    }

    /// <summary>Field number for the "current_building_id" field.</summary>
    public const int CurrentBuildingIdFieldNumber = 3;
    private uint currentBuildingId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurrentBuildingId {
      get { return currentBuildingId_; }
      set {
        currentBuildingId_ = value;
      }
    }

    /// <summary>Field number for the "locked_by_uid" field.</summary>
    public const int LockedByUidFieldNumber = 4;
    private uint lockedByUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LockedByUid {
      get { return lockedByUid_; }
      set {
        lockedByUid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FoundationInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FoundationInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if(!uidList_.Equals(other.uidList_)) return false;
      if (CurrentBuildingId != other.CurrentBuildingId) return false;
      if (LockedByUid != other.LockedByUid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != global::Weedwacker.Shared.Network.Proto.FoundationStatus.None) hash ^= Status.GetHashCode();
      hash ^= uidList_.GetHashCode();
      if (CurrentBuildingId != 0) hash ^= CurrentBuildingId.GetHashCode();
      if (LockedByUid != 0) hash ^= LockedByUid.GetHashCode();
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
      if (Status != global::Weedwacker.Shared.Network.Proto.FoundationStatus.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      uidList_.WriteTo(output, _repeated_uidList_codec);
      if (CurrentBuildingId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CurrentBuildingId);
      }
      if (LockedByUid != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(LockedByUid);
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
      if (Status != global::Weedwacker.Shared.Network.Proto.FoundationStatus.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      uidList_.WriteTo(ref output, _repeated_uidList_codec);
      if (CurrentBuildingId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CurrentBuildingId);
      }
      if (LockedByUid != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(LockedByUid);
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
      if (Status != global::Weedwacker.Shared.Network.Proto.FoundationStatus.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      size += uidList_.CalculateSize(_repeated_uidList_codec);
      if (CurrentBuildingId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurrentBuildingId);
      }
      if (LockedByUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LockedByUid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FoundationInfo other) {
      if (other == null) {
        return;
      }
      if (other.Status != global::Weedwacker.Shared.Network.Proto.FoundationStatus.None) {
        Status = other.Status;
      }
      uidList_.Add(other.uidList_);
      if (other.CurrentBuildingId != 0) {
        CurrentBuildingId = other.CurrentBuildingId;
      }
      if (other.LockedByUid != 0) {
        LockedByUid = other.LockedByUid;
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
          case 8: {
            Status = (global::Weedwacker.Shared.Network.Proto.FoundationStatus) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            uidList_.AddEntriesFrom(input, _repeated_uidList_codec);
            break;
          }
          case 24: {
            CurrentBuildingId = input.ReadUInt32();
            break;
          }
          case 32: {
            LockedByUid = input.ReadUInt32();
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
          case 8: {
            Status = (global::Weedwacker.Shared.Network.Proto.FoundationStatus) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            uidList_.AddEntriesFrom(ref input, _repeated_uidList_codec);
            break;
          }
          case 24: {
            CurrentBuildingId = input.ReadUInt32();
            break;
          }
          case 32: {
            LockedByUid = input.ReadUInt32();
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
