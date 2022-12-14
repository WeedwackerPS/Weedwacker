// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PersonalLineAllDataRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PersonalLineAllDataRsp.proto</summary>
  public static partial class PersonalLineAllDataRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PersonalLineAllDataRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PersonalLineAllDataRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxQZXJzb25hbExpbmVBbGxEYXRhUnNwLnByb3RvGhxMb2NrZWRQZXJzb25h",
            "bGxpbmVEYXRhLnByb3RvIvkBChZQZXJzb25hbExpbmVBbGxEYXRhUnNwEiUK",
            "HWN1cl9maW5pc2hlZF9kYWlseV90YXNrX2NvdW50GAwgASgNEjoKGWxvY2tl",
            "ZF9wZXJzb25hbF9saW5lX2xpc3QYCiADKAsyFy5Mb2NrZWRQZXJzb25hbGxp",
            "bmVEYXRhEg8KB3JldGNvZGUYAiABKAUSKgoiY2FuX2JlX3VubG9ja2VkX3Bl",
            "cnNvbmFsX2xpbmVfbGlzdBgBIAMoDRIiChpvbmdvaW5nX3BlcnNvbmFsX2xp",
            "bmVfbGlzdBgGIAMoDRIbChNsZWdlbmRhcnlfa2V5X2NvdW50GAUgASgNQiKq",
            "Ah9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.LockedPersonallineDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PersonalLineAllDataRsp), global::Weedwacker.Shared.Network.Proto.PersonalLineAllDataRsp.Parser, new[]{ "CurFinishedDailyTaskCount", "LockedPersonalLineList", "Retcode", "CanBeUnlockedPersonalLineList", "OngoingPersonalLineList", "LegendaryKeyCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 495;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class PersonalLineAllDataRsp : pb::IMessage<PersonalLineAllDataRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PersonalLineAllDataRsp> _parser = new pb::MessageParser<PersonalLineAllDataRsp>(() => new PersonalLineAllDataRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PersonalLineAllDataRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PersonalLineAllDataRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PersonalLineAllDataRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PersonalLineAllDataRsp(PersonalLineAllDataRsp other) : this() {
      curFinishedDailyTaskCount_ = other.curFinishedDailyTaskCount_;
      lockedPersonalLineList_ = other.lockedPersonalLineList_.Clone();
      retcode_ = other.retcode_;
      canBeUnlockedPersonalLineList_ = other.canBeUnlockedPersonalLineList_.Clone();
      ongoingPersonalLineList_ = other.ongoingPersonalLineList_.Clone();
      legendaryKeyCount_ = other.legendaryKeyCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PersonalLineAllDataRsp Clone() {
      return new PersonalLineAllDataRsp(this);
    }

    /// <summary>Field number for the "cur_finished_daily_task_count" field.</summary>
    public const int CurFinishedDailyTaskCountFieldNumber = 12;
    private uint curFinishedDailyTaskCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurFinishedDailyTaskCount {
      get { return curFinishedDailyTaskCount_; }
      set {
        curFinishedDailyTaskCount_ = value;
      }
    }

    /// <summary>Field number for the "locked_personal_line_list" field.</summary>
    public const int LockedPersonalLineListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.LockedPersonallineData> _repeated_lockedPersonalLineList_codec
        = pb::FieldCodec.ForMessage(82, global::Weedwacker.Shared.Network.Proto.LockedPersonallineData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.LockedPersonallineData> lockedPersonalLineList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.LockedPersonallineData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.LockedPersonallineData> LockedPersonalLineList {
      get { return lockedPersonalLineList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 2;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "can_be_unlocked_personal_line_list" field.</summary>
    public const int CanBeUnlockedPersonalLineListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_canBeUnlockedPersonalLineList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> canBeUnlockedPersonalLineList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CanBeUnlockedPersonalLineList {
      get { return canBeUnlockedPersonalLineList_; }
    }

    /// <summary>Field number for the "ongoing_personal_line_list" field.</summary>
    public const int OngoingPersonalLineListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_ongoingPersonalLineList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> ongoingPersonalLineList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> OngoingPersonalLineList {
      get { return ongoingPersonalLineList_; }
    }

    /// <summary>Field number for the "legendary_key_count" field.</summary>
    public const int LegendaryKeyCountFieldNumber = 5;
    private uint legendaryKeyCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LegendaryKeyCount {
      get { return legendaryKeyCount_; }
      set {
        legendaryKeyCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PersonalLineAllDataRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PersonalLineAllDataRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurFinishedDailyTaskCount != other.CurFinishedDailyTaskCount) return false;
      if(!lockedPersonalLineList_.Equals(other.lockedPersonalLineList_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!canBeUnlockedPersonalLineList_.Equals(other.canBeUnlockedPersonalLineList_)) return false;
      if(!ongoingPersonalLineList_.Equals(other.ongoingPersonalLineList_)) return false;
      if (LegendaryKeyCount != other.LegendaryKeyCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurFinishedDailyTaskCount != 0) hash ^= CurFinishedDailyTaskCount.GetHashCode();
      hash ^= lockedPersonalLineList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= canBeUnlockedPersonalLineList_.GetHashCode();
      hash ^= ongoingPersonalLineList_.GetHashCode();
      if (LegendaryKeyCount != 0) hash ^= LegendaryKeyCount.GetHashCode();
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
      canBeUnlockedPersonalLineList_.WriteTo(output, _repeated_canBeUnlockedPersonalLineList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Retcode);
      }
      if (LegendaryKeyCount != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LegendaryKeyCount);
      }
      ongoingPersonalLineList_.WriteTo(output, _repeated_ongoingPersonalLineList_codec);
      lockedPersonalLineList_.WriteTo(output, _repeated_lockedPersonalLineList_codec);
      if (CurFinishedDailyTaskCount != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CurFinishedDailyTaskCount);
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
      canBeUnlockedPersonalLineList_.WriteTo(ref output, _repeated_canBeUnlockedPersonalLineList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Retcode);
      }
      if (LegendaryKeyCount != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LegendaryKeyCount);
      }
      ongoingPersonalLineList_.WriteTo(ref output, _repeated_ongoingPersonalLineList_codec);
      lockedPersonalLineList_.WriteTo(ref output, _repeated_lockedPersonalLineList_codec);
      if (CurFinishedDailyTaskCount != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CurFinishedDailyTaskCount);
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
      if (CurFinishedDailyTaskCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurFinishedDailyTaskCount);
      }
      size += lockedPersonalLineList_.CalculateSize(_repeated_lockedPersonalLineList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += canBeUnlockedPersonalLineList_.CalculateSize(_repeated_canBeUnlockedPersonalLineList_codec);
      size += ongoingPersonalLineList_.CalculateSize(_repeated_ongoingPersonalLineList_codec);
      if (LegendaryKeyCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LegendaryKeyCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PersonalLineAllDataRsp other) {
      if (other == null) {
        return;
      }
      if (other.CurFinishedDailyTaskCount != 0) {
        CurFinishedDailyTaskCount = other.CurFinishedDailyTaskCount;
      }
      lockedPersonalLineList_.Add(other.lockedPersonalLineList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      canBeUnlockedPersonalLineList_.Add(other.canBeUnlockedPersonalLineList_);
      ongoingPersonalLineList_.Add(other.ongoingPersonalLineList_);
      if (other.LegendaryKeyCount != 0) {
        LegendaryKeyCount = other.LegendaryKeyCount;
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
          case 10:
          case 8: {
            canBeUnlockedPersonalLineList_.AddEntriesFrom(input, _repeated_canBeUnlockedPersonalLineList_codec);
            break;
          }
          case 16: {
            Retcode = input.ReadInt32();
            break;
          }
          case 40: {
            LegendaryKeyCount = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            ongoingPersonalLineList_.AddEntriesFrom(input, _repeated_ongoingPersonalLineList_codec);
            break;
          }
          case 82: {
            lockedPersonalLineList_.AddEntriesFrom(input, _repeated_lockedPersonalLineList_codec);
            break;
          }
          case 96: {
            CurFinishedDailyTaskCount = input.ReadUInt32();
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
          case 10:
          case 8: {
            canBeUnlockedPersonalLineList_.AddEntriesFrom(ref input, _repeated_canBeUnlockedPersonalLineList_codec);
            break;
          }
          case 16: {
            Retcode = input.ReadInt32();
            break;
          }
          case 40: {
            LegendaryKeyCount = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            ongoingPersonalLineList_.AddEntriesFrom(ref input, _repeated_ongoingPersonalLineList_codec);
            break;
          }
          case 82: {
            lockedPersonalLineList_.AddEntriesFrom(ref input, _repeated_lockedPersonalLineList_codec);
            break;
          }
          case 96: {
            CurFinishedDailyTaskCount = input.ReadUInt32();
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
