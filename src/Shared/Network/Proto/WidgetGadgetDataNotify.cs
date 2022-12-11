// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WidgetGadgetDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from WidgetGadgetDataNotify.proto</summary>
  public static partial class WidgetGadgetDataNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for WidgetGadgetDataNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WidgetGadgetDataNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxXaWRnZXRHYWRnZXREYXRhTm90aWZ5LnByb3RvEh9XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvGhZXaWRnZXRHYWRnZXREYXRhLnByb3RvImcK",
            "FldpZGdldEdhZGdldERhdGFOb3RpZnkSTQoSd2lkZ2V0X2dhZGdldF9kYXRh",
            "GAMgASgLMjEuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5XaWRn",
            "ZXRHYWRnZXREYXRhYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.WidgetGadgetDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.WidgetGadgetDataNotify), global::Weedwacker.Shared.Network.Proto.WidgetGadgetDataNotify.Parser, new[]{ "WidgetGadgetData" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4276;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class WidgetGadgetDataNotify : pb::IMessage<WidgetGadgetDataNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WidgetGadgetDataNotify> _parser = new pb::MessageParser<WidgetGadgetDataNotify>(() => new WidgetGadgetDataNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WidgetGadgetDataNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.WidgetGadgetDataNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetGadgetDataNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetGadgetDataNotify(WidgetGadgetDataNotify other) : this() {
      widgetGadgetData_ = other.widgetGadgetData_ != null ? other.widgetGadgetData_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetGadgetDataNotify Clone() {
      return new WidgetGadgetDataNotify(this);
    }

    /// <summary>Field number for the "widget_gadget_data" field.</summary>
    public const int WidgetGadgetDataFieldNumber = 3;
    private global::Weedwacker.Shared.Network.Proto.WidgetGadgetData widgetGadgetData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.WidgetGadgetData WidgetGadgetData {
      get { return widgetGadgetData_; }
      set {
        widgetGadgetData_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WidgetGadgetDataNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WidgetGadgetDataNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(WidgetGadgetData, other.WidgetGadgetData)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (widgetGadgetData_ != null) hash ^= WidgetGadgetData.GetHashCode();
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
      if (widgetGadgetData_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(WidgetGadgetData);
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
      if (widgetGadgetData_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(WidgetGadgetData);
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
      if (widgetGadgetData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(WidgetGadgetData);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WidgetGadgetDataNotify other) {
      if (other == null) {
        return;
      }
      if (other.widgetGadgetData_ != null) {
        if (widgetGadgetData_ == null) {
          WidgetGadgetData = new global::Weedwacker.Shared.Network.Proto.WidgetGadgetData();
        }
        WidgetGadgetData.MergeFrom(other.WidgetGadgetData);
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
          case 26: {
            if (widgetGadgetData_ == null) {
              WidgetGadgetData = new global::Weedwacker.Shared.Network.Proto.WidgetGadgetData();
            }
            input.ReadMessage(WidgetGadgetData);
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
          case 26: {
            if (widgetGadgetData_ == null) {
              WidgetGadgetData = new global::Weedwacker.Shared.Network.Proto.WidgetGadgetData();
            }
            input.ReadMessage(WidgetGadgetData);
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
