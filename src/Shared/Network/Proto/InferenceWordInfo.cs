// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InferenceWordInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from InferenceWordInfo.proto</summary>
  public static partial class InferenceWordInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for InferenceWordInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InferenceWordInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdJbmZlcmVuY2VXb3JkSW5mby5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90byKWAQoRSW5mZXJlbmNlV29yZEluZm8SGwoTVW5rMzMw",
            "MF9CRk9HS09ISUVFShgMIAEoCBIZChF1bmxvY2tfYnlfd29yZF9pZBgLIAEo",
            "DRIbChNVbmszMzAwX1BLQkNBT0hHTkxNGAogASgIEg8KB3dvcmRfaWQYAiAB",
            "KA0SGwoTVW5rMzMwMF9KUEhMRUNPSUdLRhgDIAEoCGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.InferenceWordInfo), global::Weedwacker.Shared.Network.Proto.InferenceWordInfo.Parser, new[]{ "Unk3300BFOGKOHIEEJ", "UnlockByWordId", "Unk3300PKBCAOHGNLM", "WordId", "Unk3300JPHLECOIGKF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InferenceWordInfo : pb::IMessage<InferenceWordInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InferenceWordInfo> _parser = new pb::MessageParser<InferenceWordInfo>(() => new InferenceWordInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InferenceWordInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.InferenceWordInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InferenceWordInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InferenceWordInfo(InferenceWordInfo other) : this() {
      unk3300BFOGKOHIEEJ_ = other.unk3300BFOGKOHIEEJ_;
      unlockByWordId_ = other.unlockByWordId_;
      unk3300PKBCAOHGNLM_ = other.unk3300PKBCAOHGNLM_;
      wordId_ = other.wordId_;
      unk3300JPHLECOIGKF_ = other.unk3300JPHLECOIGKF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InferenceWordInfo Clone() {
      return new InferenceWordInfo(this);
    }

    /// <summary>Field number for the "Unk3300_BFOGKOHIEEJ" field.</summary>
    public const int Unk3300BFOGKOHIEEJFieldNumber = 12;
    private bool unk3300BFOGKOHIEEJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300BFOGKOHIEEJ {
      get { return unk3300BFOGKOHIEEJ_; }
      set {
        unk3300BFOGKOHIEEJ_ = value;
      }
    }

    /// <summary>Field number for the "unlock_by_word_id" field.</summary>
    public const int UnlockByWordIdFieldNumber = 11;
    private uint unlockByWordId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UnlockByWordId {
      get { return unlockByWordId_; }
      set {
        unlockByWordId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_PKBCAOHGNLM" field.</summary>
    public const int Unk3300PKBCAOHGNLMFieldNumber = 10;
    private bool unk3300PKBCAOHGNLM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300PKBCAOHGNLM {
      get { return unk3300PKBCAOHGNLM_; }
      set {
        unk3300PKBCAOHGNLM_ = value;
      }
    }

    /// <summary>Field number for the "word_id" field.</summary>
    public const int WordIdFieldNumber = 2;
    private uint wordId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WordId {
      get { return wordId_; }
      set {
        wordId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_JPHLECOIGKF" field.</summary>
    public const int Unk3300JPHLECOIGKFFieldNumber = 3;
    private bool unk3300JPHLECOIGKF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300JPHLECOIGKF {
      get { return unk3300JPHLECOIGKF_; }
      set {
        unk3300JPHLECOIGKF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as InferenceWordInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InferenceWordInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300BFOGKOHIEEJ != other.Unk3300BFOGKOHIEEJ) return false;
      if (UnlockByWordId != other.UnlockByWordId) return false;
      if (Unk3300PKBCAOHGNLM != other.Unk3300PKBCAOHGNLM) return false;
      if (WordId != other.WordId) return false;
      if (Unk3300JPHLECOIGKF != other.Unk3300JPHLECOIGKF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300BFOGKOHIEEJ != false) hash ^= Unk3300BFOGKOHIEEJ.GetHashCode();
      if (UnlockByWordId != 0) hash ^= UnlockByWordId.GetHashCode();
      if (Unk3300PKBCAOHGNLM != false) hash ^= Unk3300PKBCAOHGNLM.GetHashCode();
      if (WordId != 0) hash ^= WordId.GetHashCode();
      if (Unk3300JPHLECOIGKF != false) hash ^= Unk3300JPHLECOIGKF.GetHashCode();
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
      if (WordId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(WordId);
      }
      if (Unk3300JPHLECOIGKF != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk3300JPHLECOIGKF);
      }
      if (Unk3300PKBCAOHGNLM != false) {
        output.WriteRawTag(80);
        output.WriteBool(Unk3300PKBCAOHGNLM);
      }
      if (UnlockByWordId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(UnlockByWordId);
      }
      if (Unk3300BFOGKOHIEEJ != false) {
        output.WriteRawTag(96);
        output.WriteBool(Unk3300BFOGKOHIEEJ);
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
      if (WordId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(WordId);
      }
      if (Unk3300JPHLECOIGKF != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk3300JPHLECOIGKF);
      }
      if (Unk3300PKBCAOHGNLM != false) {
        output.WriteRawTag(80);
        output.WriteBool(Unk3300PKBCAOHGNLM);
      }
      if (UnlockByWordId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(UnlockByWordId);
      }
      if (Unk3300BFOGKOHIEEJ != false) {
        output.WriteRawTag(96);
        output.WriteBool(Unk3300BFOGKOHIEEJ);
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
      if (Unk3300BFOGKOHIEEJ != false) {
        size += 1 + 1;
      }
      if (UnlockByWordId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UnlockByWordId);
      }
      if (Unk3300PKBCAOHGNLM != false) {
        size += 1 + 1;
      }
      if (WordId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WordId);
      }
      if (Unk3300JPHLECOIGKF != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(InferenceWordInfo other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300BFOGKOHIEEJ != false) {
        Unk3300BFOGKOHIEEJ = other.Unk3300BFOGKOHIEEJ;
      }
      if (other.UnlockByWordId != 0) {
        UnlockByWordId = other.UnlockByWordId;
      }
      if (other.Unk3300PKBCAOHGNLM != false) {
        Unk3300PKBCAOHGNLM = other.Unk3300PKBCAOHGNLM;
      }
      if (other.WordId != 0) {
        WordId = other.WordId;
      }
      if (other.Unk3300JPHLECOIGKF != false) {
        Unk3300JPHLECOIGKF = other.Unk3300JPHLECOIGKF;
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
            WordId = input.ReadUInt32();
            break;
          }
          case 24: {
            Unk3300JPHLECOIGKF = input.ReadBool();
            break;
          }
          case 80: {
            Unk3300PKBCAOHGNLM = input.ReadBool();
            break;
          }
          case 88: {
            UnlockByWordId = input.ReadUInt32();
            break;
          }
          case 96: {
            Unk3300BFOGKOHIEEJ = input.ReadBool();
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
            WordId = input.ReadUInt32();
            break;
          }
          case 24: {
            Unk3300JPHLECOIGKF = input.ReadBool();
            break;
          }
          case 80: {
            Unk3300PKBCAOHGNLM = input.ReadBool();
            break;
          }
          case 88: {
            UnlockByWordId = input.ReadUInt32();
            break;
          }
          case 96: {
            Unk3300BFOGKOHIEEJ = input.ReadBool();
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