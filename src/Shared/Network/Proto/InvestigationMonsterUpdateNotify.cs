// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InvestigationMonsterUpdateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from InvestigationMonsterUpdateNotify.proto</summary>
  public static partial class InvestigationMonsterUpdateNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for InvestigationMonsterUpdateNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InvestigationMonsterUpdateNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZJbnZlc3RpZ2F0aW9uTW9uc3RlclVwZGF0ZU5vdGlmeS5wcm90bxIfV2Vl",
            "ZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90bxoaSW52ZXN0aWdhdGlvbk1v",
            "bnN0ZXIucHJvdG8ieAogSW52ZXN0aWdhdGlvbk1vbnN0ZXJVcGRhdGVOb3Rp",
            "ZnkSVAoVaW52ZXN0aWdhdGlvbl9tb25zdGVyGAYgASgLMjUuV2VlZHdhY2tl",
            "ci5TaGFyZWQuTmV0d29yay5Qcm90by5JbnZlc3RpZ2F0aW9uTW9uc3RlcmIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.InvestigationMonsterReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.InvestigationMonsterUpdateNotify), global::Weedwacker.Shared.Network.Proto.InvestigationMonsterUpdateNotify.Parser, new[]{ "InvestigationMonster" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1910;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class InvestigationMonsterUpdateNotify : pb::IMessage<InvestigationMonsterUpdateNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InvestigationMonsterUpdateNotify> _parser = new pb::MessageParser<InvestigationMonsterUpdateNotify>(() => new InvestigationMonsterUpdateNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InvestigationMonsterUpdateNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.InvestigationMonsterUpdateNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InvestigationMonsterUpdateNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InvestigationMonsterUpdateNotify(InvestigationMonsterUpdateNotify other) : this() {
      investigationMonster_ = other.investigationMonster_ != null ? other.investigationMonster_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InvestigationMonsterUpdateNotify Clone() {
      return new InvestigationMonsterUpdateNotify(this);
    }

    /// <summary>Field number for the "investigation_monster" field.</summary>
    public const int InvestigationMonsterFieldNumber = 6;
    private global::Weedwacker.Shared.Network.Proto.InvestigationMonster investigationMonster_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.InvestigationMonster InvestigationMonster {
      get { return investigationMonster_; }
      set {
        investigationMonster_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as InvestigationMonsterUpdateNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InvestigationMonsterUpdateNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(InvestigationMonster, other.InvestigationMonster)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (investigationMonster_ != null) hash ^= InvestigationMonster.GetHashCode();
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
      if (investigationMonster_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(InvestigationMonster);
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
      if (investigationMonster_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(InvestigationMonster);
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
      if (investigationMonster_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InvestigationMonster);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(InvestigationMonsterUpdateNotify other) {
      if (other == null) {
        return;
      }
      if (other.investigationMonster_ != null) {
        if (investigationMonster_ == null) {
          InvestigationMonster = new global::Weedwacker.Shared.Network.Proto.InvestigationMonster();
        }
        InvestigationMonster.MergeFrom(other.InvestigationMonster);
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
          case 50: {
            if (investigationMonster_ == null) {
              InvestigationMonster = new global::Weedwacker.Shared.Network.Proto.InvestigationMonster();
            }
            input.ReadMessage(InvestigationMonster);
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
          case 50: {
            if (investigationMonster_ == null) {
              InvestigationMonster = new global::Weedwacker.Shared.Network.Proto.InvestigationMonster();
            }
            input.ReadMessage(InvestigationMonster);
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
