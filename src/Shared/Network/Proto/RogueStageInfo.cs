// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueStageInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from RogueStageInfo.proto</summary>
  public static partial class RogueStageInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueStageInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueStageInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRSb2d1ZVN0YWdlSW5mby5wcm90bxodUm9ndWVTaG93QXZhdGFyVGVhbUlu",
            "Zm8ucHJvdG8aGVJvZ3VlbGlrZVJ1bmVSZWNvcmQucHJvdG8ioQMKDlJvZ3Vl",
            "U3RhZ2VJbmZvEh0KFHJldmlzZV9tb25zdGVyX2xldmVsGK4PIAEoDRIRCglp",
            "c19wYXNzZWQYCyABKAgSGwoTVW5rMzMwMF9HR0hNRktOSFBBShgCIAEoDRIt",
            "CgthdmF0YXJfdGVhbRgIIAEoCzIYLlJvZ3VlU2hvd0F2YXRhclRlYW1JbmZv",
            "EhcKD2lzX3Rha2VuX3Jld2FyZBgJIAEoCBITCgtpc19leHBsb3JlZBgOIAEo",
            "CBIuChBydW5lX3JlY29yZF9saXN0GAUgAygLMhQuUm9ndWVsaWtlUnVuZVJl",
            "Y29yZBIUCgxpc19pbl9jb21iYXQYBiABKAgSEgoKY29pbl9jX251bRgDIAEo",
            "DRIPCgdpc19vcGVuGA0gASgIEhAKCHN0YWdlX2lkGAcgASgNEhgKEG1heF9w",
            "YXNzZWRfbGV2ZWwYBCABKA0SEQoJY3VyX2xldmVsGAwgASgNEhsKE1VuazMz",
            "MDBfT0hIQkVQT0lDTEkYASABKA0SHAoTVW5rMzMwMF9IUEtGSExMQ0pCTRiT",
            "AiABKA1CIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.RogueShowAvatarTeamInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.RoguelikeRuneRecordReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.RogueStageInfo), global::Weedwacker.Shared.Network.Proto.RogueStageInfo.Parser, new[]{ "ReviseMonsterLevel", "IsPassed", "Unk3300GGHMFKNHPAJ", "AvatarTeam", "IsTakenReward", "IsExplored", "RuneRecordList", "IsInCombat", "CoinCNum", "IsOpen", "StageId", "MaxPassedLevel", "CurLevel", "Unk3300OHHBEPOICLI", "Unk3300HPKFHLLCJBM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RogueStageInfo : pb::IMessage<RogueStageInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueStageInfo> _parser = new pb::MessageParser<RogueStageInfo>(() => new RogueStageInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueStageInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.RogueStageInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueStageInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueStageInfo(RogueStageInfo other) : this() {
      reviseMonsterLevel_ = other.reviseMonsterLevel_;
      isPassed_ = other.isPassed_;
      unk3300GGHMFKNHPAJ_ = other.unk3300GGHMFKNHPAJ_;
      avatarTeam_ = other.avatarTeam_ != null ? other.avatarTeam_.Clone() : null;
      isTakenReward_ = other.isTakenReward_;
      isExplored_ = other.isExplored_;
      runeRecordList_ = other.runeRecordList_.Clone();
      isInCombat_ = other.isInCombat_;
      coinCNum_ = other.coinCNum_;
      isOpen_ = other.isOpen_;
      stageId_ = other.stageId_;
      maxPassedLevel_ = other.maxPassedLevel_;
      curLevel_ = other.curLevel_;
      unk3300OHHBEPOICLI_ = other.unk3300OHHBEPOICLI_;
      unk3300HPKFHLLCJBM_ = other.unk3300HPKFHLLCJBM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueStageInfo Clone() {
      return new RogueStageInfo(this);
    }

    /// <summary>Field number for the "revise_monster_level" field.</summary>
    public const int ReviseMonsterLevelFieldNumber = 1966;
    private uint reviseMonsterLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ReviseMonsterLevel {
      get { return reviseMonsterLevel_; }
      set {
        reviseMonsterLevel_ = value;
      }
    }

    /// <summary>Field number for the "is_passed" field.</summary>
    public const int IsPassedFieldNumber = 11;
    private bool isPassed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPassed {
      get { return isPassed_; }
      set {
        isPassed_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_GGHMFKNHPAJ" field.</summary>
    public const int Unk3300GGHMFKNHPAJFieldNumber = 2;
    private uint unk3300GGHMFKNHPAJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300GGHMFKNHPAJ {
      get { return unk3300GGHMFKNHPAJ_; }
      set {
        unk3300GGHMFKNHPAJ_ = value;
      }
    }

    /// <summary>Field number for the "avatar_team" field.</summary>
    public const int AvatarTeamFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.RogueShowAvatarTeamInfo avatarTeam_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.RogueShowAvatarTeamInfo AvatarTeam {
      get { return avatarTeam_; }
      set {
        avatarTeam_ = value;
      }
    }

    /// <summary>Field number for the "is_taken_reward" field.</summary>
    public const int IsTakenRewardFieldNumber = 9;
    private bool isTakenReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTakenReward {
      get { return isTakenReward_; }
      set {
        isTakenReward_ = value;
      }
    }

    /// <summary>Field number for the "is_explored" field.</summary>
    public const int IsExploredFieldNumber = 14;
    private bool isExplored_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsExplored {
      get { return isExplored_; }
      set {
        isExplored_ = value;
      }
    }

    /// <summary>Field number for the "rune_record_list" field.</summary>
    public const int RuneRecordListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.RoguelikeRuneRecord> _repeated_runeRecordList_codec
        = pb::FieldCodec.ForMessage(42, global::Weedwacker.Shared.Network.Proto.RoguelikeRuneRecord.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RoguelikeRuneRecord> runeRecordList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RoguelikeRuneRecord>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RoguelikeRuneRecord> RuneRecordList {
      get { return runeRecordList_; }
    }

    /// <summary>Field number for the "is_in_combat" field.</summary>
    public const int IsInCombatFieldNumber = 6;
    private bool isInCombat_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsInCombat {
      get { return isInCombat_; }
      set {
        isInCombat_ = value;
      }
    }

    /// <summary>Field number for the "coin_c_num" field.</summary>
    public const int CoinCNumFieldNumber = 3;
    private uint coinCNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CoinCNum {
      get { return coinCNum_; }
      set {
        coinCNum_ = value;
      }
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 13;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 7;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "max_passed_level" field.</summary>
    public const int MaxPassedLevelFieldNumber = 4;
    private uint maxPassedLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxPassedLevel {
      get { return maxPassedLevel_; }
      set {
        maxPassedLevel_ = value;
      }
    }

    /// <summary>Field number for the "cur_level" field.</summary>
    public const int CurLevelFieldNumber = 12;
    private uint curLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurLevel {
      get { return curLevel_; }
      set {
        curLevel_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_OHHBEPOICLI" field.</summary>
    public const int Unk3300OHHBEPOICLIFieldNumber = 1;
    private uint unk3300OHHBEPOICLI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300OHHBEPOICLI {
      get { return unk3300OHHBEPOICLI_; }
      set {
        unk3300OHHBEPOICLI_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_HPKFHLLCJBM" field.</summary>
    public const int Unk3300HPKFHLLCJBMFieldNumber = 275;
    private uint unk3300HPKFHLLCJBM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300HPKFHLLCJBM {
      get { return unk3300HPKFHLLCJBM_; }
      set {
        unk3300HPKFHLLCJBM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueStageInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueStageInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ReviseMonsterLevel != other.ReviseMonsterLevel) return false;
      if (IsPassed != other.IsPassed) return false;
      if (Unk3300GGHMFKNHPAJ != other.Unk3300GGHMFKNHPAJ) return false;
      if (!object.Equals(AvatarTeam, other.AvatarTeam)) return false;
      if (IsTakenReward != other.IsTakenReward) return false;
      if (IsExplored != other.IsExplored) return false;
      if(!runeRecordList_.Equals(other.runeRecordList_)) return false;
      if (IsInCombat != other.IsInCombat) return false;
      if (CoinCNum != other.CoinCNum) return false;
      if (IsOpen != other.IsOpen) return false;
      if (StageId != other.StageId) return false;
      if (MaxPassedLevel != other.MaxPassedLevel) return false;
      if (CurLevel != other.CurLevel) return false;
      if (Unk3300OHHBEPOICLI != other.Unk3300OHHBEPOICLI) return false;
      if (Unk3300HPKFHLLCJBM != other.Unk3300HPKFHLLCJBM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ReviseMonsterLevel != 0) hash ^= ReviseMonsterLevel.GetHashCode();
      if (IsPassed != false) hash ^= IsPassed.GetHashCode();
      if (Unk3300GGHMFKNHPAJ != 0) hash ^= Unk3300GGHMFKNHPAJ.GetHashCode();
      if (avatarTeam_ != null) hash ^= AvatarTeam.GetHashCode();
      if (IsTakenReward != false) hash ^= IsTakenReward.GetHashCode();
      if (IsExplored != false) hash ^= IsExplored.GetHashCode();
      hash ^= runeRecordList_.GetHashCode();
      if (IsInCombat != false) hash ^= IsInCombat.GetHashCode();
      if (CoinCNum != 0) hash ^= CoinCNum.GetHashCode();
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (MaxPassedLevel != 0) hash ^= MaxPassedLevel.GetHashCode();
      if (CurLevel != 0) hash ^= CurLevel.GetHashCode();
      if (Unk3300OHHBEPOICLI != 0) hash ^= Unk3300OHHBEPOICLI.GetHashCode();
      if (Unk3300HPKFHLLCJBM != 0) hash ^= Unk3300HPKFHLLCJBM.GetHashCode();
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
      if (Unk3300OHHBEPOICLI != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300OHHBEPOICLI);
      }
      if (Unk3300GGHMFKNHPAJ != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300GGHMFKNHPAJ);
      }
      if (CoinCNum != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CoinCNum);
      }
      if (MaxPassedLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MaxPassedLevel);
      }
      runeRecordList_.WriteTo(output, _repeated_runeRecordList_codec);
      if (IsInCombat != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsInCombat);
      }
      if (StageId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(StageId);
      }
      if (avatarTeam_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(AvatarTeam);
      }
      if (IsTakenReward != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsTakenReward);
      }
      if (IsPassed != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsPassed);
      }
      if (CurLevel != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CurLevel);
      }
      if (IsOpen != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsOpen);
      }
      if (IsExplored != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsExplored);
      }
      if (Unk3300HPKFHLLCJBM != 0) {
        output.WriteRawTag(152, 17);
        output.WriteUInt32(Unk3300HPKFHLLCJBM);
      }
      if (ReviseMonsterLevel != 0) {
        output.WriteRawTag(240, 122);
        output.WriteUInt32(ReviseMonsterLevel);
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
      if (Unk3300OHHBEPOICLI != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300OHHBEPOICLI);
      }
      if (Unk3300GGHMFKNHPAJ != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300GGHMFKNHPAJ);
      }
      if (CoinCNum != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CoinCNum);
      }
      if (MaxPassedLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MaxPassedLevel);
      }
      runeRecordList_.WriteTo(ref output, _repeated_runeRecordList_codec);
      if (IsInCombat != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsInCombat);
      }
      if (StageId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(StageId);
      }
      if (avatarTeam_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(AvatarTeam);
      }
      if (IsTakenReward != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsTakenReward);
      }
      if (IsPassed != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsPassed);
      }
      if (CurLevel != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CurLevel);
      }
      if (IsOpen != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsOpen);
      }
      if (IsExplored != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsExplored);
      }
      if (Unk3300HPKFHLLCJBM != 0) {
        output.WriteRawTag(152, 17);
        output.WriteUInt32(Unk3300HPKFHLLCJBM);
      }
      if (ReviseMonsterLevel != 0) {
        output.WriteRawTag(240, 122);
        output.WriteUInt32(ReviseMonsterLevel);
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
      if (ReviseMonsterLevel != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(ReviseMonsterLevel);
      }
      if (IsPassed != false) {
        size += 1 + 1;
      }
      if (Unk3300GGHMFKNHPAJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300GGHMFKNHPAJ);
      }
      if (avatarTeam_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AvatarTeam);
      }
      if (IsTakenReward != false) {
        size += 1 + 1;
      }
      if (IsExplored != false) {
        size += 1 + 1;
      }
      size += runeRecordList_.CalculateSize(_repeated_runeRecordList_codec);
      if (IsInCombat != false) {
        size += 1 + 1;
      }
      if (CoinCNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoinCNum);
      }
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (MaxPassedLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxPassedLevel);
      }
      if (CurLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurLevel);
      }
      if (Unk3300OHHBEPOICLI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300OHHBEPOICLI);
      }
      if (Unk3300HPKFHLLCJBM != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300HPKFHLLCJBM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueStageInfo other) {
      if (other == null) {
        return;
      }
      if (other.ReviseMonsterLevel != 0) {
        ReviseMonsterLevel = other.ReviseMonsterLevel;
      }
      if (other.IsPassed != false) {
        IsPassed = other.IsPassed;
      }
      if (other.Unk3300GGHMFKNHPAJ != 0) {
        Unk3300GGHMFKNHPAJ = other.Unk3300GGHMFKNHPAJ;
      }
      if (other.avatarTeam_ != null) {
        if (avatarTeam_ == null) {
          AvatarTeam = new global::Weedwacker.Shared.Network.Proto.RogueShowAvatarTeamInfo();
        }
        AvatarTeam.MergeFrom(other.AvatarTeam);
      }
      if (other.IsTakenReward != false) {
        IsTakenReward = other.IsTakenReward;
      }
      if (other.IsExplored != false) {
        IsExplored = other.IsExplored;
      }
      runeRecordList_.Add(other.runeRecordList_);
      if (other.IsInCombat != false) {
        IsInCombat = other.IsInCombat;
      }
      if (other.CoinCNum != 0) {
        CoinCNum = other.CoinCNum;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.MaxPassedLevel != 0) {
        MaxPassedLevel = other.MaxPassedLevel;
      }
      if (other.CurLevel != 0) {
        CurLevel = other.CurLevel;
      }
      if (other.Unk3300OHHBEPOICLI != 0) {
        Unk3300OHHBEPOICLI = other.Unk3300OHHBEPOICLI;
      }
      if (other.Unk3300HPKFHLLCJBM != 0) {
        Unk3300HPKFHLLCJBM = other.Unk3300HPKFHLLCJBM;
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
            Unk3300OHHBEPOICLI = input.ReadUInt32();
            break;
          }
          case 16: {
            Unk3300GGHMFKNHPAJ = input.ReadUInt32();
            break;
          }
          case 24: {
            CoinCNum = input.ReadUInt32();
            break;
          }
          case 32: {
            MaxPassedLevel = input.ReadUInt32();
            break;
          }
          case 42: {
            runeRecordList_.AddEntriesFrom(input, _repeated_runeRecordList_codec);
            break;
          }
          case 48: {
            IsInCombat = input.ReadBool();
            break;
          }
          case 56: {
            StageId = input.ReadUInt32();
            break;
          }
          case 66: {
            if (avatarTeam_ == null) {
              AvatarTeam = new global::Weedwacker.Shared.Network.Proto.RogueShowAvatarTeamInfo();
            }
            input.ReadMessage(AvatarTeam);
            break;
          }
          case 72: {
            IsTakenReward = input.ReadBool();
            break;
          }
          case 88: {
            IsPassed = input.ReadBool();
            break;
          }
          case 96: {
            CurLevel = input.ReadUInt32();
            break;
          }
          case 104: {
            IsOpen = input.ReadBool();
            break;
          }
          case 112: {
            IsExplored = input.ReadBool();
            break;
          }
          case 2200: {
            Unk3300HPKFHLLCJBM = input.ReadUInt32();
            break;
          }
          case 15728: {
            ReviseMonsterLevel = input.ReadUInt32();
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
            Unk3300OHHBEPOICLI = input.ReadUInt32();
            break;
          }
          case 16: {
            Unk3300GGHMFKNHPAJ = input.ReadUInt32();
            break;
          }
          case 24: {
            CoinCNum = input.ReadUInt32();
            break;
          }
          case 32: {
            MaxPassedLevel = input.ReadUInt32();
            break;
          }
          case 42: {
            runeRecordList_.AddEntriesFrom(ref input, _repeated_runeRecordList_codec);
            break;
          }
          case 48: {
            IsInCombat = input.ReadBool();
            break;
          }
          case 56: {
            StageId = input.ReadUInt32();
            break;
          }
          case 66: {
            if (avatarTeam_ == null) {
              AvatarTeam = new global::Weedwacker.Shared.Network.Proto.RogueShowAvatarTeamInfo();
            }
            input.ReadMessage(AvatarTeam);
            break;
          }
          case 72: {
            IsTakenReward = input.ReadBool();
            break;
          }
          case 88: {
            IsPassed = input.ReadBool();
            break;
          }
          case 96: {
            CurLevel = input.ReadUInt32();
            break;
          }
          case 104: {
            IsOpen = input.ReadBool();
            break;
          }
          case 112: {
            IsExplored = input.ReadBool();
            break;
          }
          case 2200: {
            Unk3300HPKFHLLCJBM = input.ReadUInt32();
            break;
          }
          case 15728: {
            ReviseMonsterLevel = input.ReadUInt32();
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
