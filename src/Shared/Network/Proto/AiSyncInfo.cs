// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AiSyncInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AiSyncInfo.proto</summary>
  public static partial class AiSyncInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for AiSyncInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AiSyncInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBBaVN5bmNJbmZvLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3Jr",
            "LlByb3RvIlgKCkFpU3luY0luZm8SEQoJZW50aXR5X2lkGAIgASgNEhoKEmhh",
            "c19wYXRoX3RvX3RhcmdldBgEIAEoCBIbChNVbmszMzAwX0VCSUNDTExHSUNH",
            "GA4gASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AiSyncInfo), global::Weedwacker.Shared.Network.Proto.AiSyncInfo.Parser, new[]{ "EntityId", "HasPathToTarget", "Unk3300EBICCLLGICG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AiSyncInfo : pb::IMessage<AiSyncInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AiSyncInfo> _parser = new pb::MessageParser<AiSyncInfo>(() => new AiSyncInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AiSyncInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AiSyncInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AiSyncInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AiSyncInfo(AiSyncInfo other) : this() {
      entityId_ = other.entityId_;
      hasPathToTarget_ = other.hasPathToTarget_;
      unk3300EBICCLLGICG_ = other.unk3300EBICCLLGICG_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AiSyncInfo Clone() {
      return new AiSyncInfo(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 2;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "has_path_to_target" field.</summary>
    public const int HasPathToTargetFieldNumber = 4;
    private bool hasPathToTarget_;
    /// <summary>
    /// Unk3300_NOIPAMJJIDL
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasPathToTarget {
      get { return hasPathToTarget_; }
      set {
        hasPathToTarget_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_EBICCLLGICG" field.</summary>
    public const int Unk3300EBICCLLGICGFieldNumber = 14;
    private bool unk3300EBICCLLGICG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300EBICCLLGICG {
      get { return unk3300EBICCLLGICG_; }
      set {
        unk3300EBICCLLGICG_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AiSyncInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AiSyncInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (HasPathToTarget != other.HasPathToTarget) return false;
      if (Unk3300EBICCLLGICG != other.Unk3300EBICCLLGICG) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (HasPathToTarget != false) hash ^= HasPathToTarget.GetHashCode();
      if (Unk3300EBICCLLGICG != false) hash ^= Unk3300EBICCLLGICG.GetHashCode();
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
      if (EntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EntityId);
      }
      if (HasPathToTarget != false) {
        output.WriteRawTag(32);
        output.WriteBool(HasPathToTarget);
      }
      if (Unk3300EBICCLLGICG != false) {
        output.WriteRawTag(112);
        output.WriteBool(Unk3300EBICCLLGICG);
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
      if (EntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EntityId);
      }
      if (HasPathToTarget != false) {
        output.WriteRawTag(32);
        output.WriteBool(HasPathToTarget);
      }
      if (Unk3300EBICCLLGICG != false) {
        output.WriteRawTag(112);
        output.WriteBool(Unk3300EBICCLLGICG);
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
      if (HasPathToTarget != false) {
        size += 1 + 1;
      }
      if (Unk3300EBICCLLGICG != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AiSyncInfo other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.HasPathToTarget != false) {
        HasPathToTarget = other.HasPathToTarget;
      }
      if (other.Unk3300EBICCLLGICG != false) {
        Unk3300EBICCLLGICG = other.Unk3300EBICCLLGICG;
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 32: {
            HasPathToTarget = input.ReadBool();
            break;
          }
          case 112: {
            Unk3300EBICCLLGICG = input.ReadBool();
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 32: {
            HasPathToTarget = input.ReadBool();
            break;
          }
          case 112: {
            Unk3300EBICCLLGICG = input.ReadBool();
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
