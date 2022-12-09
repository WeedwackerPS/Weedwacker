// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TowerLevelEndNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from TowerLevelEndNotify.proto</summary>
  public static partial class TowerLevelEndNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for TowerLevelEndNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TowerLevelEndNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlUb3dlckxldmVsRW5kTm90aWZ5LnByb3RvEh9XZWVkd2Fja2VyLlNoYXJl",
            "ZC5OZXR3b3JrLlByb3RvGg9JdGVtUGFyYW0ucHJvdG8i2wIKE1Rvd2VyTGV2",
            "ZWxFbmROb3RpZnkSFgoOY29udGludWVfc3RhdGUYAiABKA0SHwoXZmluaXNo",
            "ZWRfc3Rhcl9jb25kX2xpc3QYBiADKA0SFQoNbmV4dF9mbG9vcl9pZBgEIAEo",
            "DRISCgppc19zdWNjZXNzGA8gASgIEkQKEHJld2FyZF9pdGVtX2xpc3QYCiAD",
            "KAsyKi5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLkl0ZW1QYXJh",
            "bSKZAQoRQ29udGludWVTdGF0ZVR5cGUSKAokQ09OVElOVUVfU1RBVEVfVFlQ",
            "RV9DQU5fTk9UX0NPTlRJTlVFEAASLAooQ09OVElOVUVfU1RBVEVfVFlQRV9D",
            "QU5fRU5URVJfTkVYVF9MRVZFTBABEiwKKENPTlRJTlVFX1NUQVRFX1RZUEVf",
            "Q0FOX0VOVEVSX05FWFRfRkxPT1IQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.TowerLevelEndNotify), global::Weedwacker.Shared.Network.Proto.TowerLevelEndNotify.Parser, new[]{ "ContinueState", "FinishedStarCondList", "NextFloorId", "IsSuccess", "RewardItemList" }, null, new[]{ typeof(global::Weedwacker.Shared.Network.Proto.TowerLevelEndNotify.Types.ContinueStateType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 2433;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class TowerLevelEndNotify : pb::IMessage<TowerLevelEndNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TowerLevelEndNotify> _parser = new pb::MessageParser<TowerLevelEndNotify>(() => new TowerLevelEndNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TowerLevelEndNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.TowerLevelEndNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerLevelEndNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerLevelEndNotify(TowerLevelEndNotify other) : this() {
      continueState_ = other.continueState_;
      finishedStarCondList_ = other.finishedStarCondList_.Clone();
      nextFloorId_ = other.nextFloorId_;
      isSuccess_ = other.isSuccess_;
      rewardItemList_ = other.rewardItemList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerLevelEndNotify Clone() {
      return new TowerLevelEndNotify(this);
    }

    /// <summary>Field number for the "continue_state" field.</summary>
    public const int ContinueStateFieldNumber = 2;
    private uint continueState_;
    /// <summary>
    /// Unk3300_BOPIBKGAMID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ContinueState {
      get { return continueState_; }
      set {
        continueState_ = value;
      }
    }

    /// <summary>Field number for the "finished_star_cond_list" field.</summary>
    public const int FinishedStarCondListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_finishedStarCondList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> finishedStarCondList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FinishedStarCondList {
      get { return finishedStarCondList_; }
    }

    /// <summary>Field number for the "next_floor_id" field.</summary>
    public const int NextFloorIdFieldNumber = 4;
    private uint nextFloorId_;
    /// <summary>
    /// Unk3300_AHBGPMBHPMO
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextFloorId {
      get { return nextFloorId_; }
      set {
        nextFloorId_ = value;
      }
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 15;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "reward_item_list" field.</summary>
    public const int RewardItemListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_rewardItemList_codec
        = pb::FieldCodec.ForMessage(82, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> rewardItemList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> RewardItemList {
      get { return rewardItemList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TowerLevelEndNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TowerLevelEndNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ContinueState != other.ContinueState) return false;
      if(!finishedStarCondList_.Equals(other.finishedStarCondList_)) return false;
      if (NextFloorId != other.NextFloorId) return false;
      if (IsSuccess != other.IsSuccess) return false;
      if(!rewardItemList_.Equals(other.rewardItemList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ContinueState != 0) hash ^= ContinueState.GetHashCode();
      hash ^= finishedStarCondList_.GetHashCode();
      if (NextFloorId != 0) hash ^= NextFloorId.GetHashCode();
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      hash ^= rewardItemList_.GetHashCode();
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
      if (ContinueState != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ContinueState);
      }
      if (NextFloorId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NextFloorId);
      }
      finishedStarCondList_.WriteTo(output, _repeated_finishedStarCondList_codec);
      rewardItemList_.WriteTo(output, _repeated_rewardItemList_codec);
      if (IsSuccess != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsSuccess);
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
      if (ContinueState != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ContinueState);
      }
      if (NextFloorId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NextFloorId);
      }
      finishedStarCondList_.WriteTo(ref output, _repeated_finishedStarCondList_codec);
      rewardItemList_.WriteTo(ref output, _repeated_rewardItemList_codec);
      if (IsSuccess != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsSuccess);
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
      if (ContinueState != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ContinueState);
      }
      size += finishedStarCondList_.CalculateSize(_repeated_finishedStarCondList_codec);
      if (NextFloorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextFloorId);
      }
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      size += rewardItemList_.CalculateSize(_repeated_rewardItemList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TowerLevelEndNotify other) {
      if (other == null) {
        return;
      }
      if (other.ContinueState != 0) {
        ContinueState = other.ContinueState;
      }
      finishedStarCondList_.Add(other.finishedStarCondList_);
      if (other.NextFloorId != 0) {
        NextFloorId = other.NextFloorId;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      rewardItemList_.Add(other.rewardItemList_);
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
            ContinueState = input.ReadUInt32();
            break;
          }
          case 32: {
            NextFloorId = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            finishedStarCondList_.AddEntriesFrom(input, _repeated_finishedStarCondList_codec);
            break;
          }
          case 82: {
            rewardItemList_.AddEntriesFrom(input, _repeated_rewardItemList_codec);
            break;
          }
          case 120: {
            IsSuccess = input.ReadBool();
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
            ContinueState = input.ReadUInt32();
            break;
          }
          case 32: {
            NextFloorId = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            finishedStarCondList_.AddEntriesFrom(ref input, _repeated_finishedStarCondList_codec);
            break;
          }
          case 82: {
            rewardItemList_.AddEntriesFrom(ref input, _repeated_rewardItemList_codec);
            break;
          }
          case 120: {
            IsSuccess = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the TowerLevelEndNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum ContinueStateType {
        [pbr::OriginalName("CONTINUE_STATE_TYPE_CAN_NOT_CONTINUE")] CanNotContinue = 0,
        [pbr::OriginalName("CONTINUE_STATE_TYPE_CAN_ENTER_NEXT_LEVEL")] CanEnterNextLevel = 1,
        [pbr::OriginalName("CONTINUE_STATE_TYPE_CAN_ENTER_NEXT_FLOOR")] CanEnterNextFloor = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
