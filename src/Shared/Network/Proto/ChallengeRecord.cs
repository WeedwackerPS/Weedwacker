// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChallengeRecord.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ChallengeRecord.proto</summary>
  public static partial class ChallengeRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for ChallengeRecord.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChallengeRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVDaGFsbGVuZ2VSZWNvcmQucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5l",
            "dHdvcmsuUHJvdG8icwoPQ2hhbGxlbmdlUmVjb3JkEh0KFWNoYWxsZW5nZV9y",
            "ZWNvcmRfdHlwZRgCIAEoDRIXCg9jaGFsbGVuZ2VfaW5kZXgYAyABKA0SFAoM",
            "Y2hhbGxlbmdlX2lkGAkgASgNEhIKCmJlc3RfdmFsdWUYBCABKA1iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ChallengeRecord), global::Weedwacker.Shared.Network.Proto.ChallengeRecord.Parser, new[]{ "ChallengeRecordType", "ChallengeIndex", "ChallengeId", "BestValue" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChallengeRecord : pb::IMessage<ChallengeRecord>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChallengeRecord> _parser = new pb::MessageParser<ChallengeRecord>(() => new ChallengeRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChallengeRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ChallengeRecordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChallengeRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChallengeRecord(ChallengeRecord other) : this() {
      challengeRecordType_ = other.challengeRecordType_;
      challengeIndex_ = other.challengeIndex_;
      challengeId_ = other.challengeId_;
      bestValue_ = other.bestValue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChallengeRecord Clone() {
      return new ChallengeRecord(this);
    }

    /// <summary>Field number for the "challenge_record_type" field.</summary>
    public const int ChallengeRecordTypeFieldNumber = 2;
    private uint challengeRecordType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeRecordType {
      get { return challengeRecordType_; }
      set {
        challengeRecordType_ = value;
      }
    }

    /// <summary>Field number for the "challenge_index" field.</summary>
    public const int ChallengeIndexFieldNumber = 3;
    private uint challengeIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeIndex {
      get { return challengeIndex_; }
      set {
        challengeIndex_ = value;
      }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 9;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    /// <summary>Field number for the "best_value" field.</summary>
    public const int BestValueFieldNumber = 4;
    private uint bestValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BestValue {
      get { return bestValue_; }
      set {
        bestValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChallengeRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChallengeRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChallengeRecordType != other.ChallengeRecordType) return false;
      if (ChallengeIndex != other.ChallengeIndex) return false;
      if (ChallengeId != other.ChallengeId) return false;
      if (BestValue != other.BestValue) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChallengeRecordType != 0) hash ^= ChallengeRecordType.GetHashCode();
      if (ChallengeIndex != 0) hash ^= ChallengeIndex.GetHashCode();
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
      if (BestValue != 0) hash ^= BestValue.GetHashCode();
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
      if (ChallengeRecordType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ChallengeRecordType);
      }
      if (ChallengeIndex != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ChallengeIndex);
      }
      if (BestValue != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(BestValue);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ChallengeId);
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
      if (ChallengeRecordType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ChallengeRecordType);
      }
      if (ChallengeIndex != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ChallengeIndex);
      }
      if (BestValue != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(BestValue);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ChallengeId);
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
      if (ChallengeRecordType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeRecordType);
      }
      if (ChallengeIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeIndex);
      }
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (BestValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BestValue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChallengeRecord other) {
      if (other == null) {
        return;
      }
      if (other.ChallengeRecordType != 0) {
        ChallengeRecordType = other.ChallengeRecordType;
      }
      if (other.ChallengeIndex != 0) {
        ChallengeIndex = other.ChallengeIndex;
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
      }
      if (other.BestValue != 0) {
        BestValue = other.BestValue;
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
            ChallengeRecordType = input.ReadUInt32();
            break;
          }
          case 24: {
            ChallengeIndex = input.ReadUInt32();
            break;
          }
          case 32: {
            BestValue = input.ReadUInt32();
            break;
          }
          case 72: {
            ChallengeId = input.ReadUInt32();
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
            ChallengeRecordType = input.ReadUInt32();
            break;
          }
          case 24: {
            ChallengeIndex = input.ReadUInt32();
            break;
          }
          case 32: {
            BestValue = input.ReadUInt32();
            break;
          }
          case 72: {
            ChallengeId = input.ReadUInt32();
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
