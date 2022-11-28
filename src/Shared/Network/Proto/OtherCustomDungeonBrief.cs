// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OtherCustomDungeonBrief.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from OtherCustomDungeonBrief.proto</summary>
  public static partial class OtherCustomDungeonBriefReflection {

    #region Descriptor
    /// <summary>File descriptor for OtherCustomDungeonBrief.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OtherCustomDungeonBriefReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1PdGhlckN1c3RvbUR1bmdlb25CcmllZi5wcm90bxobQ3VzdG9tRHVuZ2Vv",
            "bkFic3RyYWN0LnByb3RvGhpDdXN0b21EdW5nZW9uU2V0dGluZy5wcm90bxoZ",
            "Q3VzdG9tRHVuZ2VvblNvY2lhbC5wcm90bxoSU29jaWFsRGV0YWlsLnByb3Rv",
            "ItwCChdPdGhlckN1c3RvbUR1bmdlb25CcmllZhIlCg5jcmVhdG9yX2RldGFp",
            "bBgEIAEoCzINLlNvY2lhbERldGFpbBIcChRiYXR0bGVfbWluX2Nvc3RfdGlt",
            "ZRgPIAEoDRIoCghhYnN0cmFjdBgCIAEoCzIWLkN1c3RvbUR1bmdlb25BYnN0",
            "cmFjdBIUCgxkdW5nZW9uX2d1aWQYDiABKAQSJgoHc2V0dGluZxgKIAEoCzIV",
            "LkN1c3RvbUR1bmdlb25TZXR0aW5nEhIKCmR1bmdlb25faWQYBiABKA0SEAoI",
            "dGFnX2xpc3QYASADKA0SHAoUaXNfYWR2ZW50dXJlX2R1bmdlb24YCyABKAgS",
            "FwoPaXNfcHNuX3BsYXRmb3JtGAkgASgIEhEKCWlzX3N0b3JlZBgDIAEoCBIk",
            "CgZzb2NpYWwYDCABKAsyFC5DdXN0b21EdW5nZW9uU29jaWFsQiKqAh9XZWVk",
            "d2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.CustomDungeonAbstractReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.CustomDungeonSettingReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.CustomDungeonSocialReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.SocialDetailReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.OtherCustomDungeonBrief), global::Weedwacker.Shared.Network.Proto.OtherCustomDungeonBrief.Parser, new[]{ "CreatorDetail", "BattleMinCostTime", "Abstract", "DungeonGuid", "Setting", "DungeonId", "TagList", "IsAdventureDungeon", "IsPsnPlatform", "IsStored", "Social" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OtherCustomDungeonBrief : pb::IMessage<OtherCustomDungeonBrief>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OtherCustomDungeonBrief> _parser = new pb::MessageParser<OtherCustomDungeonBrief>(() => new OtherCustomDungeonBrief());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OtherCustomDungeonBrief> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.OtherCustomDungeonBriefReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OtherCustomDungeonBrief() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OtherCustomDungeonBrief(OtherCustomDungeonBrief other) : this() {
      creatorDetail_ = other.creatorDetail_ != null ? other.creatorDetail_.Clone() : null;
      battleMinCostTime_ = other.battleMinCostTime_;
      abstract_ = other.abstract_ != null ? other.abstract_.Clone() : null;
      dungeonGuid_ = other.dungeonGuid_;
      setting_ = other.setting_ != null ? other.setting_.Clone() : null;
      dungeonId_ = other.dungeonId_;
      tagList_ = other.tagList_.Clone();
      isAdventureDungeon_ = other.isAdventureDungeon_;
      isPsnPlatform_ = other.isPsnPlatform_;
      isStored_ = other.isStored_;
      social_ = other.social_ != null ? other.social_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OtherCustomDungeonBrief Clone() {
      return new OtherCustomDungeonBrief(this);
    }

    /// <summary>Field number for the "creator_detail" field.</summary>
    public const int CreatorDetailFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.SocialDetail creatorDetail_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.SocialDetail CreatorDetail {
      get { return creatorDetail_; }
      set {
        creatorDetail_ = value;
      }
    }

    /// <summary>Field number for the "battle_min_cost_time" field.</summary>
    public const int BattleMinCostTimeFieldNumber = 15;
    private uint battleMinCostTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BattleMinCostTime {
      get { return battleMinCostTime_; }
      set {
        battleMinCostTime_ = value;
      }
    }

    /// <summary>Field number for the "abstract" field.</summary>
    public const int AbstractFieldNumber = 2;
    private global::Weedwacker.Shared.Network.Proto.CustomDungeonAbstract abstract_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.CustomDungeonAbstract Abstract {
      get { return abstract_; }
      set {
        abstract_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_guid" field.</summary>
    public const int DungeonGuidFieldNumber = 14;
    private ulong dungeonGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong DungeonGuid {
      get { return dungeonGuid_; }
      set {
        dungeonGuid_ = value;
      }
    }

    /// <summary>Field number for the "setting" field.</summary>
    public const int SettingFieldNumber = 10;
    private global::Weedwacker.Shared.Network.Proto.CustomDungeonSetting setting_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.CustomDungeonSetting Setting {
      get { return setting_; }
      set {
        setting_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 6;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "tag_list" field.</summary>
    public const int TagListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_tagList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> tagList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TagList {
      get { return tagList_; }
    }

    /// <summary>Field number for the "is_adventure_dungeon" field.</summary>
    public const int IsAdventureDungeonFieldNumber = 11;
    private bool isAdventureDungeon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAdventureDungeon {
      get { return isAdventureDungeon_; }
      set {
        isAdventureDungeon_ = value;
      }
    }

    /// <summary>Field number for the "is_psn_platform" field.</summary>
    public const int IsPsnPlatformFieldNumber = 9;
    private bool isPsnPlatform_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPsnPlatform {
      get { return isPsnPlatform_; }
      set {
        isPsnPlatform_ = value;
      }
    }

    /// <summary>Field number for the "is_stored" field.</summary>
    public const int IsStoredFieldNumber = 3;
    private bool isStored_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsStored {
      get { return isStored_; }
      set {
        isStored_ = value;
      }
    }

    /// <summary>Field number for the "social" field.</summary>
    public const int SocialFieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.CustomDungeonSocial social_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.CustomDungeonSocial Social {
      get { return social_; }
      set {
        social_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OtherCustomDungeonBrief);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OtherCustomDungeonBrief other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CreatorDetail, other.CreatorDetail)) return false;
      if (BattleMinCostTime != other.BattleMinCostTime) return false;
      if (!object.Equals(Abstract, other.Abstract)) return false;
      if (DungeonGuid != other.DungeonGuid) return false;
      if (!object.Equals(Setting, other.Setting)) return false;
      if (DungeonId != other.DungeonId) return false;
      if(!tagList_.Equals(other.tagList_)) return false;
      if (IsAdventureDungeon != other.IsAdventureDungeon) return false;
      if (IsPsnPlatform != other.IsPsnPlatform) return false;
      if (IsStored != other.IsStored) return false;
      if (!object.Equals(Social, other.Social)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (creatorDetail_ != null) hash ^= CreatorDetail.GetHashCode();
      if (BattleMinCostTime != 0) hash ^= BattleMinCostTime.GetHashCode();
      if (abstract_ != null) hash ^= Abstract.GetHashCode();
      if (DungeonGuid != 0UL) hash ^= DungeonGuid.GetHashCode();
      if (setting_ != null) hash ^= Setting.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      hash ^= tagList_.GetHashCode();
      if (IsAdventureDungeon != false) hash ^= IsAdventureDungeon.GetHashCode();
      if (IsPsnPlatform != false) hash ^= IsPsnPlatform.GetHashCode();
      if (IsStored != false) hash ^= IsStored.GetHashCode();
      if (social_ != null) hash ^= Social.GetHashCode();
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
      tagList_.WriteTo(output, _repeated_tagList_codec);
      if (abstract_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Abstract);
      }
      if (IsStored != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsStored);
      }
      if (creatorDetail_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreatorDetail);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DungeonId);
      }
      if (IsPsnPlatform != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsPsnPlatform);
      }
      if (setting_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Setting);
      }
      if (IsAdventureDungeon != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsAdventureDungeon);
      }
      if (social_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Social);
      }
      if (DungeonGuid != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(DungeonGuid);
      }
      if (BattleMinCostTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(BattleMinCostTime);
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
      tagList_.WriteTo(ref output, _repeated_tagList_codec);
      if (abstract_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Abstract);
      }
      if (IsStored != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsStored);
      }
      if (creatorDetail_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreatorDetail);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DungeonId);
      }
      if (IsPsnPlatform != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsPsnPlatform);
      }
      if (setting_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Setting);
      }
      if (IsAdventureDungeon != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsAdventureDungeon);
      }
      if (social_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Social);
      }
      if (DungeonGuid != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(DungeonGuid);
      }
      if (BattleMinCostTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(BattleMinCostTime);
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
      if (creatorDetail_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreatorDetail);
      }
      if (BattleMinCostTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BattleMinCostTime);
      }
      if (abstract_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Abstract);
      }
      if (DungeonGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DungeonGuid);
      }
      if (setting_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Setting);
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      size += tagList_.CalculateSize(_repeated_tagList_codec);
      if (IsAdventureDungeon != false) {
        size += 1 + 1;
      }
      if (IsPsnPlatform != false) {
        size += 1 + 1;
      }
      if (IsStored != false) {
        size += 1 + 1;
      }
      if (social_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Social);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OtherCustomDungeonBrief other) {
      if (other == null) {
        return;
      }
      if (other.creatorDetail_ != null) {
        if (creatorDetail_ == null) {
          CreatorDetail = new global::Weedwacker.Shared.Network.Proto.SocialDetail();
        }
        CreatorDetail.MergeFrom(other.CreatorDetail);
      }
      if (other.BattleMinCostTime != 0) {
        BattleMinCostTime = other.BattleMinCostTime;
      }
      if (other.abstract_ != null) {
        if (abstract_ == null) {
          Abstract = new global::Weedwacker.Shared.Network.Proto.CustomDungeonAbstract();
        }
        Abstract.MergeFrom(other.Abstract);
      }
      if (other.DungeonGuid != 0UL) {
        DungeonGuid = other.DungeonGuid;
      }
      if (other.setting_ != null) {
        if (setting_ == null) {
          Setting = new global::Weedwacker.Shared.Network.Proto.CustomDungeonSetting();
        }
        Setting.MergeFrom(other.Setting);
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      tagList_.Add(other.tagList_);
      if (other.IsAdventureDungeon != false) {
        IsAdventureDungeon = other.IsAdventureDungeon;
      }
      if (other.IsPsnPlatform != false) {
        IsPsnPlatform = other.IsPsnPlatform;
      }
      if (other.IsStored != false) {
        IsStored = other.IsStored;
      }
      if (other.social_ != null) {
        if (social_ == null) {
          Social = new global::Weedwacker.Shared.Network.Proto.CustomDungeonSocial();
        }
        Social.MergeFrom(other.Social);
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
            tagList_.AddEntriesFrom(input, _repeated_tagList_codec);
            break;
          }
          case 18: {
            if (abstract_ == null) {
              Abstract = new global::Weedwacker.Shared.Network.Proto.CustomDungeonAbstract();
            }
            input.ReadMessage(Abstract);
            break;
          }
          case 24: {
            IsStored = input.ReadBool();
            break;
          }
          case 34: {
            if (creatorDetail_ == null) {
              CreatorDetail = new global::Weedwacker.Shared.Network.Proto.SocialDetail();
            }
            input.ReadMessage(CreatorDetail);
            break;
          }
          case 48: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 72: {
            IsPsnPlatform = input.ReadBool();
            break;
          }
          case 82: {
            if (setting_ == null) {
              Setting = new global::Weedwacker.Shared.Network.Proto.CustomDungeonSetting();
            }
            input.ReadMessage(Setting);
            break;
          }
          case 88: {
            IsAdventureDungeon = input.ReadBool();
            break;
          }
          case 98: {
            if (social_ == null) {
              Social = new global::Weedwacker.Shared.Network.Proto.CustomDungeonSocial();
            }
            input.ReadMessage(Social);
            break;
          }
          case 112: {
            DungeonGuid = input.ReadUInt64();
            break;
          }
          case 120: {
            BattleMinCostTime = input.ReadUInt32();
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
            tagList_.AddEntriesFrom(ref input, _repeated_tagList_codec);
            break;
          }
          case 18: {
            if (abstract_ == null) {
              Abstract = new global::Weedwacker.Shared.Network.Proto.CustomDungeonAbstract();
            }
            input.ReadMessage(Abstract);
            break;
          }
          case 24: {
            IsStored = input.ReadBool();
            break;
          }
          case 34: {
            if (creatorDetail_ == null) {
              CreatorDetail = new global::Weedwacker.Shared.Network.Proto.SocialDetail();
            }
            input.ReadMessage(CreatorDetail);
            break;
          }
          case 48: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 72: {
            IsPsnPlatform = input.ReadBool();
            break;
          }
          case 82: {
            if (setting_ == null) {
              Setting = new global::Weedwacker.Shared.Network.Proto.CustomDungeonSetting();
            }
            input.ReadMessage(Setting);
            break;
          }
          case 88: {
            IsAdventureDungeon = input.ReadBool();
            break;
          }
          case 98: {
            if (social_ == null) {
              Social = new global::Weedwacker.Shared.Network.Proto.CustomDungeonSocial();
            }
            input.ReadMessage(Social);
            break;
          }
          case 112: {
            DungeonGuid = input.ReadUInt64();
            break;
          }
          case 120: {
            BattleMinCostTime = input.ReadUInt32();
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
