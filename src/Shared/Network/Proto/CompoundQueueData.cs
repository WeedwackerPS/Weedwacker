// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CompoundQueueData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CompoundQueueData.proto</summary>
  public static partial class CompoundQueueDataReflection {

    #region Descriptor
    /// <summary>File descriptor for CompoundQueueData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompoundQueueDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdDb21wb3VuZFF1ZXVlRGF0YS5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90byJ/ChFDb21wb3VuZFF1ZXVlRGF0YRIbChNVbmszMzAw",
            "X05DRUhKQUFIT0tNGAUgASgNEhsKE1VuazMzMDBfQ09NSUdDTUlQTEUYDiAB",
            "KA0SGwoTVW5rMzMwMF9KSEpOT1BDUFBBRBgKIAEoDRITCgtjb21wb3VuZF9p",
            "ZBgMIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CompoundQueueData), global::Weedwacker.Shared.Network.Proto.CompoundQueueData.Parser, new[]{ "Unk3300NCEHJAAHOKM", "Unk3300COMIGCMIPLE", "Unk3300JHJNOPCPPAD", "CompoundId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CompoundQueueData : pb::IMessage<CompoundQueueData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CompoundQueueData> _parser = new pb::MessageParser<CompoundQueueData>(() => new CompoundQueueData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CompoundQueueData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CompoundQueueDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CompoundQueueData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CompoundQueueData(CompoundQueueData other) : this() {
      unk3300NCEHJAAHOKM_ = other.unk3300NCEHJAAHOKM_;
      unk3300COMIGCMIPLE_ = other.unk3300COMIGCMIPLE_;
      unk3300JHJNOPCPPAD_ = other.unk3300JHJNOPCPPAD_;
      compoundId_ = other.compoundId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CompoundQueueData Clone() {
      return new CompoundQueueData(this);
    }

    /// <summary>Field number for the "Unk3300_NCEHJAAHOKM" field.</summary>
    public const int Unk3300NCEHJAAHOKMFieldNumber = 5;
    private uint unk3300NCEHJAAHOKM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300NCEHJAAHOKM {
      get { return unk3300NCEHJAAHOKM_; }
      set {
        unk3300NCEHJAAHOKM_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_COMIGCMIPLE" field.</summary>
    public const int Unk3300COMIGCMIPLEFieldNumber = 14;
    private uint unk3300COMIGCMIPLE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300COMIGCMIPLE {
      get { return unk3300COMIGCMIPLE_; }
      set {
        unk3300COMIGCMIPLE_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_JHJNOPCPPAD" field.</summary>
    public const int Unk3300JHJNOPCPPADFieldNumber = 10;
    private uint unk3300JHJNOPCPPAD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300JHJNOPCPPAD {
      get { return unk3300JHJNOPCPPAD_; }
      set {
        unk3300JHJNOPCPPAD_ = value;
      }
    }

    /// <summary>Field number for the "compound_id" field.</summary>
    public const int CompoundIdFieldNumber = 12;
    private uint compoundId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CompoundId {
      get { return compoundId_; }
      set {
        compoundId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CompoundQueueData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CompoundQueueData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300NCEHJAAHOKM != other.Unk3300NCEHJAAHOKM) return false;
      if (Unk3300COMIGCMIPLE != other.Unk3300COMIGCMIPLE) return false;
      if (Unk3300JHJNOPCPPAD != other.Unk3300JHJNOPCPPAD) return false;
      if (CompoundId != other.CompoundId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300NCEHJAAHOKM != 0) hash ^= Unk3300NCEHJAAHOKM.GetHashCode();
      if (Unk3300COMIGCMIPLE != 0) hash ^= Unk3300COMIGCMIPLE.GetHashCode();
      if (Unk3300JHJNOPCPPAD != 0) hash ^= Unk3300JHJNOPCPPAD.GetHashCode();
      if (CompoundId != 0) hash ^= CompoundId.GetHashCode();
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
      if (Unk3300NCEHJAAHOKM != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300NCEHJAAHOKM);
      }
      if (Unk3300JHJNOPCPPAD != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300JHJNOPCPPAD);
      }
      if (CompoundId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CompoundId);
      }
      if (Unk3300COMIGCMIPLE != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3300COMIGCMIPLE);
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
      if (Unk3300NCEHJAAHOKM != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300NCEHJAAHOKM);
      }
      if (Unk3300JHJNOPCPPAD != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300JHJNOPCPPAD);
      }
      if (CompoundId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CompoundId);
      }
      if (Unk3300COMIGCMIPLE != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3300COMIGCMIPLE);
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
      if (Unk3300NCEHJAAHOKM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300NCEHJAAHOKM);
      }
      if (Unk3300COMIGCMIPLE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300COMIGCMIPLE);
      }
      if (Unk3300JHJNOPCPPAD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300JHJNOPCPPAD);
      }
      if (CompoundId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CompoundId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CompoundQueueData other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300NCEHJAAHOKM != 0) {
        Unk3300NCEHJAAHOKM = other.Unk3300NCEHJAAHOKM;
      }
      if (other.Unk3300COMIGCMIPLE != 0) {
        Unk3300COMIGCMIPLE = other.Unk3300COMIGCMIPLE;
      }
      if (other.Unk3300JHJNOPCPPAD != 0) {
        Unk3300JHJNOPCPPAD = other.Unk3300JHJNOPCPPAD;
      }
      if (other.CompoundId != 0) {
        CompoundId = other.CompoundId;
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
          case 40: {
            Unk3300NCEHJAAHOKM = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300JHJNOPCPPAD = input.ReadUInt32();
            break;
          }
          case 96: {
            CompoundId = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300COMIGCMIPLE = input.ReadUInt32();
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
          case 40: {
            Unk3300NCEHJAAHOKM = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300JHJNOPCPPAD = input.ReadUInt32();
            break;
          }
          case 96: {
            CompoundId = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300COMIGCMIPLE = input.ReadUInt32();
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
