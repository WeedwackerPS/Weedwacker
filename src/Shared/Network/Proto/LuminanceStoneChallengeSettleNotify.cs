// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LuminanceStoneChallengeSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from LuminanceStoneChallengeSettleNotify.proto</summary>
  public static partial class LuminanceStoneChallengeSettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for LuminanceStoneChallengeSettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LuminanceStoneChallengeSettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilMdW1pbmFuY2VTdG9uZUNoYWxsZW5nZVNldHRsZU5vdGlmeS5wcm90bxIf",
            "V2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90bxonTHVtaW5hbmNlU3Rv",
            "bmVDaGFsbGVuZ2VTZXR0bGVJbmZvLnByb3RvIpIBCiNMdW1pbmFuY2VTdG9u",
            "ZUNoYWxsZW5nZVNldHRsZU5vdGlmeRISCgpnYWxsZXJ5X2lkGAMgASgNElcK",
            "C3NldHRsZV9pbmZvGAUgASgLMkIuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29y",
            "ay5Qcm90by5MdW1pbmFuY2VTdG9uZUNoYWxsZW5nZVNldHRsZUluZm9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.LuminanceStoneChallengeSettleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.LuminanceStoneChallengeSettleNotify), global::Weedwacker.Shared.Network.Proto.LuminanceStoneChallengeSettleNotify.Parser, new[]{ "GalleryId", "SettleInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8784;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class LuminanceStoneChallengeSettleNotify : pb::IMessage<LuminanceStoneChallengeSettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LuminanceStoneChallengeSettleNotify> _parser = new pb::MessageParser<LuminanceStoneChallengeSettleNotify>(() => new LuminanceStoneChallengeSettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LuminanceStoneChallengeSettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.LuminanceStoneChallengeSettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LuminanceStoneChallengeSettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LuminanceStoneChallengeSettleNotify(LuminanceStoneChallengeSettleNotify other) : this() {
      galleryId_ = other.galleryId_;
      settleInfo_ = other.settleInfo_ != null ? other.settleInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LuminanceStoneChallengeSettleNotify Clone() {
      return new LuminanceStoneChallengeSettleNotify(this);
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 3;
    private uint galleryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryId {
      get { return galleryId_; }
      set {
        galleryId_ = value;
      }
    }

    /// <summary>Field number for the "settle_info" field.</summary>
    public const int SettleInfoFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.LuminanceStoneChallengeSettleInfo settleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.LuminanceStoneChallengeSettleInfo SettleInfo {
      get { return settleInfo_; }
      set {
        settleInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LuminanceStoneChallengeSettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LuminanceStoneChallengeSettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GalleryId != other.GalleryId) return false;
      if (!object.Equals(SettleInfo, other.SettleInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
      if (settleInfo_ != null) hash ^= SettleInfo.GetHashCode();
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
      if (GalleryId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GalleryId);
      }
      if (settleInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(SettleInfo);
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
      if (GalleryId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GalleryId);
      }
      if (settleInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(SettleInfo);
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
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      if (settleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SettleInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LuminanceStoneChallengeSettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.GalleryId != 0) {
        GalleryId = other.GalleryId;
      }
      if (other.settleInfo_ != null) {
        if (settleInfo_ == null) {
          SettleInfo = new global::Weedwacker.Shared.Network.Proto.LuminanceStoneChallengeSettleInfo();
        }
        SettleInfo.MergeFrom(other.SettleInfo);
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
          case 24: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 42: {
            if (settleInfo_ == null) {
              SettleInfo = new global::Weedwacker.Shared.Network.Proto.LuminanceStoneChallengeSettleInfo();
            }
            input.ReadMessage(SettleInfo);
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
          case 24: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 42: {
            if (settleInfo_ == null) {
              SettleInfo = new global::Weedwacker.Shared.Network.Proto.LuminanceStoneChallengeSettleInfo();
            }
            input.ReadMessage(SettleInfo);
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
