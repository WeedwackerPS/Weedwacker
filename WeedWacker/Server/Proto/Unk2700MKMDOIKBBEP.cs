// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_MKMDOIKBBEP.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_MKMDOIKBBEP.proto</summary>
  public static partial class Unk2700MKMDOIKBBEPReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_MKMDOIKBBEP.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700MKMDOIKBBEPReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX01LTURPSUtCQkVQLnByb3RvGhlVbmsyNzAwX0hJSEtHTUxM",
            "T0dELnByb3RvInYKE1VuazI3MDBfTUtNRE9JS0JCRVASMQoTVW5rMjcwMF9C",
            "QUJFR0lHRUVJQhgKIAEoCzIULlVuazI3MDBfSElIS0dNTExPR0QSDwoHcmV0",
            "Y29kZRgFIAEoBRIbChNVbmsyNzAwX0RKQVBIS0FMQUhBGAEgASgIQhqqAhdX",
            "ZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.Unk2700HIHKGMLLOGDReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2700_MKMDOIKBBEP), global::Weedwacker.Server.Proto.Unk2700_MKMDOIKBBEP.Parser, new[]{ "Unk2700BABEGIGEEIB", "Retcode", "Unk2700DJAPHKALAHA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8026
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk2700_MKMDOIKBBEP : pb::IMessage<Unk2700_MKMDOIKBBEP>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_MKMDOIKBBEP> _parser = new pb::MessageParser<Unk2700_MKMDOIKBBEP>(() => new Unk2700_MKMDOIKBBEP());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_MKMDOIKBBEP> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2700MKMDOIKBBEPReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_MKMDOIKBBEP() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_MKMDOIKBBEP(Unk2700_MKMDOIKBBEP other) : this() {
      unk2700BABEGIGEEIB_ = other.unk2700BABEGIGEEIB_ != null ? other.unk2700BABEGIGEEIB_.Clone() : null;
      retcode_ = other.retcode_;
      unk2700DJAPHKALAHA_ = other.unk2700DJAPHKALAHA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_MKMDOIKBBEP Clone() {
      return new Unk2700_MKMDOIKBBEP(this);
    }

    /// <summary>Field number for the "Unk2700_BABEGIGEEIB" field.</summary>
    public const int Unk2700BABEGIGEEIBFieldNumber = 10;
    private global::Weedwacker.Server.Proto.Unk2700_HIHKGMLLOGD unk2700BABEGIGEEIB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Unk2700_HIHKGMLLOGD Unk2700BABEGIGEEIB {
      get { return unk2700BABEGIGEEIB_; }
      set {
        unk2700BABEGIGEEIB_ = value;
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

    /// <summary>Field number for the "Unk2700_DJAPHKALAHA" field.</summary>
    public const int Unk2700DJAPHKALAHAFieldNumber = 1;
    private bool unk2700DJAPHKALAHA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700DJAPHKALAHA {
      get { return unk2700DJAPHKALAHA_; }
      set {
        unk2700DJAPHKALAHA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_MKMDOIKBBEP);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_MKMDOIKBBEP other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Unk2700BABEGIGEEIB, other.Unk2700BABEGIGEEIB)) return false;
      if (Retcode != other.Retcode) return false;
      if (Unk2700DJAPHKALAHA != other.Unk2700DJAPHKALAHA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (unk2700BABEGIGEEIB_ != null) hash ^= Unk2700BABEGIGEEIB.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Unk2700DJAPHKALAHA != false) hash ^= Unk2700DJAPHKALAHA.GetHashCode();
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
      if (Unk2700DJAPHKALAHA != false) {
        output.WriteRawTag(8);
        output.WriteBool(Unk2700DJAPHKALAHA);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Retcode);
      }
      if (unk2700BABEGIGEEIB_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Unk2700BABEGIGEEIB);
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
      if (Unk2700DJAPHKALAHA != false) {
        output.WriteRawTag(8);
        output.WriteBool(Unk2700DJAPHKALAHA);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Retcode);
      }
      if (unk2700BABEGIGEEIB_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Unk2700BABEGIGEEIB);
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
      if (unk2700BABEGIGEEIB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk2700BABEGIGEEIB);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (Unk2700DJAPHKALAHA != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_MKMDOIKBBEP other) {
      if (other == null) {
        return;
      }
      if (other.unk2700BABEGIGEEIB_ != null) {
        if (unk2700BABEGIGEEIB_ == null) {
          Unk2700BABEGIGEEIB = new global::Weedwacker.Server.Proto.Unk2700_HIHKGMLLOGD();
        }
        Unk2700BABEGIGEEIB.MergeFrom(other.Unk2700BABEGIGEEIB);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Unk2700DJAPHKALAHA != false) {
        Unk2700DJAPHKALAHA = other.Unk2700DJAPHKALAHA;
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
            Unk2700DJAPHKALAHA = input.ReadBool();
            break;
          }
          case 40: {
            Retcode = input.ReadInt32();
            break;
          }
          case 82: {
            if (unk2700BABEGIGEEIB_ == null) {
              Unk2700BABEGIGEEIB = new global::Weedwacker.Server.Proto.Unk2700_HIHKGMLLOGD();
            }
            input.ReadMessage(Unk2700BABEGIGEEIB);
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
            Unk2700DJAPHKALAHA = input.ReadBool();
            break;
          }
          case 40: {
            Retcode = input.ReadInt32();
            break;
          }
          case 82: {
            if (unk2700BABEGIGEEIB_ == null) {
              Unk2700BABEGIGEEIB = new global::Weedwacker.Server.Proto.Unk2700_HIHKGMLLOGD();
            }
            input.ReadMessage(Unk2700BABEGIGEEIB);
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