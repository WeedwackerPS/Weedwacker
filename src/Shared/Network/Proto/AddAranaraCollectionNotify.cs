// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AddAranaraCollectionNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AddAranaraCollectionNotify.proto</summary>
  public static partial class AddAranaraCollectionNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for AddAranaraCollectionNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AddAranaraCollectionNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBBZGRBcmFuYXJhQ29sbGVjdGlvbk5vdGlmeS5wcm90bxIfV2VlZHdhY2tl",
            "ci5TaGFyZWQuTmV0d29yay5Qcm90bxocQXJhbmFyYUNvbGxlY3Rpb25TdGF0",
            "ZS5wcm90byL4AQoaQWRkQXJhbmFyYUNvbGxlY3Rpb25Ob3RpZnkSVAoTVW5r",
            "MzMwMF9OSkxKQkJNSkxCSxgKIAEoDjI3LldlZWR3YWNrZXIuU2hhcmVkLk5l",
            "dHdvcmsuUHJvdG8uQXJhbmFyYUNvbGxlY3Rpb25TdGF0ZRIVCg1jb2xsZWN0",
            "aW9uX2lkGAcgASgNElQKE1VuazMzMDBfQUZCSUJMTktDT0QYBCABKA4yNy5X",
            "ZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLkFyYW5hcmFDb2xsZWN0",
            "aW9uU3RhdGUSFwoPY29sbGVjdGlvbl90eXBlGAIgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.AranaraCollectionStateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AddAranaraCollectionNotify), global::Weedwacker.Shared.Network.Proto.AddAranaraCollectionNotify.Parser, new[]{ "Unk3300NJLJBBMJLBK", "CollectionId", "Unk3300AFBIBLNKCOD", "CollectionType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 6391;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class AddAranaraCollectionNotify : pb::IMessage<AddAranaraCollectionNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AddAranaraCollectionNotify> _parser = new pb::MessageParser<AddAranaraCollectionNotify>(() => new AddAranaraCollectionNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AddAranaraCollectionNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AddAranaraCollectionNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddAranaraCollectionNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddAranaraCollectionNotify(AddAranaraCollectionNotify other) : this() {
      unk3300NJLJBBMJLBK_ = other.unk3300NJLJBBMJLBK_;
      collectionId_ = other.collectionId_;
      unk3300AFBIBLNKCOD_ = other.unk3300AFBIBLNKCOD_;
      collectionType_ = other.collectionType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddAranaraCollectionNotify Clone() {
      return new AddAranaraCollectionNotify(this);
    }

    /// <summary>Field number for the "Unk3300_NJLJBBMJLBK" field.</summary>
    public const int Unk3300NJLJBBMJLBKFieldNumber = 10;
    private global::Weedwacker.Shared.Network.Proto.AranaraCollectionState unk3300NJLJBBMJLBK_ = global::Weedwacker.Shared.Network.Proto.AranaraCollectionState.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.AranaraCollectionState Unk3300NJLJBBMJLBK {
      get { return unk3300NJLJBBMJLBK_; }
      set {
        unk3300NJLJBBMJLBK_ = value;
      }
    }

    /// <summary>Field number for the "collection_id" field.</summary>
    public const int CollectionIdFieldNumber = 7;
    private uint collectionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CollectionId {
      get { return collectionId_; }
      set {
        collectionId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_AFBIBLNKCOD" field.</summary>
    public const int Unk3300AFBIBLNKCODFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.AranaraCollectionState unk3300AFBIBLNKCOD_ = global::Weedwacker.Shared.Network.Proto.AranaraCollectionState.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.AranaraCollectionState Unk3300AFBIBLNKCOD {
      get { return unk3300AFBIBLNKCOD_; }
      set {
        unk3300AFBIBLNKCOD_ = value;
      }
    }

    /// <summary>Field number for the "collection_type" field.</summary>
    public const int CollectionTypeFieldNumber = 2;
    private uint collectionType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CollectionType {
      get { return collectionType_; }
      set {
        collectionType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AddAranaraCollectionNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AddAranaraCollectionNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300NJLJBBMJLBK != other.Unk3300NJLJBBMJLBK) return false;
      if (CollectionId != other.CollectionId) return false;
      if (Unk3300AFBIBLNKCOD != other.Unk3300AFBIBLNKCOD) return false;
      if (CollectionType != other.CollectionType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300NJLJBBMJLBK != global::Weedwacker.Shared.Network.Proto.AranaraCollectionState.None) hash ^= Unk3300NJLJBBMJLBK.GetHashCode();
      if (CollectionId != 0) hash ^= CollectionId.GetHashCode();
      if (Unk3300AFBIBLNKCOD != global::Weedwacker.Shared.Network.Proto.AranaraCollectionState.None) hash ^= Unk3300AFBIBLNKCOD.GetHashCode();
      if (CollectionType != 0) hash ^= CollectionType.GetHashCode();
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
      if (CollectionType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CollectionType);
      }
      if (Unk3300AFBIBLNKCOD != global::Weedwacker.Shared.Network.Proto.AranaraCollectionState.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Unk3300AFBIBLNKCOD);
      }
      if (CollectionId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CollectionId);
      }
      if (Unk3300NJLJBBMJLBK != global::Weedwacker.Shared.Network.Proto.AranaraCollectionState.None) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Unk3300NJLJBBMJLBK);
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
      if (CollectionType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CollectionType);
      }
      if (Unk3300AFBIBLNKCOD != global::Weedwacker.Shared.Network.Proto.AranaraCollectionState.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Unk3300AFBIBLNKCOD);
      }
      if (CollectionId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CollectionId);
      }
      if (Unk3300NJLJBBMJLBK != global::Weedwacker.Shared.Network.Proto.AranaraCollectionState.None) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Unk3300NJLJBBMJLBK);
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
      if (Unk3300NJLJBBMJLBK != global::Weedwacker.Shared.Network.Proto.AranaraCollectionState.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Unk3300NJLJBBMJLBK);
      }
      if (CollectionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CollectionId);
      }
      if (Unk3300AFBIBLNKCOD != global::Weedwacker.Shared.Network.Proto.AranaraCollectionState.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Unk3300AFBIBLNKCOD);
      }
      if (CollectionType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CollectionType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AddAranaraCollectionNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300NJLJBBMJLBK != global::Weedwacker.Shared.Network.Proto.AranaraCollectionState.None) {
        Unk3300NJLJBBMJLBK = other.Unk3300NJLJBBMJLBK;
      }
      if (other.CollectionId != 0) {
        CollectionId = other.CollectionId;
      }
      if (other.Unk3300AFBIBLNKCOD != global::Weedwacker.Shared.Network.Proto.AranaraCollectionState.None) {
        Unk3300AFBIBLNKCOD = other.Unk3300AFBIBLNKCOD;
      }
      if (other.CollectionType != 0) {
        CollectionType = other.CollectionType;
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
            CollectionType = input.ReadUInt32();
            break;
          }
          case 32: {
            Unk3300AFBIBLNKCOD = (global::Weedwacker.Shared.Network.Proto.AranaraCollectionState) input.ReadEnum();
            break;
          }
          case 56: {
            CollectionId = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300NJLJBBMJLBK = (global::Weedwacker.Shared.Network.Proto.AranaraCollectionState) input.ReadEnum();
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
            CollectionType = input.ReadUInt32();
            break;
          }
          case 32: {
            Unk3300AFBIBLNKCOD = (global::Weedwacker.Shared.Network.Proto.AranaraCollectionState) input.ReadEnum();
            break;
          }
          case 56: {
            CollectionId = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300NJLJBBMJLBK = (global::Weedwacker.Shared.Network.Proto.AranaraCollectionState) input.ReadEnum();
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
