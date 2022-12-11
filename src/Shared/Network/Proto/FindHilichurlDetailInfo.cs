// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FindHilichurlDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FindHilichurlDetailInfo.proto</summary>
  public static partial class FindHilichurlDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FindHilichurlDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FindHilichurlDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1GaW5kSGlsaWNodXJsRGV0YWlsSW5mby5wcm90bxIfV2VlZHdhY2tlci5T",
            "aGFyZWQuTmV0d29yay5Qcm90bxohRmluZEhpbGljaHVybERheUNvbnRlbnRJ",
            "bmZvLnByb3RvIpYCChdGaW5kSGlsaWNodXJsRGV0YWlsSW5mbxIRCglkYXlf",
            "aW5kZXgYCCABKA0SGQoRaXNfY29udGVudF9jbG9zZWQYDCABKAgSHQoVbWlu",
            "X29wZW5fcGxheWVyX2xldmVsGAIgASgNElsKFWRheV9jb250ZW50X2luZm9f",
            "bGlzdBgEIAMoCzI8LldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8u",
            "RmluZEhpbGljaHVybERheUNvbnRlbnRJbmZvEhoKEmNvbnRlbnRfY2xvc2Vf",
            "dGltZRgHIAEoDRIbChNpc19lbmRfcXVlc3RfYWNjZXB0GAUgASgIEhgKEHBs",
            "YXllcl9kYXlfaW5kZXgYDiABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.FindHilichurlDayContentInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FindHilichurlDetailInfo), global::Weedwacker.Shared.Network.Proto.FindHilichurlDetailInfo.Parser, new[]{ "DayIndex", "IsContentClosed", "MinOpenPlayerLevel", "DayContentInfoList", "ContentCloseTime", "IsEndQuestAccept", "PlayerDayIndex" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FindHilichurlDetailInfo : pb::IMessage<FindHilichurlDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FindHilichurlDetailInfo> _parser = new pb::MessageParser<FindHilichurlDetailInfo>(() => new FindHilichurlDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FindHilichurlDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FindHilichurlDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FindHilichurlDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FindHilichurlDetailInfo(FindHilichurlDetailInfo other) : this() {
      dayIndex_ = other.dayIndex_;
      isContentClosed_ = other.isContentClosed_;
      minOpenPlayerLevel_ = other.minOpenPlayerLevel_;
      dayContentInfoList_ = other.dayContentInfoList_.Clone();
      contentCloseTime_ = other.contentCloseTime_;
      isEndQuestAccept_ = other.isEndQuestAccept_;
      playerDayIndex_ = other.playerDayIndex_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FindHilichurlDetailInfo Clone() {
      return new FindHilichurlDetailInfo(this);
    }

    /// <summary>Field number for the "day_index" field.</summary>
    public const int DayIndexFieldNumber = 8;
    private uint dayIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DayIndex {
      get { return dayIndex_; }
      set {
        dayIndex_ = value;
      }
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 12;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    /// <summary>Field number for the "min_open_player_level" field.</summary>
    public const int MinOpenPlayerLevelFieldNumber = 2;
    private uint minOpenPlayerLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MinOpenPlayerLevel {
      get { return minOpenPlayerLevel_; }
      set {
        minOpenPlayerLevel_ = value;
      }
    }

    /// <summary>Field number for the "day_content_info_list" field.</summary>
    public const int DayContentInfoListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.FindHilichurlDayContentInfo> _repeated_dayContentInfoList_codec
        = pb::FieldCodec.ForMessage(34, global::Weedwacker.Shared.Network.Proto.FindHilichurlDayContentInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.FindHilichurlDayContentInfo> dayContentInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.FindHilichurlDayContentInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.FindHilichurlDayContentInfo> DayContentInfoList {
      get { return dayContentInfoList_; }
    }

    /// <summary>Field number for the "content_close_time" field.</summary>
    public const int ContentCloseTimeFieldNumber = 7;
    private uint contentCloseTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ContentCloseTime {
      get { return contentCloseTime_; }
      set {
        contentCloseTime_ = value;
      }
    }

    /// <summary>Field number for the "is_end_quest_accept" field.</summary>
    public const int IsEndQuestAcceptFieldNumber = 5;
    private bool isEndQuestAccept_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsEndQuestAccept {
      get { return isEndQuestAccept_; }
      set {
        isEndQuestAccept_ = value;
      }
    }

    /// <summary>Field number for the "player_day_index" field.</summary>
    public const int PlayerDayIndexFieldNumber = 14;
    private uint playerDayIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayerDayIndex {
      get { return playerDayIndex_; }
      set {
        playerDayIndex_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FindHilichurlDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FindHilichurlDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DayIndex != other.DayIndex) return false;
      if (IsContentClosed != other.IsContentClosed) return false;
      if (MinOpenPlayerLevel != other.MinOpenPlayerLevel) return false;
      if(!dayContentInfoList_.Equals(other.dayContentInfoList_)) return false;
      if (ContentCloseTime != other.ContentCloseTime) return false;
      if (IsEndQuestAccept != other.IsEndQuestAccept) return false;
      if (PlayerDayIndex != other.PlayerDayIndex) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DayIndex != 0) hash ^= DayIndex.GetHashCode();
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
      if (MinOpenPlayerLevel != 0) hash ^= MinOpenPlayerLevel.GetHashCode();
      hash ^= dayContentInfoList_.GetHashCode();
      if (ContentCloseTime != 0) hash ^= ContentCloseTime.GetHashCode();
      if (IsEndQuestAccept != false) hash ^= IsEndQuestAccept.GetHashCode();
      if (PlayerDayIndex != 0) hash ^= PlayerDayIndex.GetHashCode();
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
      if (MinOpenPlayerLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MinOpenPlayerLevel);
      }
      dayContentInfoList_.WriteTo(output, _repeated_dayContentInfoList_codec);
      if (IsEndQuestAccept != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsEndQuestAccept);
      }
      if (ContentCloseTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ContentCloseTime);
      }
      if (DayIndex != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(DayIndex);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsContentClosed);
      }
      if (PlayerDayIndex != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PlayerDayIndex);
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
      if (MinOpenPlayerLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MinOpenPlayerLevel);
      }
      dayContentInfoList_.WriteTo(ref output, _repeated_dayContentInfoList_codec);
      if (IsEndQuestAccept != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsEndQuestAccept);
      }
      if (ContentCloseTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ContentCloseTime);
      }
      if (DayIndex != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(DayIndex);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsContentClosed);
      }
      if (PlayerDayIndex != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PlayerDayIndex);
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
      if (DayIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DayIndex);
      }
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      if (MinOpenPlayerLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MinOpenPlayerLevel);
      }
      size += dayContentInfoList_.CalculateSize(_repeated_dayContentInfoList_codec);
      if (ContentCloseTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ContentCloseTime);
      }
      if (IsEndQuestAccept != false) {
        size += 1 + 1;
      }
      if (PlayerDayIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayerDayIndex);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FindHilichurlDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.DayIndex != 0) {
        DayIndex = other.DayIndex;
      }
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
      }
      if (other.MinOpenPlayerLevel != 0) {
        MinOpenPlayerLevel = other.MinOpenPlayerLevel;
      }
      dayContentInfoList_.Add(other.dayContentInfoList_);
      if (other.ContentCloseTime != 0) {
        ContentCloseTime = other.ContentCloseTime;
      }
      if (other.IsEndQuestAccept != false) {
        IsEndQuestAccept = other.IsEndQuestAccept;
      }
      if (other.PlayerDayIndex != 0) {
        PlayerDayIndex = other.PlayerDayIndex;
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
            MinOpenPlayerLevel = input.ReadUInt32();
            break;
          }
          case 34: {
            dayContentInfoList_.AddEntriesFrom(input, _repeated_dayContentInfoList_codec);
            break;
          }
          case 40: {
            IsEndQuestAccept = input.ReadBool();
            break;
          }
          case 56: {
            ContentCloseTime = input.ReadUInt32();
            break;
          }
          case 64: {
            DayIndex = input.ReadUInt32();
            break;
          }
          case 96: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 112: {
            PlayerDayIndex = input.ReadUInt32();
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
            MinOpenPlayerLevel = input.ReadUInt32();
            break;
          }
          case 34: {
            dayContentInfoList_.AddEntriesFrom(ref input, _repeated_dayContentInfoList_codec);
            break;
          }
          case 40: {
            IsEndQuestAccept = input.ReadBool();
            break;
          }
          case 56: {
            ContentCloseTime = input.ReadUInt32();
            break;
          }
          case 64: {
            DayIndex = input.ReadUInt32();
            break;
          }
          case 96: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 112: {
            PlayerDayIndex = input.ReadUInt32();
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
