// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeBlockArrangementInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeBlockArrangementInfo.proto</summary>
  public static partial class HomeBlockArrangementInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeBlockArrangementInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeBlockArrangementInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Ib21lQmxvY2tBcnJhbmdlbWVudEluZm8ucHJvdG8aFEhvbWVBbmltYWxE",
            "YXRhLnByb3RvGhlIb21lQmxvY2tEb3RQYXR0ZXJuLnByb3RvGhhIb21lQmxv",
            "Y2tGaWVsZERhdGEucHJvdG8aIkhvbWVGdXJuaXR1cmVDdXN0b21TdWl0ZURh",
            "dGEucHJvdG8aF0hvbWVGdXJuaXR1cmVEYXRhLnByb3RvGhxIb21lRnVybml0",
            "dXJlR3JvdXBEYXRhLnByb3RvGhxIb21lRnVybml0dXJlU3VpdGVEYXRhLnBy",
            "b3RvGhFIb21lTnBjRGF0YS5wcm90bxoWV2Vla2VuZERqaW5uSW5mby5wcm90",
            "byLUBAoYSG9tZUJsb2NrQXJyYW5nZW1lbnRJbmZvEjAKFGRlcGxveV9mdXJu",
            "aXVyZV9saXN0GAogAygLMhIuSG9tZUZ1cm5pdHVyZURhdGESKwoSZGVwbG95",
            "X2FuaW1hbF9saXN0GAcgAygLMg8uSG9tZUFuaW1hbERhdGESNQoUZnVybml0",
            "dXJlX3N1aXRlX2xpc3QYAyADKAsyFy5Ib21lRnVybml0dXJlU3VpdGVEYXRh",
            "EjIKF3dlZWtlbmRfZGppbm5faW5mb19saXN0GAUgAygLMhEuV2Vla2VuZERq",
            "aW5uSW5mbxIQCghibG9ja19pZBgOIAEoDRIuChBkb3RfcGF0dGVybl9saXN0",
            "GAYgAygLMhQuSG9tZUJsb2NrRG90UGF0dGVybhITCgtpc191bmxvY2tlZBgP",
            "IAEoCBIlCg9kZXBsb3lfbnBjX2xpc3QYASADKAsyDC5Ib21lTnBjRGF0YRI1",
            "ChRmdXJuaXR1cmVfZ3JvdXBfbGlzdBgIIAMoCzIXLkhvbWVGdXJuaXR1cmVH",
            "cm91cERhdGESJwoKZmllbGRfbGlzdBgNIAMoCzITLkhvbWVCbG9ja0ZpZWxk",
            "RGF0YRIVCg1jb21mb3J0X3ZhbHVlGAkgASgNEjUKGXBlcnNpc3RlbnRfZnVy",
            "bml0dXJlX2xpc3QYDCADKAsyEi5Ib21lRnVybml0dXJlRGF0YRJCChtmdXJu",
            "aXR1cmVfY3VzdG9tX3N1aXRlX2xpc3QYBCADKAsyHS5Ib21lRnVybml0dXJl",
            "Q3VzdG9tU3VpdGVEYXRhQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3Jr",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.HomeAnimalDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.HomeBlockDotPatternReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.HomeBlockFieldDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.HomeFurnitureCustomSuiteDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.HomeFurnitureDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.HomeFurnitureGroupDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.HomeFurnitureSuiteDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.HomeNpcDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.WeekendDjinnInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeBlockArrangementInfo), global::Weedwacker.Shared.Network.Proto.HomeBlockArrangementInfo.Parser, new[]{ "DeployFurniureList", "DeployAnimalList", "FurnitureSuiteList", "WeekendDjinnInfoList", "BlockId", "DotPatternList", "IsUnlocked", "DeployNpcList", "FurnitureGroupList", "FieldList", "ComfortValue", "PersistentFurnitureList", "FurnitureCustomSuiteList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeBlockArrangementInfo : pb::IMessage<HomeBlockArrangementInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeBlockArrangementInfo> _parser = new pb::MessageParser<HomeBlockArrangementInfo>(() => new HomeBlockArrangementInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeBlockArrangementInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeBlockArrangementInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlockArrangementInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlockArrangementInfo(HomeBlockArrangementInfo other) : this() {
      deployFurniureList_ = other.deployFurniureList_.Clone();
      deployAnimalList_ = other.deployAnimalList_.Clone();
      furnitureSuiteList_ = other.furnitureSuiteList_.Clone();
      weekendDjinnInfoList_ = other.weekendDjinnInfoList_.Clone();
      blockId_ = other.blockId_;
      dotPatternList_ = other.dotPatternList_.Clone();
      isUnlocked_ = other.isUnlocked_;
      deployNpcList_ = other.deployNpcList_.Clone();
      furnitureGroupList_ = other.furnitureGroupList_.Clone();
      fieldList_ = other.fieldList_.Clone();
      comfortValue_ = other.comfortValue_;
      persistentFurnitureList_ = other.persistentFurnitureList_.Clone();
      furnitureCustomSuiteList_ = other.furnitureCustomSuiteList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlockArrangementInfo Clone() {
      return new HomeBlockArrangementInfo(this);
    }

    /// <summary>Field number for the "deploy_furniure_list" field.</summary>
    public const int DeployFurniureListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.HomeFurnitureData> _repeated_deployFurniureList_codec
        = pb::FieldCodec.ForMessage(82, global::Weedwacker.Shared.Network.Proto.HomeFurnitureData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureData> deployFurniureList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureData> DeployFurniureList {
      get { return deployFurniureList_; }
    }

    /// <summary>Field number for the "deploy_animal_list" field.</summary>
    public const int DeployAnimalListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.HomeAnimalData> _repeated_deployAnimalList_codec
        = pb::FieldCodec.ForMessage(58, global::Weedwacker.Shared.Network.Proto.HomeAnimalData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeAnimalData> deployAnimalList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeAnimalData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeAnimalData> DeployAnimalList {
      get { return deployAnimalList_; }
    }

    /// <summary>Field number for the "furniture_suite_list" field.</summary>
    public const int FurnitureSuiteListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.HomeFurnitureSuiteData> _repeated_furnitureSuiteList_codec
        = pb::FieldCodec.ForMessage(26, global::Weedwacker.Shared.Network.Proto.HomeFurnitureSuiteData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureSuiteData> furnitureSuiteList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureSuiteData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureSuiteData> FurnitureSuiteList {
      get { return furnitureSuiteList_; }
    }

    /// <summary>Field number for the "weekend_djinn_info_list" field.</summary>
    public const int WeekendDjinnInfoListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.WeekendDjinnInfo> _repeated_weekendDjinnInfoList_codec
        = pb::FieldCodec.ForMessage(42, global::Weedwacker.Shared.Network.Proto.WeekendDjinnInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.WeekendDjinnInfo> weekendDjinnInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.WeekendDjinnInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.WeekendDjinnInfo> WeekendDjinnInfoList {
      get { return weekendDjinnInfoList_; }
    }

    /// <summary>Field number for the "block_id" field.</summary>
    public const int BlockIdFieldNumber = 14;
    private uint blockId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BlockId {
      get { return blockId_; }
      set {
        blockId_ = value;
      }
    }

    /// <summary>Field number for the "dot_pattern_list" field.</summary>
    public const int DotPatternListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.HomeBlockDotPattern> _repeated_dotPatternList_codec
        = pb::FieldCodec.ForMessage(50, global::Weedwacker.Shared.Network.Proto.HomeBlockDotPattern.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeBlockDotPattern> dotPatternList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeBlockDotPattern>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeBlockDotPattern> DotPatternList {
      get { return dotPatternList_; }
    }

    /// <summary>Field number for the "is_unlocked" field.</summary>
    public const int IsUnlockedFieldNumber = 15;
    private bool isUnlocked_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsUnlocked {
      get { return isUnlocked_; }
      set {
        isUnlocked_ = value;
      }
    }

    /// <summary>Field number for the "deploy_npc_list" field.</summary>
    public const int DeployNpcListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.HomeNpcData> _repeated_deployNpcList_codec
        = pb::FieldCodec.ForMessage(10, global::Weedwacker.Shared.Network.Proto.HomeNpcData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeNpcData> deployNpcList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeNpcData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeNpcData> DeployNpcList {
      get { return deployNpcList_; }
    }

    /// <summary>Field number for the "furniture_group_list" field.</summary>
    public const int FurnitureGroupListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.HomeFurnitureGroupData> _repeated_furnitureGroupList_codec
        = pb::FieldCodec.ForMessage(66, global::Weedwacker.Shared.Network.Proto.HomeFurnitureGroupData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureGroupData> furnitureGroupList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureGroupData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureGroupData> FurnitureGroupList {
      get { return furnitureGroupList_; }
    }

    /// <summary>Field number for the "field_list" field.</summary>
    public const int FieldListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.HomeBlockFieldData> _repeated_fieldList_codec
        = pb::FieldCodec.ForMessage(106, global::Weedwacker.Shared.Network.Proto.HomeBlockFieldData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeBlockFieldData> fieldList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeBlockFieldData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeBlockFieldData> FieldList {
      get { return fieldList_; }
    }

    /// <summary>Field number for the "comfort_value" field.</summary>
    public const int ComfortValueFieldNumber = 9;
    private uint comfortValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ComfortValue {
      get { return comfortValue_; }
      set {
        comfortValue_ = value;
      }
    }

    /// <summary>Field number for the "persistent_furniture_list" field.</summary>
    public const int PersistentFurnitureListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.HomeFurnitureData> _repeated_persistentFurnitureList_codec
        = pb::FieldCodec.ForMessage(98, global::Weedwacker.Shared.Network.Proto.HomeFurnitureData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureData> persistentFurnitureList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureData> PersistentFurnitureList {
      get { return persistentFurnitureList_; }
    }

    /// <summary>Field number for the "furniture_custom_suite_list" field.</summary>
    public const int FurnitureCustomSuiteListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.HomeFurnitureCustomSuiteData> _repeated_furnitureCustomSuiteList_codec
        = pb::FieldCodec.ForMessage(34, global::Weedwacker.Shared.Network.Proto.HomeFurnitureCustomSuiteData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureCustomSuiteData> furnitureCustomSuiteList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureCustomSuiteData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureCustomSuiteData> FurnitureCustomSuiteList {
      get { return furnitureCustomSuiteList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeBlockArrangementInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeBlockArrangementInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!deployFurniureList_.Equals(other.deployFurniureList_)) return false;
      if(!deployAnimalList_.Equals(other.deployAnimalList_)) return false;
      if(!furnitureSuiteList_.Equals(other.furnitureSuiteList_)) return false;
      if(!weekendDjinnInfoList_.Equals(other.weekendDjinnInfoList_)) return false;
      if (BlockId != other.BlockId) return false;
      if(!dotPatternList_.Equals(other.dotPatternList_)) return false;
      if (IsUnlocked != other.IsUnlocked) return false;
      if(!deployNpcList_.Equals(other.deployNpcList_)) return false;
      if(!furnitureGroupList_.Equals(other.furnitureGroupList_)) return false;
      if(!fieldList_.Equals(other.fieldList_)) return false;
      if (ComfortValue != other.ComfortValue) return false;
      if(!persistentFurnitureList_.Equals(other.persistentFurnitureList_)) return false;
      if(!furnitureCustomSuiteList_.Equals(other.furnitureCustomSuiteList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= deployFurniureList_.GetHashCode();
      hash ^= deployAnimalList_.GetHashCode();
      hash ^= furnitureSuiteList_.GetHashCode();
      hash ^= weekendDjinnInfoList_.GetHashCode();
      if (BlockId != 0) hash ^= BlockId.GetHashCode();
      hash ^= dotPatternList_.GetHashCode();
      if (IsUnlocked != false) hash ^= IsUnlocked.GetHashCode();
      hash ^= deployNpcList_.GetHashCode();
      hash ^= furnitureGroupList_.GetHashCode();
      hash ^= fieldList_.GetHashCode();
      if (ComfortValue != 0) hash ^= ComfortValue.GetHashCode();
      hash ^= persistentFurnitureList_.GetHashCode();
      hash ^= furnitureCustomSuiteList_.GetHashCode();
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
      deployNpcList_.WriteTo(output, _repeated_deployNpcList_codec);
      furnitureSuiteList_.WriteTo(output, _repeated_furnitureSuiteList_codec);
      furnitureCustomSuiteList_.WriteTo(output, _repeated_furnitureCustomSuiteList_codec);
      weekendDjinnInfoList_.WriteTo(output, _repeated_weekendDjinnInfoList_codec);
      dotPatternList_.WriteTo(output, _repeated_dotPatternList_codec);
      deployAnimalList_.WriteTo(output, _repeated_deployAnimalList_codec);
      furnitureGroupList_.WriteTo(output, _repeated_furnitureGroupList_codec);
      if (ComfortValue != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ComfortValue);
      }
      deployFurniureList_.WriteTo(output, _repeated_deployFurniureList_codec);
      persistentFurnitureList_.WriteTo(output, _repeated_persistentFurnitureList_codec);
      fieldList_.WriteTo(output, _repeated_fieldList_codec);
      if (BlockId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(BlockId);
      }
      if (IsUnlocked != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsUnlocked);
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
      deployNpcList_.WriteTo(ref output, _repeated_deployNpcList_codec);
      furnitureSuiteList_.WriteTo(ref output, _repeated_furnitureSuiteList_codec);
      furnitureCustomSuiteList_.WriteTo(ref output, _repeated_furnitureCustomSuiteList_codec);
      weekendDjinnInfoList_.WriteTo(ref output, _repeated_weekendDjinnInfoList_codec);
      dotPatternList_.WriteTo(ref output, _repeated_dotPatternList_codec);
      deployAnimalList_.WriteTo(ref output, _repeated_deployAnimalList_codec);
      furnitureGroupList_.WriteTo(ref output, _repeated_furnitureGroupList_codec);
      if (ComfortValue != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ComfortValue);
      }
      deployFurniureList_.WriteTo(ref output, _repeated_deployFurniureList_codec);
      persistentFurnitureList_.WriteTo(ref output, _repeated_persistentFurnitureList_codec);
      fieldList_.WriteTo(ref output, _repeated_fieldList_codec);
      if (BlockId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(BlockId);
      }
      if (IsUnlocked != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsUnlocked);
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
      size += deployFurniureList_.CalculateSize(_repeated_deployFurniureList_codec);
      size += deployAnimalList_.CalculateSize(_repeated_deployAnimalList_codec);
      size += furnitureSuiteList_.CalculateSize(_repeated_furnitureSuiteList_codec);
      size += weekendDjinnInfoList_.CalculateSize(_repeated_weekendDjinnInfoList_codec);
      if (BlockId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BlockId);
      }
      size += dotPatternList_.CalculateSize(_repeated_dotPatternList_codec);
      if (IsUnlocked != false) {
        size += 1 + 1;
      }
      size += deployNpcList_.CalculateSize(_repeated_deployNpcList_codec);
      size += furnitureGroupList_.CalculateSize(_repeated_furnitureGroupList_codec);
      size += fieldList_.CalculateSize(_repeated_fieldList_codec);
      if (ComfortValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ComfortValue);
      }
      size += persistentFurnitureList_.CalculateSize(_repeated_persistentFurnitureList_codec);
      size += furnitureCustomSuiteList_.CalculateSize(_repeated_furnitureCustomSuiteList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeBlockArrangementInfo other) {
      if (other == null) {
        return;
      }
      deployFurniureList_.Add(other.deployFurniureList_);
      deployAnimalList_.Add(other.deployAnimalList_);
      furnitureSuiteList_.Add(other.furnitureSuiteList_);
      weekendDjinnInfoList_.Add(other.weekendDjinnInfoList_);
      if (other.BlockId != 0) {
        BlockId = other.BlockId;
      }
      dotPatternList_.Add(other.dotPatternList_);
      if (other.IsUnlocked != false) {
        IsUnlocked = other.IsUnlocked;
      }
      deployNpcList_.Add(other.deployNpcList_);
      furnitureGroupList_.Add(other.furnitureGroupList_);
      fieldList_.Add(other.fieldList_);
      if (other.ComfortValue != 0) {
        ComfortValue = other.ComfortValue;
      }
      persistentFurnitureList_.Add(other.persistentFurnitureList_);
      furnitureCustomSuiteList_.Add(other.furnitureCustomSuiteList_);
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
          case 10: {
            deployNpcList_.AddEntriesFrom(input, _repeated_deployNpcList_codec);
            break;
          }
          case 26: {
            furnitureSuiteList_.AddEntriesFrom(input, _repeated_furnitureSuiteList_codec);
            break;
          }
          case 34: {
            furnitureCustomSuiteList_.AddEntriesFrom(input, _repeated_furnitureCustomSuiteList_codec);
            break;
          }
          case 42: {
            weekendDjinnInfoList_.AddEntriesFrom(input, _repeated_weekendDjinnInfoList_codec);
            break;
          }
          case 50: {
            dotPatternList_.AddEntriesFrom(input, _repeated_dotPatternList_codec);
            break;
          }
          case 58: {
            deployAnimalList_.AddEntriesFrom(input, _repeated_deployAnimalList_codec);
            break;
          }
          case 66: {
            furnitureGroupList_.AddEntriesFrom(input, _repeated_furnitureGroupList_codec);
            break;
          }
          case 72: {
            ComfortValue = input.ReadUInt32();
            break;
          }
          case 82: {
            deployFurniureList_.AddEntriesFrom(input, _repeated_deployFurniureList_codec);
            break;
          }
          case 98: {
            persistentFurnitureList_.AddEntriesFrom(input, _repeated_persistentFurnitureList_codec);
            break;
          }
          case 106: {
            fieldList_.AddEntriesFrom(input, _repeated_fieldList_codec);
            break;
          }
          case 112: {
            BlockId = input.ReadUInt32();
            break;
          }
          case 120: {
            IsUnlocked = input.ReadBool();
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
          case 10: {
            deployNpcList_.AddEntriesFrom(ref input, _repeated_deployNpcList_codec);
            break;
          }
          case 26: {
            furnitureSuiteList_.AddEntriesFrom(ref input, _repeated_furnitureSuiteList_codec);
            break;
          }
          case 34: {
            furnitureCustomSuiteList_.AddEntriesFrom(ref input, _repeated_furnitureCustomSuiteList_codec);
            break;
          }
          case 42: {
            weekendDjinnInfoList_.AddEntriesFrom(ref input, _repeated_weekendDjinnInfoList_codec);
            break;
          }
          case 50: {
            dotPatternList_.AddEntriesFrom(ref input, _repeated_dotPatternList_codec);
            break;
          }
          case 58: {
            deployAnimalList_.AddEntriesFrom(ref input, _repeated_deployAnimalList_codec);
            break;
          }
          case 66: {
            furnitureGroupList_.AddEntriesFrom(ref input, _repeated_furnitureGroupList_codec);
            break;
          }
          case 72: {
            ComfortValue = input.ReadUInt32();
            break;
          }
          case 82: {
            deployFurniureList_.AddEntriesFrom(ref input, _repeated_deployFurniureList_codec);
            break;
          }
          case 98: {
            persistentFurnitureList_.AddEntriesFrom(ref input, _repeated_persistentFurnitureList_codec);
            break;
          }
          case 106: {
            fieldList_.AddEntriesFrom(ref input, _repeated_fieldList_codec);
            break;
          }
          case 112: {
            BlockId = input.ReadUInt32();
            break;
          }
          case 120: {
            IsUnlocked = input.ReadBool();
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
