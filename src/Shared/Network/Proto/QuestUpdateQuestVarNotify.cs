// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QuestUpdateQuestVarNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from QuestUpdateQuestVarNotify.proto</summary>
  public static partial class QuestUpdateQuestVarNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for QuestUpdateQuestVarNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuestUpdateQuestVarNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9RdWVzdFVwZGF0ZVF1ZXN0VmFyTm90aWZ5LnByb3RvEh9XZWVkd2Fja2Vy",
            "LlNoYXJlZC5OZXR3b3JrLlByb3RvImUKGVF1ZXN0VXBkYXRlUXVlc3RWYXJO",
            "b3RpZnkSHAoUcGFyZW50X3F1ZXN0X3Zhcl9zZXEYCSABKA0SEQoJcXVlc3Rf",
            "dmFyGAMgAygFEhcKD3BhcmVudF9xdWVzdF9pZBgHIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.QuestUpdateQuestVarNotify), global::Weedwacker.Shared.Network.Proto.QuestUpdateQuestVarNotify.Parser, new[]{ "ParentQuestVarSeq", "QuestVar", "ParentQuestId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 473;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class QuestUpdateQuestVarNotify : pb::IMessage<QuestUpdateQuestVarNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QuestUpdateQuestVarNotify> _parser = new pb::MessageParser<QuestUpdateQuestVarNotify>(() => new QuestUpdateQuestVarNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QuestUpdateQuestVarNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.QuestUpdateQuestVarNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestUpdateQuestVarNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestUpdateQuestVarNotify(QuestUpdateQuestVarNotify other) : this() {
      parentQuestVarSeq_ = other.parentQuestVarSeq_;
      questVar_ = other.questVar_.Clone();
      parentQuestId_ = other.parentQuestId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestUpdateQuestVarNotify Clone() {
      return new QuestUpdateQuestVarNotify(this);
    }

    /// <summary>Field number for the "parent_quest_var_seq" field.</summary>
    public const int ParentQuestVarSeqFieldNumber = 9;
    private uint parentQuestVarSeq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ParentQuestVarSeq {
      get { return parentQuestVarSeq_; }
      set {
        parentQuestVarSeq_ = value;
      }
    }

    /// <summary>Field number for the "quest_var" field.</summary>
    public const int QuestVarFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_questVar_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> questVar_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> QuestVar {
      get { return questVar_; }
    }

    /// <summary>Field number for the "parent_quest_id" field.</summary>
    public const int ParentQuestIdFieldNumber = 7;
    private uint parentQuestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ParentQuestId {
      get { return parentQuestId_; }
      set {
        parentQuestId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QuestUpdateQuestVarNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QuestUpdateQuestVarNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ParentQuestVarSeq != other.ParentQuestVarSeq) return false;
      if(!questVar_.Equals(other.questVar_)) return false;
      if (ParentQuestId != other.ParentQuestId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ParentQuestVarSeq != 0) hash ^= ParentQuestVarSeq.GetHashCode();
      hash ^= questVar_.GetHashCode();
      if (ParentQuestId != 0) hash ^= ParentQuestId.GetHashCode();
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
      questVar_.WriteTo(output, _repeated_questVar_codec);
      if (ParentQuestId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ParentQuestId);
      }
      if (ParentQuestVarSeq != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ParentQuestVarSeq);
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
      questVar_.WriteTo(ref output, _repeated_questVar_codec);
      if (ParentQuestId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ParentQuestId);
      }
      if (ParentQuestVarSeq != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ParentQuestVarSeq);
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
      if (ParentQuestVarSeq != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParentQuestVarSeq);
      }
      size += questVar_.CalculateSize(_repeated_questVar_codec);
      if (ParentQuestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParentQuestId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QuestUpdateQuestVarNotify other) {
      if (other == null) {
        return;
      }
      if (other.ParentQuestVarSeq != 0) {
        ParentQuestVarSeq = other.ParentQuestVarSeq;
      }
      questVar_.Add(other.questVar_);
      if (other.ParentQuestId != 0) {
        ParentQuestId = other.ParentQuestId;
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
          case 26:
          case 24: {
            questVar_.AddEntriesFrom(input, _repeated_questVar_codec);
            break;
          }
          case 56: {
            ParentQuestId = input.ReadUInt32();
            break;
          }
          case 72: {
            ParentQuestVarSeq = input.ReadUInt32();
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
          case 26:
          case 24: {
            questVar_.AddEntriesFrom(ref input, _repeated_questVar_codec);
            break;
          }
          case 56: {
            ParentQuestId = input.ReadUInt32();
            break;
          }
          case 72: {
            ParentQuestVarSeq = input.ReadUInt32();
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
