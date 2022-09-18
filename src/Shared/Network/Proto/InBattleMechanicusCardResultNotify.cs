// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InBattleMechanicusCardResultNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from InBattleMechanicusCardResultNotify.proto</summary>
  public static partial class InBattleMechanicusCardResultNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for InBattleMechanicusCardResultNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InBattleMechanicusCardResultNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihJbkJhdHRsZU1lY2hhbmljdXNDYXJkUmVzdWx0Tm90aWZ5LnByb3RvGiBJ",
            "bkJhdHRsZU1lY2hhbmljdXNDYXJkSW5mby5wcm90byLPAgoiSW5CYXR0bGVN",
            "ZWNoYW5pY3VzQ2FyZFJlc3VsdE5vdGlmeRIUCgx3YWl0X3NlY29uZHMYBiAB",
            "KA0SEAoIZ3JvdXBfaWQYAiABKA0SLgoJY2FyZF9saXN0GAkgAygLMhsuSW5C",
            "YXR0bGVNZWNoYW5pY3VzQ2FyZEluZm8SGgoSd2FpdF9iZWdpbl90aW1lX3Vz",
            "GAcgASgEEmIKGXBsYXllcl9jb25maXJtZWRfY2FyZF9tYXAYDCADKAsyPy5J",
            "bkJhdHRsZU1lY2hhbmljdXNDYXJkUmVzdWx0Tm90aWZ5LlBsYXllckNvbmZp",
            "cm1lZENhcmRNYXBFbnRyeRISCgpwbGF5X2luZGV4GAggASgNGj0KG1BsYXll",
            "ckNvbmZpcm1lZENhcmRNYXBFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUY",
            "AiABKA06AjgBQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.InBattleMechanicusCardInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.InBattleMechanicusCardResultNotify), global::Weedwacker.Shared.Network.Proto.InBattleMechanicusCardResultNotify.Parser, new[]{ "WaitSeconds", "GroupId", "CardList", "WaitBeginTimeUs", "PlayerConfirmedCardMap", "PlayIndex" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 5397
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class InBattleMechanicusCardResultNotify : pb::IMessage<InBattleMechanicusCardResultNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InBattleMechanicusCardResultNotify> _parser = new pb::MessageParser<InBattleMechanicusCardResultNotify>(() => new InBattleMechanicusCardResultNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InBattleMechanicusCardResultNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.InBattleMechanicusCardResultNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleMechanicusCardResultNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleMechanicusCardResultNotify(InBattleMechanicusCardResultNotify other) : this() {
      waitSeconds_ = other.waitSeconds_;
      groupId_ = other.groupId_;
      cardList_ = other.cardList_.Clone();
      waitBeginTimeUs_ = other.waitBeginTimeUs_;
      playerConfirmedCardMap_ = other.playerConfirmedCardMap_.Clone();
      playIndex_ = other.playIndex_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleMechanicusCardResultNotify Clone() {
      return new InBattleMechanicusCardResultNotify(this);
    }

    /// <summary>Field number for the "wait_seconds" field.</summary>
    public const int WaitSecondsFieldNumber = 6;
    private uint waitSeconds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WaitSeconds {
      get { return waitSeconds_; }
      set {
        waitSeconds_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 2;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "card_list" field.</summary>
    public const int CardListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.InBattleMechanicusCardInfo> _repeated_cardList_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Shared.Network.Proto.InBattleMechanicusCardInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.InBattleMechanicusCardInfo> cardList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.InBattleMechanicusCardInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.InBattleMechanicusCardInfo> CardList {
      get { return cardList_; }
    }

    /// <summary>Field number for the "wait_begin_time_us" field.</summary>
    public const int WaitBeginTimeUsFieldNumber = 7;
    private ulong waitBeginTimeUs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong WaitBeginTimeUs {
      get { return waitBeginTimeUs_; }
      set {
        waitBeginTimeUs_ = value;
      }
    }

    /// <summary>Field number for the "player_confirmed_card_map" field.</summary>
    public const int PlayerConfirmedCardMapFieldNumber = 12;
    private static readonly pbc::MapField<uint, uint>.Codec _map_playerConfirmedCardMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 98);
    private readonly pbc::MapField<uint, uint> playerConfirmedCardMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> PlayerConfirmedCardMap {
      get { return playerConfirmedCardMap_; }
    }

    /// <summary>Field number for the "play_index" field.</summary>
    public const int PlayIndexFieldNumber = 8;
    private uint playIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayIndex {
      get { return playIndex_; }
      set {
        playIndex_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as InBattleMechanicusCardResultNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InBattleMechanicusCardResultNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WaitSeconds != other.WaitSeconds) return false;
      if (GroupId != other.GroupId) return false;
      if(!cardList_.Equals(other.cardList_)) return false;
      if (WaitBeginTimeUs != other.WaitBeginTimeUs) return false;
      if (!PlayerConfirmedCardMap.Equals(other.PlayerConfirmedCardMap)) return false;
      if (PlayIndex != other.PlayIndex) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (WaitSeconds != 0) hash ^= WaitSeconds.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      hash ^= cardList_.GetHashCode();
      if (WaitBeginTimeUs != 0UL) hash ^= WaitBeginTimeUs.GetHashCode();
      hash ^= PlayerConfirmedCardMap.GetHashCode();
      if (PlayIndex != 0) hash ^= PlayIndex.GetHashCode();
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
      if (GroupId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GroupId);
      }
      if (WaitSeconds != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(WaitSeconds);
      }
      if (WaitBeginTimeUs != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(WaitBeginTimeUs);
      }
      if (PlayIndex != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PlayIndex);
      }
      cardList_.WriteTo(output, _repeated_cardList_codec);
      playerConfirmedCardMap_.WriteTo(output, _map_playerConfirmedCardMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (GroupId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GroupId);
      }
      if (WaitSeconds != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(WaitSeconds);
      }
      if (WaitBeginTimeUs != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(WaitBeginTimeUs);
      }
      if (PlayIndex != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PlayIndex);
      }
      cardList_.WriteTo(ref output, _repeated_cardList_codec);
      playerConfirmedCardMap_.WriteTo(ref output, _map_playerConfirmedCardMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (WaitSeconds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WaitSeconds);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      size += cardList_.CalculateSize(_repeated_cardList_codec);
      if (WaitBeginTimeUs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(WaitBeginTimeUs);
      }
      size += playerConfirmedCardMap_.CalculateSize(_map_playerConfirmedCardMap_codec);
      if (PlayIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayIndex);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(InBattleMechanicusCardResultNotify other) {
      if (other == null) {
        return;
      }
      if (other.WaitSeconds != 0) {
        WaitSeconds = other.WaitSeconds;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      cardList_.Add(other.cardList_);
      if (other.WaitBeginTimeUs != 0UL) {
        WaitBeginTimeUs = other.WaitBeginTimeUs;
      }
      playerConfirmedCardMap_.Add(other.playerConfirmedCardMap_);
      if (other.PlayIndex != 0) {
        PlayIndex = other.PlayIndex;
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
            GroupId = input.ReadUInt32();
            break;
          }
          case 48: {
            WaitSeconds = input.ReadUInt32();
            break;
          }
          case 56: {
            WaitBeginTimeUs = input.ReadUInt64();
            break;
          }
          case 64: {
            PlayIndex = input.ReadUInt32();
            break;
          }
          case 74: {
            cardList_.AddEntriesFrom(input, _repeated_cardList_codec);
            break;
          }
          case 98: {
            playerConfirmedCardMap_.AddEntriesFrom(input, _map_playerConfirmedCardMap_codec);
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
            GroupId = input.ReadUInt32();
            break;
          }
          case 48: {
            WaitSeconds = input.ReadUInt32();
            break;
          }
          case 56: {
            WaitBeginTimeUs = input.ReadUInt64();
            break;
          }
          case 64: {
            PlayIndex = input.ReadUInt32();
            break;
          }
          case 74: {
            cardList_.AddEntriesFrom(ref input, _repeated_cardList_codec);
            break;
          }
          case 98: {
            playerConfirmedCardMap_.AddEntriesFrom(ref input, _map_playerConfirmedCardMap_codec);
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