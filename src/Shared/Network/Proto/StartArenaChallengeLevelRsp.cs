// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartArenaChallengeLevelRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from StartArenaChallengeLevelRsp.proto</summary>
  public static partial class StartArenaChallengeLevelRspReflection {

    #region Descriptor
    /// <summary>File descriptor for StartArenaChallengeLevelRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartArenaChallengeLevelRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFTdGFydEFyZW5hQ2hhbGxlbmdlTGV2ZWxSc3AucHJvdG8SH1dlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8iggEKG1N0YXJ0QXJlbmFDaGFsbGVu",
            "Z2VMZXZlbFJzcBIbChNVbmszMzAwX0ZERk5GTEFLT05HGAQgASgNEg8KB3Jl",
            "dGNvZGUYBSABKAUSGwoTVW5rMzMwMF9EQkhBR0hNTUxBSRgNIAEoDRIYChBn",
            "YWRnZXRfZW50aXR5X2lkGAogASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.StartArenaChallengeLevelRsp), global::Weedwacker.Shared.Network.Proto.StartArenaChallengeLevelRsp.Parser, new[]{ "Unk3300FDFNFLAKONG", "Retcode", "Unk3300DBHAGHMMLAI", "GadgetEntityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 2171;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class StartArenaChallengeLevelRsp : pb::IMessage<StartArenaChallengeLevelRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartArenaChallengeLevelRsp> _parser = new pb::MessageParser<StartArenaChallengeLevelRsp>(() => new StartArenaChallengeLevelRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartArenaChallengeLevelRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.StartArenaChallengeLevelRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartArenaChallengeLevelRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartArenaChallengeLevelRsp(StartArenaChallengeLevelRsp other) : this() {
      unk3300FDFNFLAKONG_ = other.unk3300FDFNFLAKONG_;
      retcode_ = other.retcode_;
      unk3300DBHAGHMMLAI_ = other.unk3300DBHAGHMMLAI_;
      gadgetEntityId_ = other.gadgetEntityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartArenaChallengeLevelRsp Clone() {
      return new StartArenaChallengeLevelRsp(this);
    }

    /// <summary>Field number for the "Unk3300_FDFNFLAKONG" field.</summary>
    public const int Unk3300FDFNFLAKONGFieldNumber = 4;
    private uint unk3300FDFNFLAKONG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300FDFNFLAKONG {
      get { return unk3300FDFNFLAKONG_; }
      set {
        unk3300FDFNFLAKONG_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 5;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_DBHAGHMMLAI" field.</summary>
    public const int Unk3300DBHAGHMMLAIFieldNumber = 13;
    private uint unk3300DBHAGHMMLAI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300DBHAGHMMLAI {
      get { return unk3300DBHAGHMMLAI_; }
      set {
        unk3300DBHAGHMMLAI_ = value;
      }
    }

    /// <summary>Field number for the "gadget_entity_id" field.</summary>
    public const int GadgetEntityIdFieldNumber = 10;
    private uint gadgetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetEntityId {
      get { return gadgetEntityId_; }
      set {
        gadgetEntityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartArenaChallengeLevelRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartArenaChallengeLevelRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300FDFNFLAKONG != other.Unk3300FDFNFLAKONG) return false;
      if (Retcode != other.Retcode) return false;
      if (Unk3300DBHAGHMMLAI != other.Unk3300DBHAGHMMLAI) return false;
      if (GadgetEntityId != other.GadgetEntityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300FDFNFLAKONG != 0) hash ^= Unk3300FDFNFLAKONG.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Unk3300DBHAGHMMLAI != 0) hash ^= Unk3300DBHAGHMMLAI.GetHashCode();
      if (GadgetEntityId != 0) hash ^= GadgetEntityId.GetHashCode();
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
      if (Unk3300FDFNFLAKONG != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300FDFNFLAKONG);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Retcode);
      }
      if (GadgetEntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GadgetEntityId);
      }
      if (Unk3300DBHAGHMMLAI != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300DBHAGHMMLAI);
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
      if (Unk3300FDFNFLAKONG != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300FDFNFLAKONG);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Retcode);
      }
      if (GadgetEntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GadgetEntityId);
      }
      if (Unk3300DBHAGHMMLAI != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300DBHAGHMMLAI);
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
      if (Unk3300FDFNFLAKONG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300FDFNFLAKONG);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (Unk3300DBHAGHMMLAI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300DBHAGHMMLAI);
      }
      if (GadgetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetEntityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartArenaChallengeLevelRsp other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300FDFNFLAKONG != 0) {
        Unk3300FDFNFLAKONG = other.Unk3300FDFNFLAKONG;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Unk3300DBHAGHMMLAI != 0) {
        Unk3300DBHAGHMMLAI = other.Unk3300DBHAGHMMLAI;
      }
      if (other.GadgetEntityId != 0) {
        GadgetEntityId = other.GadgetEntityId;
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
          case 32: {
            Unk3300FDFNFLAKONG = input.ReadUInt32();
            break;
          }
          case 40: {
            Retcode = input.ReadInt32();
            break;
          }
          case 80: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk3300DBHAGHMMLAI = input.ReadUInt32();
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
          case 32: {
            Unk3300FDFNFLAKONG = input.ReadUInt32();
            break;
          }
          case 40: {
            Retcode = input.ReadInt32();
            break;
          }
          case 80: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk3300DBHAGHMMLAI = input.ReadUInt32();
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
