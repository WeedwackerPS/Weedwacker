// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtCreateGadgetNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EvtCreateGadgetNotify.proto</summary>
  public static partial class EvtCreateGadgetNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtCreateGadgetNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtCreateGadgetNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtFdnRDcmVhdGVHYWRnZXROb3RpZnkucHJvdG8SH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8aEUZvcndhcmRUeXBlLnByb3RvGgxWZWN0b3Iu",
            "cHJvdG8i7wQKFUV2dENyZWF0ZUdhZGdldE5vdGlmeRIeChV0YXJnZXRfZW50",
            "aXR5X2lkX2xpc3QY9AwgAygNEjkKCGluaXRfcG9zGAkgASgLMicuV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5WZWN0b3ISFQoNaXNfYXN5bmNf",
            "bG9hZBgPIAEoCBIXCg9vd25lcl9lbnRpdHlfaWQYAiABKA0SQgoMZm9yd2Fy",
            "ZF90eXBlGAMgASgOMiwuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90",
            "by5Gb3J3YXJkVHlwZRIlChx0YXJnZXRfbG9ja19wb2ludF9pbmRleF9saXN0",
            "GJ4DIAMoDRIcChRwcm9wX293bmVyX2VudGl0eV9pZBgGIAEoDRIfChd0YXJn",
            "ZXRfbG9ja19wb2ludF9pbmRleBgEIAEoDRIcChNVbmszMzAwX09KSERKR0FG",
            "RE5OGJkLIAEoCBIPCgdjYW1wX2lkGAogASgNEhsKE1VuazMzMDBfRUpOQklH",
            "TEdNSUkYCCABKAgSQgoRaW5pdF9ldWxlcl9hbmdsZXMYDCABKAsyJy5XZWVk",
            "d2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLlZlY3RvchIfChZpc19wZWVy",
            "X2lkX2Zyb21fcGxheWVyGOEEIAEoCBIPCgdyb29tX2lkGAUgASgNEhEKCWNv",
            "bmZpZ19pZBgOIAEoDRIRCgljYW1wX3R5cGUYDSABKA0SDAoEZ3VpZBgHIAEo",
            "BBIRCgllbnRpdHlfaWQYASABKA0SGAoQdGFyZ2V0X2VudGl0eV9pZBgLIAEo",
            "DWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ForwardTypeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.EvtCreateGadgetNotify), global::Weedwacker.Shared.Network.Proto.EvtCreateGadgetNotify.Parser, new[]{ "TargetEntityIdList", "InitPos", "IsAsyncLoad", "OwnerEntityId", "ForwardType", "TargetLockPointIndexList", "PropOwnerEntityId", "TargetLockPointIndex", "Unk3300OJHDJGAFDNN", "CampId", "Unk3300EJNBIGLGMII", "InitEulerAngles", "IsPeerIdFromPlayer", "RoomId", "ConfigId", "CampType", "Guid", "EntityId", "TargetEntityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 400;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class EvtCreateGadgetNotify : pb::IMessage<EvtCreateGadgetNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtCreateGadgetNotify> _parser = new pb::MessageParser<EvtCreateGadgetNotify>(() => new EvtCreateGadgetNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtCreateGadgetNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EvtCreateGadgetNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtCreateGadgetNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtCreateGadgetNotify(EvtCreateGadgetNotify other) : this() {
      targetEntityIdList_ = other.targetEntityIdList_.Clone();
      initPos_ = other.initPos_ != null ? other.initPos_.Clone() : null;
      isAsyncLoad_ = other.isAsyncLoad_;
      ownerEntityId_ = other.ownerEntityId_;
      forwardType_ = other.forwardType_;
      targetLockPointIndexList_ = other.targetLockPointIndexList_.Clone();
      propOwnerEntityId_ = other.propOwnerEntityId_;
      targetLockPointIndex_ = other.targetLockPointIndex_;
      unk3300OJHDJGAFDNN_ = other.unk3300OJHDJGAFDNN_;
      campId_ = other.campId_;
      unk3300EJNBIGLGMII_ = other.unk3300EJNBIGLGMII_;
      initEulerAngles_ = other.initEulerAngles_ != null ? other.initEulerAngles_.Clone() : null;
      isPeerIdFromPlayer_ = other.isPeerIdFromPlayer_;
      roomId_ = other.roomId_;
      configId_ = other.configId_;
      campType_ = other.campType_;
      guid_ = other.guid_;
      entityId_ = other.entityId_;
      targetEntityId_ = other.targetEntityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtCreateGadgetNotify Clone() {
      return new EvtCreateGadgetNotify(this);
    }

    /// <summary>Field number for the "target_entity_id_list" field.</summary>
    public const int TargetEntityIdListFieldNumber = 1652;
    private static readonly pb::FieldCodec<uint> _repeated_targetEntityIdList_codec
        = pb::FieldCodec.ForUInt32(13218);
    private readonly pbc::RepeatedField<uint> targetEntityIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TargetEntityIdList {
      get { return targetEntityIdList_; }
    }

    /// <summary>Field number for the "init_pos" field.</summary>
    public const int InitPosFieldNumber = 9;
    private global::Weedwacker.Shared.Network.Proto.Vector initPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector InitPos {
      get { return initPos_; }
      set {
        initPos_ = value;
      }
    }

    /// <summary>Field number for the "is_async_load" field.</summary>
    public const int IsAsyncLoadFieldNumber = 15;
    private bool isAsyncLoad_;
    /// <summary>
    /// Unk3300_DLBIJFOONBA
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAsyncLoad {
      get { return isAsyncLoad_; }
      set {
        isAsyncLoad_ = value;
      }
    }

    /// <summary>Field number for the "owner_entity_id" field.</summary>
    public const int OwnerEntityIdFieldNumber = 2;
    private uint ownerEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OwnerEntityId {
      get { return ownerEntityId_; }
      set {
        ownerEntityId_ = value;
      }
    }

    /// <summary>Field number for the "forward_type" field.</summary>
    public const int ForwardTypeFieldNumber = 3;
    private global::Weedwacker.Shared.Network.Proto.ForwardType forwardType_ = global::Weedwacker.Shared.Network.Proto.ForwardType.Local;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ForwardType ForwardType {
      get { return forwardType_; }
      set {
        forwardType_ = value;
      }
    }

    /// <summary>Field number for the "target_lock_point_index_list" field.</summary>
    public const int TargetLockPointIndexListFieldNumber = 414;
    private static readonly pb::FieldCodec<uint> _repeated_targetLockPointIndexList_codec
        = pb::FieldCodec.ForUInt32(3314);
    private readonly pbc::RepeatedField<uint> targetLockPointIndexList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TargetLockPointIndexList {
      get { return targetLockPointIndexList_; }
    }

    /// <summary>Field number for the "prop_owner_entity_id" field.</summary>
    public const int PropOwnerEntityIdFieldNumber = 6;
    private uint propOwnerEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PropOwnerEntityId {
      get { return propOwnerEntityId_; }
      set {
        propOwnerEntityId_ = value;
      }
    }

    /// <summary>Field number for the "target_lock_point_index" field.</summary>
    public const int TargetLockPointIndexFieldNumber = 4;
    private uint targetLockPointIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetLockPointIndex {
      get { return targetLockPointIndex_; }
      set {
        targetLockPointIndex_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_OJHDJGAFDNN" field.</summary>
    public const int Unk3300OJHDJGAFDNNFieldNumber = 1433;
    private bool unk3300OJHDJGAFDNN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300OJHDJGAFDNN {
      get { return unk3300OJHDJGAFDNN_; }
      set {
        unk3300OJHDJGAFDNN_ = value;
      }
    }

    /// <summary>Field number for the "camp_id" field.</summary>
    public const int CampIdFieldNumber = 10;
    private uint campId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CampId {
      get { return campId_; }
      set {
        campId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_EJNBIGLGMII" field.</summary>
    public const int Unk3300EJNBIGLGMIIFieldNumber = 8;
    private bool unk3300EJNBIGLGMII_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300EJNBIGLGMII {
      get { return unk3300EJNBIGLGMII_; }
      set {
        unk3300EJNBIGLGMII_ = value;
      }
    }

    /// <summary>Field number for the "init_euler_angles" field.</summary>
    public const int InitEulerAnglesFieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.Vector initEulerAngles_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector InitEulerAngles {
      get { return initEulerAngles_; }
      set {
        initEulerAngles_ = value;
      }
    }

    /// <summary>Field number for the "is_peer_id_from_player" field.</summary>
    public const int IsPeerIdFromPlayerFieldNumber = 609;
    private bool isPeerIdFromPlayer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPeerIdFromPlayer {
      get { return isPeerIdFromPlayer_; }
      set {
        isPeerIdFromPlayer_ = value;
      }
    }

    /// <summary>Field number for the "room_id" field.</summary>
    public const int RoomIdFieldNumber = 5;
    private uint roomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 14;
    private uint configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "camp_type" field.</summary>
    public const int CampTypeFieldNumber = 13;
    private uint campType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CampType {
      get { return campType_; }
      set {
        campType_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 7;
    private ulong guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "target_entity_id" field.</summary>
    public const int TargetEntityIdFieldNumber = 11;
    private uint targetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetEntityId {
      get { return targetEntityId_; }
      set {
        targetEntityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtCreateGadgetNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtCreateGadgetNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!targetEntityIdList_.Equals(other.targetEntityIdList_)) return false;
      if (!object.Equals(InitPos, other.InitPos)) return false;
      if (IsAsyncLoad != other.IsAsyncLoad) return false;
      if (OwnerEntityId != other.OwnerEntityId) return false;
      if (ForwardType != other.ForwardType) return false;
      if(!targetLockPointIndexList_.Equals(other.targetLockPointIndexList_)) return false;
      if (PropOwnerEntityId != other.PropOwnerEntityId) return false;
      if (TargetLockPointIndex != other.TargetLockPointIndex) return false;
      if (Unk3300OJHDJGAFDNN != other.Unk3300OJHDJGAFDNN) return false;
      if (CampId != other.CampId) return false;
      if (Unk3300EJNBIGLGMII != other.Unk3300EJNBIGLGMII) return false;
      if (!object.Equals(InitEulerAngles, other.InitEulerAngles)) return false;
      if (IsPeerIdFromPlayer != other.IsPeerIdFromPlayer) return false;
      if (RoomId != other.RoomId) return false;
      if (ConfigId != other.ConfigId) return false;
      if (CampType != other.CampType) return false;
      if (Guid != other.Guid) return false;
      if (EntityId != other.EntityId) return false;
      if (TargetEntityId != other.TargetEntityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= targetEntityIdList_.GetHashCode();
      if (initPos_ != null) hash ^= InitPos.GetHashCode();
      if (IsAsyncLoad != false) hash ^= IsAsyncLoad.GetHashCode();
      if (OwnerEntityId != 0) hash ^= OwnerEntityId.GetHashCode();
      if (ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) hash ^= ForwardType.GetHashCode();
      hash ^= targetLockPointIndexList_.GetHashCode();
      if (PropOwnerEntityId != 0) hash ^= PropOwnerEntityId.GetHashCode();
      if (TargetLockPointIndex != 0) hash ^= TargetLockPointIndex.GetHashCode();
      if (Unk3300OJHDJGAFDNN != false) hash ^= Unk3300OJHDJGAFDNN.GetHashCode();
      if (CampId != 0) hash ^= CampId.GetHashCode();
      if (Unk3300EJNBIGLGMII != false) hash ^= Unk3300EJNBIGLGMII.GetHashCode();
      if (initEulerAngles_ != null) hash ^= InitEulerAngles.GetHashCode();
      if (IsPeerIdFromPlayer != false) hash ^= IsPeerIdFromPlayer.GetHashCode();
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (CampType != 0) hash ^= CampType.GetHashCode();
      if (Guid != 0UL) hash ^= Guid.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (TargetEntityId != 0) hash ^= TargetEntityId.GetHashCode();
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
        output.WriteRawTag(8);
        output.WriteUInt32(EntityId);
      }
      if (OwnerEntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(OwnerEntityId);
      }
      if (ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ForwardType);
      }
      if (TargetLockPointIndex != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TargetLockPointIndex);
      }
      if (RoomId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(RoomId);
      }
      if (PropOwnerEntityId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PropOwnerEntityId);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(Guid);
      }
      if (Unk3300EJNBIGLGMII != false) {
        output.WriteRawTag(64);
        output.WriteBool(Unk3300EJNBIGLGMII);
      }
      if (initPos_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(InitPos);
      }
      if (CampId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CampId);
      }
      if (TargetEntityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TargetEntityId);
      }
      if (initEulerAngles_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(InitEulerAngles);
      }
      if (CampType != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CampType);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ConfigId);
      }
      if (IsAsyncLoad != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsAsyncLoad);
      }
      targetLockPointIndexList_.WriteTo(output, _repeated_targetLockPointIndexList_codec);
      if (IsPeerIdFromPlayer != false) {
        output.WriteRawTag(136, 38);
        output.WriteBool(IsPeerIdFromPlayer);
      }
      if (Unk3300OJHDJGAFDNN != false) {
        output.WriteRawTag(200, 89);
        output.WriteBool(Unk3300OJHDJGAFDNN);
      }
      targetEntityIdList_.WriteTo(output, _repeated_targetEntityIdList_codec);
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
        output.WriteRawTag(8);
        output.WriteUInt32(EntityId);
      }
      if (OwnerEntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(OwnerEntityId);
      }
      if (ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ForwardType);
      }
      if (TargetLockPointIndex != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TargetLockPointIndex);
      }
      if (RoomId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(RoomId);
      }
      if (PropOwnerEntityId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PropOwnerEntityId);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(Guid);
      }
      if (Unk3300EJNBIGLGMII != false) {
        output.WriteRawTag(64);
        output.WriteBool(Unk3300EJNBIGLGMII);
      }
      if (initPos_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(InitPos);
      }
      if (CampId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CampId);
      }
      if (TargetEntityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TargetEntityId);
      }
      if (initEulerAngles_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(InitEulerAngles);
      }
      if (CampType != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CampType);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ConfigId);
      }
      if (IsAsyncLoad != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsAsyncLoad);
      }
      targetLockPointIndexList_.WriteTo(ref output, _repeated_targetLockPointIndexList_codec);
      if (IsPeerIdFromPlayer != false) {
        output.WriteRawTag(136, 38);
        output.WriteBool(IsPeerIdFromPlayer);
      }
      if (Unk3300OJHDJGAFDNN != false) {
        output.WriteRawTag(200, 89);
        output.WriteBool(Unk3300OJHDJGAFDNN);
      }
      targetEntityIdList_.WriteTo(ref output, _repeated_targetEntityIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += targetEntityIdList_.CalculateSize(_repeated_targetEntityIdList_codec);
      if (initPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InitPos);
      }
      if (IsAsyncLoad != false) {
        size += 1 + 1;
      }
      if (OwnerEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OwnerEntityId);
      }
      if (ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
      }
      size += targetLockPointIndexList_.CalculateSize(_repeated_targetLockPointIndexList_codec);
      if (PropOwnerEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PropOwnerEntityId);
      }
      if (TargetLockPointIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetLockPointIndex);
      }
      if (Unk3300OJHDJGAFDNN != false) {
        size += 2 + 1;
      }
      if (CampId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CampId);
      }
      if (Unk3300EJNBIGLGMII != false) {
        size += 1 + 1;
      }
      if (initEulerAngles_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InitEulerAngles);
      }
      if (IsPeerIdFromPlayer != false) {
        size += 2 + 1;
      }
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoomId);
      }
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
      }
      if (CampType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CampType);
      }
      if (Guid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Guid);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (TargetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetEntityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtCreateGadgetNotify other) {
      if (other == null) {
        return;
      }
      targetEntityIdList_.Add(other.targetEntityIdList_);
      if (other.initPos_ != null) {
        if (initPos_ == null) {
          InitPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        InitPos.MergeFrom(other.InitPos);
      }
      if (other.IsAsyncLoad != false) {
        IsAsyncLoad = other.IsAsyncLoad;
      }
      if (other.OwnerEntityId != 0) {
        OwnerEntityId = other.OwnerEntityId;
      }
      if (other.ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) {
        ForwardType = other.ForwardType;
      }
      targetLockPointIndexList_.Add(other.targetLockPointIndexList_);
      if (other.PropOwnerEntityId != 0) {
        PropOwnerEntityId = other.PropOwnerEntityId;
      }
      if (other.TargetLockPointIndex != 0) {
        TargetLockPointIndex = other.TargetLockPointIndex;
      }
      if (other.Unk3300OJHDJGAFDNN != false) {
        Unk3300OJHDJGAFDNN = other.Unk3300OJHDJGAFDNN;
      }
      if (other.CampId != 0) {
        CampId = other.CampId;
      }
      if (other.Unk3300EJNBIGLGMII != false) {
        Unk3300EJNBIGLGMII = other.Unk3300EJNBIGLGMII;
      }
      if (other.initEulerAngles_ != null) {
        if (initEulerAngles_ == null) {
          InitEulerAngles = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        InitEulerAngles.MergeFrom(other.InitEulerAngles);
      }
      if (other.IsPeerIdFromPlayer != false) {
        IsPeerIdFromPlayer = other.IsPeerIdFromPlayer;
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.CampType != 0) {
        CampType = other.CampType;
      }
      if (other.Guid != 0UL) {
        Guid = other.Guid;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.TargetEntityId != 0) {
        TargetEntityId = other.TargetEntityId;
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 16: {
            OwnerEntityId = input.ReadUInt32();
            break;
          }
          case 24: {
            ForwardType = (global::Weedwacker.Shared.Network.Proto.ForwardType) input.ReadEnum();
            break;
          }
          case 32: {
            TargetLockPointIndex = input.ReadUInt32();
            break;
          }
          case 40: {
            RoomId = input.ReadUInt32();
            break;
          }
          case 48: {
            PropOwnerEntityId = input.ReadUInt32();
            break;
          }
          case 56: {
            Guid = input.ReadUInt64();
            break;
          }
          case 64: {
            Unk3300EJNBIGLGMII = input.ReadBool();
            break;
          }
          case 74: {
            if (initPos_ == null) {
              InitPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(InitPos);
            break;
          }
          case 80: {
            CampId = input.ReadUInt32();
            break;
          }
          case 88: {
            TargetEntityId = input.ReadUInt32();
            break;
          }
          case 98: {
            if (initEulerAngles_ == null) {
              InitEulerAngles = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(InitEulerAngles);
            break;
          }
          case 104: {
            CampType = input.ReadUInt32();
            break;
          }
          case 112: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 120: {
            IsAsyncLoad = input.ReadBool();
            break;
          }
          case 3314:
          case 3312: {
            targetLockPointIndexList_.AddEntriesFrom(input, _repeated_targetLockPointIndexList_codec);
            break;
          }
          case 4872: {
            IsPeerIdFromPlayer = input.ReadBool();
            break;
          }
          case 11464: {
            Unk3300OJHDJGAFDNN = input.ReadBool();
            break;
          }
          case 13218:
          case 13216: {
            targetEntityIdList_.AddEntriesFrom(input, _repeated_targetEntityIdList_codec);
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 16: {
            OwnerEntityId = input.ReadUInt32();
            break;
          }
          case 24: {
            ForwardType = (global::Weedwacker.Shared.Network.Proto.ForwardType) input.ReadEnum();
            break;
          }
          case 32: {
            TargetLockPointIndex = input.ReadUInt32();
            break;
          }
          case 40: {
            RoomId = input.ReadUInt32();
            break;
          }
          case 48: {
            PropOwnerEntityId = input.ReadUInt32();
            break;
          }
          case 56: {
            Guid = input.ReadUInt64();
            break;
          }
          case 64: {
            Unk3300EJNBIGLGMII = input.ReadBool();
            break;
          }
          case 74: {
            if (initPos_ == null) {
              InitPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(InitPos);
            break;
          }
          case 80: {
            CampId = input.ReadUInt32();
            break;
          }
          case 88: {
            TargetEntityId = input.ReadUInt32();
            break;
          }
          case 98: {
            if (initEulerAngles_ == null) {
              InitEulerAngles = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(InitEulerAngles);
            break;
          }
          case 104: {
            CampType = input.ReadUInt32();
            break;
          }
          case 112: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 120: {
            IsAsyncLoad = input.ReadBool();
            break;
          }
          case 3314:
          case 3312: {
            targetLockPointIndexList_.AddEntriesFrom(ref input, _repeated_targetLockPointIndexList_codec);
            break;
          }
          case 4872: {
            IsPeerIdFromPlayer = input.ReadBool();
            break;
          }
          case 11464: {
            Unk3300OJHDJGAFDNN = input.ReadBool();
            break;
          }
          case 13218:
          case 13216: {
            targetEntityIdList_.AddEntriesFrom(ref input, _repeated_targetEntityIdList_codec);
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
