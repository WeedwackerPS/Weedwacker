// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FleurFairGallerySettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from FleurFairGallerySettleInfo.proto</summary>
  public static partial class FleurFairGallerySettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FleurFairGallerySettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FleurFairGallerySettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBGbGV1ckZhaXJHYWxsZXJ5U2V0dGxlSW5mby5wcm90byL5AQoaRmxldXJG",
            "YWlyR2FsbGVyeVNldHRsZUluZm8SDgoGZW5lcmd5GAIgASgNEhsKE2dhbGxl",
            "cnlfc3RhZ2VfaW5kZXgYCyABKA0SRwoPZW5lcmd5X3N0YXRfbWFwGAYgAygL",
            "Mi4uRmxldXJGYWlyR2FsbGVyeVNldHRsZUluZm8uRW5lcmd5U3RhdE1hcEVu",
            "dHJ5EhsKE2dhbGxlcnlfc3RhZ2VfY291bnQYCSABKA0SEgoKaXNfc3VjY2Vz",
            "cxgBIAEoCBo0ChJFbmVyZ3lTdGF0TWFwRW50cnkSCwoDa2V5GAEgASgNEg0K",
            "BXZhbHVlGAIgASgFOgI4AUIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.FleurFairGallerySettleInfo), global::Weedwacker.Server.Proto.FleurFairGallerySettleInfo.Parser, new[]{ "Energy", "GalleryStageIndex", "EnergyStatMap", "GalleryStageCount", "IsSuccess" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FleurFairGallerySettleInfo : pb::IMessage<FleurFairGallerySettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FleurFairGallerySettleInfo> _parser = new pb::MessageParser<FleurFairGallerySettleInfo>(() => new FleurFairGallerySettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FleurFairGallerySettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.FleurFairGallerySettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairGallerySettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairGallerySettleInfo(FleurFairGallerySettleInfo other) : this() {
      energy_ = other.energy_;
      galleryStageIndex_ = other.galleryStageIndex_;
      energyStatMap_ = other.energyStatMap_.Clone();
      galleryStageCount_ = other.galleryStageCount_;
      isSuccess_ = other.isSuccess_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairGallerySettleInfo Clone() {
      return new FleurFairGallerySettleInfo(this);
    }

    /// <summary>Field number for the "energy" field.</summary>
    public const int EnergyFieldNumber = 2;
    private uint energy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Energy {
      get { return energy_; }
      set {
        energy_ = value;
      }
    }

    /// <summary>Field number for the "gallery_stage_index" field.</summary>
    public const int GalleryStageIndexFieldNumber = 11;
    private uint galleryStageIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryStageIndex {
      get { return galleryStageIndex_; }
      set {
        galleryStageIndex_ = value;
      }
    }

    /// <summary>Field number for the "energy_stat_map" field.</summary>
    public const int EnergyStatMapFieldNumber = 6;
    private static readonly pbc::MapField<uint, int>.Codec _map_energyStatMap_codec
        = new pbc::MapField<uint, int>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 50);
    private readonly pbc::MapField<uint, int> energyStatMap_ = new pbc::MapField<uint, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, int> EnergyStatMap {
      get { return energyStatMap_; }
    }

    /// <summary>Field number for the "gallery_stage_count" field.</summary>
    public const int GalleryStageCountFieldNumber = 9;
    private uint galleryStageCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryStageCount {
      get { return galleryStageCount_; }
      set {
        galleryStageCount_ = value;
      }
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 1;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FleurFairGallerySettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FleurFairGallerySettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Energy != other.Energy) return false;
      if (GalleryStageIndex != other.GalleryStageIndex) return false;
      if (!EnergyStatMap.Equals(other.EnergyStatMap)) return false;
      if (GalleryStageCount != other.GalleryStageCount) return false;
      if (IsSuccess != other.IsSuccess) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Energy != 0) hash ^= Energy.GetHashCode();
      if (GalleryStageIndex != 0) hash ^= GalleryStageIndex.GetHashCode();
      hash ^= EnergyStatMap.GetHashCode();
      if (GalleryStageCount != 0) hash ^= GalleryStageCount.GetHashCode();
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
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
      if (IsSuccess != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsSuccess);
      }
      if (Energy != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Energy);
      }
      energyStatMap_.WriteTo(output, _map_energyStatMap_codec);
      if (GalleryStageCount != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GalleryStageCount);
      }
      if (GalleryStageIndex != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GalleryStageIndex);
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
      if (IsSuccess != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsSuccess);
      }
      if (Energy != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Energy);
      }
      energyStatMap_.WriteTo(ref output, _map_energyStatMap_codec);
      if (GalleryStageCount != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GalleryStageCount);
      }
      if (GalleryStageIndex != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GalleryStageIndex);
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
      if (Energy != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Energy);
      }
      if (GalleryStageIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryStageIndex);
      }
      size += energyStatMap_.CalculateSize(_map_energyStatMap_codec);
      if (GalleryStageCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryStageCount);
      }
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FleurFairGallerySettleInfo other) {
      if (other == null) {
        return;
      }
      if (other.Energy != 0) {
        Energy = other.Energy;
      }
      if (other.GalleryStageIndex != 0) {
        GalleryStageIndex = other.GalleryStageIndex;
      }
      energyStatMap_.Add(other.energyStatMap_);
      if (other.GalleryStageCount != 0) {
        GalleryStageCount = other.GalleryStageCount;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
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
            IsSuccess = input.ReadBool();
            break;
          }
          case 16: {
            Energy = input.ReadUInt32();
            break;
          }
          case 50: {
            energyStatMap_.AddEntriesFrom(input, _map_energyStatMap_codec);
            break;
          }
          case 72: {
            GalleryStageCount = input.ReadUInt32();
            break;
          }
          case 88: {
            GalleryStageIndex = input.ReadUInt32();
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
            IsSuccess = input.ReadBool();
            break;
          }
          case 16: {
            Energy = input.ReadUInt32();
            break;
          }
          case 50: {
            energyStatMap_.AddEntriesFrom(ref input, _map_energyStatMap_codec);
            break;
          }
          case 72: {
            GalleryStageCount = input.ReadUInt32();
            break;
          }
          case 88: {
            GalleryStageIndex = input.ReadUInt32();
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