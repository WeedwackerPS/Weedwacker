// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeBlueprintBatchBriefMuipData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeBlueprintBatchBriefMuipData.proto</summary>
  public static partial class HomeBlueprintBatchBriefMuipDataReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeBlueprintBatchBriefMuipData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeBlueprintBatchBriefMuipDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVIb21lQmx1ZXByaW50QmF0Y2hCcmllZk11aXBEYXRhLnByb3RvEh9XZWVk",
            "d2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvGiBIb21lQmx1ZXByaW50QnJp",
            "ZWZNdWlwRGF0YS5wcm90byKVAQofSG9tZUJsdWVwcmludEJhdGNoQnJpZWZN",
            "dWlwRGF0YRJPCgpicmllZl9saXN0GAEgAygLMjsuV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90by5Ib21lQmx1ZXByaW50QnJpZWZNdWlwRGF0YRIh",
            "Chlub3RfZXhpc3Rfc2hhcmVfY29kZV9saXN0GAIgAygJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.HomeBlueprintBriefMuipDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeBlueprintBatchBriefMuipData), global::Weedwacker.Shared.Network.Proto.HomeBlueprintBatchBriefMuipData.Parser, new[]{ "BriefList", "NotExistShareCodeList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeBlueprintBatchBriefMuipData : pb::IMessage<HomeBlueprintBatchBriefMuipData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeBlueprintBatchBriefMuipData> _parser = new pb::MessageParser<HomeBlueprintBatchBriefMuipData>(() => new HomeBlueprintBatchBriefMuipData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeBlueprintBatchBriefMuipData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeBlueprintBatchBriefMuipDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlueprintBatchBriefMuipData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlueprintBatchBriefMuipData(HomeBlueprintBatchBriefMuipData other) : this() {
      briefList_ = other.briefList_.Clone();
      notExistShareCodeList_ = other.notExistShareCodeList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlueprintBatchBriefMuipData Clone() {
      return new HomeBlueprintBatchBriefMuipData(this);
    }

    /// <summary>Field number for the "brief_list" field.</summary>
    public const int BriefListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.HomeBlueprintBriefMuipData> _repeated_briefList_codec
        = pb::FieldCodec.ForMessage(10, global::Weedwacker.Shared.Network.Proto.HomeBlueprintBriefMuipData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeBlueprintBriefMuipData> briefList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeBlueprintBriefMuipData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeBlueprintBriefMuipData> BriefList {
      get { return briefList_; }
    }

    /// <summary>Field number for the "not_exist_share_code_list" field.</summary>
    public const int NotExistShareCodeListFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_notExistShareCodeList_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> notExistShareCodeList_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> NotExistShareCodeList {
      get { return notExistShareCodeList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeBlueprintBatchBriefMuipData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeBlueprintBatchBriefMuipData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!briefList_.Equals(other.briefList_)) return false;
      if(!notExistShareCodeList_.Equals(other.notExistShareCodeList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= briefList_.GetHashCode();
      hash ^= notExistShareCodeList_.GetHashCode();
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
      briefList_.WriteTo(output, _repeated_briefList_codec);
      notExistShareCodeList_.WriteTo(output, _repeated_notExistShareCodeList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      briefList_.WriteTo(ref output, _repeated_briefList_codec);
      notExistShareCodeList_.WriteTo(ref output, _repeated_notExistShareCodeList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += briefList_.CalculateSize(_repeated_briefList_codec);
      size += notExistShareCodeList_.CalculateSize(_repeated_notExistShareCodeList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeBlueprintBatchBriefMuipData other) {
      if (other == null) {
        return;
      }
      briefList_.Add(other.briefList_);
      notExistShareCodeList_.Add(other.notExistShareCodeList_);
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
          case 10: {
            briefList_.AddEntriesFrom(input, _repeated_briefList_codec);
            break;
          }
          case 18: {
            notExistShareCodeList_.AddEntriesFrom(input, _repeated_notExistShareCodeList_codec);
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
          case 10: {
            briefList_.AddEntriesFrom(ref input, _repeated_briefList_codec);
            break;
          }
          case 18: {
            notExistShareCodeList_.AddEntriesFrom(ref input, _repeated_notExistShareCodeList_codec);
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
