// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageMarketFinishStorePlayRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from VintageMarketFinishStorePlayRsp.proto</summary>
  public static partial class VintageMarketFinishStorePlayRspReflection {

    #region Descriptor
    /// <summary>File descriptor for VintageMarketFinishStorePlayRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VintageMarketFinishStorePlayRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVWaW50YWdlTWFya2V0RmluaXNoU3RvcmVQbGF5UnNwLnByb3RvIp8DCh9W",
            "aW50YWdlTWFya2V0RmluaXNoU3RvcmVQbGF5UnNwEh4KFnRyaWdnZXJfZW52",
            "X2V2ZW50X2xpc3QYCCADKA0SEwoLc3RvcmVfcm91bmQYDCABKA0SHgoWdHJp",
            "Z2dlcl9ucGNfZXZlbnRfbGlzdBgKIAMoDRIbChNsb3dfYXR0cl9zdG9yZV9s",
            "aXN0GAsgAygNEhsKE3JvdW5kX2NvaW5fYl9pbmNvbWUYCSABKA0SGgoScm91",
            "bmRfZGVsdGFfY29pbl9jGAEgASgNEk4KEHN0b3JlX2luY29tZV9tYXAYAyAD",
            "KAsyNC5WaW50YWdlTWFya2V0RmluaXNoU3RvcmVQbGF5UnNwLlN0b3JlSW5j",
            "b21lTWFwRW50cnkSDwoHcmV0Y29kZRgHIAEoBRIaChJyb3VuZF90b3RhbF9p",
            "bmNvbWUYDiABKA0SHQoVZGlzcGxheV9yZXR1cm5fY29pbl9iGA8gASgNGjUK",
            "E1N0b3JlSW5jb21lTWFwRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIg",
            "ASgNOgI4AUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.VintageMarketFinishStorePlayRsp), global::Weedwacker.Shared.Network.Proto.VintageMarketFinishStorePlayRsp.Parser, new[]{ "TriggerEnvEventList", "StoreRound", "TriggerNpcEventList", "LowAttrStoreList", "RoundCoinBIncome", "RoundDeltaCoinC", "StoreIncomeMap", "Retcode", "RoundTotalIncome", "DisplayReturnCoinB" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 23462
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class VintageMarketFinishStorePlayRsp : pb::IMessage<VintageMarketFinishStorePlayRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VintageMarketFinishStorePlayRsp> _parser = new pb::MessageParser<VintageMarketFinishStorePlayRsp>(() => new VintageMarketFinishStorePlayRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VintageMarketFinishStorePlayRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.VintageMarketFinishStorePlayRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketFinishStorePlayRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketFinishStorePlayRsp(VintageMarketFinishStorePlayRsp other) : this() {
      triggerEnvEventList_ = other.triggerEnvEventList_.Clone();
      storeRound_ = other.storeRound_;
      triggerNpcEventList_ = other.triggerNpcEventList_.Clone();
      lowAttrStoreList_ = other.lowAttrStoreList_.Clone();
      roundCoinBIncome_ = other.roundCoinBIncome_;
      roundDeltaCoinC_ = other.roundDeltaCoinC_;
      storeIncomeMap_ = other.storeIncomeMap_.Clone();
      retcode_ = other.retcode_;
      roundTotalIncome_ = other.roundTotalIncome_;
      displayReturnCoinB_ = other.displayReturnCoinB_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketFinishStorePlayRsp Clone() {
      return new VintageMarketFinishStorePlayRsp(this);
    }

    /// <summary>Field number for the "trigger_env_event_list" field.</summary>
    public const int TriggerEnvEventListFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_triggerEnvEventList_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> triggerEnvEventList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TriggerEnvEventList {
      get { return triggerEnvEventList_; }
    }

    /// <summary>Field number for the "store_round" field.</summary>
    public const int StoreRoundFieldNumber = 12;
    private uint storeRound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StoreRound {
      get { return storeRound_; }
      set {
        storeRound_ = value;
      }
    }

    /// <summary>Field number for the "trigger_npc_event_list" field.</summary>
    public const int TriggerNpcEventListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_triggerNpcEventList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> triggerNpcEventList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TriggerNpcEventList {
      get { return triggerNpcEventList_; }
    }

    /// <summary>Field number for the "low_attr_store_list" field.</summary>
    public const int LowAttrStoreListFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_lowAttrStoreList_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> lowAttrStoreList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LowAttrStoreList {
      get { return lowAttrStoreList_; }
    }

    /// <summary>Field number for the "round_coin_b_income" field.</summary>
    public const int RoundCoinBIncomeFieldNumber = 9;
    private uint roundCoinBIncome_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RoundCoinBIncome {
      get { return roundCoinBIncome_; }
      set {
        roundCoinBIncome_ = value;
      }
    }

    /// <summary>Field number for the "round_delta_coin_c" field.</summary>
    public const int RoundDeltaCoinCFieldNumber = 1;
    private uint roundDeltaCoinC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RoundDeltaCoinC {
      get { return roundDeltaCoinC_; }
      set {
        roundDeltaCoinC_ = value;
      }
    }

    /// <summary>Field number for the "store_income_map" field.</summary>
    public const int StoreIncomeMapFieldNumber = 3;
    private static readonly pbc::MapField<uint, uint>.Codec _map_storeIncomeMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 26);
    private readonly pbc::MapField<uint, uint> storeIncomeMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> StoreIncomeMap {
      get { return storeIncomeMap_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "round_total_income" field.</summary>
    public const int RoundTotalIncomeFieldNumber = 14;
    private uint roundTotalIncome_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RoundTotalIncome {
      get { return roundTotalIncome_; }
      set {
        roundTotalIncome_ = value;
      }
    }

    /// <summary>Field number for the "display_return_coin_b" field.</summary>
    public const int DisplayReturnCoinBFieldNumber = 15;
    private uint displayReturnCoinB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DisplayReturnCoinB {
      get { return displayReturnCoinB_; }
      set {
        displayReturnCoinB_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VintageMarketFinishStorePlayRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VintageMarketFinishStorePlayRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!triggerEnvEventList_.Equals(other.triggerEnvEventList_)) return false;
      if (StoreRound != other.StoreRound) return false;
      if(!triggerNpcEventList_.Equals(other.triggerNpcEventList_)) return false;
      if(!lowAttrStoreList_.Equals(other.lowAttrStoreList_)) return false;
      if (RoundCoinBIncome != other.RoundCoinBIncome) return false;
      if (RoundDeltaCoinC != other.RoundDeltaCoinC) return false;
      if (!StoreIncomeMap.Equals(other.StoreIncomeMap)) return false;
      if (Retcode != other.Retcode) return false;
      if (RoundTotalIncome != other.RoundTotalIncome) return false;
      if (DisplayReturnCoinB != other.DisplayReturnCoinB) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= triggerEnvEventList_.GetHashCode();
      if (StoreRound != 0) hash ^= StoreRound.GetHashCode();
      hash ^= triggerNpcEventList_.GetHashCode();
      hash ^= lowAttrStoreList_.GetHashCode();
      if (RoundCoinBIncome != 0) hash ^= RoundCoinBIncome.GetHashCode();
      if (RoundDeltaCoinC != 0) hash ^= RoundDeltaCoinC.GetHashCode();
      hash ^= StoreIncomeMap.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (RoundTotalIncome != 0) hash ^= RoundTotalIncome.GetHashCode();
      if (DisplayReturnCoinB != 0) hash ^= DisplayReturnCoinB.GetHashCode();
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
      if (RoundDeltaCoinC != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(RoundDeltaCoinC);
      }
      storeIncomeMap_.WriteTo(output, _map_storeIncomeMap_codec);
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      triggerEnvEventList_.WriteTo(output, _repeated_triggerEnvEventList_codec);
      if (RoundCoinBIncome != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(RoundCoinBIncome);
      }
      triggerNpcEventList_.WriteTo(output, _repeated_triggerNpcEventList_codec);
      lowAttrStoreList_.WriteTo(output, _repeated_lowAttrStoreList_codec);
      if (StoreRound != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(StoreRound);
      }
      if (RoundTotalIncome != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(RoundTotalIncome);
      }
      if (DisplayReturnCoinB != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(DisplayReturnCoinB);
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
      if (RoundDeltaCoinC != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(RoundDeltaCoinC);
      }
      storeIncomeMap_.WriteTo(ref output, _map_storeIncomeMap_codec);
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      triggerEnvEventList_.WriteTo(ref output, _repeated_triggerEnvEventList_codec);
      if (RoundCoinBIncome != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(RoundCoinBIncome);
      }
      triggerNpcEventList_.WriteTo(ref output, _repeated_triggerNpcEventList_codec);
      lowAttrStoreList_.WriteTo(ref output, _repeated_lowAttrStoreList_codec);
      if (StoreRound != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(StoreRound);
      }
      if (RoundTotalIncome != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(RoundTotalIncome);
      }
      if (DisplayReturnCoinB != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(DisplayReturnCoinB);
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
      size += triggerEnvEventList_.CalculateSize(_repeated_triggerEnvEventList_codec);
      if (StoreRound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StoreRound);
      }
      size += triggerNpcEventList_.CalculateSize(_repeated_triggerNpcEventList_codec);
      size += lowAttrStoreList_.CalculateSize(_repeated_lowAttrStoreList_codec);
      if (RoundCoinBIncome != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoundCoinBIncome);
      }
      if (RoundDeltaCoinC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoundDeltaCoinC);
      }
      size += storeIncomeMap_.CalculateSize(_map_storeIncomeMap_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (RoundTotalIncome != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoundTotalIncome);
      }
      if (DisplayReturnCoinB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DisplayReturnCoinB);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VintageMarketFinishStorePlayRsp other) {
      if (other == null) {
        return;
      }
      triggerEnvEventList_.Add(other.triggerEnvEventList_);
      if (other.StoreRound != 0) {
        StoreRound = other.StoreRound;
      }
      triggerNpcEventList_.Add(other.triggerNpcEventList_);
      lowAttrStoreList_.Add(other.lowAttrStoreList_);
      if (other.RoundCoinBIncome != 0) {
        RoundCoinBIncome = other.RoundCoinBIncome;
      }
      if (other.RoundDeltaCoinC != 0) {
        RoundDeltaCoinC = other.RoundDeltaCoinC;
      }
      storeIncomeMap_.Add(other.storeIncomeMap_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.RoundTotalIncome != 0) {
        RoundTotalIncome = other.RoundTotalIncome;
      }
      if (other.DisplayReturnCoinB != 0) {
        DisplayReturnCoinB = other.DisplayReturnCoinB;
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
            RoundDeltaCoinC = input.ReadUInt32();
            break;
          }
          case 26: {
            storeIncomeMap_.AddEntriesFrom(input, _map_storeIncomeMap_codec);
            break;
          }
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 66:
          case 64: {
            triggerEnvEventList_.AddEntriesFrom(input, _repeated_triggerEnvEventList_codec);
            break;
          }
          case 72: {
            RoundCoinBIncome = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            triggerNpcEventList_.AddEntriesFrom(input, _repeated_triggerNpcEventList_codec);
            break;
          }
          case 90:
          case 88: {
            lowAttrStoreList_.AddEntriesFrom(input, _repeated_lowAttrStoreList_codec);
            break;
          }
          case 96: {
            StoreRound = input.ReadUInt32();
            break;
          }
          case 112: {
            RoundTotalIncome = input.ReadUInt32();
            break;
          }
          case 120: {
            DisplayReturnCoinB = input.ReadUInt32();
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
            RoundDeltaCoinC = input.ReadUInt32();
            break;
          }
          case 26: {
            storeIncomeMap_.AddEntriesFrom(ref input, _map_storeIncomeMap_codec);
            break;
          }
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 66:
          case 64: {
            triggerEnvEventList_.AddEntriesFrom(ref input, _repeated_triggerEnvEventList_codec);
            break;
          }
          case 72: {
            RoundCoinBIncome = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            triggerNpcEventList_.AddEntriesFrom(ref input, _repeated_triggerNpcEventList_codec);
            break;
          }
          case 90:
          case 88: {
            lowAttrStoreList_.AddEntriesFrom(ref input, _repeated_lowAttrStoreList_codec);
            break;
          }
          case 96: {
            StoreRound = input.ReadUInt32();
            break;
          }
          case 112: {
            RoundTotalIncome = input.ReadUInt32();
            break;
          }
          case 120: {
            DisplayReturnCoinB = input.ReadUInt32();
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
