// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AsterActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AsterActivityDetailInfo.proto</summary>
  public static partial class AsterActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for AsterActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AsterActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Bc3RlckFjdGl2aXR5RGV0YWlsSW5mby5wcm90bxIfV2VlZHdhY2tlci5T",
            "aGFyZWQuTmV0d29yay5Qcm90bxoaQXN0ZXJMYXJnZURldGFpbEluZm8ucHJv",
            "dG8aG0FzdGVyTGl0dGxlRGV0YWlsSW5mby5wcm90bxoYQXN0ZXJNaWREZXRh",
            "aWxJbmZvLnByb3RvGh1Bc3RlclByb2dyZXNzRGV0YWlsSW5mby5wcm90byLf",
            "AwoXQXN0ZXJBY3Rpdml0eURldGFpbEluZm8SGgoSY29udGVudF9jbG9zZV90",
            "aW1lGAEgASgNEkwKDGFzdGVyX2xpdHRsZRgFIAEoCzI2LldlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG8uQXN0ZXJMaXR0bGVEZXRhaWxJbmZvEhsK",
            "E1VuazMzMDBfRENIQkZFSk5CSFAYDSABKA0SRgoJYXN0ZXJfbWlkGAwgASgL",
            "MjMuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5Bc3Rlck1pZERl",
            "dGFpbEluZm8SHwoXaXNfc3BlY2lhbF9yZXdhcmRfdGFrZW4YAyABKAgSGwoT",
            "VW5rMzMwMF9LRkRHRkZQSkdKQxgEIAEoDRJQCg5hc3Rlcl9wcm9ncmVzcxgI",
            "IAEoCzI4LldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uQXN0ZXJQ",
            "cm9ncmVzc0RldGFpbEluZm8SSgoLYXN0ZXJfbGFyZ2UYCiABKAsyNS5XZWVk",
            "d2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLkFzdGVyTGFyZ2VEZXRhaWxJ",
            "bmZvEhkKEWlzX2NvbnRlbnRfY2xvc2VkGAYgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.AsterLargeDetailInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.AsterLittleDetailInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.AsterMidDetailInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.AsterProgressDetailInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AsterActivityDetailInfo), global::Weedwacker.Shared.Network.Proto.AsterActivityDetailInfo.Parser, new[]{ "ContentCloseTime", "AsterLittle", "Unk3300DCHBFEJNBHP", "AsterMid", "IsSpecialRewardTaken", "Unk3300KFDGFFPJGJC", "AsterProgress", "AsterLarge", "IsContentClosed" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AsterActivityDetailInfo : pb::IMessage<AsterActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AsterActivityDetailInfo> _parser = new pb::MessageParser<AsterActivityDetailInfo>(() => new AsterActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AsterActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AsterActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AsterActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AsterActivityDetailInfo(AsterActivityDetailInfo other) : this() {
      contentCloseTime_ = other.contentCloseTime_;
      asterLittle_ = other.asterLittle_ != null ? other.asterLittle_.Clone() : null;
      unk3300DCHBFEJNBHP_ = other.unk3300DCHBFEJNBHP_;
      asterMid_ = other.asterMid_ != null ? other.asterMid_.Clone() : null;
      isSpecialRewardTaken_ = other.isSpecialRewardTaken_;
      unk3300KFDGFFPJGJC_ = other.unk3300KFDGFFPJGJC_;
      asterProgress_ = other.asterProgress_ != null ? other.asterProgress_.Clone() : null;
      asterLarge_ = other.asterLarge_ != null ? other.asterLarge_.Clone() : null;
      isContentClosed_ = other.isContentClosed_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AsterActivityDetailInfo Clone() {
      return new AsterActivityDetailInfo(this);
    }

    /// <summary>Field number for the "content_close_time" field.</summary>
    public const int ContentCloseTimeFieldNumber = 1;
    private uint contentCloseTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ContentCloseTime {
      get { return contentCloseTime_; }
      set {
        contentCloseTime_ = value;
      }
    }

    /// <summary>Field number for the "aster_little" field.</summary>
    public const int AsterLittleFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.AsterLittleDetailInfo asterLittle_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.AsterLittleDetailInfo AsterLittle {
      get { return asterLittle_; }
      set {
        asterLittle_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_DCHBFEJNBHP" field.</summary>
    public const int Unk3300DCHBFEJNBHPFieldNumber = 13;
    private uint unk3300DCHBFEJNBHP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300DCHBFEJNBHP {
      get { return unk3300DCHBFEJNBHP_; }
      set {
        unk3300DCHBFEJNBHP_ = value;
      }
    }

    /// <summary>Field number for the "aster_mid" field.</summary>
    public const int AsterMidFieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.AsterMidDetailInfo asterMid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.AsterMidDetailInfo AsterMid {
      get { return asterMid_; }
      set {
        asterMid_ = value;
      }
    }

    /// <summary>Field number for the "is_special_reward_taken" field.</summary>
    public const int IsSpecialRewardTakenFieldNumber = 3;
    private bool isSpecialRewardTaken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSpecialRewardTaken {
      get { return isSpecialRewardTaken_; }
      set {
        isSpecialRewardTaken_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_KFDGFFPJGJC" field.</summary>
    public const int Unk3300KFDGFFPJGJCFieldNumber = 4;
    private uint unk3300KFDGFFPJGJC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300KFDGFFPJGJC {
      get { return unk3300KFDGFFPJGJC_; }
      set {
        unk3300KFDGFFPJGJC_ = value;
      }
    }

    /// <summary>Field number for the "aster_progress" field.</summary>
    public const int AsterProgressFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.AsterProgressDetailInfo asterProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.AsterProgressDetailInfo AsterProgress {
      get { return asterProgress_; }
      set {
        asterProgress_ = value;
      }
    }

    /// <summary>Field number for the "aster_large" field.</summary>
    public const int AsterLargeFieldNumber = 10;
    private global::Weedwacker.Shared.Network.Proto.AsterLargeDetailInfo asterLarge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.AsterLargeDetailInfo AsterLarge {
      get { return asterLarge_; }
      set {
        asterLarge_ = value;
      }
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 6;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AsterActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AsterActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ContentCloseTime != other.ContentCloseTime) return false;
      if (!object.Equals(AsterLittle, other.AsterLittle)) return false;
      if (Unk3300DCHBFEJNBHP != other.Unk3300DCHBFEJNBHP) return false;
      if (!object.Equals(AsterMid, other.AsterMid)) return false;
      if (IsSpecialRewardTaken != other.IsSpecialRewardTaken) return false;
      if (Unk3300KFDGFFPJGJC != other.Unk3300KFDGFFPJGJC) return false;
      if (!object.Equals(AsterProgress, other.AsterProgress)) return false;
      if (!object.Equals(AsterLarge, other.AsterLarge)) return false;
      if (IsContentClosed != other.IsContentClosed) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ContentCloseTime != 0) hash ^= ContentCloseTime.GetHashCode();
      if (asterLittle_ != null) hash ^= AsterLittle.GetHashCode();
      if (Unk3300DCHBFEJNBHP != 0) hash ^= Unk3300DCHBFEJNBHP.GetHashCode();
      if (asterMid_ != null) hash ^= AsterMid.GetHashCode();
      if (IsSpecialRewardTaken != false) hash ^= IsSpecialRewardTaken.GetHashCode();
      if (Unk3300KFDGFFPJGJC != 0) hash ^= Unk3300KFDGFFPJGJC.GetHashCode();
      if (asterProgress_ != null) hash ^= AsterProgress.GetHashCode();
      if (asterLarge_ != null) hash ^= AsterLarge.GetHashCode();
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
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
      if (ContentCloseTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ContentCloseTime);
      }
      if (IsSpecialRewardTaken != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsSpecialRewardTaken);
      }
      if (Unk3300KFDGFFPJGJC != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300KFDGFFPJGJC);
      }
      if (asterLittle_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(AsterLittle);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsContentClosed);
      }
      if (asterProgress_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(AsterProgress);
      }
      if (asterLarge_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(AsterLarge);
      }
      if (asterMid_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(AsterMid);
      }
      if (Unk3300DCHBFEJNBHP != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300DCHBFEJNBHP);
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
      if (ContentCloseTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ContentCloseTime);
      }
      if (IsSpecialRewardTaken != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsSpecialRewardTaken);
      }
      if (Unk3300KFDGFFPJGJC != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300KFDGFFPJGJC);
      }
      if (asterLittle_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(AsterLittle);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsContentClosed);
      }
      if (asterProgress_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(AsterProgress);
      }
      if (asterLarge_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(AsterLarge);
      }
      if (asterMid_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(AsterMid);
      }
      if (Unk3300DCHBFEJNBHP != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300DCHBFEJNBHP);
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
      if (ContentCloseTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ContentCloseTime);
      }
      if (asterLittle_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AsterLittle);
      }
      if (Unk3300DCHBFEJNBHP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300DCHBFEJNBHP);
      }
      if (asterMid_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AsterMid);
      }
      if (IsSpecialRewardTaken != false) {
        size += 1 + 1;
      }
      if (Unk3300KFDGFFPJGJC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300KFDGFFPJGJC);
      }
      if (asterProgress_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AsterProgress);
      }
      if (asterLarge_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AsterLarge);
      }
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AsterActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.ContentCloseTime != 0) {
        ContentCloseTime = other.ContentCloseTime;
      }
      if (other.asterLittle_ != null) {
        if (asterLittle_ == null) {
          AsterLittle = new global::Weedwacker.Shared.Network.Proto.AsterLittleDetailInfo();
        }
        AsterLittle.MergeFrom(other.AsterLittle);
      }
      if (other.Unk3300DCHBFEJNBHP != 0) {
        Unk3300DCHBFEJNBHP = other.Unk3300DCHBFEJNBHP;
      }
      if (other.asterMid_ != null) {
        if (asterMid_ == null) {
          AsterMid = new global::Weedwacker.Shared.Network.Proto.AsterMidDetailInfo();
        }
        AsterMid.MergeFrom(other.AsterMid);
      }
      if (other.IsSpecialRewardTaken != false) {
        IsSpecialRewardTaken = other.IsSpecialRewardTaken;
      }
      if (other.Unk3300KFDGFFPJGJC != 0) {
        Unk3300KFDGFFPJGJC = other.Unk3300KFDGFFPJGJC;
      }
      if (other.asterProgress_ != null) {
        if (asterProgress_ == null) {
          AsterProgress = new global::Weedwacker.Shared.Network.Proto.AsterProgressDetailInfo();
        }
        AsterProgress.MergeFrom(other.AsterProgress);
      }
      if (other.asterLarge_ != null) {
        if (asterLarge_ == null) {
          AsterLarge = new global::Weedwacker.Shared.Network.Proto.AsterLargeDetailInfo();
        }
        AsterLarge.MergeFrom(other.AsterLarge);
      }
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
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
            ContentCloseTime = input.ReadUInt32();
            break;
          }
          case 24: {
            IsSpecialRewardTaken = input.ReadBool();
            break;
          }
          case 32: {
            Unk3300KFDGFFPJGJC = input.ReadUInt32();
            break;
          }
          case 42: {
            if (asterLittle_ == null) {
              AsterLittle = new global::Weedwacker.Shared.Network.Proto.AsterLittleDetailInfo();
            }
            input.ReadMessage(AsterLittle);
            break;
          }
          case 48: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 66: {
            if (asterProgress_ == null) {
              AsterProgress = new global::Weedwacker.Shared.Network.Proto.AsterProgressDetailInfo();
            }
            input.ReadMessage(AsterProgress);
            break;
          }
          case 82: {
            if (asterLarge_ == null) {
              AsterLarge = new global::Weedwacker.Shared.Network.Proto.AsterLargeDetailInfo();
            }
            input.ReadMessage(AsterLarge);
            break;
          }
          case 98: {
            if (asterMid_ == null) {
              AsterMid = new global::Weedwacker.Shared.Network.Proto.AsterMidDetailInfo();
            }
            input.ReadMessage(AsterMid);
            break;
          }
          case 104: {
            Unk3300DCHBFEJNBHP = input.ReadUInt32();
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
            ContentCloseTime = input.ReadUInt32();
            break;
          }
          case 24: {
            IsSpecialRewardTaken = input.ReadBool();
            break;
          }
          case 32: {
            Unk3300KFDGFFPJGJC = input.ReadUInt32();
            break;
          }
          case 42: {
            if (asterLittle_ == null) {
              AsterLittle = new global::Weedwacker.Shared.Network.Proto.AsterLittleDetailInfo();
            }
            input.ReadMessage(AsterLittle);
            break;
          }
          case 48: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 66: {
            if (asterProgress_ == null) {
              AsterProgress = new global::Weedwacker.Shared.Network.Proto.AsterProgressDetailInfo();
            }
            input.ReadMessage(AsterProgress);
            break;
          }
          case 82: {
            if (asterLarge_ == null) {
              AsterLarge = new global::Weedwacker.Shared.Network.Proto.AsterLargeDetailInfo();
            }
            input.ReadMessage(AsterLarge);
            break;
          }
          case 98: {
            if (asterMid_ == null) {
              AsterMid = new global::Weedwacker.Shared.Network.Proto.AsterMidDetailInfo();
            }
            input.ReadMessage(AsterMid);
            break;
          }
          case 104: {
            Unk3300DCHBFEJNBHP = input.ReadUInt32();
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
