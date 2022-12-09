// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneWeatherForecastRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SceneWeatherForecastRsp.proto</summary>
  public static partial class SceneWeatherForecastRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneWeatherForecastRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneWeatherForecastRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1TY2VuZVdlYXRoZXJGb3JlY2FzdFJzcC5wcm90bxIfV2VlZHdhY2tlci5T",
            "aGFyZWQuTmV0d29yay5Qcm90byJkChdTY2VuZVdlYXRoZXJGb3JlY2FzdFJz",
            "cBIdChVmb3JlY2FzdF9jbGltYXRlX2xpc3QYDyADKA0SDwoHcmV0Y29kZRgM",
            "IAEoBRIZChFuZXh0X2NsaW1hdGVfdGltZRgEIAEoBGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SceneWeatherForecastRsp), global::Weedwacker.Shared.Network.Proto.SceneWeatherForecastRsp.Parser, new[]{ "ForecastClimateList", "Retcode", "NextClimateTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 3064;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class SceneWeatherForecastRsp : pb::IMessage<SceneWeatherForecastRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneWeatherForecastRsp> _parser = new pb::MessageParser<SceneWeatherForecastRsp>(() => new SceneWeatherForecastRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneWeatherForecastRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SceneWeatherForecastRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneWeatherForecastRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneWeatherForecastRsp(SceneWeatherForecastRsp other) : this() {
      forecastClimateList_ = other.forecastClimateList_.Clone();
      retcode_ = other.retcode_;
      nextClimateTime_ = other.nextClimateTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneWeatherForecastRsp Clone() {
      return new SceneWeatherForecastRsp(this);
    }

    /// <summary>Field number for the "forecast_climate_list" field.</summary>
    public const int ForecastClimateListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_forecastClimateList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> forecastClimateList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ForecastClimateList {
      get { return forecastClimateList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "next_climate_time" field.</summary>
    public const int NextClimateTimeFieldNumber = 4;
    private ulong nextClimateTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong NextClimateTime {
      get { return nextClimateTime_; }
      set {
        nextClimateTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneWeatherForecastRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneWeatherForecastRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!forecastClimateList_.Equals(other.forecastClimateList_)) return false;
      if (Retcode != other.Retcode) return false;
      if (NextClimateTime != other.NextClimateTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= forecastClimateList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (NextClimateTime != 0UL) hash ^= NextClimateTime.GetHashCode();
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
      if (NextClimateTime != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(NextClimateTime);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(Retcode);
      }
      forecastClimateList_.WriteTo(output, _repeated_forecastClimateList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (NextClimateTime != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(NextClimateTime);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(Retcode);
      }
      forecastClimateList_.WriteTo(ref output, _repeated_forecastClimateList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += forecastClimateList_.CalculateSize(_repeated_forecastClimateList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (NextClimateTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(NextClimateTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneWeatherForecastRsp other) {
      if (other == null) {
        return;
      }
      forecastClimateList_.Add(other.forecastClimateList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.NextClimateTime != 0UL) {
        NextClimateTime = other.NextClimateTime;
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
            NextClimateTime = input.ReadUInt64();
            break;
          }
          case 96: {
            Retcode = input.ReadInt32();
            break;
          }
          case 122:
          case 120: {
            forecastClimateList_.AddEntriesFrom(input, _repeated_forecastClimateList_codec);
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
            NextClimateTime = input.ReadUInt64();
            break;
          }
          case 96: {
            Retcode = input.ReadInt32();
            break;
          }
          case 122:
          case 120: {
            forecastClimateList_.AddEntriesFrom(ref input, _repeated_forecastClimateList_codec);
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
