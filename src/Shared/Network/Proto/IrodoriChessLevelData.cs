// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IrodoriChessLevelData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from IrodoriChessLevelData.proto</summary>
  public static partial class IrodoriChessLevelDataReflection {

    #region Descriptor
    /// <summary>File descriptor for IrodoriChessLevelData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IrodoriChessLevelDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtJcm9kb3JpQ2hlc3NMZXZlbERhdGEucHJvdG8SH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8aGUlyb2RvcmlDaGVzc01hcERhdGEucHJvdG8i",
            "4gEKFUlyb2RvcmlDaGVzc0xldmVsRGF0YRJRChNVbmszMzAwX0dDSUdOQ0dP",
            "Qk1MGAYgASgLMjQuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5J",
            "cm9kb3JpQ2hlc3NNYXBEYXRhEhAKCGxldmVsX2lkGA4gASgNElEKE1VuazMz",
            "MDBfQkdJTkVNSEJOQUQYCiABKAsyNC5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3",
            "b3JrLlByb3RvLklyb2RvcmlDaGVzc01hcERhdGESEQoJb3Blbl90aW1lGAgg",
            "ASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.IrodoriChessMapDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.IrodoriChessLevelData), global::Weedwacker.Shared.Network.Proto.IrodoriChessLevelData.Parser, new[]{ "Unk3300GCIGNCGOBML", "LevelId", "Unk3300BGINEMHBNAD", "OpenTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IrodoriChessLevelData : pb::IMessage<IrodoriChessLevelData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IrodoriChessLevelData> _parser = new pb::MessageParser<IrodoriChessLevelData>(() => new IrodoriChessLevelData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IrodoriChessLevelData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.IrodoriChessLevelDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriChessLevelData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriChessLevelData(IrodoriChessLevelData other) : this() {
      unk3300GCIGNCGOBML_ = other.unk3300GCIGNCGOBML_ != null ? other.unk3300GCIGNCGOBML_.Clone() : null;
      levelId_ = other.levelId_;
      unk3300BGINEMHBNAD_ = other.unk3300BGINEMHBNAD_ != null ? other.unk3300BGINEMHBNAD_.Clone() : null;
      openTime_ = other.openTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriChessLevelData Clone() {
      return new IrodoriChessLevelData(this);
    }

    /// <summary>Field number for the "Unk3300_GCIGNCGOBML" field.</summary>
    public const int Unk3300GCIGNCGOBMLFieldNumber = 6;
    private global::Weedwacker.Shared.Network.Proto.IrodoriChessMapData unk3300GCIGNCGOBML_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.IrodoriChessMapData Unk3300GCIGNCGOBML {
      get { return unk3300GCIGNCGOBML_; }
      set {
        unk3300GCIGNCGOBML_ = value;
      }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 14;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_BGINEMHBNAD" field.</summary>
    public const int Unk3300BGINEMHBNADFieldNumber = 10;
    private global::Weedwacker.Shared.Network.Proto.IrodoriChessMapData unk3300BGINEMHBNAD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.IrodoriChessMapData Unk3300BGINEMHBNAD {
      get { return unk3300BGINEMHBNAD_; }
      set {
        unk3300BGINEMHBNAD_ = value;
      }
    }

    /// <summary>Field number for the "open_time" field.</summary>
    public const int OpenTimeFieldNumber = 8;
    private uint openTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OpenTime {
      get { return openTime_; }
      set {
        openTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IrodoriChessLevelData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IrodoriChessLevelData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Unk3300GCIGNCGOBML, other.Unk3300GCIGNCGOBML)) return false;
      if (LevelId != other.LevelId) return false;
      if (!object.Equals(Unk3300BGINEMHBNAD, other.Unk3300BGINEMHBNAD)) return false;
      if (OpenTime != other.OpenTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (unk3300GCIGNCGOBML_ != null) hash ^= Unk3300GCIGNCGOBML.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (unk3300BGINEMHBNAD_ != null) hash ^= Unk3300BGINEMHBNAD.GetHashCode();
      if (OpenTime != 0) hash ^= OpenTime.GetHashCode();
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
      if (unk3300GCIGNCGOBML_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Unk3300GCIGNCGOBML);
      }
      if (OpenTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(OpenTime);
      }
      if (unk3300BGINEMHBNAD_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Unk3300BGINEMHBNAD);
      }
      if (LevelId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LevelId);
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
      if (unk3300GCIGNCGOBML_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Unk3300GCIGNCGOBML);
      }
      if (OpenTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(OpenTime);
      }
      if (unk3300BGINEMHBNAD_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Unk3300BGINEMHBNAD);
      }
      if (LevelId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LevelId);
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
      if (unk3300GCIGNCGOBML_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk3300GCIGNCGOBML);
      }
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (unk3300BGINEMHBNAD_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk3300BGINEMHBNAD);
      }
      if (OpenTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpenTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IrodoriChessLevelData other) {
      if (other == null) {
        return;
      }
      if (other.unk3300GCIGNCGOBML_ != null) {
        if (unk3300GCIGNCGOBML_ == null) {
          Unk3300GCIGNCGOBML = new global::Weedwacker.Shared.Network.Proto.IrodoriChessMapData();
        }
        Unk3300GCIGNCGOBML.MergeFrom(other.Unk3300GCIGNCGOBML);
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.unk3300BGINEMHBNAD_ != null) {
        if (unk3300BGINEMHBNAD_ == null) {
          Unk3300BGINEMHBNAD = new global::Weedwacker.Shared.Network.Proto.IrodoriChessMapData();
        }
        Unk3300BGINEMHBNAD.MergeFrom(other.Unk3300BGINEMHBNAD);
      }
      if (other.OpenTime != 0) {
        OpenTime = other.OpenTime;
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
          case 50: {
            if (unk3300GCIGNCGOBML_ == null) {
              Unk3300GCIGNCGOBML = new global::Weedwacker.Shared.Network.Proto.IrodoriChessMapData();
            }
            input.ReadMessage(Unk3300GCIGNCGOBML);
            break;
          }
          case 64: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 82: {
            if (unk3300BGINEMHBNAD_ == null) {
              Unk3300BGINEMHBNAD = new global::Weedwacker.Shared.Network.Proto.IrodoriChessMapData();
            }
            input.ReadMessage(Unk3300BGINEMHBNAD);
            break;
          }
          case 112: {
            LevelId = input.ReadUInt32();
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
          case 50: {
            if (unk3300GCIGNCGOBML_ == null) {
              Unk3300GCIGNCGOBML = new global::Weedwacker.Shared.Network.Proto.IrodoriChessMapData();
            }
            input.ReadMessage(Unk3300GCIGNCGOBML);
            break;
          }
          case 64: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 82: {
            if (unk3300BGINEMHBNAD_ == null) {
              Unk3300BGINEMHBNAD = new global::Weedwacker.Shared.Network.Proto.IrodoriChessMapData();
            }
            input.ReadMessage(Unk3300BGINEMHBNAD);
            break;
          }
          case 112: {
            LevelId = input.ReadUInt32();
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
