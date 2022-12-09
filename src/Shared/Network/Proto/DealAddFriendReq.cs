// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DealAddFriendReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from DealAddFriendReq.proto</summary>
  public static partial class DealAddFriendReqReflection {

    #region Descriptor
    /// <summary>File descriptor for DealAddFriendReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DealAddFriendReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZEZWFsQWRkRnJpZW5kUmVxLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5O",
            "ZXR3b3JrLlByb3RvGh1EZWFsQWRkRnJpZW5kUmVzdWx0VHlwZS5wcm90byKA",
            "AQoQRGVhbEFkZEZyaWVuZFJlcRJYChZkZWFsX2FkZF9mcmllbmRfcmVzdWx0",
            "GAcgASgOMjguV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5EZWFs",
            "QWRkRnJpZW5kUmVzdWx0VHlwZRISCgp0YXJnZXRfdWlkGAogASgNYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.DealAddFriendResultTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.DealAddFriendReq), global::Weedwacker.Shared.Network.Proto.DealAddFriendReq.Parser, new[]{ "DealAddFriendResult", "TargetUid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4061;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class DealAddFriendReq : pb::IMessage<DealAddFriendReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DealAddFriendReq> _parser = new pb::MessageParser<DealAddFriendReq>(() => new DealAddFriendReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DealAddFriendReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.DealAddFriendReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DealAddFriendReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DealAddFriendReq(DealAddFriendReq other) : this() {
      dealAddFriendResult_ = other.dealAddFriendResult_;
      targetUid_ = other.targetUid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DealAddFriendReq Clone() {
      return new DealAddFriendReq(this);
    }

    /// <summary>Field number for the "deal_add_friend_result" field.</summary>
    public const int DealAddFriendResultFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.DealAddFriendResultType dealAddFriendResult_ = global::Weedwacker.Shared.Network.Proto.DealAddFriendResultType.Reject;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.DealAddFriendResultType DealAddFriendResult {
      get { return dealAddFriendResult_; }
      set {
        dealAddFriendResult_ = value;
      }
    }

    /// <summary>Field number for the "target_uid" field.</summary>
    public const int TargetUidFieldNumber = 10;
    private uint targetUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetUid {
      get { return targetUid_; }
      set {
        targetUid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DealAddFriendReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DealAddFriendReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DealAddFriendResult != other.DealAddFriendResult) return false;
      if (TargetUid != other.TargetUid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DealAddFriendResult != global::Weedwacker.Shared.Network.Proto.DealAddFriendResultType.Reject) hash ^= DealAddFriendResult.GetHashCode();
      if (TargetUid != 0) hash ^= TargetUid.GetHashCode();
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
      if (DealAddFriendResult != global::Weedwacker.Shared.Network.Proto.DealAddFriendResultType.Reject) {
        output.WriteRawTag(56);
        output.WriteEnum((int) DealAddFriendResult);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(TargetUid);
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
      if (DealAddFriendResult != global::Weedwacker.Shared.Network.Proto.DealAddFriendResultType.Reject) {
        output.WriteRawTag(56);
        output.WriteEnum((int) DealAddFriendResult);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(TargetUid);
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
      if (DealAddFriendResult != global::Weedwacker.Shared.Network.Proto.DealAddFriendResultType.Reject) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DealAddFriendResult);
      }
      if (TargetUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetUid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DealAddFriendReq other) {
      if (other == null) {
        return;
      }
      if (other.DealAddFriendResult != global::Weedwacker.Shared.Network.Proto.DealAddFriendResultType.Reject) {
        DealAddFriendResult = other.DealAddFriendResult;
      }
      if (other.TargetUid != 0) {
        TargetUid = other.TargetUid;
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
          case 56: {
            DealAddFriendResult = (global::Weedwacker.Shared.Network.Proto.DealAddFriendResultType) input.ReadEnum();
            break;
          }
          case 80: {
            TargetUid = input.ReadUInt32();
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
          case 56: {
            DealAddFriendResult = (global::Weedwacker.Shared.Network.Proto.DealAddFriendResultType) input.ReadEnum();
            break;
          }
          case 80: {
            TargetUid = input.ReadUInt32();
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
