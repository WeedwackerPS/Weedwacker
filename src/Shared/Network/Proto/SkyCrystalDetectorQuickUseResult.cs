// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SkyCrystalDetectorQuickUseResult.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SkyCrystalDetectorQuickUseResult.proto</summary>
  public static partial class SkyCrystalDetectorQuickUseResultReflection {

    #region Descriptor
    /// <summary>File descriptor for SkyCrystalDetectorQuickUseResult.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SkyCrystalDetectorQuickUseResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZTa3lDcnlzdGFsRGV0ZWN0b3JRdWlja1VzZVJlc3VsdC5wcm90bxIfV2Vl",
            "ZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90bxocU2t5Q3J5c3RhbERldGVj",
            "dG9yRGF0YS5wcm90byKPAQogU2t5Q3J5c3RhbERldGVjdG9yUXVpY2tVc2VS",
            "ZXN1bHQSDwoHcmV0Y29kZRgCIAEoBRJaChlza3lfY3J5c3RhbF9kZXRlY3Rv",
            "cl9kYXRhGAQgASgLMjcuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90",
            "by5Ta3lDcnlzdGFsRGV0ZWN0b3JEYXRhYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.SkyCrystalDetectorDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SkyCrystalDetectorQuickUseResult), global::Weedwacker.Shared.Network.Proto.SkyCrystalDetectorQuickUseResult.Parser, new[]{ "Retcode", "SkyCrystalDetectorData" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SkyCrystalDetectorQuickUseResult : pb::IMessage<SkyCrystalDetectorQuickUseResult>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SkyCrystalDetectorQuickUseResult> _parser = new pb::MessageParser<SkyCrystalDetectorQuickUseResult>(() => new SkyCrystalDetectorQuickUseResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SkyCrystalDetectorQuickUseResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SkyCrystalDetectorQuickUseResultReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkyCrystalDetectorQuickUseResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkyCrystalDetectorQuickUseResult(SkyCrystalDetectorQuickUseResult other) : this() {
      retcode_ = other.retcode_;
      skyCrystalDetectorData_ = other.skyCrystalDetectorData_ != null ? other.skyCrystalDetectorData_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkyCrystalDetectorQuickUseResult Clone() {
      return new SkyCrystalDetectorQuickUseResult(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 2;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "sky_crystal_detector_data" field.</summary>
    public const int SkyCrystalDetectorDataFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.SkyCrystalDetectorData skyCrystalDetectorData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.SkyCrystalDetectorData SkyCrystalDetectorData {
      get { return skyCrystalDetectorData_; }
      set {
        skyCrystalDetectorData_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SkyCrystalDetectorQuickUseResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SkyCrystalDetectorQuickUseResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(SkyCrystalDetectorData, other.SkyCrystalDetectorData)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (skyCrystalDetectorData_ != null) hash ^= SkyCrystalDetectorData.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Retcode);
      }
      if (skyCrystalDetectorData_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(SkyCrystalDetectorData);
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
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Retcode);
      }
      if (skyCrystalDetectorData_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(SkyCrystalDetectorData);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (skyCrystalDetectorData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SkyCrystalDetectorData);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SkyCrystalDetectorQuickUseResult other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.skyCrystalDetectorData_ != null) {
        if (skyCrystalDetectorData_ == null) {
          SkyCrystalDetectorData = new global::Weedwacker.Shared.Network.Proto.SkyCrystalDetectorData();
        }
        SkyCrystalDetectorData.MergeFrom(other.SkyCrystalDetectorData);
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
            Retcode = input.ReadInt32();
            break;
          }
          case 34: {
            if (skyCrystalDetectorData_ == null) {
              SkyCrystalDetectorData = new global::Weedwacker.Shared.Network.Proto.SkyCrystalDetectorData();
            }
            input.ReadMessage(SkyCrystalDetectorData);
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
            Retcode = input.ReadInt32();
            break;
          }
          case 34: {
            if (skyCrystalDetectorData_ == null) {
              SkyCrystalDetectorData = new global::Weedwacker.Shared.Network.Proto.SkyCrystalDetectorData();
            }
            input.ReadMessage(SkyCrystalDetectorData);
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
