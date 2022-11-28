// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgCostDice.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGMsgCostDice.proto</summary>
  public static partial class GCGMsgCostDiceReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGMsgCostDice.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGMsgCostDiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRHQ0dNc2dDb3N0RGljZS5wcm90bxoPR0NHUmVhc29uLnByb3RvImMKDkdD",
            "R01zZ0Nvc3REaWNlEhUKDWNvbnRyb2xsZXJfaWQYBiABKA0SHgoWc2VsZWN0",
            "X2RpY2VfaW5kZXhfbGlzdBgNIAMoDRIaCgZyZWFzb24YCSABKA4yCi5HQ0dS",
            "ZWFzb25CIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGMsgCostDice), global::Weedwacker.Shared.Network.Proto.GCGMsgCostDice.Parser, new[]{ "ControllerId", "SelectDiceIndexList", "Reason" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGMsgCostDice : pb::IMessage<GCGMsgCostDice>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGMsgCostDice> _parser = new pb::MessageParser<GCGMsgCostDice>(() => new GCGMsgCostDice());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGMsgCostDice> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGMsgCostDiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgCostDice() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgCostDice(GCGMsgCostDice other) : this() {
      controllerId_ = other.controllerId_;
      selectDiceIndexList_ = other.selectDiceIndexList_.Clone();
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgCostDice Clone() {
      return new GCGMsgCostDice(this);
    }

    /// <summary>Field number for the "controller_id" field.</summary>
    public const int ControllerIdFieldNumber = 6;
    private uint controllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ControllerId {
      get { return controllerId_; }
      set {
        controllerId_ = value;
      }
    }

    /// <summary>Field number for the "select_dice_index_list" field.</summary>
    public const int SelectDiceIndexListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_selectDiceIndexList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> selectDiceIndexList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SelectDiceIndexList {
      get { return selectDiceIndexList_; }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 9;
    private global::Weedwacker.Shared.Network.Proto.GCGReason reason_ = global::Weedwacker.Shared.Network.Proto.GCGReason.Default;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGMsgCostDice);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGMsgCostDice other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ControllerId != other.ControllerId) return false;
      if(!selectDiceIndexList_.Equals(other.selectDiceIndexList_)) return false;
      if (Reason != other.Reason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
      hash ^= selectDiceIndexList_.GetHashCode();
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) hash ^= Reason.GetHashCode();
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
      if (ControllerId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ControllerId);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Reason);
      }
      selectDiceIndexList_.WriteTo(output, _repeated_selectDiceIndexList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ControllerId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ControllerId);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Reason);
      }
      selectDiceIndexList_.WriteTo(ref output, _repeated_selectDiceIndexList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
      }
      size += selectDiceIndexList_.CalculateSize(_repeated_selectDiceIndexList_codec);
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGMsgCostDice other) {
      if (other == null) {
        return;
      }
      if (other.ControllerId != 0) {
        ControllerId = other.ControllerId;
      }
      selectDiceIndexList_.Add(other.selectDiceIndexList_);
      if (other.Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
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
          case 48: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 72: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GCGReason) input.ReadEnum();
            break;
          }
          case 106:
          case 104: {
            selectDiceIndexList_.AddEntriesFrom(input, _repeated_selectDiceIndexList_codec);
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
          case 48: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 72: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GCGReason) input.ReadEnum();
            break;
          }
          case 106:
          case 104: {
            selectDiceIndexList_.AddEntriesFrom(ref input, _repeated_selectDiceIndexList_codec);
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
