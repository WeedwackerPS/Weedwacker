// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MassiveBoxInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from MassiveBoxInfo.proto</summary>
  public static partial class MassiveBoxInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for MassiveBoxInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MassiveBoxInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRNYXNzaXZlQm94SW5mby5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQuTmV0",
            "d29yay5Qcm90bxoMVmVjdG9yLnByb3RvIskCCg5NYXNzaXZlQm94SW5mbxIK",
            "CgJpZBgBIAEoBRIRCgljb25maWdfaWQYAiABKA0SNwoGY2VudGVyGAMgASgL",
            "MicuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5WZWN0b3ISOAoH",
            "ZXh0ZW50cxgEIAEoCzInLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJv",
            "dG8uVmVjdG9yEjMKAnVwGAUgASgLMicuV2VlZHdhY2tlci5TaGFyZWQuTmV0",
            "d29yay5Qcm90by5WZWN0b3ISOAoHZm9yd2FyZBgGIAEoCzInLldlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uVmVjdG9yEjYKBXJpZ2h0GAcgASgL",
            "MicuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5WZWN0b3JiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.MassiveBoxInfo), global::Weedwacker.Shared.Network.Proto.MassiveBoxInfo.Parser, new[]{ "Id", "ConfigId", "Center", "Extents", "Up", "Forward", "Right" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MassiveBoxInfo : pb::IMessage<MassiveBoxInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MassiveBoxInfo> _parser = new pb::MessageParser<MassiveBoxInfo>(() => new MassiveBoxInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MassiveBoxInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.MassiveBoxInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MassiveBoxInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MassiveBoxInfo(MassiveBoxInfo other) : this() {
      id_ = other.id_;
      configId_ = other.configId_;
      center_ = other.center_ != null ? other.center_.Clone() : null;
      extents_ = other.extents_ != null ? other.extents_.Clone() : null;
      up_ = other.up_ != null ? other.up_.Clone() : null;
      forward_ = other.forward_ != null ? other.forward_.Clone() : null;
      right_ = other.right_ != null ? other.right_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MassiveBoxInfo Clone() {
      return new MassiveBoxInfo(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 2;
    private uint configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "center" field.</summary>
    public const int CenterFieldNumber = 3;
    private global::Weedwacker.Shared.Network.Proto.Vector center_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Center {
      get { return center_; }
      set {
        center_ = value;
      }
    }

    /// <summary>Field number for the "extents" field.</summary>
    public const int ExtentsFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.Vector extents_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Extents {
      get { return extents_; }
      set {
        extents_ = value;
      }
    }

    /// <summary>Field number for the "up" field.</summary>
    public const int UpFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.Vector up_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Up {
      get { return up_; }
      set {
        up_ = value;
      }
    }

    /// <summary>Field number for the "forward" field.</summary>
    public const int ForwardFieldNumber = 6;
    private global::Weedwacker.Shared.Network.Proto.Vector forward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Forward {
      get { return forward_; }
      set {
        forward_ = value;
      }
    }

    /// <summary>Field number for the "right" field.</summary>
    public const int RightFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.Vector right_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Right {
      get { return right_; }
      set {
        right_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MassiveBoxInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MassiveBoxInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (ConfigId != other.ConfigId) return false;
      if (!object.Equals(Center, other.Center)) return false;
      if (!object.Equals(Extents, other.Extents)) return false;
      if (!object.Equals(Up, other.Up)) return false;
      if (!object.Equals(Forward, other.Forward)) return false;
      if (!object.Equals(Right, other.Right)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (center_ != null) hash ^= Center.GetHashCode();
      if (extents_ != null) hash ^= Extents.GetHashCode();
      if (up_ != null) hash ^= Up.GetHashCode();
      if (forward_ != null) hash ^= Forward.GetHashCode();
      if (right_ != null) hash ^= Right.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ConfigId);
      }
      if (center_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Center);
      }
      if (extents_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Extents);
      }
      if (up_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Up);
      }
      if (forward_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Forward);
      }
      if (right_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Right);
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ConfigId);
      }
      if (center_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Center);
      }
      if (extents_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Extents);
      }
      if (up_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Up);
      }
      if (forward_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Forward);
      }
      if (right_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Right);
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
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
      }
      if (center_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Center);
      }
      if (extents_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Extents);
      }
      if (up_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Up);
      }
      if (forward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Forward);
      }
      if (right_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Right);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MassiveBoxInfo other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.center_ != null) {
        if (center_ == null) {
          Center = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Center.MergeFrom(other.Center);
      }
      if (other.extents_ != null) {
        if (extents_ == null) {
          Extents = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Extents.MergeFrom(other.Extents);
      }
      if (other.up_ != null) {
        if (up_ == null) {
          Up = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Up.MergeFrom(other.Up);
      }
      if (other.forward_ != null) {
        if (forward_ == null) {
          Forward = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Forward.MergeFrom(other.Forward);
      }
      if (other.right_ != null) {
        if (right_ == null) {
          Right = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Right.MergeFrom(other.Right);
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
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 26: {
            if (center_ == null) {
              Center = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Center);
            break;
          }
          case 34: {
            if (extents_ == null) {
              Extents = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Extents);
            break;
          }
          case 42: {
            if (up_ == null) {
              Up = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Up);
            break;
          }
          case 50: {
            if (forward_ == null) {
              Forward = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Forward);
            break;
          }
          case 58: {
            if (right_ == null) {
              Right = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Right);
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
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 26: {
            if (center_ == null) {
              Center = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Center);
            break;
          }
          case 34: {
            if (extents_ == null) {
              Extents = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Extents);
            break;
          }
          case 42: {
            if (up_ == null) {
              Up = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Up);
            break;
          }
          case 50: {
            if (forward_ == null) {
              Forward = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Forward);
            break;
          }
          case 58: {
            if (right_ == null) {
              Right = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Right);
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
