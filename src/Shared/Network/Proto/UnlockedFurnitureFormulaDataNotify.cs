// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UnlockedFurnitureFormulaDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from UnlockedFurnitureFormulaDataNotify.proto</summary>
  public static partial class UnlockedFurnitureFormulaDataNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for UnlockedFurnitureFormulaDataNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnlockedFurnitureFormulaDataNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihVbmxvY2tlZEZ1cm5pdHVyZUZvcm11bGFEYXRhTm90aWZ5LnByb3RvEh9X",
            "ZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvIk8KIlVubG9ja2VkRnVy",
            "bml0dXJlRm9ybXVsYURhdGFOb3RpZnkSDgoGaXNfYWxsGAQgASgIEhkKEWZ1",
            "cm5pdHVyZV9pZF9saXN0GAIgAygNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.UnlockedFurnitureFormulaDataNotify), global::Weedwacker.Shared.Network.Proto.UnlockedFurnitureFormulaDataNotify.Parser, new[]{ "IsAll", "FurnitureIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4716;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class UnlockedFurnitureFormulaDataNotify : pb::IMessage<UnlockedFurnitureFormulaDataNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UnlockedFurnitureFormulaDataNotify> _parser = new pb::MessageParser<UnlockedFurnitureFormulaDataNotify>(() => new UnlockedFurnitureFormulaDataNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UnlockedFurnitureFormulaDataNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.UnlockedFurnitureFormulaDataNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnlockedFurnitureFormulaDataNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnlockedFurnitureFormulaDataNotify(UnlockedFurnitureFormulaDataNotify other) : this() {
      isAll_ = other.isAll_;
      furnitureIdList_ = other.furnitureIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnlockedFurnitureFormulaDataNotify Clone() {
      return new UnlockedFurnitureFormulaDataNotify(this);
    }

    /// <summary>Field number for the "is_all" field.</summary>
    public const int IsAllFieldNumber = 4;
    private bool isAll_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAll {
      get { return isAll_; }
      set {
        isAll_ = value;
      }
    }

    /// <summary>Field number for the "furniture_id_list" field.</summary>
    public const int FurnitureIdListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_furnitureIdList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> furnitureIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FurnitureIdList {
      get { return furnitureIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UnlockedFurnitureFormulaDataNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UnlockedFurnitureFormulaDataNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsAll != other.IsAll) return false;
      if(!furnitureIdList_.Equals(other.furnitureIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsAll != false) hash ^= IsAll.GetHashCode();
      hash ^= furnitureIdList_.GetHashCode();
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
      furnitureIdList_.WriteTo(output, _repeated_furnitureIdList_codec);
      if (IsAll != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsAll);
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
      furnitureIdList_.WriteTo(ref output, _repeated_furnitureIdList_codec);
      if (IsAll != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsAll);
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
      if (IsAll != false) {
        size += 1 + 1;
      }
      size += furnitureIdList_.CalculateSize(_repeated_furnitureIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UnlockedFurnitureFormulaDataNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsAll != false) {
        IsAll = other.IsAll;
      }
      furnitureIdList_.Add(other.furnitureIdList_);
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
          case 18:
          case 16: {
            furnitureIdList_.AddEntriesFrom(input, _repeated_furnitureIdList_codec);
            break;
          }
          case 32: {
            IsAll = input.ReadBool();
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
          case 18:
          case 16: {
            furnitureIdList_.AddEntriesFrom(ref input, _repeated_furnitureIdList_codec);
            break;
          }
          case 32: {
            IsAll = input.ReadBool();
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
