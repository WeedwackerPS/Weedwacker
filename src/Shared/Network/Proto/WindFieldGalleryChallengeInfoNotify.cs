// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WindFieldGalleryChallengeInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from WindFieldGalleryChallengeInfoNotify.proto</summary>
  public static partial class WindFieldGalleryChallengeInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for WindFieldGalleryChallengeInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WindFieldGalleryChallengeInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilXaW5kRmllbGRHYWxsZXJ5Q2hhbGxlbmdlSW5mb05vdGlmeS5wcm90bxIf",
            "V2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90byLcAQojV2luZEZpZWxk",
            "R2FsbGVyeUNoYWxsZW5nZUluZm9Ob3RpZnkSGwoTVW5rMzMwMF9GRk9EQUtN",
            "S0dFSxgNIAEoDRIQCghpc19zdGFydBgCIAEoCBIbChNVbmszMzAwX0dMTkhC",
            "SkpKSU5LGAUgASgNEhsKE1VuazMzMDBfTkJJQktGS09DRksYAyABKA0SEgoK",
            "aXNfc3VjY2VzcxgHIAEoCBIbChNVbmszMzAwX0dOSktPQ0xKRk5NGAggASgN",
            "EhsKE1VuazMzMDBfTU1PTlBETUlFQk4YCiABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.WindFieldGalleryChallengeInfoNotify), global::Weedwacker.Shared.Network.Proto.WindFieldGalleryChallengeInfoNotify.Parser, new[]{ "Unk3300FFODAKMKGEK", "IsStart", "Unk3300GLNHBJJJINK", "Unk3300NBIBKFKOCFK", "IsSuccess", "Unk3300GNJKOCLJFNM", "Unk3300MMONPDMIEBN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 5503;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class WindFieldGalleryChallengeInfoNotify : pb::IMessage<WindFieldGalleryChallengeInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WindFieldGalleryChallengeInfoNotify> _parser = new pb::MessageParser<WindFieldGalleryChallengeInfoNotify>(() => new WindFieldGalleryChallengeInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WindFieldGalleryChallengeInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.WindFieldGalleryChallengeInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WindFieldGalleryChallengeInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WindFieldGalleryChallengeInfoNotify(WindFieldGalleryChallengeInfoNotify other) : this() {
      unk3300FFODAKMKGEK_ = other.unk3300FFODAKMKGEK_;
      isStart_ = other.isStart_;
      unk3300GLNHBJJJINK_ = other.unk3300GLNHBJJJINK_;
      unk3300NBIBKFKOCFK_ = other.unk3300NBIBKFKOCFK_;
      isSuccess_ = other.isSuccess_;
      unk3300GNJKOCLJFNM_ = other.unk3300GNJKOCLJFNM_;
      unk3300MMONPDMIEBN_ = other.unk3300MMONPDMIEBN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WindFieldGalleryChallengeInfoNotify Clone() {
      return new WindFieldGalleryChallengeInfoNotify(this);
    }

    /// <summary>Field number for the "Unk3300_FFODAKMKGEK" field.</summary>
    public const int Unk3300FFODAKMKGEKFieldNumber = 13;
    private uint unk3300FFODAKMKGEK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300FFODAKMKGEK {
      get { return unk3300FFODAKMKGEK_; }
      set {
        unk3300FFODAKMKGEK_ = value;
      }
    }

    /// <summary>Field number for the "is_start" field.</summary>
    public const int IsStartFieldNumber = 2;
    private bool isStart_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsStart {
      get { return isStart_; }
      set {
        isStart_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_GLNHBJJJINK" field.</summary>
    public const int Unk3300GLNHBJJJINKFieldNumber = 5;
    private uint unk3300GLNHBJJJINK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300GLNHBJJJINK {
      get { return unk3300GLNHBJJJINK_; }
      set {
        unk3300GLNHBJJJINK_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_NBIBKFKOCFK" field.</summary>
    public const int Unk3300NBIBKFKOCFKFieldNumber = 3;
    private uint unk3300NBIBKFKOCFK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300NBIBKFKOCFK {
      get { return unk3300NBIBKFKOCFK_; }
      set {
        unk3300NBIBKFKOCFK_ = value;
      }
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 7;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_GNJKOCLJFNM" field.</summary>
    public const int Unk3300GNJKOCLJFNMFieldNumber = 8;
    private uint unk3300GNJKOCLJFNM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300GNJKOCLJFNM {
      get { return unk3300GNJKOCLJFNM_; }
      set {
        unk3300GNJKOCLJFNM_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_MMONPDMIEBN" field.</summary>
    public const int Unk3300MMONPDMIEBNFieldNumber = 10;
    private uint unk3300MMONPDMIEBN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300MMONPDMIEBN {
      get { return unk3300MMONPDMIEBN_; }
      set {
        unk3300MMONPDMIEBN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WindFieldGalleryChallengeInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WindFieldGalleryChallengeInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300FFODAKMKGEK != other.Unk3300FFODAKMKGEK) return false;
      if (IsStart != other.IsStart) return false;
      if (Unk3300GLNHBJJJINK != other.Unk3300GLNHBJJJINK) return false;
      if (Unk3300NBIBKFKOCFK != other.Unk3300NBIBKFKOCFK) return false;
      if (IsSuccess != other.IsSuccess) return false;
      if (Unk3300GNJKOCLJFNM != other.Unk3300GNJKOCLJFNM) return false;
      if (Unk3300MMONPDMIEBN != other.Unk3300MMONPDMIEBN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300FFODAKMKGEK != 0) hash ^= Unk3300FFODAKMKGEK.GetHashCode();
      if (IsStart != false) hash ^= IsStart.GetHashCode();
      if (Unk3300GLNHBJJJINK != 0) hash ^= Unk3300GLNHBJJJINK.GetHashCode();
      if (Unk3300NBIBKFKOCFK != 0) hash ^= Unk3300NBIBKFKOCFK.GetHashCode();
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (Unk3300GNJKOCLJFNM != 0) hash ^= Unk3300GNJKOCLJFNM.GetHashCode();
      if (Unk3300MMONPDMIEBN != 0) hash ^= Unk3300MMONPDMIEBN.GetHashCode();
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
      if (IsStart != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsStart);
      }
      if (Unk3300NBIBKFKOCFK != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk3300NBIBKFKOCFK);
      }
      if (Unk3300GLNHBJJJINK != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300GLNHBJJJINK);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsSuccess);
      }
      if (Unk3300GNJKOCLJFNM != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk3300GNJKOCLJFNM);
      }
      if (Unk3300MMONPDMIEBN != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300MMONPDMIEBN);
      }
      if (Unk3300FFODAKMKGEK != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300FFODAKMKGEK);
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
      if (IsStart != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsStart);
      }
      if (Unk3300NBIBKFKOCFK != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk3300NBIBKFKOCFK);
      }
      if (Unk3300GLNHBJJJINK != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300GLNHBJJJINK);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsSuccess);
      }
      if (Unk3300GNJKOCLJFNM != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk3300GNJKOCLJFNM);
      }
      if (Unk3300MMONPDMIEBN != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300MMONPDMIEBN);
      }
      if (Unk3300FFODAKMKGEK != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300FFODAKMKGEK);
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
      if (Unk3300FFODAKMKGEK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300FFODAKMKGEK);
      }
      if (IsStart != false) {
        size += 1 + 1;
      }
      if (Unk3300GLNHBJJJINK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300GLNHBJJJINK);
      }
      if (Unk3300NBIBKFKOCFK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300NBIBKFKOCFK);
      }
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (Unk3300GNJKOCLJFNM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300GNJKOCLJFNM);
      }
      if (Unk3300MMONPDMIEBN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300MMONPDMIEBN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WindFieldGalleryChallengeInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300FFODAKMKGEK != 0) {
        Unk3300FFODAKMKGEK = other.Unk3300FFODAKMKGEK;
      }
      if (other.IsStart != false) {
        IsStart = other.IsStart;
      }
      if (other.Unk3300GLNHBJJJINK != 0) {
        Unk3300GLNHBJJJINK = other.Unk3300GLNHBJJJINK;
      }
      if (other.Unk3300NBIBKFKOCFK != 0) {
        Unk3300NBIBKFKOCFK = other.Unk3300NBIBKFKOCFK;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      if (other.Unk3300GNJKOCLJFNM != 0) {
        Unk3300GNJKOCLJFNM = other.Unk3300GNJKOCLJFNM;
      }
      if (other.Unk3300MMONPDMIEBN != 0) {
        Unk3300MMONPDMIEBN = other.Unk3300MMONPDMIEBN;
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
            IsStart = input.ReadBool();
            break;
          }
          case 24: {
            Unk3300NBIBKFKOCFK = input.ReadUInt32();
            break;
          }
          case 40: {
            Unk3300GLNHBJJJINK = input.ReadUInt32();
            break;
          }
          case 56: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 64: {
            Unk3300GNJKOCLJFNM = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300MMONPDMIEBN = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk3300FFODAKMKGEK = input.ReadUInt32();
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
            IsStart = input.ReadBool();
            break;
          }
          case 24: {
            Unk3300NBIBKFKOCFK = input.ReadUInt32();
            break;
          }
          case 40: {
            Unk3300GLNHBJJJINK = input.ReadUInt32();
            break;
          }
          case 56: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 64: {
            Unk3300GNJKOCLJFNM = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300MMONPDMIEBN = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk3300FFODAKMKGEK = input.ReadUInt32();
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
