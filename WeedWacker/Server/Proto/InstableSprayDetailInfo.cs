// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InstableSprayDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from InstableSprayDetailInfo.proto</summary>
  public static partial class InstableSprayDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for InstableSprayDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InstableSprayDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1JbnN0YWJsZVNwcmF5RGV0YWlsSW5mby5wcm90bxoZVW5rMzAwMF9JQ0xL",
            "SkpOR09ITi5wcm90byJMChdJbnN0YWJsZVNwcmF5RGV0YWlsSW5mbxIxChNV",
            "bmsyNzAwX1BIS0hJUExET09BGAkgAygLMhQuVW5rMzAwMF9JQ0xLSkpOR09I",
            "TkIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.Unk3000ICLKJJNGOHNReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.InstableSprayDetailInfo), global::Weedwacker.Server.Proto.InstableSprayDetailInfo.Parser, new[]{ "Unk2700PHKHIPLDOOA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InstableSprayDetailInfo : pb::IMessage<InstableSprayDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InstableSprayDetailInfo> _parser = new pb::MessageParser<InstableSprayDetailInfo>(() => new InstableSprayDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InstableSprayDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.InstableSprayDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InstableSprayDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InstableSprayDetailInfo(InstableSprayDetailInfo other) : this() {
      unk2700PHKHIPLDOOA_ = other.unk2700PHKHIPLDOOA_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InstableSprayDetailInfo Clone() {
      return new InstableSprayDetailInfo(this);
    }

    /// <summary>Field number for the "Unk2700_PHKHIPLDOOA" field.</summary>
    public const int Unk2700PHKHIPLDOOAFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.Unk3000_ICLKJJNGOHN> _repeated_unk2700PHKHIPLDOOA_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Server.Proto.Unk3000_ICLKJJNGOHN.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk3000_ICLKJJNGOHN> unk2700PHKHIPLDOOA_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk3000_ICLKJJNGOHN>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk3000_ICLKJJNGOHN> Unk2700PHKHIPLDOOA {
      get { return unk2700PHKHIPLDOOA_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as InstableSprayDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InstableSprayDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk2700PHKHIPLDOOA_.Equals(other.unk2700PHKHIPLDOOA_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk2700PHKHIPLDOOA_.GetHashCode();
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
      unk2700PHKHIPLDOOA_.WriteTo(output, _repeated_unk2700PHKHIPLDOOA_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unk2700PHKHIPLDOOA_.WriteTo(ref output, _repeated_unk2700PHKHIPLDOOA_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unk2700PHKHIPLDOOA_.CalculateSize(_repeated_unk2700PHKHIPLDOOA_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(InstableSprayDetailInfo other) {
      if (other == null) {
        return;
      }
      unk2700PHKHIPLDOOA_.Add(other.unk2700PHKHIPLDOOA_);
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
          case 74: {
            unk2700PHKHIPLDOOA_.AddEntriesFrom(input, _repeated_unk2700PHKHIPLDOOA_codec);
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
          case 74: {
            unk2700PHKHIPLDOOA_.AddEntriesFrom(ref input, _repeated_unk2700PHKHIPLDOOA_codec);
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