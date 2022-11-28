// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryMuqadasPotionInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SceneGalleryMuqadasPotionInfo.proto</summary>
  public static partial class SceneGalleryMuqadasPotionInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneGalleryMuqadasPotionInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneGalleryMuqadasPotionInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNTY2VuZUdhbGxlcnlNdXFhZGFzUG90aW9uSW5mby5wcm90byJ9Ch1TY2Vu",
            "ZUdhbGxlcnlNdXFhZGFzUG90aW9uSW5mbxINCgVzY29yZRgGIAEoDRIeChZj",
            "YXB0dXJlX3dlYWtuZXNzX2NvdW50GAQgASgNEhQKDHNraWxsX2VuZXJneRgK",
            "IAEoDRIXCg9za2lsbF91c2VfbGltaXQYCSABKA1CIqoCH1dlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SceneGalleryMuqadasPotionInfo), global::Weedwacker.Shared.Network.Proto.SceneGalleryMuqadasPotionInfo.Parser, new[]{ "Score", "CaptureWeaknessCount", "SkillEnergy", "SkillUseLimit" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneGalleryMuqadasPotionInfo : pb::IMessage<SceneGalleryMuqadasPotionInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneGalleryMuqadasPotionInfo> _parser = new pb::MessageParser<SceneGalleryMuqadasPotionInfo>(() => new SceneGalleryMuqadasPotionInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneGalleryMuqadasPotionInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SceneGalleryMuqadasPotionInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryMuqadasPotionInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryMuqadasPotionInfo(SceneGalleryMuqadasPotionInfo other) : this() {
      score_ = other.score_;
      captureWeaknessCount_ = other.captureWeaknessCount_;
      skillEnergy_ = other.skillEnergy_;
      skillUseLimit_ = other.skillUseLimit_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryMuqadasPotionInfo Clone() {
      return new SceneGalleryMuqadasPotionInfo(this);
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 6;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "capture_weakness_count" field.</summary>
    public const int CaptureWeaknessCountFieldNumber = 4;
    private uint captureWeaknessCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CaptureWeaknessCount {
      get { return captureWeaknessCount_; }
      set {
        captureWeaknessCount_ = value;
      }
    }

    /// <summary>Field number for the "skill_energy" field.</summary>
    public const int SkillEnergyFieldNumber = 10;
    private uint skillEnergy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillEnergy {
      get { return skillEnergy_; }
      set {
        skillEnergy_ = value;
      }
    }

    /// <summary>Field number for the "skill_use_limit" field.</summary>
    public const int SkillUseLimitFieldNumber = 9;
    private uint skillUseLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillUseLimit {
      get { return skillUseLimit_; }
      set {
        skillUseLimit_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneGalleryMuqadasPotionInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneGalleryMuqadasPotionInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Score != other.Score) return false;
      if (CaptureWeaknessCount != other.CaptureWeaknessCount) return false;
      if (SkillEnergy != other.SkillEnergy) return false;
      if (SkillUseLimit != other.SkillUseLimit) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Score != 0) hash ^= Score.GetHashCode();
      if (CaptureWeaknessCount != 0) hash ^= CaptureWeaknessCount.GetHashCode();
      if (SkillEnergy != 0) hash ^= SkillEnergy.GetHashCode();
      if (SkillUseLimit != 0) hash ^= SkillUseLimit.GetHashCode();
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
      if (CaptureWeaknessCount != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CaptureWeaknessCount);
      }
      if (Score != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Score);
      }
      if (SkillUseLimit != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(SkillUseLimit);
      }
      if (SkillEnergy != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(SkillEnergy);
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
      if (CaptureWeaknessCount != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CaptureWeaknessCount);
      }
      if (Score != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Score);
      }
      if (SkillUseLimit != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(SkillUseLimit);
      }
      if (SkillEnergy != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(SkillEnergy);
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
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (CaptureWeaknessCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CaptureWeaknessCount);
      }
      if (SkillEnergy != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillEnergy);
      }
      if (SkillUseLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillUseLimit);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneGalleryMuqadasPotionInfo other) {
      if (other == null) {
        return;
      }
      if (other.Score != 0) {
        Score = other.Score;
      }
      if (other.CaptureWeaknessCount != 0) {
        CaptureWeaknessCount = other.CaptureWeaknessCount;
      }
      if (other.SkillEnergy != 0) {
        SkillEnergy = other.SkillEnergy;
      }
      if (other.SkillUseLimit != 0) {
        SkillUseLimit = other.SkillUseLimit;
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
            CaptureWeaknessCount = input.ReadUInt32();
            break;
          }
          case 48: {
            Score = input.ReadUInt32();
            break;
          }
          case 72: {
            SkillUseLimit = input.ReadUInt32();
            break;
          }
          case 80: {
            SkillEnergy = input.ReadUInt32();
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
            CaptureWeaknessCount = input.ReadUInt32();
            break;
          }
          case 48: {
            Score = input.ReadUInt32();
            break;
          }
          case 72: {
            SkillUseLimit = input.ReadUInt32();
            break;
          }
          case 80: {
            SkillEnergy = input.ReadUInt32();
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
