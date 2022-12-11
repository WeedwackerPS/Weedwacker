// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeCustomFurnitureInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeCustomFurnitureInfoNotify.proto</summary>
  public static partial class HomeCustomFurnitureInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeCustomFurnitureInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeCustomFurnitureInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNIb21lQ3VzdG9tRnVybml0dXJlSW5mb05vdGlmeS5wcm90bxIfV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90bxodSG9tZUN1c3RvbUZ1cm5pdHVy",
            "ZUluZm8ucHJvdG8i6QIKHUhvbWVDdXN0b21GdXJuaXR1cmVJbmZvTm90aWZ5",
            "EiQKHGRlbGV0ZV9jdXN0b21fZnVybml0dXJlX2xpc3QYDSADKA0SXAoaY3Vz",
            "dG9tX2Z1cm5pdHVyZV9pbmZvX2xpc3QYDyADKAsyOC5XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvLkhvbWVDdXN0b21GdXJuaXR1cmVJbmZvEoIB",
            "Chx1c2VkX3N1Yl9mdXJuaXR1cmVfY291bnRfbWFwGAMgAygLMlwuV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5Ib21lQ3VzdG9tRnVybml0dXJl",
            "SW5mb05vdGlmeS5Vc2VkU3ViRnVybml0dXJlQ291bnRNYXBFbnRyeRo/Ch1V",
            "c2VkU3ViRnVybml0dXJlQ291bnRNYXBFbnRyeRILCgNrZXkYASABKA0SDQoF",
            "dmFsdWUYAiABKA06AjgBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.HomeCustomFurnitureInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeCustomFurnitureInfoNotify), global::Weedwacker.Shared.Network.Proto.HomeCustomFurnitureInfoNotify.Parser, new[]{ "DeleteCustomFurnitureList", "CustomFurnitureInfoList", "UsedSubFurnitureCountMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4888;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class HomeCustomFurnitureInfoNotify : pb::IMessage<HomeCustomFurnitureInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeCustomFurnitureInfoNotify> _parser = new pb::MessageParser<HomeCustomFurnitureInfoNotify>(() => new HomeCustomFurnitureInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeCustomFurnitureInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeCustomFurnitureInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeCustomFurnitureInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeCustomFurnitureInfoNotify(HomeCustomFurnitureInfoNotify other) : this() {
      deleteCustomFurnitureList_ = other.deleteCustomFurnitureList_.Clone();
      customFurnitureInfoList_ = other.customFurnitureInfoList_.Clone();
      usedSubFurnitureCountMap_ = other.usedSubFurnitureCountMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeCustomFurnitureInfoNotify Clone() {
      return new HomeCustomFurnitureInfoNotify(this);
    }

    /// <summary>Field number for the "delete_custom_furniture_list" field.</summary>
    public const int DeleteCustomFurnitureListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_deleteCustomFurnitureList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> deleteCustomFurnitureList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DeleteCustomFurnitureList {
      get { return deleteCustomFurnitureList_; }
    }

    /// <summary>Field number for the "custom_furniture_info_list" field.</summary>
    public const int CustomFurnitureInfoListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.HomeCustomFurnitureInfo> _repeated_customFurnitureInfoList_codec
        = pb::FieldCodec.ForMessage(122, global::Weedwacker.Shared.Network.Proto.HomeCustomFurnitureInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeCustomFurnitureInfo> customFurnitureInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeCustomFurnitureInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeCustomFurnitureInfo> CustomFurnitureInfoList {
      get { return customFurnitureInfoList_; }
    }

    /// <summary>Field number for the "used_sub_furniture_count_map" field.</summary>
    public const int UsedSubFurnitureCountMapFieldNumber = 3;
    private static readonly pbc::MapField<uint, uint>.Codec _map_usedSubFurnitureCountMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 26);
    private readonly pbc::MapField<uint, uint> usedSubFurnitureCountMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> UsedSubFurnitureCountMap {
      get { return usedSubFurnitureCountMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeCustomFurnitureInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeCustomFurnitureInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!deleteCustomFurnitureList_.Equals(other.deleteCustomFurnitureList_)) return false;
      if(!customFurnitureInfoList_.Equals(other.customFurnitureInfoList_)) return false;
      if (!UsedSubFurnitureCountMap.Equals(other.UsedSubFurnitureCountMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= deleteCustomFurnitureList_.GetHashCode();
      hash ^= customFurnitureInfoList_.GetHashCode();
      hash ^= UsedSubFurnitureCountMap.GetHashCode();
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
      usedSubFurnitureCountMap_.WriteTo(output, _map_usedSubFurnitureCountMap_codec);
      deleteCustomFurnitureList_.WriteTo(output, _repeated_deleteCustomFurnitureList_codec);
      customFurnitureInfoList_.WriteTo(output, _repeated_customFurnitureInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      usedSubFurnitureCountMap_.WriteTo(ref output, _map_usedSubFurnitureCountMap_codec);
      deleteCustomFurnitureList_.WriteTo(ref output, _repeated_deleteCustomFurnitureList_codec);
      customFurnitureInfoList_.WriteTo(ref output, _repeated_customFurnitureInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += deleteCustomFurnitureList_.CalculateSize(_repeated_deleteCustomFurnitureList_codec);
      size += customFurnitureInfoList_.CalculateSize(_repeated_customFurnitureInfoList_codec);
      size += usedSubFurnitureCountMap_.CalculateSize(_map_usedSubFurnitureCountMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeCustomFurnitureInfoNotify other) {
      if (other == null) {
        return;
      }
      deleteCustomFurnitureList_.Add(other.deleteCustomFurnitureList_);
      customFurnitureInfoList_.Add(other.customFurnitureInfoList_);
      usedSubFurnitureCountMap_.Add(other.usedSubFurnitureCountMap_);
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
          case 26: {
            usedSubFurnitureCountMap_.AddEntriesFrom(input, _map_usedSubFurnitureCountMap_codec);
            break;
          }
          case 106:
          case 104: {
            deleteCustomFurnitureList_.AddEntriesFrom(input, _repeated_deleteCustomFurnitureList_codec);
            break;
          }
          case 122: {
            customFurnitureInfoList_.AddEntriesFrom(input, _repeated_customFurnitureInfoList_codec);
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
          case 26: {
            usedSubFurnitureCountMap_.AddEntriesFrom(ref input, _map_usedSubFurnitureCountMap_codec);
            break;
          }
          case 106:
          case 104: {
            deleteCustomFurnitureList_.AddEntriesFrom(ref input, _repeated_deleteCustomFurnitureList_codec);
            break;
          }
          case 122: {
            customFurnitureInfoList_.AddEntriesFrom(ref input, _repeated_customFurnitureInfoList_codec);
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
