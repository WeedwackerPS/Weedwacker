// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ScenePlayBattleSettlePlayerInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ScenePlayBattleSettlePlayerInfo.proto</summary>
  public static partial class ScenePlayBattleSettlePlayerInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ScenePlayBattleSettlePlayerInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScenePlayBattleSettlePlayerInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVTY2VuZVBsYXlCYXR0bGVTZXR0bGVQbGF5ZXJJbmZvLnByb3RvEh9XZWVk",
            "d2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvGhtFeGhpYml0aW9uRGlzcGxh",
            "eUluZm8ucHJvdG8aFFByb2ZpbGVQaWN0dXJlLnByb3RvIqECCh9TY2VuZVBs",
            "YXlCYXR0bGVTZXR0bGVQbGF5ZXJJbmZvEgsKA3VpZBgHIAEoDRJJCgljYXJk",
            "X2xpc3QYBCADKAsyNi5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3Rv",
            "LkV4aGliaXRpb25EaXNwbGF5SW5mbxJICg9wcm9maWxlX3BpY3R1cmUYCCAB",
            "KAsyLy5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLlByb2ZpbGVQ",
            "aWN0dXJlEhAKCG5pY2tuYW1lGAMgASgJEg0KBXBhcmFtGAsgASgDEhQKDHN0",
            "YXRpc3RpY19pZBgNIAEoDRIRCglvbmxpbmVfaWQYBSABKAkSEgoKaGVhZF9p",
            "bWFnZRgCIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ProfilePictureReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ScenePlayBattleSettlePlayerInfo), global::Weedwacker.Shared.Network.Proto.ScenePlayBattleSettlePlayerInfo.Parser, new[]{ "Uid", "CardList", "ProfilePicture", "Nickname", "Param", "StatisticId", "OnlineId", "HeadImage" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ScenePlayBattleSettlePlayerInfo : pb::IMessage<ScenePlayBattleSettlePlayerInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ScenePlayBattleSettlePlayerInfo> _parser = new pb::MessageParser<ScenePlayBattleSettlePlayerInfo>(() => new ScenePlayBattleSettlePlayerInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ScenePlayBattleSettlePlayerInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ScenePlayBattleSettlePlayerInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScenePlayBattleSettlePlayerInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScenePlayBattleSettlePlayerInfo(ScenePlayBattleSettlePlayerInfo other) : this() {
      uid_ = other.uid_;
      cardList_ = other.cardList_.Clone();
      profilePicture_ = other.profilePicture_ != null ? other.profilePicture_.Clone() : null;
      nickname_ = other.nickname_;
      param_ = other.param_;
      statisticId_ = other.statisticId_;
      onlineId_ = other.onlineId_;
      headImage_ = other.headImage_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScenePlayBattleSettlePlayerInfo Clone() {
      return new ScenePlayBattleSettlePlayerInfo(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 7;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "card_list" field.</summary>
    public const int CardListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfo> _repeated_cardList_codec
        = pb::FieldCodec.ForMessage(34, global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfo> cardList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfo> CardList {
      get { return cardList_; }
    }

    /// <summary>Field number for the "profile_picture" field.</summary>
    public const int ProfilePictureFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.ProfilePicture profilePicture_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ProfilePicture ProfilePicture {
      get { return profilePicture_; }
      set {
        profilePicture_ = value;
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 3;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "param" field.</summary>
    public const int ParamFieldNumber = 11;
    private long param_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Param {
      get { return param_; }
      set {
        param_ = value;
      }
    }

    /// <summary>Field number for the "statistic_id" field.</summary>
    public const int StatisticIdFieldNumber = 13;
    private uint statisticId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StatisticId {
      get { return statisticId_; }
      set {
        statisticId_ = value;
      }
    }

    /// <summary>Field number for the "online_id" field.</summary>
    public const int OnlineIdFieldNumber = 5;
    private string onlineId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OnlineId {
      get { return onlineId_; }
      set {
        onlineId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "head_image" field.</summary>
    public const int HeadImageFieldNumber = 2;
    private uint headImage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HeadImage {
      get { return headImage_; }
      set {
        headImage_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ScenePlayBattleSettlePlayerInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ScenePlayBattleSettlePlayerInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if(!cardList_.Equals(other.cardList_)) return false;
      if (!object.Equals(ProfilePicture, other.ProfilePicture)) return false;
      if (Nickname != other.Nickname) return false;
      if (Param != other.Param) return false;
      if (StatisticId != other.StatisticId) return false;
      if (OnlineId != other.OnlineId) return false;
      if (HeadImage != other.HeadImage) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0) hash ^= Uid.GetHashCode();
      hash ^= cardList_.GetHashCode();
      if (profilePicture_ != null) hash ^= ProfilePicture.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (Param != 0L) hash ^= Param.GetHashCode();
      if (StatisticId != 0) hash ^= StatisticId.GetHashCode();
      if (OnlineId.Length != 0) hash ^= OnlineId.GetHashCode();
      if (HeadImage != 0) hash ^= HeadImage.GetHashCode();
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
      if (HeadImage != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(HeadImage);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Nickname);
      }
      cardList_.WriteTo(output, _repeated_cardList_codec);
      if (OnlineId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OnlineId);
      }
      if (Uid != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Uid);
      }
      if (profilePicture_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ProfilePicture);
      }
      if (Param != 0L) {
        output.WriteRawTag(88);
        output.WriteInt64(Param);
      }
      if (StatisticId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(StatisticId);
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
      if (HeadImage != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(HeadImage);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Nickname);
      }
      cardList_.WriteTo(ref output, _repeated_cardList_codec);
      if (OnlineId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OnlineId);
      }
      if (Uid != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Uid);
      }
      if (profilePicture_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ProfilePicture);
      }
      if (Param != 0L) {
        output.WriteRawTag(88);
        output.WriteInt64(Param);
      }
      if (StatisticId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(StatisticId);
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
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      size += cardList_.CalculateSize(_repeated_cardList_codec);
      if (profilePicture_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProfilePicture);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (Param != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Param);
      }
      if (StatisticId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StatisticId);
      }
      if (OnlineId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OnlineId);
      }
      if (HeadImage != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HeadImage);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ScenePlayBattleSettlePlayerInfo other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      cardList_.Add(other.cardList_);
      if (other.profilePicture_ != null) {
        if (profilePicture_ == null) {
          ProfilePicture = new global::Weedwacker.Shared.Network.Proto.ProfilePicture();
        }
        ProfilePicture.MergeFrom(other.ProfilePicture);
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.Param != 0L) {
        Param = other.Param;
      }
      if (other.StatisticId != 0) {
        StatisticId = other.StatisticId;
      }
      if (other.OnlineId.Length != 0) {
        OnlineId = other.OnlineId;
      }
      if (other.HeadImage != 0) {
        HeadImage = other.HeadImage;
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
            HeadImage = input.ReadUInt32();
            break;
          }
          case 26: {
            Nickname = input.ReadString();
            break;
          }
          case 34: {
            cardList_.AddEntriesFrom(input, _repeated_cardList_codec);
            break;
          }
          case 42: {
            OnlineId = input.ReadString();
            break;
          }
          case 56: {
            Uid = input.ReadUInt32();
            break;
          }
          case 66: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::Weedwacker.Shared.Network.Proto.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 88: {
            Param = input.ReadInt64();
            break;
          }
          case 104: {
            StatisticId = input.ReadUInt32();
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
            HeadImage = input.ReadUInt32();
            break;
          }
          case 26: {
            Nickname = input.ReadString();
            break;
          }
          case 34: {
            cardList_.AddEntriesFrom(ref input, _repeated_cardList_codec);
            break;
          }
          case 42: {
            OnlineId = input.ReadString();
            break;
          }
          case 56: {
            Uid = input.ReadUInt32();
            break;
          }
          case 66: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::Weedwacker.Shared.Network.Proto.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 88: {
            Param = input.ReadInt64();
            break;
          }
          case 104: {
            StatisticId = input.ReadUInt32();
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
