// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ActivityCondStateChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ActivityCondStateChangeNotify.proto</summary>
  public static partial class ActivityCondStateChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ActivityCondStateChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ActivityCondStateChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNBY3Rpdml0eUNvbmRTdGF0ZUNoYW5nZU5vdGlmeS5wcm90bxIfV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90bxoQVWludDMyUGFpci5wcm90byKB",
            "AgodQWN0aXZpdHlDb25kU3RhdGVDaGFuZ2VOb3RpZnkSEwoLYWN0aXZpdHlf",
            "aWQYBSABKA0SEwoLc2NoZWR1bGVfaWQYDiABKA0SGwoTVW5rMzMwMF9IS0tO",
            "SUhOQkhBRRgBIAMoDRIbChNVbmszMzAwX0JHTklCTEtDUENBGAQgAygNEh4K",
            "FmFjdGl2YXRlZF9zYWxlX2lkX2xpc3QYCCADKA0SXAonZGlzYWJsZV90cmFu",
            "c2Zlcl9wb2ludF9pbnRlcmFjdGlvbl9saXN0GAsgAygLMisuV2VlZHdhY2tl",
            "ci5TaGFyZWQuTmV0d29yay5Qcm90by5VaW50MzJQYWlyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Uint32PairReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ActivityCondStateChangeNotify), global::Weedwacker.Shared.Network.Proto.ActivityCondStateChangeNotify.Parser, new[]{ "ActivityId", "ScheduleId", "Unk3300HKKNIHNBHAE", "Unk3300BGNIBLKCPCA", "ActivatedSaleIdList", "DisableTransferPointInteractionList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 2194;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class ActivityCondStateChangeNotify : pb::IMessage<ActivityCondStateChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ActivityCondStateChangeNotify> _parser = new pb::MessageParser<ActivityCondStateChangeNotify>(() => new ActivityCondStateChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ActivityCondStateChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ActivityCondStateChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityCondStateChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityCondStateChangeNotify(ActivityCondStateChangeNotify other) : this() {
      activityId_ = other.activityId_;
      scheduleId_ = other.scheduleId_;
      unk3300HKKNIHNBHAE_ = other.unk3300HKKNIHNBHAE_.Clone();
      unk3300BGNIBLKCPCA_ = other.unk3300BGNIBLKCPCA_.Clone();
      activatedSaleIdList_ = other.activatedSaleIdList_.Clone();
      disableTransferPointInteractionList_ = other.disableTransferPointInteractionList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityCondStateChangeNotify Clone() {
      return new ActivityCondStateChangeNotify(this);
    }

    /// <summary>Field number for the "activity_id" field.</summary>
    public const int ActivityIdFieldNumber = 5;
    private uint activityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ActivityId {
      get { return activityId_; }
      set {
        activityId_ = value;
      }
    }

    /// <summary>Field number for the "schedule_id" field.</summary>
    public const int ScheduleIdFieldNumber = 14;
    private uint scheduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScheduleId {
      get { return scheduleId_; }
      set {
        scheduleId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_HKKNIHNBHAE" field.</summary>
    public const int Unk3300HKKNIHNBHAEFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300HKKNIHNBHAE_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> unk3300HKKNIHNBHAE_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300HKKNIHNBHAE {
      get { return unk3300HKKNIHNBHAE_; }
    }

    /// <summary>Field number for the "Unk3300_BGNIBLKCPCA" field.</summary>
    public const int Unk3300BGNIBLKCPCAFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300BGNIBLKCPCA_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> unk3300BGNIBLKCPCA_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300BGNIBLKCPCA {
      get { return unk3300BGNIBLKCPCA_; }
    }

    /// <summary>Field number for the "activated_sale_id_list" field.</summary>
    public const int ActivatedSaleIdListFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_activatedSaleIdList_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> activatedSaleIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ActivatedSaleIdList {
      get { return activatedSaleIdList_; }
    }

    /// <summary>Field number for the "disable_transfer_point_interaction_list" field.</summary>
    public const int DisableTransferPointInteractionListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.Uint32Pair> _repeated_disableTransferPointInteractionList_codec
        = pb::FieldCodec.ForMessage(90, global::Weedwacker.Shared.Network.Proto.Uint32Pair.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Uint32Pair> disableTransferPointInteractionList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Uint32Pair>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Uint32Pair> DisableTransferPointInteractionList {
      get { return disableTransferPointInteractionList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ActivityCondStateChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ActivityCondStateChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ActivityId != other.ActivityId) return false;
      if (ScheduleId != other.ScheduleId) return false;
      if(!unk3300HKKNIHNBHAE_.Equals(other.unk3300HKKNIHNBHAE_)) return false;
      if(!unk3300BGNIBLKCPCA_.Equals(other.unk3300BGNIBLKCPCA_)) return false;
      if(!activatedSaleIdList_.Equals(other.activatedSaleIdList_)) return false;
      if(!disableTransferPointInteractionList_.Equals(other.disableTransferPointInteractionList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ActivityId != 0) hash ^= ActivityId.GetHashCode();
      if (ScheduleId != 0) hash ^= ScheduleId.GetHashCode();
      hash ^= unk3300HKKNIHNBHAE_.GetHashCode();
      hash ^= unk3300BGNIBLKCPCA_.GetHashCode();
      hash ^= activatedSaleIdList_.GetHashCode();
      hash ^= disableTransferPointInteractionList_.GetHashCode();
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
      unk3300HKKNIHNBHAE_.WriteTo(output, _repeated_unk3300HKKNIHNBHAE_codec);
      unk3300BGNIBLKCPCA_.WriteTo(output, _repeated_unk3300BGNIBLKCPCA_codec);
      if (ActivityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ActivityId);
      }
      activatedSaleIdList_.WriteTo(output, _repeated_activatedSaleIdList_codec);
      disableTransferPointInteractionList_.WriteTo(output, _repeated_disableTransferPointInteractionList_codec);
      if (ScheduleId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ScheduleId);
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
      unk3300HKKNIHNBHAE_.WriteTo(ref output, _repeated_unk3300HKKNIHNBHAE_codec);
      unk3300BGNIBLKCPCA_.WriteTo(ref output, _repeated_unk3300BGNIBLKCPCA_codec);
      if (ActivityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ActivityId);
      }
      activatedSaleIdList_.WriteTo(ref output, _repeated_activatedSaleIdList_codec);
      disableTransferPointInteractionList_.WriteTo(ref output, _repeated_disableTransferPointInteractionList_codec);
      if (ScheduleId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ScheduleId);
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
      if (ActivityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ActivityId);
      }
      if (ScheduleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScheduleId);
      }
      size += unk3300HKKNIHNBHAE_.CalculateSize(_repeated_unk3300HKKNIHNBHAE_codec);
      size += unk3300BGNIBLKCPCA_.CalculateSize(_repeated_unk3300BGNIBLKCPCA_codec);
      size += activatedSaleIdList_.CalculateSize(_repeated_activatedSaleIdList_codec);
      size += disableTransferPointInteractionList_.CalculateSize(_repeated_disableTransferPointInteractionList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ActivityCondStateChangeNotify other) {
      if (other == null) {
        return;
      }
      if (other.ActivityId != 0) {
        ActivityId = other.ActivityId;
      }
      if (other.ScheduleId != 0) {
        ScheduleId = other.ScheduleId;
      }
      unk3300HKKNIHNBHAE_.Add(other.unk3300HKKNIHNBHAE_);
      unk3300BGNIBLKCPCA_.Add(other.unk3300BGNIBLKCPCA_);
      activatedSaleIdList_.Add(other.activatedSaleIdList_);
      disableTransferPointInteractionList_.Add(other.disableTransferPointInteractionList_);
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
            unk3300HKKNIHNBHAE_.AddEntriesFrom(input, _repeated_unk3300HKKNIHNBHAE_codec);
            break;
          }
          case 34:
          case 32: {
            unk3300BGNIBLKCPCA_.AddEntriesFrom(input, _repeated_unk3300BGNIBLKCPCA_codec);
            break;
          }
          case 40: {
            ActivityId = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            activatedSaleIdList_.AddEntriesFrom(input, _repeated_activatedSaleIdList_codec);
            break;
          }
          case 90: {
            disableTransferPointInteractionList_.AddEntriesFrom(input, _repeated_disableTransferPointInteractionList_codec);
            break;
          }
          case 112: {
            ScheduleId = input.ReadUInt32();
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
            unk3300HKKNIHNBHAE_.AddEntriesFrom(ref input, _repeated_unk3300HKKNIHNBHAE_codec);
            break;
          }
          case 34:
          case 32: {
            unk3300BGNIBLKCPCA_.AddEntriesFrom(ref input, _repeated_unk3300BGNIBLKCPCA_codec);
            break;
          }
          case 40: {
            ActivityId = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            activatedSaleIdList_.AddEntriesFrom(ref input, _repeated_activatedSaleIdList_codec);
            break;
          }
          case 90: {
            disableTransferPointInteractionList_.AddEntriesFrom(ref input, _repeated_disableTransferPointInteractionList_codec);
            break;
          }
          case 112: {
            ScheduleId = input.ReadUInt32();
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
