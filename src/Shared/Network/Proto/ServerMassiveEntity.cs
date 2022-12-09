// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ServerMassiveEntity.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ServerMassiveEntity.proto</summary>
  public static partial class ServerMassiveEntityReflection {

    #region Descriptor
    /// <summary>File descriptor for ServerMassiveEntity.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServerMassiveEntityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlTZXJ2ZXJNYXNzaXZlRW50aXR5LnByb3RvEh9XZWVkd2Fja2VyLlNoYXJl",
            "ZC5OZXR3b3JrLlByb3RvGhRNYXNzaXZlQm94SW5mby5wcm90bxoWTWFzc2l2",
            "ZUdyYXNzSW5mby5wcm90bxoWTWFzc2l2ZVdhdGVySW5mby5wcm90byLiAgoT",
            "U2VydmVyTWFzc2l2ZUVudGl0eRITCgtlbnRpdHlfdHlwZRgBIAEoDRIRCglj",
            "b25maWdfaWQYAiABKA0SEgoKcnVudGltZV9pZBgDIAEoDRIZChFhdXRob3Jp",
            "dHlfcGVlcl9pZBgEIAEoDRIOCgZvYmpfaWQYBSABKAMSRwoKd2F0ZXJfaW5m",
            "bxgGIAEoCzIxLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uTWFz",
            "c2l2ZVdhdGVySW5mb0gAEkcKCmdyYXNzX2luZm8YByABKAsyMS5XZWVkd2Fj",
            "a2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLk1hc3NpdmVHcmFzc0luZm9IABJD",
            "Cghib3hfaW5mbxgIIAEoCzIvLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsu",
            "UHJvdG8uTWFzc2l2ZUJveEluZm9IAEINCgtlbnRpdHlfaW5mb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.MassiveBoxInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.MassiveGrassInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.MassiveWaterInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ServerMassiveEntity), global::Weedwacker.Shared.Network.Proto.ServerMassiveEntity.Parser, new[]{ "EntityType", "ConfigId", "RuntimeId", "AuthorityPeerId", "ObjId", "WaterInfo", "GrassInfo", "BoxInfo" }, new[]{ "EntityInfo" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ServerMassiveEntity : pb::IMessage<ServerMassiveEntity>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ServerMassiveEntity> _parser = new pb::MessageParser<ServerMassiveEntity>(() => new ServerMassiveEntity());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ServerMassiveEntity> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ServerMassiveEntityReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ServerMassiveEntity() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ServerMassiveEntity(ServerMassiveEntity other) : this() {
      entityType_ = other.entityType_;
      configId_ = other.configId_;
      runtimeId_ = other.runtimeId_;
      authorityPeerId_ = other.authorityPeerId_;
      objId_ = other.objId_;
      switch (other.EntityInfoCase) {
        case EntityInfoOneofCase.WaterInfo:
          WaterInfo = other.WaterInfo.Clone();
          break;
        case EntityInfoOneofCase.GrassInfo:
          GrassInfo = other.GrassInfo.Clone();
          break;
        case EntityInfoOneofCase.BoxInfo:
          BoxInfo = other.BoxInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ServerMassiveEntity Clone() {
      return new ServerMassiveEntity(this);
    }

    /// <summary>Field number for the "entity_type" field.</summary>
    public const int EntityTypeFieldNumber = 1;
    private uint entityType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityType {
      get { return entityType_; }
      set {
        entityType_ = value;
      }
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 2;
    private uint configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "runtime_id" field.</summary>
    public const int RuntimeIdFieldNumber = 3;
    private uint runtimeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RuntimeId {
      get { return runtimeId_; }
      set {
        runtimeId_ = value;
      }
    }

    /// <summary>Field number for the "authority_peer_id" field.</summary>
    public const int AuthorityPeerIdFieldNumber = 4;
    private uint authorityPeerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AuthorityPeerId {
      get { return authorityPeerId_; }
      set {
        authorityPeerId_ = value;
      }
    }

    /// <summary>Field number for the "obj_id" field.</summary>
    public const int ObjIdFieldNumber = 5;
    private long objId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ObjId {
      get { return objId_; }
      set {
        objId_ = value;
      }
    }

    /// <summary>Field number for the "water_info" field.</summary>
    public const int WaterInfoFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.MassiveWaterInfo WaterInfo {
      get { return entityInfoCase_ == EntityInfoOneofCase.WaterInfo ? (global::Weedwacker.Shared.Network.Proto.MassiveWaterInfo) entityInfo_ : null; }
      set {
        entityInfo_ = value;
        entityInfoCase_ = value == null ? EntityInfoOneofCase.None : EntityInfoOneofCase.WaterInfo;
      }
    }

    /// <summary>Field number for the "grass_info" field.</summary>
    public const int GrassInfoFieldNumber = 7;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.MassiveGrassInfo GrassInfo {
      get { return entityInfoCase_ == EntityInfoOneofCase.GrassInfo ? (global::Weedwacker.Shared.Network.Proto.MassiveGrassInfo) entityInfo_ : null; }
      set {
        entityInfo_ = value;
        entityInfoCase_ = value == null ? EntityInfoOneofCase.None : EntityInfoOneofCase.GrassInfo;
      }
    }

    /// <summary>Field number for the "box_info" field.</summary>
    public const int BoxInfoFieldNumber = 8;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.MassiveBoxInfo BoxInfo {
      get { return entityInfoCase_ == EntityInfoOneofCase.BoxInfo ? (global::Weedwacker.Shared.Network.Proto.MassiveBoxInfo) entityInfo_ : null; }
      set {
        entityInfo_ = value;
        entityInfoCase_ = value == null ? EntityInfoOneofCase.None : EntityInfoOneofCase.BoxInfo;
      }
    }

    private object entityInfo_;
    /// <summary>Enum of possible cases for the "entity_info" oneof.</summary>
    public enum EntityInfoOneofCase {
      None = 0,
      WaterInfo = 6,
      GrassInfo = 7,
      BoxInfo = 8,
    }
    private EntityInfoOneofCase entityInfoCase_ = EntityInfoOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityInfoOneofCase EntityInfoCase {
      get { return entityInfoCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearEntityInfo() {
      entityInfoCase_ = EntityInfoOneofCase.None;
      entityInfo_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ServerMassiveEntity);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ServerMassiveEntity other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityType != other.EntityType) return false;
      if (ConfigId != other.ConfigId) return false;
      if (RuntimeId != other.RuntimeId) return false;
      if (AuthorityPeerId != other.AuthorityPeerId) return false;
      if (ObjId != other.ObjId) return false;
      if (!object.Equals(WaterInfo, other.WaterInfo)) return false;
      if (!object.Equals(GrassInfo, other.GrassInfo)) return false;
      if (!object.Equals(BoxInfo, other.BoxInfo)) return false;
      if (EntityInfoCase != other.EntityInfoCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityType != 0) hash ^= EntityType.GetHashCode();
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (RuntimeId != 0) hash ^= RuntimeId.GetHashCode();
      if (AuthorityPeerId != 0) hash ^= AuthorityPeerId.GetHashCode();
      if (ObjId != 0L) hash ^= ObjId.GetHashCode();
      if (entityInfoCase_ == EntityInfoOneofCase.WaterInfo) hash ^= WaterInfo.GetHashCode();
      if (entityInfoCase_ == EntityInfoOneofCase.GrassInfo) hash ^= GrassInfo.GetHashCode();
      if (entityInfoCase_ == EntityInfoOneofCase.BoxInfo) hash ^= BoxInfo.GetHashCode();
      hash ^= (int) entityInfoCase_;
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
      if (EntityType != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EntityType);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ConfigId);
      }
      if (RuntimeId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(RuntimeId);
      }
      if (AuthorityPeerId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AuthorityPeerId);
      }
      if (ObjId != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(ObjId);
      }
      if (entityInfoCase_ == EntityInfoOneofCase.WaterInfo) {
        output.WriteRawTag(50);
        output.WriteMessage(WaterInfo);
      }
      if (entityInfoCase_ == EntityInfoOneofCase.GrassInfo) {
        output.WriteRawTag(58);
        output.WriteMessage(GrassInfo);
      }
      if (entityInfoCase_ == EntityInfoOneofCase.BoxInfo) {
        output.WriteRawTag(66);
        output.WriteMessage(BoxInfo);
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
      if (EntityType != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EntityType);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ConfigId);
      }
      if (RuntimeId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(RuntimeId);
      }
      if (AuthorityPeerId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AuthorityPeerId);
      }
      if (ObjId != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(ObjId);
      }
      if (entityInfoCase_ == EntityInfoOneofCase.WaterInfo) {
        output.WriteRawTag(50);
        output.WriteMessage(WaterInfo);
      }
      if (entityInfoCase_ == EntityInfoOneofCase.GrassInfo) {
        output.WriteRawTag(58);
        output.WriteMessage(GrassInfo);
      }
      if (entityInfoCase_ == EntityInfoOneofCase.BoxInfo) {
        output.WriteRawTag(66);
        output.WriteMessage(BoxInfo);
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
      if (EntityType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityType);
      }
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
      }
      if (RuntimeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RuntimeId);
      }
      if (AuthorityPeerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AuthorityPeerId);
      }
      if (ObjId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ObjId);
      }
      if (entityInfoCase_ == EntityInfoOneofCase.WaterInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(WaterInfo);
      }
      if (entityInfoCase_ == EntityInfoOneofCase.GrassInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GrassInfo);
      }
      if (entityInfoCase_ == EntityInfoOneofCase.BoxInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BoxInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ServerMassiveEntity other) {
      if (other == null) {
        return;
      }
      if (other.EntityType != 0) {
        EntityType = other.EntityType;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.RuntimeId != 0) {
        RuntimeId = other.RuntimeId;
      }
      if (other.AuthorityPeerId != 0) {
        AuthorityPeerId = other.AuthorityPeerId;
      }
      if (other.ObjId != 0L) {
        ObjId = other.ObjId;
      }
      switch (other.EntityInfoCase) {
        case EntityInfoOneofCase.WaterInfo:
          if (WaterInfo == null) {
            WaterInfo = new global::Weedwacker.Shared.Network.Proto.MassiveWaterInfo();
          }
          WaterInfo.MergeFrom(other.WaterInfo);
          break;
        case EntityInfoOneofCase.GrassInfo:
          if (GrassInfo == null) {
            GrassInfo = new global::Weedwacker.Shared.Network.Proto.MassiveGrassInfo();
          }
          GrassInfo.MergeFrom(other.GrassInfo);
          break;
        case EntityInfoOneofCase.BoxInfo:
          if (BoxInfo == null) {
            BoxInfo = new global::Weedwacker.Shared.Network.Proto.MassiveBoxInfo();
          }
          BoxInfo.MergeFrom(other.BoxInfo);
          break;
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
            EntityType = input.ReadUInt32();
            break;
          }
          case 16: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 24: {
            RuntimeId = input.ReadUInt32();
            break;
          }
          case 32: {
            AuthorityPeerId = input.ReadUInt32();
            break;
          }
          case 40: {
            ObjId = input.ReadInt64();
            break;
          }
          case 50: {
            global::Weedwacker.Shared.Network.Proto.MassiveWaterInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.MassiveWaterInfo();
            if (entityInfoCase_ == EntityInfoOneofCase.WaterInfo) {
              subBuilder.MergeFrom(WaterInfo);
            }
            input.ReadMessage(subBuilder);
            WaterInfo = subBuilder;
            break;
          }
          case 58: {
            global::Weedwacker.Shared.Network.Proto.MassiveGrassInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.MassiveGrassInfo();
            if (entityInfoCase_ == EntityInfoOneofCase.GrassInfo) {
              subBuilder.MergeFrom(GrassInfo);
            }
            input.ReadMessage(subBuilder);
            GrassInfo = subBuilder;
            break;
          }
          case 66: {
            global::Weedwacker.Shared.Network.Proto.MassiveBoxInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.MassiveBoxInfo();
            if (entityInfoCase_ == EntityInfoOneofCase.BoxInfo) {
              subBuilder.MergeFrom(BoxInfo);
            }
            input.ReadMessage(subBuilder);
            BoxInfo = subBuilder;
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
            EntityType = input.ReadUInt32();
            break;
          }
          case 16: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 24: {
            RuntimeId = input.ReadUInt32();
            break;
          }
          case 32: {
            AuthorityPeerId = input.ReadUInt32();
            break;
          }
          case 40: {
            ObjId = input.ReadInt64();
            break;
          }
          case 50: {
            global::Weedwacker.Shared.Network.Proto.MassiveWaterInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.MassiveWaterInfo();
            if (entityInfoCase_ == EntityInfoOneofCase.WaterInfo) {
              subBuilder.MergeFrom(WaterInfo);
            }
            input.ReadMessage(subBuilder);
            WaterInfo = subBuilder;
            break;
          }
          case 58: {
            global::Weedwacker.Shared.Network.Proto.MassiveGrassInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.MassiveGrassInfo();
            if (entityInfoCase_ == EntityInfoOneofCase.GrassInfo) {
              subBuilder.MergeFrom(GrassInfo);
            }
            input.ReadMessage(subBuilder);
            GrassInfo = subBuilder;
            break;
          }
          case 66: {
            global::Weedwacker.Shared.Network.Proto.MassiveBoxInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.MassiveBoxInfo();
            if (entityInfoCase_ == EntityInfoOneofCase.BoxInfo) {
              subBuilder.MergeFrom(BoxInfo);
            }
            input.ReadMessage(subBuilder);
            BoxInfo = subBuilder;
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
