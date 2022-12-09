// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OneofGatherPointDetectorData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from OneofGatherPointDetectorData.proto</summary>
  public static partial class OneofGatherPointDetectorDataReflection {

    #region Descriptor
    /// <summary>File descriptor for OneofGatherPointDetectorData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OneofGatherPointDetectorDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJPbmVvZkdhdGhlclBvaW50RGV0ZWN0b3JEYXRhLnByb3RvEh9XZWVkd2Fj",
            "a2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvGgxWZWN0b3IucHJvdG8i4AEKHE9u",
            "ZW9mR2F0aGVyUG9pbnREZXRlY3RvckRhdGESEwoLaGludF9yYWRpdXMYBCAB",
            "KA0SEQoJY29uZmlnX2lkGAMgASgNEhUKDWlzX2hpbnRfdmFsaWQYCyABKAgS",
            "QAoPaGludF9jZW50ZXJfcG9zGAwgASgLMicuV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90by5WZWN0b3ISGAoQaXNfYWxsX2NvbGxlY3RlZBgKIAEo",
            "CBIQCghncm91cF9pZBgBIAEoDRITCgttYXRlcmlhbF9pZBgJIAEoDWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.OneofGatherPointDetectorData), global::Weedwacker.Shared.Network.Proto.OneofGatherPointDetectorData.Parser, new[]{ "HintRadius", "ConfigId", "IsHintValid", "HintCenterPos", "IsAllCollected", "GroupId", "MaterialId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OneofGatherPointDetectorData : pb::IMessage<OneofGatherPointDetectorData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OneofGatherPointDetectorData> _parser = new pb::MessageParser<OneofGatherPointDetectorData>(() => new OneofGatherPointDetectorData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OneofGatherPointDetectorData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.OneofGatherPointDetectorDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OneofGatherPointDetectorData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OneofGatherPointDetectorData(OneofGatherPointDetectorData other) : this() {
      hintRadius_ = other.hintRadius_;
      configId_ = other.configId_;
      isHintValid_ = other.isHintValid_;
      hintCenterPos_ = other.hintCenterPos_ != null ? other.hintCenterPos_.Clone() : null;
      isAllCollected_ = other.isAllCollected_;
      groupId_ = other.groupId_;
      materialId_ = other.materialId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OneofGatherPointDetectorData Clone() {
      return new OneofGatherPointDetectorData(this);
    }

    /// <summary>Field number for the "hint_radius" field.</summary>
    public const int HintRadiusFieldNumber = 4;
    private uint hintRadius_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HintRadius {
      get { return hintRadius_; }
      set {
        hintRadius_ = value;
      }
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 3;
    private uint configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "is_hint_valid" field.</summary>
    public const int IsHintValidFieldNumber = 11;
    private bool isHintValid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsHintValid {
      get { return isHintValid_; }
      set {
        isHintValid_ = value;
      }
    }

    /// <summary>Field number for the "hint_center_pos" field.</summary>
    public const int HintCenterPosFieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.Vector hintCenterPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector HintCenterPos {
      get { return hintCenterPos_; }
      set {
        hintCenterPos_ = value;
      }
    }

    /// <summary>Field number for the "is_all_collected" field.</summary>
    public const int IsAllCollectedFieldNumber = 10;
    private bool isAllCollected_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAllCollected {
      get { return isAllCollected_; }
      set {
        isAllCollected_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 1;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "material_id" field.</summary>
    public const int MaterialIdFieldNumber = 9;
    private uint materialId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaterialId {
      get { return materialId_; }
      set {
        materialId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OneofGatherPointDetectorData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OneofGatherPointDetectorData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HintRadius != other.HintRadius) return false;
      if (ConfigId != other.ConfigId) return false;
      if (IsHintValid != other.IsHintValid) return false;
      if (!object.Equals(HintCenterPos, other.HintCenterPos)) return false;
      if (IsAllCollected != other.IsAllCollected) return false;
      if (GroupId != other.GroupId) return false;
      if (MaterialId != other.MaterialId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HintRadius != 0) hash ^= HintRadius.GetHashCode();
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (IsHintValid != false) hash ^= IsHintValid.GetHashCode();
      if (hintCenterPos_ != null) hash ^= HintCenterPos.GetHashCode();
      if (IsAllCollected != false) hash ^= IsAllCollected.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (MaterialId != 0) hash ^= MaterialId.GetHashCode();
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
      if (GroupId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GroupId);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ConfigId);
      }
      if (HintRadius != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(HintRadius);
      }
      if (MaterialId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MaterialId);
      }
      if (IsAllCollected != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsAllCollected);
      }
      if (IsHintValid != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsHintValid);
      }
      if (hintCenterPos_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(HintCenterPos);
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
      if (GroupId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GroupId);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ConfigId);
      }
      if (HintRadius != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(HintRadius);
      }
      if (MaterialId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MaterialId);
      }
      if (IsAllCollected != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsAllCollected);
      }
      if (IsHintValid != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsHintValid);
      }
      if (hintCenterPos_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(HintCenterPos);
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
      if (HintRadius != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HintRadius);
      }
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
      }
      if (IsHintValid != false) {
        size += 1 + 1;
      }
      if (hintCenterPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HintCenterPos);
      }
      if (IsAllCollected != false) {
        size += 1 + 1;
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (MaterialId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaterialId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OneofGatherPointDetectorData other) {
      if (other == null) {
        return;
      }
      if (other.HintRadius != 0) {
        HintRadius = other.HintRadius;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.IsHintValid != false) {
        IsHintValid = other.IsHintValid;
      }
      if (other.hintCenterPos_ != null) {
        if (hintCenterPos_ == null) {
          HintCenterPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        HintCenterPos.MergeFrom(other.HintCenterPos);
      }
      if (other.IsAllCollected != false) {
        IsAllCollected = other.IsAllCollected;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.MaterialId != 0) {
        MaterialId = other.MaterialId;
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
            GroupId = input.ReadUInt32();
            break;
          }
          case 24: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 32: {
            HintRadius = input.ReadUInt32();
            break;
          }
          case 72: {
            MaterialId = input.ReadUInt32();
            break;
          }
          case 80: {
            IsAllCollected = input.ReadBool();
            break;
          }
          case 88: {
            IsHintValid = input.ReadBool();
            break;
          }
          case 98: {
            if (hintCenterPos_ == null) {
              HintCenterPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(HintCenterPos);
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
            GroupId = input.ReadUInt32();
            break;
          }
          case 24: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 32: {
            HintRadius = input.ReadUInt32();
            break;
          }
          case 72: {
            MaterialId = input.ReadUInt32();
            break;
          }
          case 80: {
            IsAllCollected = input.ReadBool();
            break;
          }
          case 88: {
            IsHintValid = input.ReadBool();
            break;
          }
          case 98: {
            if (hintCenterPos_ == null) {
              HintCenterPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(HintCenterPos);
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
