// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneEntityAppearNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SceneEntityAppearNotify.proto</summary>
  public static partial class SceneEntityAppearNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneEntityAppearNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneEntityAppearNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1TY2VuZUVudGl0eUFwcGVhck5vdGlmeS5wcm90bxoVU2NlbmVFbnRpdHlJ",
            "bmZvLnByb3RvGhBWaXNpb25UeXBlLnByb3RvInEKF1NjZW5lRW50aXR5QXBw",
            "ZWFyTm90aWZ5EiAKC2FwcGVhcl90eXBlGA8gASgOMgsuVmlzaW9uVHlwZRIN",
            "CgVwYXJhbRgJIAEoDRIlCgtlbnRpdHlfbGlzdBgFIAMoCzIQLlNjZW5lRW50",
            "aXR5SW5mb0IiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.SceneEntityInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VisionTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SceneEntityAppearNotify), global::Weedwacker.Shared.Network.Proto.SceneEntityAppearNotify.Parser, new[]{ "AppearType", "Param", "EntityList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 221
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class SceneEntityAppearNotify : pb::IMessage<SceneEntityAppearNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneEntityAppearNotify> _parser = new pb::MessageParser<SceneEntityAppearNotify>(() => new SceneEntityAppearNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneEntityAppearNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SceneEntityAppearNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityAppearNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityAppearNotify(SceneEntityAppearNotify other) : this() {
      appearType_ = other.appearType_;
      param_ = other.param_;
      entityList_ = other.entityList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityAppearNotify Clone() {
      return new SceneEntityAppearNotify(this);
    }

    /// <summary>Field number for the "appear_type" field.</summary>
    public const int AppearTypeFieldNumber = 15;
    private global::Weedwacker.Shared.Network.Proto.VisionType appearType_ = global::Weedwacker.Shared.Network.Proto.VisionType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.VisionType AppearType {
      get { return appearType_; }
      set {
        appearType_ = value;
      }
    }

    /// <summary>Field number for the "param" field.</summary>
    public const int ParamFieldNumber = 9;
    private uint param_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Param {
      get { return param_; }
      set {
        param_ = value;
      }
    }

    /// <summary>Field number for the "entity_list" field.</summary>
    public const int EntityListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.SceneEntityInfo> _repeated_entityList_codec
        = pb::FieldCodec.ForMessage(42, global::Weedwacker.Shared.Network.Proto.SceneEntityInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SceneEntityInfo> entityList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SceneEntityInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SceneEntityInfo> EntityList {
      get { return entityList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneEntityAppearNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneEntityAppearNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AppearType != other.AppearType) return false;
      if (Param != other.Param) return false;
      if(!entityList_.Equals(other.entityList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AppearType != global::Weedwacker.Shared.Network.Proto.VisionType.None) hash ^= AppearType.GetHashCode();
      if (Param != 0) hash ^= Param.GetHashCode();
      hash ^= entityList_.GetHashCode();
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
      entityList_.WriteTo(output, _repeated_entityList_codec);
      if (Param != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Param);
      }
      if (AppearType != global::Weedwacker.Shared.Network.Proto.VisionType.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) AppearType);
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
      entityList_.WriteTo(ref output, _repeated_entityList_codec);
      if (Param != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Param);
      }
      if (AppearType != global::Weedwacker.Shared.Network.Proto.VisionType.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) AppearType);
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
      if (AppearType != global::Weedwacker.Shared.Network.Proto.VisionType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AppearType);
      }
      if (Param != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Param);
      }
      size += entityList_.CalculateSize(_repeated_entityList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneEntityAppearNotify other) {
      if (other == null) {
        return;
      }
      if (other.AppearType != global::Weedwacker.Shared.Network.Proto.VisionType.None) {
        AppearType = other.AppearType;
      }
      if (other.Param != 0) {
        Param = other.Param;
      }
      entityList_.Add(other.entityList_);
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
          case 42: {
            entityList_.AddEntriesFrom(input, _repeated_entityList_codec);
            break;
          }
          case 72: {
            Param = input.ReadUInt32();
            break;
          }
          case 120: {
            AppearType = (global::Weedwacker.Shared.Network.Proto.VisionType) input.ReadEnum();
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
          case 42: {
            entityList_.AddEntriesFrom(ref input, _repeated_entityList_codec);
            break;
          }
          case 72: {
            Param = input.ReadUInt32();
            break;
          }
          case 120: {
            AppearType = (global::Weedwacker.Shared.Network.Proto.VisionType) input.ReadEnum();
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