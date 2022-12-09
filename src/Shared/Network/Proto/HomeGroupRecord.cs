// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeGroupRecord.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeGroupRecord.proto</summary>
  public static partial class HomeGroupRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeGroupRecord.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeGroupRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVIb21lR3JvdXBSZWNvcmQucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5l",
            "dHdvcmsuUHJvdG8aF0hvbWVCYWxsb29uUmVjb3JkLnByb3RvGhZIb21lUmFj",
            "aW5nUmVjb3JkLnByb3RvGiBIb21lU2Vla0Z1cm5pdHVyZUFsbFJlY29yZC5w",
            "cm90bxoVSG9tZVN0YWtlUmVjb3JkLnByb3RvIogDCg9Ib21lR3JvdXBSZWNv",
            "cmQSEAoIZ3JvdXBfaWQYDyABKA0SUQoTcmFjaW5nX2dhbGxlcnlfaW5mbxjD",
            "BiABKAsyMS5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLkhvbWVS",
            "YWNpbmdSZWNvcmRIABJTChRiYWxsb29uX2dhbGxlcnlfaW5mbxjWBSABKAsy",
            "Mi5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLkhvbWVCYWxsb29u",
            "UmVjb3JkSAASTAoPc3Rha2VfcGxheV9pbmZvGJoOIAEoCzIwLldlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uSG9tZVN0YWtlUmVjb3JkSAASYwob",
            "c2Vla19mdXJuaXR1cmVfZ2FsbGVyeV9pbmZvGPICIAEoCzI7LldlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uSG9tZVNlZWtGdXJuaXR1cmVBbGxS",
            "ZWNvcmRIAEIICgZkZXRhaWxiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.HomeBalloonRecordReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.HomeRacingRecordReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.HomeSeekFurnitureAllRecordReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.HomeStakeRecordReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeGroupRecord), global::Weedwacker.Shared.Network.Proto.HomeGroupRecord.Parser, new[]{ "GroupId", "RacingGalleryInfo", "BalloonGalleryInfo", "StakePlayInfo", "SeekFurnitureGalleryInfo" }, new[]{ "Detail" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeGroupRecord : pb::IMessage<HomeGroupRecord>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeGroupRecord> _parser = new pb::MessageParser<HomeGroupRecord>(() => new HomeGroupRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeGroupRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeGroupRecordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeGroupRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeGroupRecord(HomeGroupRecord other) : this() {
      groupId_ = other.groupId_;
      switch (other.DetailCase) {
        case DetailOneofCase.RacingGalleryInfo:
          RacingGalleryInfo = other.RacingGalleryInfo.Clone();
          break;
        case DetailOneofCase.BalloonGalleryInfo:
          BalloonGalleryInfo = other.BalloonGalleryInfo.Clone();
          break;
        case DetailOneofCase.StakePlayInfo:
          StakePlayInfo = other.StakePlayInfo.Clone();
          break;
        case DetailOneofCase.SeekFurnitureGalleryInfo:
          SeekFurnitureGalleryInfo = other.SeekFurnitureGalleryInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeGroupRecord Clone() {
      return new HomeGroupRecord(this);
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 15;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "racing_gallery_info" field.</summary>
    public const int RacingGalleryInfoFieldNumber = 835;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.HomeRacingRecord RacingGalleryInfo {
      get { return detailCase_ == DetailOneofCase.RacingGalleryInfo ? (global::Weedwacker.Shared.Network.Proto.HomeRacingRecord) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.RacingGalleryInfo;
      }
    }

    /// <summary>Field number for the "balloon_gallery_info" field.</summary>
    public const int BalloonGalleryInfoFieldNumber = 726;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.HomeBalloonRecord BalloonGalleryInfo {
      get { return detailCase_ == DetailOneofCase.BalloonGalleryInfo ? (global::Weedwacker.Shared.Network.Proto.HomeBalloonRecord) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.BalloonGalleryInfo;
      }
    }

    /// <summary>Field number for the "stake_play_info" field.</summary>
    public const int StakePlayInfoFieldNumber = 1818;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.HomeStakeRecord StakePlayInfo {
      get { return detailCase_ == DetailOneofCase.StakePlayInfo ? (global::Weedwacker.Shared.Network.Proto.HomeStakeRecord) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.StakePlayInfo;
      }
    }

    /// <summary>Field number for the "seek_furniture_gallery_info" field.</summary>
    public const int SeekFurnitureGalleryInfoFieldNumber = 370;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.HomeSeekFurnitureAllRecord SeekFurnitureGalleryInfo {
      get { return detailCase_ == DetailOneofCase.SeekFurnitureGalleryInfo ? (global::Weedwacker.Shared.Network.Proto.HomeSeekFurnitureAllRecord) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.SeekFurnitureGalleryInfo;
      }
    }

    private object detail_;
    /// <summary>Enum of possible cases for the "detail" oneof.</summary>
    public enum DetailOneofCase {
      None = 0,
      RacingGalleryInfo = 835,
      BalloonGalleryInfo = 726,
      StakePlayInfo = 1818,
      SeekFurnitureGalleryInfo = 370,
    }
    private DetailOneofCase detailCase_ = DetailOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DetailOneofCase DetailCase {
      get { return detailCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDetail() {
      detailCase_ = DetailOneofCase.None;
      detail_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeGroupRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeGroupRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GroupId != other.GroupId) return false;
      if (!object.Equals(RacingGalleryInfo, other.RacingGalleryInfo)) return false;
      if (!object.Equals(BalloonGalleryInfo, other.BalloonGalleryInfo)) return false;
      if (!object.Equals(StakePlayInfo, other.StakePlayInfo)) return false;
      if (!object.Equals(SeekFurnitureGalleryInfo, other.SeekFurnitureGalleryInfo)) return false;
      if (DetailCase != other.DetailCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (detailCase_ == DetailOneofCase.RacingGalleryInfo) hash ^= RacingGalleryInfo.GetHashCode();
      if (detailCase_ == DetailOneofCase.BalloonGalleryInfo) hash ^= BalloonGalleryInfo.GetHashCode();
      if (detailCase_ == DetailOneofCase.StakePlayInfo) hash ^= StakePlayInfo.GetHashCode();
      if (detailCase_ == DetailOneofCase.SeekFurnitureGalleryInfo) hash ^= SeekFurnitureGalleryInfo.GetHashCode();
      hash ^= (int) detailCase_;
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
      if (GroupId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(GroupId);
      }
      if (detailCase_ == DetailOneofCase.SeekFurnitureGalleryInfo) {
        output.WriteRawTag(146, 23);
        output.WriteMessage(SeekFurnitureGalleryInfo);
      }
      if (detailCase_ == DetailOneofCase.BalloonGalleryInfo) {
        output.WriteRawTag(178, 45);
        output.WriteMessage(BalloonGalleryInfo);
      }
      if (detailCase_ == DetailOneofCase.RacingGalleryInfo) {
        output.WriteRawTag(154, 52);
        output.WriteMessage(RacingGalleryInfo);
      }
      if (detailCase_ == DetailOneofCase.StakePlayInfo) {
        output.WriteRawTag(210, 113);
        output.WriteMessage(StakePlayInfo);
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
      if (GroupId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(GroupId);
      }
      if (detailCase_ == DetailOneofCase.SeekFurnitureGalleryInfo) {
        output.WriteRawTag(146, 23);
        output.WriteMessage(SeekFurnitureGalleryInfo);
      }
      if (detailCase_ == DetailOneofCase.BalloonGalleryInfo) {
        output.WriteRawTag(178, 45);
        output.WriteMessage(BalloonGalleryInfo);
      }
      if (detailCase_ == DetailOneofCase.RacingGalleryInfo) {
        output.WriteRawTag(154, 52);
        output.WriteMessage(RacingGalleryInfo);
      }
      if (detailCase_ == DetailOneofCase.StakePlayInfo) {
        output.WriteRawTag(210, 113);
        output.WriteMessage(StakePlayInfo);
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
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (detailCase_ == DetailOneofCase.RacingGalleryInfo) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(RacingGalleryInfo);
      }
      if (detailCase_ == DetailOneofCase.BalloonGalleryInfo) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(BalloonGalleryInfo);
      }
      if (detailCase_ == DetailOneofCase.StakePlayInfo) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(StakePlayInfo);
      }
      if (detailCase_ == DetailOneofCase.SeekFurnitureGalleryInfo) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(SeekFurnitureGalleryInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeGroupRecord other) {
      if (other == null) {
        return;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      switch (other.DetailCase) {
        case DetailOneofCase.RacingGalleryInfo:
          if (RacingGalleryInfo == null) {
            RacingGalleryInfo = new global::Weedwacker.Shared.Network.Proto.HomeRacingRecord();
          }
          RacingGalleryInfo.MergeFrom(other.RacingGalleryInfo);
          break;
        case DetailOneofCase.BalloonGalleryInfo:
          if (BalloonGalleryInfo == null) {
            BalloonGalleryInfo = new global::Weedwacker.Shared.Network.Proto.HomeBalloonRecord();
          }
          BalloonGalleryInfo.MergeFrom(other.BalloonGalleryInfo);
          break;
        case DetailOneofCase.StakePlayInfo:
          if (StakePlayInfo == null) {
            StakePlayInfo = new global::Weedwacker.Shared.Network.Proto.HomeStakeRecord();
          }
          StakePlayInfo.MergeFrom(other.StakePlayInfo);
          break;
        case DetailOneofCase.SeekFurnitureGalleryInfo:
          if (SeekFurnitureGalleryInfo == null) {
            SeekFurnitureGalleryInfo = new global::Weedwacker.Shared.Network.Proto.HomeSeekFurnitureAllRecord();
          }
          SeekFurnitureGalleryInfo.MergeFrom(other.SeekFurnitureGalleryInfo);
          break;
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
          case 120: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 2962: {
            global::Weedwacker.Shared.Network.Proto.HomeSeekFurnitureAllRecord subBuilder = new global::Weedwacker.Shared.Network.Proto.HomeSeekFurnitureAllRecord();
            if (detailCase_ == DetailOneofCase.SeekFurnitureGalleryInfo) {
              subBuilder.MergeFrom(SeekFurnitureGalleryInfo);
            }
            input.ReadMessage(subBuilder);
            SeekFurnitureGalleryInfo = subBuilder;
            break;
          }
          case 5810: {
            global::Weedwacker.Shared.Network.Proto.HomeBalloonRecord subBuilder = new global::Weedwacker.Shared.Network.Proto.HomeBalloonRecord();
            if (detailCase_ == DetailOneofCase.BalloonGalleryInfo) {
              subBuilder.MergeFrom(BalloonGalleryInfo);
            }
            input.ReadMessage(subBuilder);
            BalloonGalleryInfo = subBuilder;
            break;
          }
          case 6682: {
            global::Weedwacker.Shared.Network.Proto.HomeRacingRecord subBuilder = new global::Weedwacker.Shared.Network.Proto.HomeRacingRecord();
            if (detailCase_ == DetailOneofCase.RacingGalleryInfo) {
              subBuilder.MergeFrom(RacingGalleryInfo);
            }
            input.ReadMessage(subBuilder);
            RacingGalleryInfo = subBuilder;
            break;
          }
          case 14546: {
            global::Weedwacker.Shared.Network.Proto.HomeStakeRecord subBuilder = new global::Weedwacker.Shared.Network.Proto.HomeStakeRecord();
            if (detailCase_ == DetailOneofCase.StakePlayInfo) {
              subBuilder.MergeFrom(StakePlayInfo);
            }
            input.ReadMessage(subBuilder);
            StakePlayInfo = subBuilder;
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
          case 120: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 2962: {
            global::Weedwacker.Shared.Network.Proto.HomeSeekFurnitureAllRecord subBuilder = new global::Weedwacker.Shared.Network.Proto.HomeSeekFurnitureAllRecord();
            if (detailCase_ == DetailOneofCase.SeekFurnitureGalleryInfo) {
              subBuilder.MergeFrom(SeekFurnitureGalleryInfo);
            }
            input.ReadMessage(subBuilder);
            SeekFurnitureGalleryInfo = subBuilder;
            break;
          }
          case 5810: {
            global::Weedwacker.Shared.Network.Proto.HomeBalloonRecord subBuilder = new global::Weedwacker.Shared.Network.Proto.HomeBalloonRecord();
            if (detailCase_ == DetailOneofCase.BalloonGalleryInfo) {
              subBuilder.MergeFrom(BalloonGalleryInfo);
            }
            input.ReadMessage(subBuilder);
            BalloonGalleryInfo = subBuilder;
            break;
          }
          case 6682: {
            global::Weedwacker.Shared.Network.Proto.HomeRacingRecord subBuilder = new global::Weedwacker.Shared.Network.Proto.HomeRacingRecord();
            if (detailCase_ == DetailOneofCase.RacingGalleryInfo) {
              subBuilder.MergeFrom(RacingGalleryInfo);
            }
            input.ReadMessage(subBuilder);
            RacingGalleryInfo = subBuilder;
            break;
          }
          case 14546: {
            global::Weedwacker.Shared.Network.Proto.HomeStakeRecord subBuilder = new global::Weedwacker.Shared.Network.Proto.HomeStakeRecord();
            if (detailCase_ == DetailOneofCase.StakePlayInfo) {
              subBuilder.MergeFrom(StakePlayInfo);
            }
            input.ReadMessage(subBuilder);
            StakePlayInfo = subBuilder;
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
