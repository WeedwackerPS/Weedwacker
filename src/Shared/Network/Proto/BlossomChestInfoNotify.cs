// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BlossomChestInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BlossomChestInfoNotify.proto</summary>
  public static partial class BlossomChestInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for BlossomChestInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BlossomChestInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxCbG9zc29tQ2hlc3RJbmZvTm90aWZ5LnByb3RvEh9XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvGhZCbG9zc29tQ2hlc3RJbmZvLnByb3RvInoK",
            "FkJsb3Nzb21DaGVzdEluZm9Ob3RpZnkSTQoSYmxvc3NvbV9jaGVzdF9pbmZv",
            "GA0gASgLMjEuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5CbG9z",
            "c29tQ2hlc3RJbmZvEhEKCWVudGl0eV9pZBgKIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.BlossomChestInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BlossomChestInfoNotify), global::Weedwacker.Shared.Network.Proto.BlossomChestInfoNotify.Parser, new[]{ "BlossomChestInfo", "EntityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 847;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class BlossomChestInfoNotify : pb::IMessage<BlossomChestInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BlossomChestInfoNotify> _parser = new pb::MessageParser<BlossomChestInfoNotify>(() => new BlossomChestInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BlossomChestInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BlossomChestInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlossomChestInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlossomChestInfoNotify(BlossomChestInfoNotify other) : this() {
      blossomChestInfo_ = other.blossomChestInfo_ != null ? other.blossomChestInfo_.Clone() : null;
      entityId_ = other.entityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlossomChestInfoNotify Clone() {
      return new BlossomChestInfoNotify(this);
    }

    /// <summary>Field number for the "blossom_chest_info" field.</summary>
    public const int BlossomChestInfoFieldNumber = 13;
    private global::Weedwacker.Shared.Network.Proto.BlossomChestInfo blossomChestInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.BlossomChestInfo BlossomChestInfo {
      get { return blossomChestInfo_; }
      set {
        blossomChestInfo_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 10;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BlossomChestInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BlossomChestInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BlossomChestInfo, other.BlossomChestInfo)) return false;
      if (EntityId != other.EntityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (blossomChestInfo_ != null) hash ^= BlossomChestInfo.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
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
        output.WriteRawTag(80);
        output.WriteUInt32(EntityId);
      }
      if (blossomChestInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(BlossomChestInfo);
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
        output.WriteRawTag(80);
        output.WriteUInt32(EntityId);
      }
      if (blossomChestInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(BlossomChestInfo);
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
      if (blossomChestInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BlossomChestInfo);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BlossomChestInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.blossomChestInfo_ != null) {
        if (blossomChestInfo_ == null) {
          BlossomChestInfo = new global::Weedwacker.Shared.Network.Proto.BlossomChestInfo();
        }
        BlossomChestInfo.MergeFrom(other.BlossomChestInfo);
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
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
          case 80: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 106: {
            if (blossomChestInfo_ == null) {
              BlossomChestInfo = new global::Weedwacker.Shared.Network.Proto.BlossomChestInfo();
            }
            input.ReadMessage(BlossomChestInfo);
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
          case 80: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 106: {
            if (blossomChestInfo_ == null) {
              BlossomChestInfo = new global::Weedwacker.Shared.Network.Proto.BlossomChestInfo();
            }
            input.ReadMessage(BlossomChestInfo);
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
