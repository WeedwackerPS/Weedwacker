// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgRemoveCards.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGMsgRemoveCards.proto</summary>
  public static partial class GCGMsgRemoveCardsReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGMsgRemoveCards.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGMsgRemoveCardsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHQ0dNc2dSZW1vdmVDYXJkcy5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90bxoPR0NHUmVhc29uLnByb3RvGhFHQ0dab25lVHlwZS5w",
            "cm90byK6AQoRR0NHTXNnUmVtb3ZlQ2FyZHMSFgoOY2FyZF9ndWlkX2xpc3QY",
            "AiADKA0SOgoGcmVhc29uGA0gASgOMiouV2VlZHdhY2tlci5TaGFyZWQuTmV0",
            "d29yay5Qcm90by5HQ0dSZWFzb24SFQoNY29udHJvbGxlcl9pZBgJIAEoDRI6",
            "CgR6b25lGA8gASgOMiwuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90",
            "by5HQ0dab25lVHlwZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGReasonReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGZoneTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGMsgRemoveCards), global::Weedwacker.Shared.Network.Proto.GCGMsgRemoveCards.Parser, new[]{ "CardGuidList", "Reason", "ControllerId", "Zone" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGMsgRemoveCards : pb::IMessage<GCGMsgRemoveCards>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGMsgRemoveCards> _parser = new pb::MessageParser<GCGMsgRemoveCards>(() => new GCGMsgRemoveCards());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGMsgRemoveCards> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGMsgRemoveCardsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgRemoveCards() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgRemoveCards(GCGMsgRemoveCards other) : this() {
      cardGuidList_ = other.cardGuidList_.Clone();
      reason_ = other.reason_;
      controllerId_ = other.controllerId_;
      zone_ = other.zone_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgRemoveCards Clone() {
      return new GCGMsgRemoveCards(this);
    }

    /// <summary>Field number for the "card_guid_list" field.</summary>
    public const int CardGuidListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_cardGuidList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> cardGuidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CardGuidList {
      get { return cardGuidList_; }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 13;
    private global::Weedwacker.Shared.Network.Proto.GCGReason reason_ = global::Weedwacker.Shared.Network.Proto.GCGReason.Default;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "controller_id" field.</summary>
    public const int ControllerIdFieldNumber = 9;
    private uint controllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ControllerId {
      get { return controllerId_; }
      set {
        controllerId_ = value;
      }
    }

    /// <summary>Field number for the "zone" field.</summary>
    public const int ZoneFieldNumber = 15;
    private global::Weedwacker.Shared.Network.Proto.GCGZoneType zone_ = global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGZoneType Zone {
      get { return zone_; }
      set {
        zone_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGMsgRemoveCards);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGMsgRemoveCards other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!cardGuidList_.Equals(other.cardGuidList_)) return false;
      if (Reason != other.Reason) return false;
      if (ControllerId != other.ControllerId) return false;
      if (Zone != other.Zone) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= cardGuidList_.GetHashCode();
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) hash ^= Reason.GetHashCode();
      if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
      if (Zone != global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid) hash ^= Zone.GetHashCode();
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
      cardGuidList_.WriteTo(output, _repeated_cardGuidList_codec);
      if (ControllerId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ControllerId);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Reason);
      }
      if (Zone != global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid) {
        output.WriteRawTag(120);
        output.WriteEnum((int) Zone);
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
      cardGuidList_.WriteTo(ref output, _repeated_cardGuidList_codec);
      if (ControllerId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ControllerId);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Reason);
      }
      if (Zone != global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid) {
        output.WriteRawTag(120);
        output.WriteEnum((int) Zone);
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
      size += cardGuidList_.CalculateSize(_repeated_cardGuidList_codec);
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (ControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
      }
      if (Zone != global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Zone);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGMsgRemoveCards other) {
      if (other == null) {
        return;
      }
      cardGuidList_.Add(other.cardGuidList_);
      if (other.Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        Reason = other.Reason;
      }
      if (other.ControllerId != 0) {
        ControllerId = other.ControllerId;
      }
      if (other.Zone != global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid) {
        Zone = other.Zone;
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
          case 18:
          case 16: {
            cardGuidList_.AddEntriesFrom(input, _repeated_cardGuidList_codec);
            break;
          }
          case 72: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 104: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GCGReason) input.ReadEnum();
            break;
          }
          case 120: {
            Zone = (global::Weedwacker.Shared.Network.Proto.GCGZoneType) input.ReadEnum();
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
          case 18:
          case 16: {
            cardGuidList_.AddEntriesFrom(ref input, _repeated_cardGuidList_codec);
            break;
          }
          case 72: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 104: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GCGReason) input.ReadEnum();
            break;
          }
          case 120: {
            Zone = (global::Weedwacker.Shared.Network.Proto.GCGZoneType) input.ReadEnum();
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
