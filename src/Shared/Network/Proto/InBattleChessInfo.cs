// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InBattleChessInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from InBattleChessInfo.proto</summary>
  public static partial class InBattleChessInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for InBattleChessInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InBattleChessInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdJbkJhdHRsZUNoZXNzSW5mby5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90bxoTQ2hlc3NDYXJkSW5mby5wcm90bxoWQ2hlc3NNeXN0",
            "ZXJ5SW5mby5wcm90bxoVQ2hlc3NQbGF5ZXJJbmZvLnByb3RvIoUEChFJbkJh",
            "dHRsZUNoZXNzSW5mbxINCgVyb3VuZBgCIAEoDRJHCgxteXN0ZXJ5X2luZm8Y",
            "BiABKAsyMS5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLkNoZXNz",
            "TXlzdGVyeUluZm8SXgoPcGxheWVyX2luZm9fbWFwGA8gAygLMkUuV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5JbkJhdHRsZUNoZXNzSW5mby5Q",
            "bGF5ZXJJbmZvTWFwRW50cnkSHgoWbWF4X2VzY2FwYWJsZV9tb25zdGVycxgH",
            "IAEoDRIYChBlc2NhcGVkX21vbnN0ZXJzGAsgASgNEk8KF3NlbGVjdGVkX2Nh",
            "cmRfaW5mb19saXN0GAQgAygLMi4uV2VlZHdhY2tlci5TaGFyZWQuTmV0d29y",
            "ay5Qcm90by5DaGVzc0NhcmRJbmZvEhMKC3RvdGFsX3JvdW5kGA0gASgNEhUK",
            "DWxlZnRfbW9uc3RlcnMYBSABKA0SGQoRYmFuX2NhcmRfdGFnX2xpc3QYASAD",
            "KA0aZgoSUGxheWVySW5mb01hcEVudHJ5EgsKA2tleRgBIAEoDRI/CgV2YWx1",
            "ZRgCIAEoCzIwLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uQ2hl",
            "c3NQbGF5ZXJJbmZvOgI4AWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ChessCardInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ChessMysteryInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ChessPlayerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.InBattleChessInfo), global::Weedwacker.Shared.Network.Proto.InBattleChessInfo.Parser, new[]{ "Round", "MysteryInfo", "PlayerInfoMap", "MaxEscapableMonsters", "EscapedMonsters", "SelectedCardInfoList", "TotalRound", "LeftMonsters", "BanCardTagList" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InBattleChessInfo : pb::IMessage<InBattleChessInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InBattleChessInfo> _parser = new pb::MessageParser<InBattleChessInfo>(() => new InBattleChessInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InBattleChessInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.InBattleChessInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleChessInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleChessInfo(InBattleChessInfo other) : this() {
      round_ = other.round_;
      mysteryInfo_ = other.mysteryInfo_ != null ? other.mysteryInfo_.Clone() : null;
      playerInfoMap_ = other.playerInfoMap_.Clone();
      maxEscapableMonsters_ = other.maxEscapableMonsters_;
      escapedMonsters_ = other.escapedMonsters_;
      selectedCardInfoList_ = other.selectedCardInfoList_.Clone();
      totalRound_ = other.totalRound_;
      leftMonsters_ = other.leftMonsters_;
      banCardTagList_ = other.banCardTagList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleChessInfo Clone() {
      return new InBattleChessInfo(this);
    }

    /// <summary>Field number for the "round" field.</summary>
    public const int RoundFieldNumber = 2;
    private uint round_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Round {
      get { return round_; }
      set {
        round_ = value;
      }
    }

    /// <summary>Field number for the "mystery_info" field.</summary>
    public const int MysteryInfoFieldNumber = 6;
    private global::Weedwacker.Shared.Network.Proto.ChessMysteryInfo mysteryInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ChessMysteryInfo MysteryInfo {
      get { return mysteryInfo_; }
      set {
        mysteryInfo_ = value;
      }
    }

    /// <summary>Field number for the "player_info_map" field.</summary>
    public const int PlayerInfoMapFieldNumber = 15;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.ChessPlayerInfo>.Codec _map_playerInfoMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.ChessPlayerInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.ChessPlayerInfo.Parser), 122);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.ChessPlayerInfo> playerInfoMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.ChessPlayerInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.ChessPlayerInfo> PlayerInfoMap {
      get { return playerInfoMap_; }
    }

    /// <summary>Field number for the "max_escapable_monsters" field.</summary>
    public const int MaxEscapableMonstersFieldNumber = 7;
    private uint maxEscapableMonsters_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxEscapableMonsters {
      get { return maxEscapableMonsters_; }
      set {
        maxEscapableMonsters_ = value;
      }
    }

    /// <summary>Field number for the "escaped_monsters" field.</summary>
    public const int EscapedMonstersFieldNumber = 11;
    private uint escapedMonsters_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EscapedMonsters {
      get { return escapedMonsters_; }
      set {
        escapedMonsters_ = value;
      }
    }

    /// <summary>Field number for the "selected_card_info_list" field.</summary>
    public const int SelectedCardInfoListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ChessCardInfo> _repeated_selectedCardInfoList_codec
        = pb::FieldCodec.ForMessage(34, global::Weedwacker.Shared.Network.Proto.ChessCardInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ChessCardInfo> selectedCardInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ChessCardInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ChessCardInfo> SelectedCardInfoList {
      get { return selectedCardInfoList_; }
    }

    /// <summary>Field number for the "total_round" field.</summary>
    public const int TotalRoundFieldNumber = 13;
    private uint totalRound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalRound {
      get { return totalRound_; }
      set {
        totalRound_ = value;
      }
    }

    /// <summary>Field number for the "left_monsters" field.</summary>
    public const int LeftMonstersFieldNumber = 5;
    private uint leftMonsters_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LeftMonsters {
      get { return leftMonsters_; }
      set {
        leftMonsters_ = value;
      }
    }

    /// <summary>Field number for the "ban_card_tag_list" field.</summary>
    public const int BanCardTagListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_banCardTagList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> banCardTagList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BanCardTagList {
      get { return banCardTagList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as InBattleChessInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InBattleChessInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Round != other.Round) return false;
      if (!object.Equals(MysteryInfo, other.MysteryInfo)) return false;
      if (!PlayerInfoMap.Equals(other.PlayerInfoMap)) return false;
      if (MaxEscapableMonsters != other.MaxEscapableMonsters) return false;
      if (EscapedMonsters != other.EscapedMonsters) return false;
      if(!selectedCardInfoList_.Equals(other.selectedCardInfoList_)) return false;
      if (TotalRound != other.TotalRound) return false;
      if (LeftMonsters != other.LeftMonsters) return false;
      if(!banCardTagList_.Equals(other.banCardTagList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Round != 0) hash ^= Round.GetHashCode();
      if (mysteryInfo_ != null) hash ^= MysteryInfo.GetHashCode();
      hash ^= PlayerInfoMap.GetHashCode();
      if (MaxEscapableMonsters != 0) hash ^= MaxEscapableMonsters.GetHashCode();
      if (EscapedMonsters != 0) hash ^= EscapedMonsters.GetHashCode();
      hash ^= selectedCardInfoList_.GetHashCode();
      if (TotalRound != 0) hash ^= TotalRound.GetHashCode();
      if (LeftMonsters != 0) hash ^= LeftMonsters.GetHashCode();
      hash ^= banCardTagList_.GetHashCode();
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
      banCardTagList_.WriteTo(output, _repeated_banCardTagList_codec);
      if (Round != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Round);
      }
      selectedCardInfoList_.WriteTo(output, _repeated_selectedCardInfoList_codec);
      if (LeftMonsters != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LeftMonsters);
      }
      if (mysteryInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(MysteryInfo);
      }
      if (MaxEscapableMonsters != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MaxEscapableMonsters);
      }
      if (EscapedMonsters != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(EscapedMonsters);
      }
      if (TotalRound != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TotalRound);
      }
      playerInfoMap_.WriteTo(output, _map_playerInfoMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      banCardTagList_.WriteTo(ref output, _repeated_banCardTagList_codec);
      if (Round != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Round);
      }
      selectedCardInfoList_.WriteTo(ref output, _repeated_selectedCardInfoList_codec);
      if (LeftMonsters != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LeftMonsters);
      }
      if (mysteryInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(MysteryInfo);
      }
      if (MaxEscapableMonsters != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MaxEscapableMonsters);
      }
      if (EscapedMonsters != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(EscapedMonsters);
      }
      if (TotalRound != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TotalRound);
      }
      playerInfoMap_.WriteTo(ref output, _map_playerInfoMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Round != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Round);
      }
      if (mysteryInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MysteryInfo);
      }
      size += playerInfoMap_.CalculateSize(_map_playerInfoMap_codec);
      if (MaxEscapableMonsters != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxEscapableMonsters);
      }
      if (EscapedMonsters != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EscapedMonsters);
      }
      size += selectedCardInfoList_.CalculateSize(_repeated_selectedCardInfoList_codec);
      if (TotalRound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalRound);
      }
      if (LeftMonsters != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeftMonsters);
      }
      size += banCardTagList_.CalculateSize(_repeated_banCardTagList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(InBattleChessInfo other) {
      if (other == null) {
        return;
      }
      if (other.Round != 0) {
        Round = other.Round;
      }
      if (other.mysteryInfo_ != null) {
        if (mysteryInfo_ == null) {
          MysteryInfo = new global::Weedwacker.Shared.Network.Proto.ChessMysteryInfo();
        }
        MysteryInfo.MergeFrom(other.MysteryInfo);
      }
      playerInfoMap_.Add(other.playerInfoMap_);
      if (other.MaxEscapableMonsters != 0) {
        MaxEscapableMonsters = other.MaxEscapableMonsters;
      }
      if (other.EscapedMonsters != 0) {
        EscapedMonsters = other.EscapedMonsters;
      }
      selectedCardInfoList_.Add(other.selectedCardInfoList_);
      if (other.TotalRound != 0) {
        TotalRound = other.TotalRound;
      }
      if (other.LeftMonsters != 0) {
        LeftMonsters = other.LeftMonsters;
      }
      banCardTagList_.Add(other.banCardTagList_);
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
            banCardTagList_.AddEntriesFrom(input, _repeated_banCardTagList_codec);
            break;
          }
          case 16: {
            Round = input.ReadUInt32();
            break;
          }
          case 34: {
            selectedCardInfoList_.AddEntriesFrom(input, _repeated_selectedCardInfoList_codec);
            break;
          }
          case 40: {
            LeftMonsters = input.ReadUInt32();
            break;
          }
          case 50: {
            if (mysteryInfo_ == null) {
              MysteryInfo = new global::Weedwacker.Shared.Network.Proto.ChessMysteryInfo();
            }
            input.ReadMessage(MysteryInfo);
            break;
          }
          case 56: {
            MaxEscapableMonsters = input.ReadUInt32();
            break;
          }
          case 88: {
            EscapedMonsters = input.ReadUInt32();
            break;
          }
          case 104: {
            TotalRound = input.ReadUInt32();
            break;
          }
          case 122: {
            playerInfoMap_.AddEntriesFrom(input, _map_playerInfoMap_codec);
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
            banCardTagList_.AddEntriesFrom(ref input, _repeated_banCardTagList_codec);
            break;
          }
          case 16: {
            Round = input.ReadUInt32();
            break;
          }
          case 34: {
            selectedCardInfoList_.AddEntriesFrom(ref input, _repeated_selectedCardInfoList_codec);
            break;
          }
          case 40: {
            LeftMonsters = input.ReadUInt32();
            break;
          }
          case 50: {
            if (mysteryInfo_ == null) {
              MysteryInfo = new global::Weedwacker.Shared.Network.Proto.ChessMysteryInfo();
            }
            input.ReadMessage(MysteryInfo);
            break;
          }
          case 56: {
            MaxEscapableMonsters = input.ReadUInt32();
            break;
          }
          case 88: {
            EscapedMonsters = input.ReadUInt32();
            break;
          }
          case 104: {
            TotalRound = input.ReadUInt32();
            break;
          }
          case 122: {
            playerInfoMap_.AddEntriesFrom(ref input, _map_playerInfoMap_codec);
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
