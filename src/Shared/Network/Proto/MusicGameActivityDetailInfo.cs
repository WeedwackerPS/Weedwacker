// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MusicGameActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from MusicGameActivityDetailInfo.proto</summary>
  public static partial class MusicGameActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for MusicGameActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MusicGameActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFNdXNpY0dhbWVBY3Rpdml0eURldGFpbEluZm8ucHJvdG8SH1dlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8aFU11c2ljR2FtZVJlY29yZC5wcm90",
            "bxoXVWdjTXVzaWNCcmllZkluZm8ucHJvdG8ipQMKG011c2ljR2FtZUFjdGl2",
            "aXR5RGV0YWlsSW5mbxJRChVwZXJzb25fY3VzdG9tX2JlYXRtYXAYAiADKAsy",
            "Mi5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLlVnY011c2ljQnJp",
            "ZWZJbmZvElEKFW90aGVyc19jdXN0b21fYmVhdG1hcBgMIAMoCzIyLldlZWR3",
            "YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uVWdjTXVzaWNCcmllZkluZm8S",
            "cwoVbXVzaWNfZ2FtZV9yZWNvcmRfbWFwGAkgAygLMlQuV2VlZHdhY2tlci5T",
            "aGFyZWQuTmV0d29yay5Qcm90by5NdXNpY0dhbWVBY3Rpdml0eURldGFpbElu",
            "Zm8uTXVzaWNHYW1lUmVjb3JkTWFwRW50cnkaawoXTXVzaWNHYW1lUmVjb3Jk",
            "TWFwRW50cnkSCwoDa2V5GAEgASgNEj8KBXZhbHVlGAIgASgLMjAuV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5NdXNpY0dhbWVSZWNvcmQ6AjgB",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.MusicGameRecordReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.MusicGameActivityDetailInfo), global::Weedwacker.Shared.Network.Proto.MusicGameActivityDetailInfo.Parser, new[]{ "PersonCustomBeatmap", "OthersCustomBeatmap", "MusicGameRecordMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MusicGameActivityDetailInfo : pb::IMessage<MusicGameActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MusicGameActivityDetailInfo> _parser = new pb::MessageParser<MusicGameActivityDetailInfo>(() => new MusicGameActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MusicGameActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.MusicGameActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameActivityDetailInfo(MusicGameActivityDetailInfo other) : this() {
      personCustomBeatmap_ = other.personCustomBeatmap_.Clone();
      othersCustomBeatmap_ = other.othersCustomBeatmap_.Clone();
      musicGameRecordMap_ = other.musicGameRecordMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameActivityDetailInfo Clone() {
      return new MusicGameActivityDetailInfo(this);
    }

    /// <summary>Field number for the "person_custom_beatmap" field.</summary>
    public const int PersonCustomBeatmapFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo> _repeated_personCustomBeatmap_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo> personCustomBeatmap_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo>();
    /// <summary>
    /// Unk3300_AAGCDCOIPJM
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo> PersonCustomBeatmap {
      get { return personCustomBeatmap_; }
    }

    /// <summary>Field number for the "others_custom_beatmap" field.</summary>
    public const int OthersCustomBeatmapFieldNumber = 12;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo> _repeated_othersCustomBeatmap_codec
        = pb::FieldCodec.ForMessage(98, global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo> othersCustomBeatmap_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo>();
    /// <summary>
    /// Unk3300_OKHAACGHMAP
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo> OthersCustomBeatmap {
      get { return othersCustomBeatmap_; }
    }

    /// <summary>Field number for the "music_game_record_map" field.</summary>
    public const int MusicGameRecordMapFieldNumber = 9;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.MusicGameRecord>.Codec _map_musicGameRecordMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.MusicGameRecord>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.MusicGameRecord.Parser), 74);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.MusicGameRecord> musicGameRecordMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.MusicGameRecord>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.MusicGameRecord> MusicGameRecordMap {
      get { return musicGameRecordMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MusicGameActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MusicGameActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!personCustomBeatmap_.Equals(other.personCustomBeatmap_)) return false;
      if(!othersCustomBeatmap_.Equals(other.othersCustomBeatmap_)) return false;
      if (!MusicGameRecordMap.Equals(other.MusicGameRecordMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= personCustomBeatmap_.GetHashCode();
      hash ^= othersCustomBeatmap_.GetHashCode();
      hash ^= MusicGameRecordMap.GetHashCode();
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
      personCustomBeatmap_.WriteTo(output, _repeated_personCustomBeatmap_codec);
      musicGameRecordMap_.WriteTo(output, _map_musicGameRecordMap_codec);
      othersCustomBeatmap_.WriteTo(output, _repeated_othersCustomBeatmap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      personCustomBeatmap_.WriteTo(ref output, _repeated_personCustomBeatmap_codec);
      musicGameRecordMap_.WriteTo(ref output, _map_musicGameRecordMap_codec);
      othersCustomBeatmap_.WriteTo(ref output, _repeated_othersCustomBeatmap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += personCustomBeatmap_.CalculateSize(_repeated_personCustomBeatmap_codec);
      size += othersCustomBeatmap_.CalculateSize(_repeated_othersCustomBeatmap_codec);
      size += musicGameRecordMap_.CalculateSize(_map_musicGameRecordMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MusicGameActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      personCustomBeatmap_.Add(other.personCustomBeatmap_);
      othersCustomBeatmap_.Add(other.othersCustomBeatmap_);
      musicGameRecordMap_.Add(other.musicGameRecordMap_);
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
          case 18: {
            personCustomBeatmap_.AddEntriesFrom(input, _repeated_personCustomBeatmap_codec);
            break;
          }
          case 74: {
            musicGameRecordMap_.AddEntriesFrom(input, _map_musicGameRecordMap_codec);
            break;
          }
          case 98: {
            othersCustomBeatmap_.AddEntriesFrom(input, _repeated_othersCustomBeatmap_codec);
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
          case 18: {
            personCustomBeatmap_.AddEntriesFrom(ref input, _repeated_personCustomBeatmap_codec);
            break;
          }
          case 74: {
            musicGameRecordMap_.AddEntriesFrom(ref input, _map_musicGameRecordMap_codec);
            break;
          }
          case 98: {
            othersCustomBeatmap_.AddEntriesFrom(ref input, _repeated_othersCustomBeatmap_codec);
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
