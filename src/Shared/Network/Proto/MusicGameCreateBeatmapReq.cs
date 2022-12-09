// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MusicGameCreateBeatmapReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from MusicGameCreateBeatmapReq.proto</summary>
  public static partial class MusicGameCreateBeatmapReqReflection {

    #region Descriptor
    /// <summary>File descriptor for MusicGameCreateBeatmapReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MusicGameCreateBeatmapReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9NdXNpY0dhbWVDcmVhdGVCZWF0bWFwUmVxLnByb3RvEh9XZWVkd2Fja2Vy",
            "LlNoYXJlZC5OZXR3b3JrLlByb3RvGhJNdXNpY0JlYXRtYXAucHJvdG8aFE11",
            "c2ljQnJpZWZJbmZvLnByb3RvGhtNdXNpY0dhbWVVbmtub3duMUVudW0ucHJv",
            "dG8imAIKGU11c2ljR2FtZUNyZWF0ZUJlYXRtYXBSZXESTQoNdW5rbm93bl9l",
            "bnVtMRgMIAEoDjI2LldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8u",
            "TXVzaWNHYW1lVW5rbm93bjFFbnVtEkUKDG11c2ljX3JlY29yZBgKIAEoCzIt",
            "LldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uTXVzaWNCZWF0bWFw",
            "SAASTAoQbXVzaWNfYnJpZWZfaW5mbxj9ByABKAsyLy5XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvLk11c2ljQnJpZWZJbmZvSAFCCQoHYmVhdG1h",
            "cEIMCgpicmllZl9pbmZvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.MusicBeatmapReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.MusicBriefInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.MusicGameUnknown1EnumReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.MusicGameCreateBeatmapReq), global::Weedwacker.Shared.Network.Proto.MusicGameCreateBeatmapReq.Parser, new[]{ "UnknownEnum1", "MusicRecord", "MusicBriefInfo" }, new[]{ "Beatmap", "BriefInfo" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 6326
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class MusicGameCreateBeatmapReq : pb::IMessage<MusicGameCreateBeatmapReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MusicGameCreateBeatmapReq> _parser = new pb::MessageParser<MusicGameCreateBeatmapReq>(() => new MusicGameCreateBeatmapReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MusicGameCreateBeatmapReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.MusicGameCreateBeatmapReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameCreateBeatmapReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameCreateBeatmapReq(MusicGameCreateBeatmapReq other) : this() {
      unknownEnum1_ = other.unknownEnum1_;
      switch (other.BeatmapCase) {
        case BeatmapOneofCase.MusicRecord:
          MusicRecord = other.MusicRecord.Clone();
          break;
      }

      switch (other.BriefInfoCase) {
        case BriefInfoOneofCase.MusicBriefInfo:
          MusicBriefInfo = other.MusicBriefInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameCreateBeatmapReq Clone() {
      return new MusicGameCreateBeatmapReq(this);
    }

    /// <summary>Field number for the "unknown_enum1" field.</summary>
    public const int UnknownEnum1FieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.MusicGameUnknown1Enum unknownEnum1_ = global::Weedwacker.Shared.Network.Proto.MusicGameUnknown1Enum.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.MusicGameUnknown1Enum UnknownEnum1 {
      get { return unknownEnum1_; }
      set {
        unknownEnum1_ = value;
      }
    }

    /// <summary>Field number for the "music_record" field.</summary>
    public const int MusicRecordFieldNumber = 10;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.MusicBeatmap MusicRecord {
      get { return beatmapCase_ == BeatmapOneofCase.MusicRecord ? (global::Weedwacker.Shared.Network.Proto.MusicBeatmap) beatmap_ : null; }
      set {
        beatmap_ = value;
        beatmapCase_ = value == null ? BeatmapOneofCase.None : BeatmapOneofCase.MusicRecord;
      }
    }

    /// <summary>Field number for the "music_brief_info" field.</summary>
    public const int MusicBriefInfoFieldNumber = 1021;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.MusicBriefInfo MusicBriefInfo {
      get { return briefInfoCase_ == BriefInfoOneofCase.MusicBriefInfo ? (global::Weedwacker.Shared.Network.Proto.MusicBriefInfo) briefInfo_ : null; }
      set {
        briefInfo_ = value;
        briefInfoCase_ = value == null ? BriefInfoOneofCase.None : BriefInfoOneofCase.MusicBriefInfo;
      }
    }

    private object beatmap_;
    /// <summary>Enum of possible cases for the "beatmap" oneof.</summary>
    public enum BeatmapOneofCase {
      None = 0,
      MusicRecord = 10,
    }
    private BeatmapOneofCase beatmapCase_ = BeatmapOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BeatmapOneofCase BeatmapCase {
      get { return beatmapCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBeatmap() {
      beatmapCase_ = BeatmapOneofCase.None;
      beatmap_ = null;
    }

    private object briefInfo_;
    /// <summary>Enum of possible cases for the "brief_info" oneof.</summary>
    public enum BriefInfoOneofCase {
      None = 0,
      MusicBriefInfo = 1021,
    }
    private BriefInfoOneofCase briefInfoCase_ = BriefInfoOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BriefInfoOneofCase BriefInfoCase {
      get { return briefInfoCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBriefInfo() {
      briefInfoCase_ = BriefInfoOneofCase.None;
      briefInfo_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MusicGameCreateBeatmapReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MusicGameCreateBeatmapReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UnknownEnum1 != other.UnknownEnum1) return false;
      if (!object.Equals(MusicRecord, other.MusicRecord)) return false;
      if (!object.Equals(MusicBriefInfo, other.MusicBriefInfo)) return false;
      if (BeatmapCase != other.BeatmapCase) return false;
      if (BriefInfoCase != other.BriefInfoCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (UnknownEnum1 != global::Weedwacker.Shared.Network.Proto.MusicGameUnknown1Enum.None) hash ^= UnknownEnum1.GetHashCode();
      if (beatmapCase_ == BeatmapOneofCase.MusicRecord) hash ^= MusicRecord.GetHashCode();
      if (briefInfoCase_ == BriefInfoOneofCase.MusicBriefInfo) hash ^= MusicBriefInfo.GetHashCode();
      hash ^= (int) beatmapCase_;
      hash ^= (int) briefInfoCase_;
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
      if (beatmapCase_ == BeatmapOneofCase.MusicRecord) {
        output.WriteRawTag(82);
        output.WriteMessage(MusicRecord);
      }
      if (UnknownEnum1 != global::Weedwacker.Shared.Network.Proto.MusicGameUnknown1Enum.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) UnknownEnum1);
      }
      if (briefInfoCase_ == BriefInfoOneofCase.MusicBriefInfo) {
        output.WriteRawTag(234, 63);
        output.WriteMessage(MusicBriefInfo);
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
      if (beatmapCase_ == BeatmapOneofCase.MusicRecord) {
        output.WriteRawTag(82);
        output.WriteMessage(MusicRecord);
      }
      if (UnknownEnum1 != global::Weedwacker.Shared.Network.Proto.MusicGameUnknown1Enum.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) UnknownEnum1);
      }
      if (briefInfoCase_ == BriefInfoOneofCase.MusicBriefInfo) {
        output.WriteRawTag(234, 63);
        output.WriteMessage(MusicBriefInfo);
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
      if (UnknownEnum1 != global::Weedwacker.Shared.Network.Proto.MusicGameUnknown1Enum.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UnknownEnum1);
      }
      if (beatmapCase_ == BeatmapOneofCase.MusicRecord) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MusicRecord);
      }
      if (briefInfoCase_ == BriefInfoOneofCase.MusicBriefInfo) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(MusicBriefInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MusicGameCreateBeatmapReq other) {
      if (other == null) {
        return;
      }
      if (other.UnknownEnum1 != global::Weedwacker.Shared.Network.Proto.MusicGameUnknown1Enum.None) {
        UnknownEnum1 = other.UnknownEnum1;
      }
      switch (other.BeatmapCase) {
        case BeatmapOneofCase.MusicRecord:
          if (MusicRecord == null) {
            MusicRecord = new global::Weedwacker.Shared.Network.Proto.MusicBeatmap();
          }
          MusicRecord.MergeFrom(other.MusicRecord);
          break;
      }

      switch (other.BriefInfoCase) {
        case BriefInfoOneofCase.MusicBriefInfo:
          if (MusicBriefInfo == null) {
            MusicBriefInfo = new global::Weedwacker.Shared.Network.Proto.MusicBriefInfo();
          }
          MusicBriefInfo.MergeFrom(other.MusicBriefInfo);
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
          case 82: {
            global::Weedwacker.Shared.Network.Proto.MusicBeatmap subBuilder = new global::Weedwacker.Shared.Network.Proto.MusicBeatmap();
            if (beatmapCase_ == BeatmapOneofCase.MusicRecord) {
              subBuilder.MergeFrom(MusicRecord);
            }
            input.ReadMessage(subBuilder);
            MusicRecord = subBuilder;
            break;
          }
          case 96: {
            UnknownEnum1 = (global::Weedwacker.Shared.Network.Proto.MusicGameUnknown1Enum) input.ReadEnum();
            break;
          }
          case 8170: {
            global::Weedwacker.Shared.Network.Proto.MusicBriefInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.MusicBriefInfo();
            if (briefInfoCase_ == BriefInfoOneofCase.MusicBriefInfo) {
              subBuilder.MergeFrom(MusicBriefInfo);
            }
            input.ReadMessage(subBuilder);
            MusicBriefInfo = subBuilder;
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
          case 82: {
            global::Weedwacker.Shared.Network.Proto.MusicBeatmap subBuilder = new global::Weedwacker.Shared.Network.Proto.MusicBeatmap();
            if (beatmapCase_ == BeatmapOneofCase.MusicRecord) {
              subBuilder.MergeFrom(MusicRecord);
            }
            input.ReadMessage(subBuilder);
            MusicRecord = subBuilder;
            break;
          }
          case 96: {
            UnknownEnum1 = (global::Weedwacker.Shared.Network.Proto.MusicGameUnknown1Enum) input.ReadEnum();
            break;
          }
          case 8170: {
            global::Weedwacker.Shared.Network.Proto.MusicBriefInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.MusicBriefInfo();
            if (briefInfoCase_ == BriefInfoOneofCase.MusicBriefInfo) {
              subBuilder.MergeFrom(MusicBriefInfo);
            }
            input.ReadMessage(subBuilder);
            MusicBriefInfo = subBuilder;
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
