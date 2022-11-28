// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtSetAttackTargetInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EvtSetAttackTargetInfo.proto</summary>
  public static partial class EvtSetAttackTargetInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtSetAttackTargetInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtSetAttackTargetInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxFdnRTZXRBdHRhY2tUYXJnZXRJbmZvLnByb3RvImEKFkV2dFNldEF0dGFj",
            "a1RhcmdldEluZm8SEQoJZW50aXR5X2lkGAsgASgNEhoKEnNlbGVjdF9wb2lu",
            "dF9pbmRleBgGIAEoDRIYChBhdHRhY2tfdGFyZ2V0X2lkGAcgASgNQiKqAh9X",
            "ZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.EvtSetAttackTargetInfo), global::Weedwacker.Shared.Network.Proto.EvtSetAttackTargetInfo.Parser, new[]{ "EntityId", "SelectPointIndex", "AttackTargetId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtSetAttackTargetInfo : pb::IMessage<EvtSetAttackTargetInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtSetAttackTargetInfo> _parser = new pb::MessageParser<EvtSetAttackTargetInfo>(() => new EvtSetAttackTargetInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtSetAttackTargetInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EvtSetAttackTargetInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtSetAttackTargetInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtSetAttackTargetInfo(EvtSetAttackTargetInfo other) : this() {
      entityId_ = other.entityId_;
      selectPointIndex_ = other.selectPointIndex_;
      attackTargetId_ = other.attackTargetId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtSetAttackTargetInfo Clone() {
      return new EvtSetAttackTargetInfo(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 11;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "select_point_index" field.</summary>
    public const int SelectPointIndexFieldNumber = 6;
    private uint selectPointIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SelectPointIndex {
      get { return selectPointIndex_; }
      set {
        selectPointIndex_ = value;
      }
    }

    /// <summary>Field number for the "attack_target_id" field.</summary>
    public const int AttackTargetIdFieldNumber = 7;
    private uint attackTargetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AttackTargetId {
      get { return attackTargetId_; }
      set {
        attackTargetId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtSetAttackTargetInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtSetAttackTargetInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (SelectPointIndex != other.SelectPointIndex) return false;
      if (AttackTargetId != other.AttackTargetId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (SelectPointIndex != 0) hash ^= SelectPointIndex.GetHashCode();
      if (AttackTargetId != 0) hash ^= AttackTargetId.GetHashCode();
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
      if (SelectPointIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SelectPointIndex);
      }
      if (AttackTargetId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(AttackTargetId);
      }
      if (EntityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(EntityId);
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
      if (SelectPointIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SelectPointIndex);
      }
      if (AttackTargetId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(AttackTargetId);
      }
      if (EntityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(EntityId);
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
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (SelectPointIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SelectPointIndex);
      }
      if (AttackTargetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AttackTargetId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtSetAttackTargetInfo other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.SelectPointIndex != 0) {
        SelectPointIndex = other.SelectPointIndex;
      }
      if (other.AttackTargetId != 0) {
        AttackTargetId = other.AttackTargetId;
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
          case 48: {
            SelectPointIndex = input.ReadUInt32();
            break;
          }
          case 56: {
            AttackTargetId = input.ReadUInt32();
            break;
          }
          case 88: {
            EntityId = input.ReadUInt32();
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
          case 48: {
            SelectPointIndex = input.ReadUInt32();
            break;
          }
          case 56: {
            AttackTargetId = input.ReadUInt32();
            break;
          }
          case 88: {
            EntityId = input.ReadUInt32();
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
