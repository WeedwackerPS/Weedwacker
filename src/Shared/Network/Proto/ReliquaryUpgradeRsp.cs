// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReliquaryUpgradeRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ReliquaryUpgradeRsp.proto</summary>
  public static partial class ReliquaryUpgradeRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ReliquaryUpgradeRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReliquaryUpgradeRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlSZWxpcXVhcnlVcGdyYWRlUnNwLnByb3RvIr4BChNSZWxpcXVhcnlVcGdy",
            "YWRlUnNwEhwKFGN1cl9hcHBlbmRfcHJvcF9saXN0GA0gAygNEg8KB3JldGNv",
            "ZGUYCyABKAUSHQoVdGFyZ2V0X3JlbGlxdWFyeV9ndWlkGA4gASgEEhEKCWN1",
            "cl9sZXZlbBgCIAEoDRIRCglvbGRfbGV2ZWwYBiABKA0SHAoUb2xkX2FwcGVu",
            "ZF9wcm9wX2xpc3QYCiADKA0SFQoNcG93ZXJfdXBfcmF0ZRgBIAEoDUIiqgIf",
            "V2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ReliquaryUpgradeRsp), global::Weedwacker.Shared.Network.Proto.ReliquaryUpgradeRsp.Parser, new[]{ "CurAppendPropList", "Retcode", "TargetReliquaryGuid", "CurLevel", "OldLevel", "OldAppendPropList", "PowerUpRate" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 607;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class ReliquaryUpgradeRsp : pb::IMessage<ReliquaryUpgradeRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReliquaryUpgradeRsp> _parser = new pb::MessageParser<ReliquaryUpgradeRsp>(() => new ReliquaryUpgradeRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReliquaryUpgradeRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ReliquaryUpgradeRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReliquaryUpgradeRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReliquaryUpgradeRsp(ReliquaryUpgradeRsp other) : this() {
      curAppendPropList_ = other.curAppendPropList_.Clone();
      retcode_ = other.retcode_;
      targetReliquaryGuid_ = other.targetReliquaryGuid_;
      curLevel_ = other.curLevel_;
      oldLevel_ = other.oldLevel_;
      oldAppendPropList_ = other.oldAppendPropList_.Clone();
      powerUpRate_ = other.powerUpRate_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReliquaryUpgradeRsp Clone() {
      return new ReliquaryUpgradeRsp(this);
    }

    /// <summary>Field number for the "cur_append_prop_list" field.</summary>
    public const int CurAppendPropListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_curAppendPropList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> curAppendPropList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CurAppendPropList {
      get { return curAppendPropList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "target_reliquary_guid" field.</summary>
    public const int TargetReliquaryGuidFieldNumber = 14;
    private ulong targetReliquaryGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TargetReliquaryGuid {
      get { return targetReliquaryGuid_; }
      set {
        targetReliquaryGuid_ = value;
      }
    }

    /// <summary>Field number for the "cur_level" field.</summary>
    public const int CurLevelFieldNumber = 2;
    private uint curLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurLevel {
      get { return curLevel_; }
      set {
        curLevel_ = value;
      }
    }

    /// <summary>Field number for the "old_level" field.</summary>
    public const int OldLevelFieldNumber = 6;
    private uint oldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OldLevel {
      get { return oldLevel_; }
      set {
        oldLevel_ = value;
      }
    }

    /// <summary>Field number for the "old_append_prop_list" field.</summary>
    public const int OldAppendPropListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_oldAppendPropList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> oldAppendPropList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> OldAppendPropList {
      get { return oldAppendPropList_; }
    }

    /// <summary>Field number for the "power_up_rate" field.</summary>
    public const int PowerUpRateFieldNumber = 1;
    private uint powerUpRate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PowerUpRate {
      get { return powerUpRate_; }
      set {
        powerUpRate_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ReliquaryUpgradeRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReliquaryUpgradeRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!curAppendPropList_.Equals(other.curAppendPropList_)) return false;
      if (Retcode != other.Retcode) return false;
      if (TargetReliquaryGuid != other.TargetReliquaryGuid) return false;
      if (CurLevel != other.CurLevel) return false;
      if (OldLevel != other.OldLevel) return false;
      if(!oldAppendPropList_.Equals(other.oldAppendPropList_)) return false;
      if (PowerUpRate != other.PowerUpRate) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= curAppendPropList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (TargetReliquaryGuid != 0UL) hash ^= TargetReliquaryGuid.GetHashCode();
      if (CurLevel != 0) hash ^= CurLevel.GetHashCode();
      if (OldLevel != 0) hash ^= OldLevel.GetHashCode();
      hash ^= oldAppendPropList_.GetHashCode();
      if (PowerUpRate != 0) hash ^= PowerUpRate.GetHashCode();
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
      if (PowerUpRate != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PowerUpRate);
      }
      if (CurLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CurLevel);
      }
      if (OldLevel != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(OldLevel);
      }
      oldAppendPropList_.WriteTo(output, _repeated_oldAppendPropList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Retcode);
      }
      curAppendPropList_.WriteTo(output, _repeated_curAppendPropList_codec);
      if (TargetReliquaryGuid != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(TargetReliquaryGuid);
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
      if (PowerUpRate != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PowerUpRate);
      }
      if (CurLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CurLevel);
      }
      if (OldLevel != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(OldLevel);
      }
      oldAppendPropList_.WriteTo(ref output, _repeated_oldAppendPropList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Retcode);
      }
      curAppendPropList_.WriteTo(ref output, _repeated_curAppendPropList_codec);
      if (TargetReliquaryGuid != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(TargetReliquaryGuid);
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
      size += curAppendPropList_.CalculateSize(_repeated_curAppendPropList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (TargetReliquaryGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TargetReliquaryGuid);
      }
      if (CurLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurLevel);
      }
      if (OldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OldLevel);
      }
      size += oldAppendPropList_.CalculateSize(_repeated_oldAppendPropList_codec);
      if (PowerUpRate != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PowerUpRate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ReliquaryUpgradeRsp other) {
      if (other == null) {
        return;
      }
      curAppendPropList_.Add(other.curAppendPropList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.TargetReliquaryGuid != 0UL) {
        TargetReliquaryGuid = other.TargetReliquaryGuid;
      }
      if (other.CurLevel != 0) {
        CurLevel = other.CurLevel;
      }
      if (other.OldLevel != 0) {
        OldLevel = other.OldLevel;
      }
      oldAppendPropList_.Add(other.oldAppendPropList_);
      if (other.PowerUpRate != 0) {
        PowerUpRate = other.PowerUpRate;
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
          case 8: {
            PowerUpRate = input.ReadUInt32();
            break;
          }
          case 16: {
            CurLevel = input.ReadUInt32();
            break;
          }
          case 48: {
            OldLevel = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            oldAppendPropList_.AddEntriesFrom(input, _repeated_oldAppendPropList_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadInt32();
            break;
          }
          case 106:
          case 104: {
            curAppendPropList_.AddEntriesFrom(input, _repeated_curAppendPropList_codec);
            break;
          }
          case 112: {
            TargetReliquaryGuid = input.ReadUInt64();
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
          case 8: {
            PowerUpRate = input.ReadUInt32();
            break;
          }
          case 16: {
            CurLevel = input.ReadUInt32();
            break;
          }
          case 48: {
            OldLevel = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            oldAppendPropList_.AddEntriesFrom(ref input, _repeated_oldAppendPropList_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadInt32();
            break;
          }
          case 106:
          case 104: {
            curAppendPropList_.AddEntriesFrom(ref input, _repeated_curAppendPropList_codec);
            break;
          }
          case 112: {
            TargetReliquaryGuid = input.ReadUInt64();
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
