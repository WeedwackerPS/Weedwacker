// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk3000_EDGJEBLODLF.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk3000_EDGJEBLODLF.proto</summary>
  public static partial class Unk3000EDGJEBLODLFReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk3000_EDGJEBLODLF.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk3000EDGJEBLODLFReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmszMDAwX0VER0pFQkxPRExGLnByb3RvIn0KE1VuazMwMDBfRURHSkVC",
            "TE9ETEYSGwoTVW5rMzAwMF9DRkRNTEdLTkxLTBgCIAEoDRIbChNVbmszMDAw",
            "X0NJT0xFR0VIREFDGA0gASgNEhsKE1VuazMwMDBfRkRHRkFIQU9FUFAYBSAB",
            "KA0SDwoHcmV0Y29kZRgIIAEoBUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0",
            "d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk3000_EDGJEBLODLF), global::Weedwacker.Shared.Network.Proto.Unk3000_EDGJEBLODLF.Parser, new[]{ "Unk3000CFDMLGKNLKL", "Unk3000CIOLEGEHDAC", "Unk3000FDGFAHAOEPP", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 416
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk3000_EDGJEBLODLF : pb::IMessage<Unk3000_EDGJEBLODLF>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk3000_EDGJEBLODLF> _parser = new pb::MessageParser<Unk3000_EDGJEBLODLF>(() => new Unk3000_EDGJEBLODLF());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk3000_EDGJEBLODLF> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk3000EDGJEBLODLFReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_EDGJEBLODLF() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_EDGJEBLODLF(Unk3000_EDGJEBLODLF other) : this() {
      unk3000CFDMLGKNLKL_ = other.unk3000CFDMLGKNLKL_;
      unk3000CIOLEGEHDAC_ = other.unk3000CIOLEGEHDAC_;
      unk3000FDGFAHAOEPP_ = other.unk3000FDGFAHAOEPP_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_EDGJEBLODLF Clone() {
      return new Unk3000_EDGJEBLODLF(this);
    }

    /// <summary>Field number for the "Unk3000_CFDMLGKNLKL" field.</summary>
    public const int Unk3000CFDMLGKNLKLFieldNumber = 2;
    private uint unk3000CFDMLGKNLKL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3000CFDMLGKNLKL {
      get { return unk3000CFDMLGKNLKL_; }
      set {
        unk3000CFDMLGKNLKL_ = value;
      }
    }

    /// <summary>Field number for the "Unk3000_CIOLEGEHDAC" field.</summary>
    public const int Unk3000CIOLEGEHDACFieldNumber = 13;
    private uint unk3000CIOLEGEHDAC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3000CIOLEGEHDAC {
      get { return unk3000CIOLEGEHDAC_; }
      set {
        unk3000CIOLEGEHDAC_ = value;
      }
    }

    /// <summary>Field number for the "Unk3000_FDGFAHAOEPP" field.</summary>
    public const int Unk3000FDGFAHAOEPPFieldNumber = 5;
    private uint unk3000FDGFAHAOEPP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3000FDGFAHAOEPP {
      get { return unk3000FDGFAHAOEPP_; }
      set {
        unk3000FDGFAHAOEPP_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk3000_EDGJEBLODLF);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk3000_EDGJEBLODLF other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3000CFDMLGKNLKL != other.Unk3000CFDMLGKNLKL) return false;
      if (Unk3000CIOLEGEHDAC != other.Unk3000CIOLEGEHDAC) return false;
      if (Unk3000FDGFAHAOEPP != other.Unk3000FDGFAHAOEPP) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3000CFDMLGKNLKL != 0) hash ^= Unk3000CFDMLGKNLKL.GetHashCode();
      if (Unk3000CIOLEGEHDAC != 0) hash ^= Unk3000CIOLEGEHDAC.GetHashCode();
      if (Unk3000FDGFAHAOEPP != 0) hash ^= Unk3000FDGFAHAOEPP.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (Unk3000CFDMLGKNLKL != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3000CFDMLGKNLKL);
      }
      if (Unk3000FDGFAHAOEPP != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3000FDGFAHAOEPP);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (Unk3000CIOLEGEHDAC != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3000CIOLEGEHDAC);
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
      if (Unk3000CFDMLGKNLKL != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3000CFDMLGKNLKL);
      }
      if (Unk3000FDGFAHAOEPP != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3000FDGFAHAOEPP);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (Unk3000CIOLEGEHDAC != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3000CIOLEGEHDAC);
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
      if (Unk3000CFDMLGKNLKL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3000CFDMLGKNLKL);
      }
      if (Unk3000CIOLEGEHDAC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3000CIOLEGEHDAC);
      }
      if (Unk3000FDGFAHAOEPP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3000FDGFAHAOEPP);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk3000_EDGJEBLODLF other) {
      if (other == null) {
        return;
      }
      if (other.Unk3000CFDMLGKNLKL != 0) {
        Unk3000CFDMLGKNLKL = other.Unk3000CFDMLGKNLKL;
      }
      if (other.Unk3000CIOLEGEHDAC != 0) {
        Unk3000CIOLEGEHDAC = other.Unk3000CIOLEGEHDAC;
      }
      if (other.Unk3000FDGFAHAOEPP != 0) {
        Unk3000FDGFAHAOEPP = other.Unk3000FDGFAHAOEPP;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
            Unk3000CFDMLGKNLKL = input.ReadUInt32();
            break;
          }
          case 40: {
            Unk3000FDGFAHAOEPP = input.ReadUInt32();
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 104: {
            Unk3000CIOLEGEHDAC = input.ReadUInt32();
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
            Unk3000CFDMLGKNLKL = input.ReadUInt32();
            break;
          }
          case 40: {
            Unk3000FDGFAHAOEPP = input.ReadUInt32();
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 104: {
            Unk3000CIOLEGEHDAC = input.ReadUInt32();
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