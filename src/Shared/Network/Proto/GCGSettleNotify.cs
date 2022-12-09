// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGSettleNotify.proto</summary>
  public static partial class GCGSettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGSettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGSettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVHQ0dTZXR0bGVOb3RpZnkucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5l",
            "dHdvcmsuUHJvdG8aEkdDR0VuZFJlYXNvbi5wcm90bxoZR0NHR2FtZUJ1c2lu",
            "ZXNzVHlwZS5wcm90bxoPSXRlbVBhcmFtLnByb3RvIukCCg9HQ0dTZXR0bGVO",
            "b3RpZnkSRAoQcmV3YXJkX2l0ZW1fbGlzdBgIIAMoCzIqLldlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG8uSXRlbVBhcmFtEiIKGmZpbmlzaGVkX2No",
            "YWxsZW5nZV9pZF9saXN0GAEgAygNEg8KB2dhbWVfaWQYAyABKA0SDgoGaXNf",
            "d2luGAIgASgIEksKDWJ1c2luZXNzX3R5cGUYBSABKA4yNC5XZWVkd2Fja2Vy",
            "LlNoYXJlZC5OZXR3b3JrLlByb3RvLkdDR0dhbWVCdXNpbmVzc1R5cGUSGQoR",
            "d2luX2NvbnRyb2xsZXJfaWQYCyABKA0SJAocZm9yYmlkX2ZpbmlzaF9jaGFs",
            "bGVuZ2VfbGlzdBgKIAMoDRI9CgZyZWFzb24YBCABKA4yLS5XZWVkd2Fja2Vy",
            "LlNoYXJlZC5OZXR3b3JrLlByb3RvLkdDR0VuZFJlYXNvbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGEndReasonReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGGameBusinessTypeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGSettleNotify), global::Weedwacker.Shared.Network.Proto.GCGSettleNotify.Parser, new[]{ "RewardItemList", "FinishedChallengeIdList", "GameId", "IsWin", "BusinessType", "WinControllerId", "ForbidFinishChallengeList", "Reason" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 7562;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class GCGSettleNotify : pb::IMessage<GCGSettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGSettleNotify> _parser = new pb::MessageParser<GCGSettleNotify>(() => new GCGSettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGSettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGSettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSettleNotify(GCGSettleNotify other) : this() {
      rewardItemList_ = other.rewardItemList_.Clone();
      finishedChallengeIdList_ = other.finishedChallengeIdList_.Clone();
      gameId_ = other.gameId_;
      isWin_ = other.isWin_;
      businessType_ = other.businessType_;
      winControllerId_ = other.winControllerId_;
      forbidFinishChallengeList_ = other.forbidFinishChallengeList_.Clone();
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSettleNotify Clone() {
      return new GCGSettleNotify(this);
    }

    /// <summary>Field number for the "reward_item_list" field.</summary>
    public const int RewardItemListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_rewardItemList_codec
        = pb::FieldCodec.ForMessage(66, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> rewardItemList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> RewardItemList {
      get { return rewardItemList_; }
    }

    /// <summary>Field number for the "finished_challenge_id_list" field.</summary>
    public const int FinishedChallengeIdListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_finishedChallengeIdList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> finishedChallengeIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FinishedChallengeIdList {
      get { return finishedChallengeIdList_; }
    }

    /// <summary>Field number for the "game_id" field.</summary>
    public const int GameIdFieldNumber = 3;
    private uint gameId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameId {
      get { return gameId_; }
      set {
        gameId_ = value;
      }
    }

    /// <summary>Field number for the "is_win" field.</summary>
    public const int IsWinFieldNumber = 2;
    private bool isWin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsWin {
      get { return isWin_; }
      set {
        isWin_ = value;
      }
    }

    /// <summary>Field number for the "business_type" field.</summary>
    public const int BusinessTypeFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType businessType_ = global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType BusinessType {
      get { return businessType_; }
      set {
        businessType_ = value;
      }
    }

    /// <summary>Field number for the "win_controller_id" field.</summary>
    public const int WinControllerIdFieldNumber = 11;
    private uint winControllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WinControllerId {
      get { return winControllerId_; }
      set {
        winControllerId_ = value;
      }
    }

    /// <summary>Field number for the "forbid_finish_challenge_list" field.</summary>
    public const int ForbidFinishChallengeListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_forbidFinishChallengeList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> forbidFinishChallengeList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ForbidFinishChallengeList {
      get { return forbidFinishChallengeList_; }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.GCGEndReason reason_ = global::Weedwacker.Shared.Network.Proto.GCGEndReason.Default;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGEndReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGSettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGSettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!rewardItemList_.Equals(other.rewardItemList_)) return false;
      if(!finishedChallengeIdList_.Equals(other.finishedChallengeIdList_)) return false;
      if (GameId != other.GameId) return false;
      if (IsWin != other.IsWin) return false;
      if (BusinessType != other.BusinessType) return false;
      if (WinControllerId != other.WinControllerId) return false;
      if(!forbidFinishChallengeList_.Equals(other.forbidFinishChallengeList_)) return false;
      if (Reason != other.Reason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= rewardItemList_.GetHashCode();
      hash ^= finishedChallengeIdList_.GetHashCode();
      if (GameId != 0) hash ^= GameId.GetHashCode();
      if (IsWin != false) hash ^= IsWin.GetHashCode();
      if (BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) hash ^= BusinessType.GetHashCode();
      if (WinControllerId != 0) hash ^= WinControllerId.GetHashCode();
      hash ^= forbidFinishChallengeList_.GetHashCode();
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGEndReason.Default) hash ^= Reason.GetHashCode();
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
      finishedChallengeIdList_.WriteTo(output, _repeated_finishedChallengeIdList_codec);
      if (IsWin != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsWin);
      }
      if (GameId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GameId);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGEndReason.Default) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Reason);
      }
      if (BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) BusinessType);
      }
      rewardItemList_.WriteTo(output, _repeated_rewardItemList_codec);
      forbidFinishChallengeList_.WriteTo(output, _repeated_forbidFinishChallengeList_codec);
      if (WinControllerId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WinControllerId);
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
      finishedChallengeIdList_.WriteTo(ref output, _repeated_finishedChallengeIdList_codec);
      if (IsWin != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsWin);
      }
      if (GameId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GameId);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGEndReason.Default) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Reason);
      }
      if (BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) BusinessType);
      }
      rewardItemList_.WriteTo(ref output, _repeated_rewardItemList_codec);
      forbidFinishChallengeList_.WriteTo(ref output, _repeated_forbidFinishChallengeList_codec);
      if (WinControllerId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WinControllerId);
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
      size += rewardItemList_.CalculateSize(_repeated_rewardItemList_codec);
      size += finishedChallengeIdList_.CalculateSize(_repeated_finishedChallengeIdList_codec);
      if (GameId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameId);
      }
      if (IsWin != false) {
        size += 1 + 1;
      }
      if (BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BusinessType);
      }
      if (WinControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WinControllerId);
      }
      size += forbidFinishChallengeList_.CalculateSize(_repeated_forbidFinishChallengeList_codec);
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGEndReason.Default) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGSettleNotify other) {
      if (other == null) {
        return;
      }
      rewardItemList_.Add(other.rewardItemList_);
      finishedChallengeIdList_.Add(other.finishedChallengeIdList_);
      if (other.GameId != 0) {
        GameId = other.GameId;
      }
      if (other.IsWin != false) {
        IsWin = other.IsWin;
      }
      if (other.BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) {
        BusinessType = other.BusinessType;
      }
      if (other.WinControllerId != 0) {
        WinControllerId = other.WinControllerId;
      }
      forbidFinishChallengeList_.Add(other.forbidFinishChallengeList_);
      if (other.Reason != global::Weedwacker.Shared.Network.Proto.GCGEndReason.Default) {
        Reason = other.Reason;
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
            finishedChallengeIdList_.AddEntriesFrom(input, _repeated_finishedChallengeIdList_codec);
            break;
          }
          case 16: {
            IsWin = input.ReadBool();
            break;
          }
          case 24: {
            GameId = input.ReadUInt32();
            break;
          }
          case 32: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GCGEndReason) input.ReadEnum();
            break;
          }
          case 40: {
            BusinessType = (global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType) input.ReadEnum();
            break;
          }
          case 66: {
            rewardItemList_.AddEntriesFrom(input, _repeated_rewardItemList_codec);
            break;
          }
          case 82:
          case 80: {
            forbidFinishChallengeList_.AddEntriesFrom(input, _repeated_forbidFinishChallengeList_codec);
            break;
          }
          case 88: {
            WinControllerId = input.ReadUInt32();
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
            finishedChallengeIdList_.AddEntriesFrom(ref input, _repeated_finishedChallengeIdList_codec);
            break;
          }
          case 16: {
            IsWin = input.ReadBool();
            break;
          }
          case 24: {
            GameId = input.ReadUInt32();
            break;
          }
          case 32: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GCGEndReason) input.ReadEnum();
            break;
          }
          case 40: {
            BusinessType = (global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType) input.ReadEnum();
            break;
          }
          case 66: {
            rewardItemList_.AddEntriesFrom(ref input, _repeated_rewardItemList_codec);
            break;
          }
          case 82:
          case 80: {
            forbidFinishChallengeList_.AddEntriesFrom(ref input, _repeated_forbidFinishChallengeList_codec);
            break;
          }
          case 88: {
            WinControllerId = input.ReadUInt32();
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
