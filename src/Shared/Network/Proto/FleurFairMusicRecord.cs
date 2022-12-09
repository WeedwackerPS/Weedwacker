// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FleurFairMusicRecord.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FleurFairMusicRecord.proto</summary>
  public static partial class FleurFairMusicRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for FleurFairMusicRecord.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FleurFairMusicRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpGbGV1ckZhaXJNdXNpY1JlY29yZC5wcm90bxIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90byJPChRGbGV1ckZhaXJNdXNpY1JlY29yZBIRCglt",
            "YXhfc2NvcmUYCyABKA0SEQoJaXNfdW5sb2NrGAogASgIEhEKCW1heF9jb21i",
            "bxgGIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FleurFairMusicRecord), global::Weedwacker.Shared.Network.Proto.FleurFairMusicRecord.Parser, new[]{ "MaxScore", "IsUnlock", "MaxCombo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FleurFairMusicRecord : pb::IMessage<FleurFairMusicRecord>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FleurFairMusicRecord> _parser = new pb::MessageParser<FleurFairMusicRecord>(() => new FleurFairMusicRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FleurFairMusicRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FleurFairMusicRecordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairMusicRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairMusicRecord(FleurFairMusicRecord other) : this() {
      maxScore_ = other.maxScore_;
      isUnlock_ = other.isUnlock_;
      maxCombo_ = other.maxCombo_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairMusicRecord Clone() {
      return new FleurFairMusicRecord(this);
    }

    /// <summary>Field number for the "max_score" field.</summary>
    public const int MaxScoreFieldNumber = 11;
    private uint maxScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxScore {
      get { return maxScore_; }
      set {
        maxScore_ = value;
      }
    }

    /// <summary>Field number for the "is_unlock" field.</summary>
    public const int IsUnlockFieldNumber = 10;
    private bool isUnlock_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsUnlock {
      get { return isUnlock_; }
      set {
        isUnlock_ = value;
      }
    }

    /// <summary>Field number for the "max_combo" field.</summary>
    public const int MaxComboFieldNumber = 6;
    private uint maxCombo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxCombo {
      get { return maxCombo_; }
      set {
        maxCombo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FleurFairMusicRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FleurFairMusicRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MaxScore != other.MaxScore) return false;
      if (IsUnlock != other.IsUnlock) return false;
      if (MaxCombo != other.MaxCombo) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MaxScore != 0) hash ^= MaxScore.GetHashCode();
      if (IsUnlock != false) hash ^= IsUnlock.GetHashCode();
      if (MaxCombo != 0) hash ^= MaxCombo.GetHashCode();
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
      if (MaxCombo != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MaxCombo);
      }
      if (IsUnlock != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsUnlock);
      }
      if (MaxScore != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MaxScore);
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
      if (MaxCombo != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MaxCombo);
      }
      if (IsUnlock != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsUnlock);
      }
      if (MaxScore != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MaxScore);
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
      if (MaxScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxScore);
      }
      if (IsUnlock != false) {
        size += 1 + 1;
      }
      if (MaxCombo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxCombo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FleurFairMusicRecord other) {
      if (other == null) {
        return;
      }
      if (other.MaxScore != 0) {
        MaxScore = other.MaxScore;
      }
      if (other.IsUnlock != false) {
        IsUnlock = other.IsUnlock;
      }
      if (other.MaxCombo != 0) {
        MaxCombo = other.MaxCombo;
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
          case 48: {
            MaxCombo = input.ReadUInt32();
            break;
          }
          case 80: {
            IsUnlock = input.ReadBool();
            break;
          }
          case 88: {
            MaxScore = input.ReadUInt32();
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
          case 48: {
            MaxCombo = input.ReadUInt32();
            break;
          }
          case 80: {
            IsUnlock = input.ReadBool();
            break;
          }
          case 88: {
            MaxScore = input.ReadUInt32();
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
