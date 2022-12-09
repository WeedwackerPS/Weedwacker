// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeonSetting.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CustomDungeonSetting.proto</summary>
  public static partial class CustomDungeonSettingReflection {

    #region Descriptor
    /// <summary>File descriptor for CustomDungeonSetting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomDungeonSettingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpDdXN0b21EdW5nZW9uU2V0dGluZy5wcm90bxIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90byKyAQoUQ3VzdG9tRHVuZ2VvblNldHRpbmcSFQoN",
            "c3RhcnRfcm9vbV9pZBgDIAEoDRISCgp0aW1lX2xpbWl0GAkgASgNEhYKDm9w",
            "ZW5fcm9vbV9saXN0GA4gAygNEhIKCmNvaW5fbGltaXQYBSABKA0SFwoPaXNf",
            "Zm9yYmlkX3NraWxsGAcgASgIEhgKEGlzX2Fycml2ZV9maW5pc2gYBiABKAgS",
            "EAoIbGlmZV9udW0YCCABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CustomDungeonSetting), global::Weedwacker.Shared.Network.Proto.CustomDungeonSetting.Parser, new[]{ "StartRoomId", "TimeLimit", "OpenRoomList", "CoinLimit", "IsForbidSkill", "IsArriveFinish", "LifeNum" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CustomDungeonSetting : pb::IMessage<CustomDungeonSetting>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomDungeonSetting> _parser = new pb::MessageParser<CustomDungeonSetting>(() => new CustomDungeonSetting());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomDungeonSetting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CustomDungeonSettingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonSetting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonSetting(CustomDungeonSetting other) : this() {
      startRoomId_ = other.startRoomId_;
      timeLimit_ = other.timeLimit_;
      openRoomList_ = other.openRoomList_.Clone();
      coinLimit_ = other.coinLimit_;
      isForbidSkill_ = other.isForbidSkill_;
      isArriveFinish_ = other.isArriveFinish_;
      lifeNum_ = other.lifeNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonSetting Clone() {
      return new CustomDungeonSetting(this);
    }

    /// <summary>Field number for the "start_room_id" field.</summary>
    public const int StartRoomIdFieldNumber = 3;
    private uint startRoomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StartRoomId {
      get { return startRoomId_; }
      set {
        startRoomId_ = value;
      }
    }

    /// <summary>Field number for the "time_limit" field.</summary>
    public const int TimeLimitFieldNumber = 9;
    private uint timeLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TimeLimit {
      get { return timeLimit_; }
      set {
        timeLimit_ = value;
      }
    }

    /// <summary>Field number for the "open_room_list" field.</summary>
    public const int OpenRoomListFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_openRoomList_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> openRoomList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> OpenRoomList {
      get { return openRoomList_; }
    }

    /// <summary>Field number for the "coin_limit" field.</summary>
    public const int CoinLimitFieldNumber = 5;
    private uint coinLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CoinLimit {
      get { return coinLimit_; }
      set {
        coinLimit_ = value;
      }
    }

    /// <summary>Field number for the "is_forbid_skill" field.</summary>
    public const int IsForbidSkillFieldNumber = 7;
    private bool isForbidSkill_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsForbidSkill {
      get { return isForbidSkill_; }
      set {
        isForbidSkill_ = value;
      }
    }

    /// <summary>Field number for the "is_arrive_finish" field.</summary>
    public const int IsArriveFinishFieldNumber = 6;
    private bool isArriveFinish_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsArriveFinish {
      get { return isArriveFinish_; }
      set {
        isArriveFinish_ = value;
      }
    }

    /// <summary>Field number for the "life_num" field.</summary>
    public const int LifeNumFieldNumber = 8;
    private uint lifeNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LifeNum {
      get { return lifeNum_; }
      set {
        lifeNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomDungeonSetting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomDungeonSetting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StartRoomId != other.StartRoomId) return false;
      if (TimeLimit != other.TimeLimit) return false;
      if(!openRoomList_.Equals(other.openRoomList_)) return false;
      if (CoinLimit != other.CoinLimit) return false;
      if (IsForbidSkill != other.IsForbidSkill) return false;
      if (IsArriveFinish != other.IsArriveFinish) return false;
      if (LifeNum != other.LifeNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StartRoomId != 0) hash ^= StartRoomId.GetHashCode();
      if (TimeLimit != 0) hash ^= TimeLimit.GetHashCode();
      hash ^= openRoomList_.GetHashCode();
      if (CoinLimit != 0) hash ^= CoinLimit.GetHashCode();
      if (IsForbidSkill != false) hash ^= IsForbidSkill.GetHashCode();
      if (IsArriveFinish != false) hash ^= IsArriveFinish.GetHashCode();
      if (LifeNum != 0) hash ^= LifeNum.GetHashCode();
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
      if (StartRoomId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(StartRoomId);
      }
      if (CoinLimit != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CoinLimit);
      }
      if (IsArriveFinish != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsArriveFinish);
      }
      if (IsForbidSkill != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsForbidSkill);
      }
      if (LifeNum != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(LifeNum);
      }
      if (TimeLimit != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(TimeLimit);
      }
      openRoomList_.WriteTo(output, _repeated_openRoomList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (StartRoomId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(StartRoomId);
      }
      if (CoinLimit != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CoinLimit);
      }
      if (IsArriveFinish != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsArriveFinish);
      }
      if (IsForbidSkill != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsForbidSkill);
      }
      if (LifeNum != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(LifeNum);
      }
      if (TimeLimit != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(TimeLimit);
      }
      openRoomList_.WriteTo(ref output, _repeated_openRoomList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (StartRoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartRoomId);
      }
      if (TimeLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TimeLimit);
      }
      size += openRoomList_.CalculateSize(_repeated_openRoomList_codec);
      if (CoinLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoinLimit);
      }
      if (IsForbidSkill != false) {
        size += 1 + 1;
      }
      if (IsArriveFinish != false) {
        size += 1 + 1;
      }
      if (LifeNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LifeNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomDungeonSetting other) {
      if (other == null) {
        return;
      }
      if (other.StartRoomId != 0) {
        StartRoomId = other.StartRoomId;
      }
      if (other.TimeLimit != 0) {
        TimeLimit = other.TimeLimit;
      }
      openRoomList_.Add(other.openRoomList_);
      if (other.CoinLimit != 0) {
        CoinLimit = other.CoinLimit;
      }
      if (other.IsForbidSkill != false) {
        IsForbidSkill = other.IsForbidSkill;
      }
      if (other.IsArriveFinish != false) {
        IsArriveFinish = other.IsArriveFinish;
      }
      if (other.LifeNum != 0) {
        LifeNum = other.LifeNum;
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
          case 24: {
            StartRoomId = input.ReadUInt32();
            break;
          }
          case 40: {
            CoinLimit = input.ReadUInt32();
            break;
          }
          case 48: {
            IsArriveFinish = input.ReadBool();
            break;
          }
          case 56: {
            IsForbidSkill = input.ReadBool();
            break;
          }
          case 64: {
            LifeNum = input.ReadUInt32();
            break;
          }
          case 72: {
            TimeLimit = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            openRoomList_.AddEntriesFrom(input, _repeated_openRoomList_codec);
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
          case 24: {
            StartRoomId = input.ReadUInt32();
            break;
          }
          case 40: {
            CoinLimit = input.ReadUInt32();
            break;
          }
          case 48: {
            IsArriveFinish = input.ReadBool();
            break;
          }
          case 56: {
            IsForbidSkill = input.ReadBool();
            break;
          }
          case 64: {
            LifeNum = input.ReadUInt32();
            break;
          }
          case 72: {
            TimeLimit = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            openRoomList_.AddEntriesFrom(ref input, _repeated_openRoomList_codec);
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
