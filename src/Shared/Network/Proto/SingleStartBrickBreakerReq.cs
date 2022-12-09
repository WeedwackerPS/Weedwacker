// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SingleStartBrickBreakerReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SingleStartBrickBreakerReq.proto</summary>
  public static partial class SingleStartBrickBreakerReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SingleStartBrickBreakerReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SingleStartBrickBreakerReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBTaW5nbGVTdGFydEJyaWNrQnJlYWtlclJlcS5wcm90bxIfV2VlZHdhY2tl",
            "ci5TaGFyZWQuTmV0d29yay5Qcm90byJ5ChpTaW5nbGVTdGFydEJyaWNrQnJl",
            "YWtlclJlcRISCgppc19kdW5nZW9uGA0gASgIEhAKCGxldmVsX2lkGAggASgN",
            "EhkKEWNob3Nlbl9za2lsbF9saXN0GAwgAygNEhoKEmNob3Nlbl9hdmF0YXJf",
            "bGlzdBgFIAMoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SingleStartBrickBreakerReq), global::Weedwacker.Shared.Network.Proto.SingleStartBrickBreakerReq.Parser, new[]{ "IsDungeon", "LevelId", "ChosenSkillList", "ChosenAvatarList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 23663;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class SingleStartBrickBreakerReq : pb::IMessage<SingleStartBrickBreakerReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SingleStartBrickBreakerReq> _parser = new pb::MessageParser<SingleStartBrickBreakerReq>(() => new SingleStartBrickBreakerReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SingleStartBrickBreakerReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SingleStartBrickBreakerReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SingleStartBrickBreakerReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SingleStartBrickBreakerReq(SingleStartBrickBreakerReq other) : this() {
      isDungeon_ = other.isDungeon_;
      levelId_ = other.levelId_;
      chosenSkillList_ = other.chosenSkillList_.Clone();
      chosenAvatarList_ = other.chosenAvatarList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SingleStartBrickBreakerReq Clone() {
      return new SingleStartBrickBreakerReq(this);
    }

    /// <summary>Field number for the "is_dungeon" field.</summary>
    public const int IsDungeonFieldNumber = 13;
    private bool isDungeon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsDungeon {
      get { return isDungeon_; }
      set {
        isDungeon_ = value;
      }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 8;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "chosen_skill_list" field.</summary>
    public const int ChosenSkillListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_chosenSkillList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> chosenSkillList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ChosenSkillList {
      get { return chosenSkillList_; }
    }

    /// <summary>Field number for the "chosen_avatar_list" field.</summary>
    public const int ChosenAvatarListFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_chosenAvatarList_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> chosenAvatarList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ChosenAvatarList {
      get { return chosenAvatarList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SingleStartBrickBreakerReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SingleStartBrickBreakerReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsDungeon != other.IsDungeon) return false;
      if (LevelId != other.LevelId) return false;
      if(!chosenSkillList_.Equals(other.chosenSkillList_)) return false;
      if(!chosenAvatarList_.Equals(other.chosenAvatarList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsDungeon != false) hash ^= IsDungeon.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      hash ^= chosenSkillList_.GetHashCode();
      hash ^= chosenAvatarList_.GetHashCode();
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
      chosenAvatarList_.WriteTo(output, _repeated_chosenAvatarList_codec);
      if (LevelId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(LevelId);
      }
      chosenSkillList_.WriteTo(output, _repeated_chosenSkillList_codec);
      if (IsDungeon != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsDungeon);
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
      chosenAvatarList_.WriteTo(ref output, _repeated_chosenAvatarList_codec);
      if (LevelId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(LevelId);
      }
      chosenSkillList_.WriteTo(ref output, _repeated_chosenSkillList_codec);
      if (IsDungeon != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsDungeon);
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
      if (IsDungeon != false) {
        size += 1 + 1;
      }
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      size += chosenSkillList_.CalculateSize(_repeated_chosenSkillList_codec);
      size += chosenAvatarList_.CalculateSize(_repeated_chosenAvatarList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SingleStartBrickBreakerReq other) {
      if (other == null) {
        return;
      }
      if (other.IsDungeon != false) {
        IsDungeon = other.IsDungeon;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      chosenSkillList_.Add(other.chosenSkillList_);
      chosenAvatarList_.Add(other.chosenAvatarList_);
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
          case 42:
          case 40: {
            chosenAvatarList_.AddEntriesFrom(input, _repeated_chosenAvatarList_codec);
            break;
          }
          case 64: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            chosenSkillList_.AddEntriesFrom(input, _repeated_chosenSkillList_codec);
            break;
          }
          case 104: {
            IsDungeon = input.ReadBool();
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
          case 42:
          case 40: {
            chosenAvatarList_.AddEntriesFrom(ref input, _repeated_chosenAvatarList_codec);
            break;
          }
          case 64: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            chosenSkillList_.AddEntriesFrom(ref input, _repeated_chosenSkillList_codec);
            break;
          }
          case 104: {
            IsDungeon = input.ReadBool();
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
