// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TowerAllDataRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from TowerAllDataRsp.proto</summary>
  public static partial class TowerAllDataRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TowerAllDataRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TowerAllDataRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVUb3dlckFsbERhdGFSc3AucHJvdG8aGVRvd2VyQ3VyTGV2ZWxSZWNvcmQu",
            "cHJvdG8aFlRvd2VyRmxvb3JSZWNvcmQucHJvdG8aF1Rvd2VyTW9udGhseUJy",
            "aWVmLnByb3RvIr8GCg9Ub3dlckFsbERhdGFSc3ASGwoTVW5rMzMwMF9IQ0RG",
            "SkJITUhIRhgGIAEoDRIhChluZXh0X3NjaGVkdWxlX2NoYW5nZV90aW1lGAgg",
            "ASgNEhkKEWlzX2ZpcnN0X2ludGVyYWN0GAUgASgIEhkKEXRvd2VyX3NjaGVk",
            "dWxlX2lkGAEgASgNEhsKE1VuazMzMDBfSkJBQ0tFTkRIREcYCiABKA0SHAoT",
            "c2NoZWR1bGVfc3RhcnRfdGltZRjiBCABKA0SDwoHcmV0Y29kZRgLIAEoBRIb",
            "ChNVbmszMzAwX09IQ0hDSkdKSURLGAQgASgNEh4KFnZhbGlkX3Rvd2VyX3Jl",
            "Y29yZF9udW0YAiABKA0SOAobbGFzdF9zY2hlZHVsZV9tb250aGx5X2JyaWVm",
            "GN0JIAEoCzISLlRvd2VyTW9udGhseUJyaWVmEi4KEGN1cl9sZXZlbF9yZWNv",
            "cmQYDCABKAsyFC5Ub3dlckN1ckxldmVsUmVjb3JkEjIKF3Rvd2VyX2Zsb29y",
            "X3JlY29yZF9saXN0GA0gAygLMhEuVG93ZXJGbG9vclJlY29yZBIpCg1tb250",
            "aGx5X2JyaWVmGAkgASgLMhIuVG93ZXJNb250aGx5QnJpZWYSGwoTVW5rMzMw",
            "MF9MRUtPRENGUElOShgHIAEoDRJfCiJza2lwX2Zsb29yX2dyYW50ZWRfcmV3",
            "YXJkX2l0ZW1fbWFwGAMgAygLMjMuVG93ZXJBbGxEYXRhUnNwLlNraXBGbG9v",
            "ckdyYW50ZWRSZXdhcmRJdGVtTWFwRW50cnkSIgoaaXNfZmluaXNoZWRfZW50",
            "cmFuY2VfZmxvb3IYDyABKAgSQwoTZmxvb3Jfb3Blbl90aW1lX21hcBgOIAMo",
            "CzImLlRvd2VyQWxsRGF0YVJzcC5GbG9vck9wZW5UaW1lTWFwRW50cnkaRAoi",
            "U2tpcEZsb29yR3JhbnRlZFJld2FyZEl0ZW1NYXBFbnRyeRILCgNrZXkYASAB",
            "KA0SDQoFdmFsdWUYAiABKA06AjgBGjcKFUZsb29yT3BlblRpbWVNYXBFbnRy",
            "eRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06AjgBQiKqAh9XZWVkd2Fj",
            "a2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.TowerCurLevelRecordReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.TowerFloorRecordReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.TowerMonthlyBriefReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.TowerAllDataRsp), global::Weedwacker.Shared.Network.Proto.TowerAllDataRsp.Parser, new[]{ "Unk3300HCDFJBHMHHF", "NextScheduleChangeTime", "IsFirstInteract", "TowerScheduleId", "Unk3300JBACKENDHDG", "ScheduleStartTime", "Retcode", "Unk3300OHCHCJGJIDK", "ValidTowerRecordNum", "LastScheduleMonthlyBrief", "CurLevelRecord", "TowerFloorRecordList", "MonthlyBrief", "Unk3300LEKODCFPINJ", "SkipFloorGrantedRewardItemMap", "IsFinishedEntranceFloor", "FloorOpenTimeMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 2478;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class TowerAllDataRsp : pb::IMessage<TowerAllDataRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TowerAllDataRsp> _parser = new pb::MessageParser<TowerAllDataRsp>(() => new TowerAllDataRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TowerAllDataRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.TowerAllDataRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerAllDataRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerAllDataRsp(TowerAllDataRsp other) : this() {
      unk3300HCDFJBHMHHF_ = other.unk3300HCDFJBHMHHF_;
      nextScheduleChangeTime_ = other.nextScheduleChangeTime_;
      isFirstInteract_ = other.isFirstInteract_;
      towerScheduleId_ = other.towerScheduleId_;
      unk3300JBACKENDHDG_ = other.unk3300JBACKENDHDG_;
      scheduleStartTime_ = other.scheduleStartTime_;
      retcode_ = other.retcode_;
      unk3300OHCHCJGJIDK_ = other.unk3300OHCHCJGJIDK_;
      validTowerRecordNum_ = other.validTowerRecordNum_;
      lastScheduleMonthlyBrief_ = other.lastScheduleMonthlyBrief_ != null ? other.lastScheduleMonthlyBrief_.Clone() : null;
      curLevelRecord_ = other.curLevelRecord_ != null ? other.curLevelRecord_.Clone() : null;
      towerFloorRecordList_ = other.towerFloorRecordList_.Clone();
      monthlyBrief_ = other.monthlyBrief_ != null ? other.monthlyBrief_.Clone() : null;
      unk3300LEKODCFPINJ_ = other.unk3300LEKODCFPINJ_;
      skipFloorGrantedRewardItemMap_ = other.skipFloorGrantedRewardItemMap_.Clone();
      isFinishedEntranceFloor_ = other.isFinishedEntranceFloor_;
      floorOpenTimeMap_ = other.floorOpenTimeMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerAllDataRsp Clone() {
      return new TowerAllDataRsp(this);
    }

    /// <summary>Field number for the "Unk3300_HCDFJBHMHHF" field.</summary>
    public const int Unk3300HCDFJBHMHHFFieldNumber = 6;
    private uint unk3300HCDFJBHMHHF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300HCDFJBHMHHF {
      get { return unk3300HCDFJBHMHHF_; }
      set {
        unk3300HCDFJBHMHHF_ = value;
      }
    }

    /// <summary>Field number for the "next_schedule_change_time" field.</summary>
    public const int NextScheduleChangeTimeFieldNumber = 8;
    private uint nextScheduleChangeTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextScheduleChangeTime {
      get { return nextScheduleChangeTime_; }
      set {
        nextScheduleChangeTime_ = value;
      }
    }

    /// <summary>Field number for the "is_first_interact" field.</summary>
    public const int IsFirstInteractFieldNumber = 5;
    private bool isFirstInteract_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFirstInteract {
      get { return isFirstInteract_; }
      set {
        isFirstInteract_ = value;
      }
    }

    /// <summary>Field number for the "tower_schedule_id" field.</summary>
    public const int TowerScheduleIdFieldNumber = 1;
    private uint towerScheduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TowerScheduleId {
      get { return towerScheduleId_; }
      set {
        towerScheduleId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_JBACKENDHDG" field.</summary>
    public const int Unk3300JBACKENDHDGFieldNumber = 10;
    private uint unk3300JBACKENDHDG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300JBACKENDHDG {
      get { return unk3300JBACKENDHDG_; }
      set {
        unk3300JBACKENDHDG_ = value;
      }
    }

    /// <summary>Field number for the "schedule_start_time" field.</summary>
    public const int ScheduleStartTimeFieldNumber = 610;
    private uint scheduleStartTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScheduleStartTime {
      get { return scheduleStartTime_; }
      set {
        scheduleStartTime_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_OHCHCJGJIDK" field.</summary>
    public const int Unk3300OHCHCJGJIDKFieldNumber = 4;
    private uint unk3300OHCHCJGJIDK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300OHCHCJGJIDK {
      get { return unk3300OHCHCJGJIDK_; }
      set {
        unk3300OHCHCJGJIDK_ = value;
      }
    }

    /// <summary>Field number for the "valid_tower_record_num" field.</summary>
    public const int ValidTowerRecordNumFieldNumber = 2;
    private uint validTowerRecordNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ValidTowerRecordNum {
      get { return validTowerRecordNum_; }
      set {
        validTowerRecordNum_ = value;
      }
    }

    /// <summary>Field number for the "last_schedule_monthly_brief" field.</summary>
    public const int LastScheduleMonthlyBriefFieldNumber = 1245;
    private global::Weedwacker.Shared.Network.Proto.TowerMonthlyBrief lastScheduleMonthlyBrief_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.TowerMonthlyBrief LastScheduleMonthlyBrief {
      get { return lastScheduleMonthlyBrief_; }
      set {
        lastScheduleMonthlyBrief_ = value;
      }
    }

    /// <summary>Field number for the "cur_level_record" field.</summary>
    public const int CurLevelRecordFieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.TowerCurLevelRecord curLevelRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.TowerCurLevelRecord CurLevelRecord {
      get { return curLevelRecord_; }
      set {
        curLevelRecord_ = value;
      }
    }

    /// <summary>Field number for the "tower_floor_record_list" field.</summary>
    public const int TowerFloorRecordListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.TowerFloorRecord> _repeated_towerFloorRecordList_codec
        = pb::FieldCodec.ForMessage(106, global::Weedwacker.Shared.Network.Proto.TowerFloorRecord.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.TowerFloorRecord> towerFloorRecordList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.TowerFloorRecord>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.TowerFloorRecord> TowerFloorRecordList {
      get { return towerFloorRecordList_; }
    }

    /// <summary>Field number for the "monthly_brief" field.</summary>
    public const int MonthlyBriefFieldNumber = 9;
    private global::Weedwacker.Shared.Network.Proto.TowerMonthlyBrief monthlyBrief_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.TowerMonthlyBrief MonthlyBrief {
      get { return monthlyBrief_; }
      set {
        monthlyBrief_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_LEKODCFPINJ" field.</summary>
    public const int Unk3300LEKODCFPINJFieldNumber = 7;
    private uint unk3300LEKODCFPINJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300LEKODCFPINJ {
      get { return unk3300LEKODCFPINJ_; }
      set {
        unk3300LEKODCFPINJ_ = value;
      }
    }

    /// <summary>Field number for the "skip_floor_granted_reward_item_map" field.</summary>
    public const int SkipFloorGrantedRewardItemMapFieldNumber = 3;
    private static readonly pbc::MapField<uint, uint>.Codec _map_skipFloorGrantedRewardItemMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 26);
    private readonly pbc::MapField<uint, uint> skipFloorGrantedRewardItemMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> SkipFloorGrantedRewardItemMap {
      get { return skipFloorGrantedRewardItemMap_; }
    }

    /// <summary>Field number for the "is_finished_entrance_floor" field.</summary>
    public const int IsFinishedEntranceFloorFieldNumber = 15;
    private bool isFinishedEntranceFloor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinishedEntranceFloor {
      get { return isFinishedEntranceFloor_; }
      set {
        isFinishedEntranceFloor_ = value;
      }
    }

    /// <summary>Field number for the "floor_open_time_map" field.</summary>
    public const int FloorOpenTimeMapFieldNumber = 14;
    private static readonly pbc::MapField<uint, uint>.Codec _map_floorOpenTimeMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 114);
    private readonly pbc::MapField<uint, uint> floorOpenTimeMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> FloorOpenTimeMap {
      get { return floorOpenTimeMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TowerAllDataRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TowerAllDataRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300HCDFJBHMHHF != other.Unk3300HCDFJBHMHHF) return false;
      if (NextScheduleChangeTime != other.NextScheduleChangeTime) return false;
      if (IsFirstInteract != other.IsFirstInteract) return false;
      if (TowerScheduleId != other.TowerScheduleId) return false;
      if (Unk3300JBACKENDHDG != other.Unk3300JBACKENDHDG) return false;
      if (ScheduleStartTime != other.ScheduleStartTime) return false;
      if (Retcode != other.Retcode) return false;
      if (Unk3300OHCHCJGJIDK != other.Unk3300OHCHCJGJIDK) return false;
      if (ValidTowerRecordNum != other.ValidTowerRecordNum) return false;
      if (!object.Equals(LastScheduleMonthlyBrief, other.LastScheduleMonthlyBrief)) return false;
      if (!object.Equals(CurLevelRecord, other.CurLevelRecord)) return false;
      if(!towerFloorRecordList_.Equals(other.towerFloorRecordList_)) return false;
      if (!object.Equals(MonthlyBrief, other.MonthlyBrief)) return false;
      if (Unk3300LEKODCFPINJ != other.Unk3300LEKODCFPINJ) return false;
      if (!SkipFloorGrantedRewardItemMap.Equals(other.SkipFloorGrantedRewardItemMap)) return false;
      if (IsFinishedEntranceFloor != other.IsFinishedEntranceFloor) return false;
      if (!FloorOpenTimeMap.Equals(other.FloorOpenTimeMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300HCDFJBHMHHF != 0) hash ^= Unk3300HCDFJBHMHHF.GetHashCode();
      if (NextScheduleChangeTime != 0) hash ^= NextScheduleChangeTime.GetHashCode();
      if (IsFirstInteract != false) hash ^= IsFirstInteract.GetHashCode();
      if (TowerScheduleId != 0) hash ^= TowerScheduleId.GetHashCode();
      if (Unk3300JBACKENDHDG != 0) hash ^= Unk3300JBACKENDHDG.GetHashCode();
      if (ScheduleStartTime != 0) hash ^= ScheduleStartTime.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Unk3300OHCHCJGJIDK != 0) hash ^= Unk3300OHCHCJGJIDK.GetHashCode();
      if (ValidTowerRecordNum != 0) hash ^= ValidTowerRecordNum.GetHashCode();
      if (lastScheduleMonthlyBrief_ != null) hash ^= LastScheduleMonthlyBrief.GetHashCode();
      if (curLevelRecord_ != null) hash ^= CurLevelRecord.GetHashCode();
      hash ^= towerFloorRecordList_.GetHashCode();
      if (monthlyBrief_ != null) hash ^= MonthlyBrief.GetHashCode();
      if (Unk3300LEKODCFPINJ != 0) hash ^= Unk3300LEKODCFPINJ.GetHashCode();
      hash ^= SkipFloorGrantedRewardItemMap.GetHashCode();
      if (IsFinishedEntranceFloor != false) hash ^= IsFinishedEntranceFloor.GetHashCode();
      hash ^= FloorOpenTimeMap.GetHashCode();
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
      if (TowerScheduleId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TowerScheduleId);
      }
      if (ValidTowerRecordNum != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ValidTowerRecordNum);
      }
      skipFloorGrantedRewardItemMap_.WriteTo(output, _map_skipFloorGrantedRewardItemMap_codec);
      if (Unk3300OHCHCJGJIDK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300OHCHCJGJIDK);
      }
      if (IsFirstInteract != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsFirstInteract);
      }
      if (Unk3300HCDFJBHMHHF != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300HCDFJBHMHHF);
      }
      if (Unk3300LEKODCFPINJ != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300LEKODCFPINJ);
      }
      if (NextScheduleChangeTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NextScheduleChangeTime);
      }
      if (monthlyBrief_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(MonthlyBrief);
      }
      if (Unk3300JBACKENDHDG != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300JBACKENDHDG);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Retcode);
      }
      if (curLevelRecord_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(CurLevelRecord);
      }
      towerFloorRecordList_.WriteTo(output, _repeated_towerFloorRecordList_codec);
      floorOpenTimeMap_.WriteTo(output, _map_floorOpenTimeMap_codec);
      if (IsFinishedEntranceFloor != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsFinishedEntranceFloor);
      }
      if (ScheduleStartTime != 0) {
        output.WriteRawTag(144, 38);
        output.WriteUInt32(ScheduleStartTime);
      }
      if (lastScheduleMonthlyBrief_ != null) {
        output.WriteRawTag(234, 77);
        output.WriteMessage(LastScheduleMonthlyBrief);
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
      if (TowerScheduleId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TowerScheduleId);
      }
      if (ValidTowerRecordNum != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ValidTowerRecordNum);
      }
      skipFloorGrantedRewardItemMap_.WriteTo(ref output, _map_skipFloorGrantedRewardItemMap_codec);
      if (Unk3300OHCHCJGJIDK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300OHCHCJGJIDK);
      }
      if (IsFirstInteract != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsFirstInteract);
      }
      if (Unk3300HCDFJBHMHHF != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300HCDFJBHMHHF);
      }
      if (Unk3300LEKODCFPINJ != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300LEKODCFPINJ);
      }
      if (NextScheduleChangeTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NextScheduleChangeTime);
      }
      if (monthlyBrief_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(MonthlyBrief);
      }
      if (Unk3300JBACKENDHDG != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300JBACKENDHDG);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Retcode);
      }
      if (curLevelRecord_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(CurLevelRecord);
      }
      towerFloorRecordList_.WriteTo(ref output, _repeated_towerFloorRecordList_codec);
      floorOpenTimeMap_.WriteTo(ref output, _map_floorOpenTimeMap_codec);
      if (IsFinishedEntranceFloor != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsFinishedEntranceFloor);
      }
      if (ScheduleStartTime != 0) {
        output.WriteRawTag(144, 38);
        output.WriteUInt32(ScheduleStartTime);
      }
      if (lastScheduleMonthlyBrief_ != null) {
        output.WriteRawTag(234, 77);
        output.WriteMessage(LastScheduleMonthlyBrief);
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
      if (Unk3300HCDFJBHMHHF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300HCDFJBHMHHF);
      }
      if (NextScheduleChangeTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextScheduleChangeTime);
      }
      if (IsFirstInteract != false) {
        size += 1 + 1;
      }
      if (TowerScheduleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TowerScheduleId);
      }
      if (Unk3300JBACKENDHDG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300JBACKENDHDG);
      }
      if (ScheduleStartTime != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(ScheduleStartTime);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (Unk3300OHCHCJGJIDK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300OHCHCJGJIDK);
      }
      if (ValidTowerRecordNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ValidTowerRecordNum);
      }
      if (lastScheduleMonthlyBrief_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(LastScheduleMonthlyBrief);
      }
      if (curLevelRecord_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurLevelRecord);
      }
      size += towerFloorRecordList_.CalculateSize(_repeated_towerFloorRecordList_codec);
      if (monthlyBrief_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MonthlyBrief);
      }
      if (Unk3300LEKODCFPINJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300LEKODCFPINJ);
      }
      size += skipFloorGrantedRewardItemMap_.CalculateSize(_map_skipFloorGrantedRewardItemMap_codec);
      if (IsFinishedEntranceFloor != false) {
        size += 1 + 1;
      }
      size += floorOpenTimeMap_.CalculateSize(_map_floorOpenTimeMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TowerAllDataRsp other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300HCDFJBHMHHF != 0) {
        Unk3300HCDFJBHMHHF = other.Unk3300HCDFJBHMHHF;
      }
      if (other.NextScheduleChangeTime != 0) {
        NextScheduleChangeTime = other.NextScheduleChangeTime;
      }
      if (other.IsFirstInteract != false) {
        IsFirstInteract = other.IsFirstInteract;
      }
      if (other.TowerScheduleId != 0) {
        TowerScheduleId = other.TowerScheduleId;
      }
      if (other.Unk3300JBACKENDHDG != 0) {
        Unk3300JBACKENDHDG = other.Unk3300JBACKENDHDG;
      }
      if (other.ScheduleStartTime != 0) {
        ScheduleStartTime = other.ScheduleStartTime;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Unk3300OHCHCJGJIDK != 0) {
        Unk3300OHCHCJGJIDK = other.Unk3300OHCHCJGJIDK;
      }
      if (other.ValidTowerRecordNum != 0) {
        ValidTowerRecordNum = other.ValidTowerRecordNum;
      }
      if (other.lastScheduleMonthlyBrief_ != null) {
        if (lastScheduleMonthlyBrief_ == null) {
          LastScheduleMonthlyBrief = new global::Weedwacker.Shared.Network.Proto.TowerMonthlyBrief();
        }
        LastScheduleMonthlyBrief.MergeFrom(other.LastScheduleMonthlyBrief);
      }
      if (other.curLevelRecord_ != null) {
        if (curLevelRecord_ == null) {
          CurLevelRecord = new global::Weedwacker.Shared.Network.Proto.TowerCurLevelRecord();
        }
        CurLevelRecord.MergeFrom(other.CurLevelRecord);
      }
      towerFloorRecordList_.Add(other.towerFloorRecordList_);
      if (other.monthlyBrief_ != null) {
        if (monthlyBrief_ == null) {
          MonthlyBrief = new global::Weedwacker.Shared.Network.Proto.TowerMonthlyBrief();
        }
        MonthlyBrief.MergeFrom(other.MonthlyBrief);
      }
      if (other.Unk3300LEKODCFPINJ != 0) {
        Unk3300LEKODCFPINJ = other.Unk3300LEKODCFPINJ;
      }
      skipFloorGrantedRewardItemMap_.Add(other.skipFloorGrantedRewardItemMap_);
      if (other.IsFinishedEntranceFloor != false) {
        IsFinishedEntranceFloor = other.IsFinishedEntranceFloor;
      }
      floorOpenTimeMap_.Add(other.floorOpenTimeMap_);
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
            TowerScheduleId = input.ReadUInt32();
            break;
          }
          case 16: {
            ValidTowerRecordNum = input.ReadUInt32();
            break;
          }
          case 26: {
            skipFloorGrantedRewardItemMap_.AddEntriesFrom(input, _map_skipFloorGrantedRewardItemMap_codec);
            break;
          }
          case 32: {
            Unk3300OHCHCJGJIDK = input.ReadUInt32();
            break;
          }
          case 40: {
            IsFirstInteract = input.ReadBool();
            break;
          }
          case 48: {
            Unk3300HCDFJBHMHHF = input.ReadUInt32();
            break;
          }
          case 56: {
            Unk3300LEKODCFPINJ = input.ReadUInt32();
            break;
          }
          case 64: {
            NextScheduleChangeTime = input.ReadUInt32();
            break;
          }
          case 74: {
            if (monthlyBrief_ == null) {
              MonthlyBrief = new global::Weedwacker.Shared.Network.Proto.TowerMonthlyBrief();
            }
            input.ReadMessage(MonthlyBrief);
            break;
          }
          case 80: {
            Unk3300JBACKENDHDG = input.ReadUInt32();
            break;
          }
          case 88: {
            Retcode = input.ReadInt32();
            break;
          }
          case 98: {
            if (curLevelRecord_ == null) {
              CurLevelRecord = new global::Weedwacker.Shared.Network.Proto.TowerCurLevelRecord();
            }
            input.ReadMessage(CurLevelRecord);
            break;
          }
          case 106: {
            towerFloorRecordList_.AddEntriesFrom(input, _repeated_towerFloorRecordList_codec);
            break;
          }
          case 114: {
            floorOpenTimeMap_.AddEntriesFrom(input, _map_floorOpenTimeMap_codec);
            break;
          }
          case 120: {
            IsFinishedEntranceFloor = input.ReadBool();
            break;
          }
          case 4880: {
            ScheduleStartTime = input.ReadUInt32();
            break;
          }
          case 9962: {
            if (lastScheduleMonthlyBrief_ == null) {
              LastScheduleMonthlyBrief = new global::Weedwacker.Shared.Network.Proto.TowerMonthlyBrief();
            }
            input.ReadMessage(LastScheduleMonthlyBrief);
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
            TowerScheduleId = input.ReadUInt32();
            break;
          }
          case 16: {
            ValidTowerRecordNum = input.ReadUInt32();
            break;
          }
          case 26: {
            skipFloorGrantedRewardItemMap_.AddEntriesFrom(ref input, _map_skipFloorGrantedRewardItemMap_codec);
            break;
          }
          case 32: {
            Unk3300OHCHCJGJIDK = input.ReadUInt32();
            break;
          }
          case 40: {
            IsFirstInteract = input.ReadBool();
            break;
          }
          case 48: {
            Unk3300HCDFJBHMHHF = input.ReadUInt32();
            break;
          }
          case 56: {
            Unk3300LEKODCFPINJ = input.ReadUInt32();
            break;
          }
          case 64: {
            NextScheduleChangeTime = input.ReadUInt32();
            break;
          }
          case 74: {
            if (monthlyBrief_ == null) {
              MonthlyBrief = new global::Weedwacker.Shared.Network.Proto.TowerMonthlyBrief();
            }
            input.ReadMessage(MonthlyBrief);
            break;
          }
          case 80: {
            Unk3300JBACKENDHDG = input.ReadUInt32();
            break;
          }
          case 88: {
            Retcode = input.ReadInt32();
            break;
          }
          case 98: {
            if (curLevelRecord_ == null) {
              CurLevelRecord = new global::Weedwacker.Shared.Network.Proto.TowerCurLevelRecord();
            }
            input.ReadMessage(CurLevelRecord);
            break;
          }
          case 106: {
            towerFloorRecordList_.AddEntriesFrom(ref input, _repeated_towerFloorRecordList_codec);
            break;
          }
          case 114: {
            floorOpenTimeMap_.AddEntriesFrom(ref input, _map_floorOpenTimeMap_codec);
            break;
          }
          case 120: {
            IsFinishedEntranceFloor = input.ReadBool();
            break;
          }
          case 4880: {
            ScheduleStartTime = input.ReadUInt32();
            break;
          }
          case 9962: {
            if (lastScheduleMonthlyBrief_ == null) {
              LastScheduleMonthlyBrief = new global::Weedwacker.Shared.Network.Proto.TowerMonthlyBrief();
            }
            input.ReadMessage(LastScheduleMonthlyBrief);
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
