// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AnchorPointOpReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AnchorPointOpReq.proto</summary>
  public static partial class AnchorPointOpReqReflection {

    #region Descriptor
    /// <summary>File descriptor for AnchorPointOpReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AnchorPointOpReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZBbmNob3JQb2ludE9wUmVxLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5O",
            "ZXR3b3JrLlByb3RvIsEBChBBbmNob3JQb2ludE9wUmVxEhcKD2FuY2hvcl9w",
            "b2ludF9pZBgEIAEoDRIcChRhbmNob3JfcG9pbnRfb3BfdHlwZRgKIAEoDSJ2",
            "ChFBbmNob3JQb2ludE9wVHlwZRIdChlBTkNIT1JfUE9JTlRfT1BfVFlQRV9O",
            "T05FEAASIQodQU5DSE9SX1BPSU5UX09QX1RZUEVfVEVMRVBPUlQQARIfChtB",
            "TkNIT1JfUE9JTlRfT1BfVFlQRV9SRU1PVkUQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AnchorPointOpReq), global::Weedwacker.Shared.Network.Proto.AnchorPointOpReq.Parser, new[]{ "AnchorPointId", "AnchorPointOpType" }, null, new[]{ typeof(global::Weedwacker.Shared.Network.Proto.AnchorPointOpReq.Types.AnchorPointOpType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4285;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class AnchorPointOpReq : pb::IMessage<AnchorPointOpReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AnchorPointOpReq> _parser = new pb::MessageParser<AnchorPointOpReq>(() => new AnchorPointOpReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AnchorPointOpReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AnchorPointOpReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnchorPointOpReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnchorPointOpReq(AnchorPointOpReq other) : this() {
      anchorPointId_ = other.anchorPointId_;
      anchorPointOpType_ = other.anchorPointOpType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnchorPointOpReq Clone() {
      return new AnchorPointOpReq(this);
    }

    /// <summary>Field number for the "anchor_point_id" field.</summary>
    public const int AnchorPointIdFieldNumber = 4;
    private uint anchorPointId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AnchorPointId {
      get { return anchorPointId_; }
      set {
        anchorPointId_ = value;
      }
    }

    /// <summary>Field number for the "anchor_point_op_type" field.</summary>
    public const int AnchorPointOpTypeFieldNumber = 10;
    private uint anchorPointOpType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AnchorPointOpType {
      get { return anchorPointOpType_; }
      set {
        anchorPointOpType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AnchorPointOpReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AnchorPointOpReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AnchorPointId != other.AnchorPointId) return false;
      if (AnchorPointOpType != other.AnchorPointOpType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AnchorPointId != 0) hash ^= AnchorPointId.GetHashCode();
      if (AnchorPointOpType != 0) hash ^= AnchorPointOpType.GetHashCode();
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
      if (AnchorPointId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AnchorPointId);
      }
      if (AnchorPointOpType != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(AnchorPointOpType);
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
      if (AnchorPointId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AnchorPointId);
      }
      if (AnchorPointOpType != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(AnchorPointOpType);
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
      if (AnchorPointId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AnchorPointId);
      }
      if (AnchorPointOpType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AnchorPointOpType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AnchorPointOpReq other) {
      if (other == null) {
        return;
      }
      if (other.AnchorPointId != 0) {
        AnchorPointId = other.AnchorPointId;
      }
      if (other.AnchorPointOpType != 0) {
        AnchorPointOpType = other.AnchorPointOpType;
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
            AnchorPointId = input.ReadUInt32();
            break;
          }
          case 80: {
            AnchorPointOpType = input.ReadUInt32();
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
            AnchorPointId = input.ReadUInt32();
            break;
          }
          case 80: {
            AnchorPointOpType = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AnchorPointOpReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum AnchorPointOpType {
        [pbr::OriginalName("ANCHOR_POINT_OP_TYPE_NONE")] None = 0,
        [pbr::OriginalName("ANCHOR_POINT_OP_TYPE_TELEPORT")] Teleport = 1,
        [pbr::OriginalName("ANCHOR_POINT_OP_TYPE_REMOVE")] Remove = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
