// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MultistageSettleWatcherInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from MultistageSettleWatcherInfo.proto</summary>
  public static partial class MultistageSettleWatcherInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for MultistageSettleWatcherInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MultistageSettleWatcherInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFNdWx0aXN0YWdlU2V0dGxlV2F0Y2hlckluZm8ucHJvdG8SH1dlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8icwobTXVsdGlzdGFnZVNldHRsZVdh",
            "dGNoZXJJbmZvEhIKCmlzX2ludmVyc2UYAyABKAgSFAoMY3VyX3Byb2dyZXNz",
            "GAYgASgNEhIKCndhdGNoZXJfaWQYBSABKA0SFgoOdG90YWxfcHJvZ3Jlc3MY",
            "CyABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.MultistageSettleWatcherInfo), global::Weedwacker.Shared.Network.Proto.MultistageSettleWatcherInfo.Parser, new[]{ "IsInverse", "CurProgress", "WatcherId", "TotalProgress" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MultistageSettleWatcherInfo : pb::IMessage<MultistageSettleWatcherInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MultistageSettleWatcherInfo> _parser = new pb::MessageParser<MultistageSettleWatcherInfo>(() => new MultistageSettleWatcherInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MultistageSettleWatcherInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.MultistageSettleWatcherInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultistageSettleWatcherInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultistageSettleWatcherInfo(MultistageSettleWatcherInfo other) : this() {
      isInverse_ = other.isInverse_;
      curProgress_ = other.curProgress_;
      watcherId_ = other.watcherId_;
      totalProgress_ = other.totalProgress_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultistageSettleWatcherInfo Clone() {
      return new MultistageSettleWatcherInfo(this);
    }

    /// <summary>Field number for the "is_inverse" field.</summary>
    public const int IsInverseFieldNumber = 3;
    private bool isInverse_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsInverse {
      get { return isInverse_; }
      set {
        isInverse_ = value;
      }
    }

    /// <summary>Field number for the "cur_progress" field.</summary>
    public const int CurProgressFieldNumber = 6;
    private uint curProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurProgress {
      get { return curProgress_; }
      set {
        curProgress_ = value;
      }
    }

    /// <summary>Field number for the "watcher_id" field.</summary>
    public const int WatcherIdFieldNumber = 5;
    private uint watcherId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WatcherId {
      get { return watcherId_; }
      set {
        watcherId_ = value;
      }
    }

    /// <summary>Field number for the "total_progress" field.</summary>
    public const int TotalProgressFieldNumber = 11;
    private uint totalProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalProgress {
      get { return totalProgress_; }
      set {
        totalProgress_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MultistageSettleWatcherInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MultistageSettleWatcherInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsInverse != other.IsInverse) return false;
      if (CurProgress != other.CurProgress) return false;
      if (WatcherId != other.WatcherId) return false;
      if (TotalProgress != other.TotalProgress) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsInverse != false) hash ^= IsInverse.GetHashCode();
      if (CurProgress != 0) hash ^= CurProgress.GetHashCode();
      if (WatcherId != 0) hash ^= WatcherId.GetHashCode();
      if (TotalProgress != 0) hash ^= TotalProgress.GetHashCode();
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
      if (IsInverse != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsInverse);
      }
      if (WatcherId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(WatcherId);
      }
      if (CurProgress != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CurProgress);
      }
      if (TotalProgress != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TotalProgress);
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
      if (IsInverse != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsInverse);
      }
      if (WatcherId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(WatcherId);
      }
      if (CurProgress != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CurProgress);
      }
      if (TotalProgress != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TotalProgress);
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
      if (IsInverse != false) {
        size += 1 + 1;
      }
      if (CurProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurProgress);
      }
      if (WatcherId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WatcherId);
      }
      if (TotalProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalProgress);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MultistageSettleWatcherInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsInverse != false) {
        IsInverse = other.IsInverse;
      }
      if (other.CurProgress != 0) {
        CurProgress = other.CurProgress;
      }
      if (other.WatcherId != 0) {
        WatcherId = other.WatcherId;
      }
      if (other.TotalProgress != 0) {
        TotalProgress = other.TotalProgress;
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
            IsInverse = input.ReadBool();
            break;
          }
          case 40: {
            WatcherId = input.ReadUInt32();
            break;
          }
          case 48: {
            CurProgress = input.ReadUInt32();
            break;
          }
          case 88: {
            TotalProgress = input.ReadUInt32();
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
            IsInverse = input.ReadBool();
            break;
          }
          case 40: {
            WatcherId = input.ReadUInt32();
            break;
          }
          case 48: {
            CurProgress = input.ReadUInt32();
            break;
          }
          case 88: {
            TotalProgress = input.ReadUInt32();
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
