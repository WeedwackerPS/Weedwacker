// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetCityHuntingOfferRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GetCityHuntingOfferRsp.proto</summary>
  public static partial class GetCityHuntingOfferRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetCityHuntingOfferRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetCityHuntingOfferRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxHZXRDaXR5SHVudGluZ09mZmVyUnNwLnByb3RvEh9XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvGhZIdW50aW5nT2ZmZXJEYXRhLnByb3RvGhFI",
            "dW50aW5nUGFpci5wcm90byKRAgoWR2V0Q2l0eUh1bnRpbmdPZmZlclJzcBJN",
            "ChJodW50aW5nX29mZmVyX2xpc3QYAiADKAsyMS5XZWVkd2Fja2VyLlNoYXJl",
            "ZC5OZXR3b3JrLlByb3RvLkh1bnRpbmdPZmZlckRhdGESDwoHcmV0Y29kZRgJ",
            "IAEoBRIfChdjdXJfd2Vla19maW5pc2hlZF9jb3VudBgBIAEoDRJKChRvbmdv",
            "aW5nX2h1bnRpbmdfcGFpchgPIAEoCzIsLldlZWR3YWNrZXIuU2hhcmVkLk5l",
            "dHdvcmsuUHJvdG8uSHVudGluZ1BhaXISGQoRbmV4dF9yZWZyZXNoX3RpbWUY",
            "BSABKA0SDwoHY2l0eV9pZBgMIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.HuntingOfferDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.HuntingPairReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GetCityHuntingOfferRsp), global::Weedwacker.Shared.Network.Proto.GetCityHuntingOfferRsp.Parser, new[]{ "HuntingOfferList", "Retcode", "CurWeekFinishedCount", "OngoingHuntingPair", "NextRefreshTime", "CityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4335;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class GetCityHuntingOfferRsp : pb::IMessage<GetCityHuntingOfferRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetCityHuntingOfferRsp> _parser = new pb::MessageParser<GetCityHuntingOfferRsp>(() => new GetCityHuntingOfferRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetCityHuntingOfferRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GetCityHuntingOfferRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetCityHuntingOfferRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetCityHuntingOfferRsp(GetCityHuntingOfferRsp other) : this() {
      huntingOfferList_ = other.huntingOfferList_.Clone();
      retcode_ = other.retcode_;
      curWeekFinishedCount_ = other.curWeekFinishedCount_;
      ongoingHuntingPair_ = other.ongoingHuntingPair_ != null ? other.ongoingHuntingPair_.Clone() : null;
      nextRefreshTime_ = other.nextRefreshTime_;
      cityId_ = other.cityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetCityHuntingOfferRsp Clone() {
      return new GetCityHuntingOfferRsp(this);
    }

    /// <summary>Field number for the "hunting_offer_list" field.</summary>
    public const int HuntingOfferListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.HuntingOfferData> _repeated_huntingOfferList_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.HuntingOfferData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HuntingOfferData> huntingOfferList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HuntingOfferData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HuntingOfferData> HuntingOfferList {
      get { return huntingOfferList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 9;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "cur_week_finished_count" field.</summary>
    public const int CurWeekFinishedCountFieldNumber = 1;
    private uint curWeekFinishedCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurWeekFinishedCount {
      get { return curWeekFinishedCount_; }
      set {
        curWeekFinishedCount_ = value;
      }
    }

    /// <summary>Field number for the "ongoing_hunting_pair" field.</summary>
    public const int OngoingHuntingPairFieldNumber = 15;
    private global::Weedwacker.Shared.Network.Proto.HuntingPair ongoingHuntingPair_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.HuntingPair OngoingHuntingPair {
      get { return ongoingHuntingPair_; }
      set {
        ongoingHuntingPair_ = value;
      }
    }

    /// <summary>Field number for the "next_refresh_time" field.</summary>
    public const int NextRefreshTimeFieldNumber = 5;
    private uint nextRefreshTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextRefreshTime {
      get { return nextRefreshTime_; }
      set {
        nextRefreshTime_ = value;
      }
    }

    /// <summary>Field number for the "city_id" field.</summary>
    public const int CityIdFieldNumber = 12;
    private uint cityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CityId {
      get { return cityId_; }
      set {
        cityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetCityHuntingOfferRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetCityHuntingOfferRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!huntingOfferList_.Equals(other.huntingOfferList_)) return false;
      if (Retcode != other.Retcode) return false;
      if (CurWeekFinishedCount != other.CurWeekFinishedCount) return false;
      if (!object.Equals(OngoingHuntingPair, other.OngoingHuntingPair)) return false;
      if (NextRefreshTime != other.NextRefreshTime) return false;
      if (CityId != other.CityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= huntingOfferList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (CurWeekFinishedCount != 0) hash ^= CurWeekFinishedCount.GetHashCode();
      if (ongoingHuntingPair_ != null) hash ^= OngoingHuntingPair.GetHashCode();
      if (NextRefreshTime != 0) hash ^= NextRefreshTime.GetHashCode();
      if (CityId != 0) hash ^= CityId.GetHashCode();
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
      if (CurWeekFinishedCount != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CurWeekFinishedCount);
      }
      huntingOfferList_.WriteTo(output, _repeated_huntingOfferList_codec);
      if (NextRefreshTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NextRefreshTime);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Retcode);
      }
      if (CityId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CityId);
      }
      if (ongoingHuntingPair_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(OngoingHuntingPair);
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
      if (CurWeekFinishedCount != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CurWeekFinishedCount);
      }
      huntingOfferList_.WriteTo(ref output, _repeated_huntingOfferList_codec);
      if (NextRefreshTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NextRefreshTime);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Retcode);
      }
      if (CityId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CityId);
      }
      if (ongoingHuntingPair_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(OngoingHuntingPair);
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
      size += huntingOfferList_.CalculateSize(_repeated_huntingOfferList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (CurWeekFinishedCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurWeekFinishedCount);
      }
      if (ongoingHuntingPair_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OngoingHuntingPair);
      }
      if (NextRefreshTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextRefreshTime);
      }
      if (CityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetCityHuntingOfferRsp other) {
      if (other == null) {
        return;
      }
      huntingOfferList_.Add(other.huntingOfferList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.CurWeekFinishedCount != 0) {
        CurWeekFinishedCount = other.CurWeekFinishedCount;
      }
      if (other.ongoingHuntingPair_ != null) {
        if (ongoingHuntingPair_ == null) {
          OngoingHuntingPair = new global::Weedwacker.Shared.Network.Proto.HuntingPair();
        }
        OngoingHuntingPair.MergeFrom(other.OngoingHuntingPair);
      }
      if (other.NextRefreshTime != 0) {
        NextRefreshTime = other.NextRefreshTime;
      }
      if (other.CityId != 0) {
        CityId = other.CityId;
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
          case 8: {
            CurWeekFinishedCount = input.ReadUInt32();
            break;
          }
          case 18: {
            huntingOfferList_.AddEntriesFrom(input, _repeated_huntingOfferList_codec);
            break;
          }
          case 40: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 72: {
            Retcode = input.ReadInt32();
            break;
          }
          case 96: {
            CityId = input.ReadUInt32();
            break;
          }
          case 122: {
            if (ongoingHuntingPair_ == null) {
              OngoingHuntingPair = new global::Weedwacker.Shared.Network.Proto.HuntingPair();
            }
            input.ReadMessage(OngoingHuntingPair);
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
          case 8: {
            CurWeekFinishedCount = input.ReadUInt32();
            break;
          }
          case 18: {
            huntingOfferList_.AddEntriesFrom(ref input, _repeated_huntingOfferList_codec);
            break;
          }
          case 40: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 72: {
            Retcode = input.ReadInt32();
            break;
          }
          case 96: {
            CityId = input.ReadUInt32();
            break;
          }
          case 122: {
            if (ongoingHuntingPair_ == null) {
              OngoingHuntingPair = new global::Weedwacker.Shared.Network.Proto.HuntingPair();
            }
            input.ReadMessage(OngoingHuntingPair);
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
