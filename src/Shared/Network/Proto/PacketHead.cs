// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PacketHead.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PacketHead.proto</summary>
  public static partial class PacketHeadReflection {

    #region Descriptor
    /// <summary>File descriptor for PacketHead.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PacketHeadReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBQYWNrZXRIZWFkLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3Jr",
            "LlByb3RvIogFCgpQYWNrZXRIZWFkEhEKCXBhY2tldF9pZBgBIAEoDRIOCgZy",
            "cGNfaWQYAiABKA0SGgoSY2xpZW50X3NlcXVlbmNlX2lkGAMgASgNEhcKD2Vu",
            "ZXRfY2hhbm5lbF9pZBgEIAEoDRIYChBlbmV0X2lzX3JlbGlhYmxlGAUgASgN",
            "Eg8KB3NlbnRfbXMYBiABKAQSDwoHdXNlcl9pZBgLIAEoDRIPCgd1c2VyX2lw",
            "GAwgASgNEhcKD3VzZXJfc2Vzc2lvbl9pZBgNIAEoDRIUCgxyZWN2X3RpbWVf",
            "bXMYFSABKAQSGQoRcnBjX2JlZ2luX3RpbWVfbXMYFiABKA0SSAoHZXh0X21h",
            "cBgXIAMoCzI3LldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uUGFj",
            "a2V0SGVhZC5FeHRNYXBFbnRyeRIVCg1zZW5kZXJfYXBwX2lkGBggASgNEhYK",
            "DnNvdXJjZV9zZXJ2aWNlGB8gASgNEhYKDnRhcmdldF9zZXJ2aWNlGCAgASgN",
            "ElwKEnNlcnZpY2VfYXBwX2lkX21hcBghIAMoCzJALldlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8uUGFja2V0SGVhZC5TZXJ2aWNlQXBwSWRNYXBF",
            "bnRyeRIaChJpc19zZXRfZ2FtZV90aHJlYWQYIiABKAgSGQoRZ2FtZV90aHJl",
            "YWRfaW5kZXgYIyABKA0aLQoLRXh0TWFwRW50cnkSCwoDa2V5GAEgASgNEg0K",
            "BXZhbHVlGAIgASgNOgI4ARo2ChRTZXJ2aWNlQXBwSWRNYXBFbnRyeRILCgNr",
            "ZXkYASABKA0SDQoFdmFsdWUYAiABKA06AjgBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PacketHead), global::Weedwacker.Shared.Network.Proto.PacketHead.Parser, new[]{ "PacketId", "RpcId", "ClientSequenceId", "EnetChannelId", "EnetIsReliable", "SentMs", "UserId", "UserIp", "UserSessionId", "RecvTimeMs", "RpcBeginTimeMs", "ExtMap", "SenderAppId", "SourceService", "TargetService", "ServiceAppIdMap", "IsSetGameThread", "GameThreadIndex" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PacketHead : pb::IMessage<PacketHead>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PacketHead> _parser = new pb::MessageParser<PacketHead>(() => new PacketHead());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PacketHead> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PacketHeadReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PacketHead() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PacketHead(PacketHead other) : this() {
      packetId_ = other.packetId_;
      rpcId_ = other.rpcId_;
      clientSequenceId_ = other.clientSequenceId_;
      enetChannelId_ = other.enetChannelId_;
      enetIsReliable_ = other.enetIsReliable_;
      sentMs_ = other.sentMs_;
      userId_ = other.userId_;
      userIp_ = other.userIp_;
      userSessionId_ = other.userSessionId_;
      recvTimeMs_ = other.recvTimeMs_;
      rpcBeginTimeMs_ = other.rpcBeginTimeMs_;
      extMap_ = other.extMap_.Clone();
      senderAppId_ = other.senderAppId_;
      sourceService_ = other.sourceService_;
      targetService_ = other.targetService_;
      serviceAppIdMap_ = other.serviceAppIdMap_.Clone();
      isSetGameThread_ = other.isSetGameThread_;
      gameThreadIndex_ = other.gameThreadIndex_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PacketHead Clone() {
      return new PacketHead(this);
    }

    /// <summary>Field number for the "packet_id" field.</summary>
    public const int PacketIdFieldNumber = 1;
    private uint packetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PacketId {
      get { return packetId_; }
      set {
        packetId_ = value;
      }
    }

    /// <summary>Field number for the "rpc_id" field.</summary>
    public const int RpcIdFieldNumber = 2;
    private uint rpcId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    /// <summary>Field number for the "client_sequence_id" field.</summary>
    public const int ClientSequenceIdFieldNumber = 3;
    private uint clientSequenceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClientSequenceId {
      get { return clientSequenceId_; }
      set {
        clientSequenceId_ = value;
      }
    }

    /// <summary>Field number for the "enet_channel_id" field.</summary>
    public const int EnetChannelIdFieldNumber = 4;
    private uint enetChannelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EnetChannelId {
      get { return enetChannelId_; }
      set {
        enetChannelId_ = value;
      }
    }

    /// <summary>Field number for the "enet_is_reliable" field.</summary>
    public const int EnetIsReliableFieldNumber = 5;
    private uint enetIsReliable_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EnetIsReliable {
      get { return enetIsReliable_; }
      set {
        enetIsReliable_ = value;
      }
    }

    /// <summary>Field number for the "sent_ms" field.</summary>
    public const int SentMsFieldNumber = 6;
    private ulong sentMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong SentMs {
      get { return sentMs_; }
      set {
        sentMs_ = value;
      }
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 11;
    private uint userId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "user_ip" field.</summary>
    public const int UserIpFieldNumber = 12;
    private uint userIp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UserIp {
      get { return userIp_; }
      set {
        userIp_ = value;
      }
    }

    /// <summary>Field number for the "user_session_id" field.</summary>
    public const int UserSessionIdFieldNumber = 13;
    private uint userSessionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UserSessionId {
      get { return userSessionId_; }
      set {
        userSessionId_ = value;
      }
    }

    /// <summary>Field number for the "recv_time_ms" field.</summary>
    public const int RecvTimeMsFieldNumber = 21;
    private ulong recvTimeMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong RecvTimeMs {
      get { return recvTimeMs_; }
      set {
        recvTimeMs_ = value;
      }
    }

    /// <summary>Field number for the "rpc_begin_time_ms" field.</summary>
    public const int RpcBeginTimeMsFieldNumber = 22;
    private uint rpcBeginTimeMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RpcBeginTimeMs {
      get { return rpcBeginTimeMs_; }
      set {
        rpcBeginTimeMs_ = value;
      }
    }

    /// <summary>Field number for the "ext_map" field.</summary>
    public const int ExtMapFieldNumber = 23;
    private static readonly pbc::MapField<uint, uint>.Codec _map_extMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 186);
    private readonly pbc::MapField<uint, uint> extMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> ExtMap {
      get { return extMap_; }
    }

    /// <summary>Field number for the "sender_app_id" field.</summary>
    public const int SenderAppIdFieldNumber = 24;
    private uint senderAppId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SenderAppId {
      get { return senderAppId_; }
      set {
        senderAppId_ = value;
      }
    }

    /// <summary>Field number for the "source_service" field.</summary>
    public const int SourceServiceFieldNumber = 31;
    private uint sourceService_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceService {
      get { return sourceService_; }
      set {
        sourceService_ = value;
      }
    }

    /// <summary>Field number for the "target_service" field.</summary>
    public const int TargetServiceFieldNumber = 32;
    private uint targetService_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetService {
      get { return targetService_; }
      set {
        targetService_ = value;
      }
    }

    /// <summary>Field number for the "service_app_id_map" field.</summary>
    public const int ServiceAppIdMapFieldNumber = 33;
    private static readonly pbc::MapField<uint, uint>.Codec _map_serviceAppIdMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 266);
    private readonly pbc::MapField<uint, uint> serviceAppIdMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> ServiceAppIdMap {
      get { return serviceAppIdMap_; }
    }

    /// <summary>Field number for the "is_set_game_thread" field.</summary>
    public const int IsSetGameThreadFieldNumber = 34;
    private bool isSetGameThread_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSetGameThread {
      get { return isSetGameThread_; }
      set {
        isSetGameThread_ = value;
      }
    }

    /// <summary>Field number for the "game_thread_index" field.</summary>
    public const int GameThreadIndexFieldNumber = 35;
    private uint gameThreadIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameThreadIndex {
      get { return gameThreadIndex_; }
      set {
        gameThreadIndex_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PacketHead);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PacketHead other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PacketId != other.PacketId) return false;
      if (RpcId != other.RpcId) return false;
      if (ClientSequenceId != other.ClientSequenceId) return false;
      if (EnetChannelId != other.EnetChannelId) return false;
      if (EnetIsReliable != other.EnetIsReliable) return false;
      if (SentMs != other.SentMs) return false;
      if (UserId != other.UserId) return false;
      if (UserIp != other.UserIp) return false;
      if (UserSessionId != other.UserSessionId) return false;
      if (RecvTimeMs != other.RecvTimeMs) return false;
      if (RpcBeginTimeMs != other.RpcBeginTimeMs) return false;
      if (!ExtMap.Equals(other.ExtMap)) return false;
      if (SenderAppId != other.SenderAppId) return false;
      if (SourceService != other.SourceService) return false;
      if (TargetService != other.TargetService) return false;
      if (!ServiceAppIdMap.Equals(other.ServiceAppIdMap)) return false;
      if (IsSetGameThread != other.IsSetGameThread) return false;
      if (GameThreadIndex != other.GameThreadIndex) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PacketId != 0) hash ^= PacketId.GetHashCode();
      if (RpcId != 0) hash ^= RpcId.GetHashCode();
      if (ClientSequenceId != 0) hash ^= ClientSequenceId.GetHashCode();
      if (EnetChannelId != 0) hash ^= EnetChannelId.GetHashCode();
      if (EnetIsReliable != 0) hash ^= EnetIsReliable.GetHashCode();
      if (SentMs != 0UL) hash ^= SentMs.GetHashCode();
      if (UserId != 0) hash ^= UserId.GetHashCode();
      if (UserIp != 0) hash ^= UserIp.GetHashCode();
      if (UserSessionId != 0) hash ^= UserSessionId.GetHashCode();
      if (RecvTimeMs != 0UL) hash ^= RecvTimeMs.GetHashCode();
      if (RpcBeginTimeMs != 0) hash ^= RpcBeginTimeMs.GetHashCode();
      hash ^= ExtMap.GetHashCode();
      if (SenderAppId != 0) hash ^= SenderAppId.GetHashCode();
      if (SourceService != 0) hash ^= SourceService.GetHashCode();
      if (TargetService != 0) hash ^= TargetService.GetHashCode();
      hash ^= ServiceAppIdMap.GetHashCode();
      if (IsSetGameThread != false) hash ^= IsSetGameThread.GetHashCode();
      if (GameThreadIndex != 0) hash ^= GameThreadIndex.GetHashCode();
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
      if (PacketId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PacketId);
      }
      if (RpcId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(RpcId);
      }
      if (ClientSequenceId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ClientSequenceId);
      }
      if (EnetChannelId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EnetChannelId);
      }
      if (EnetIsReliable != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(EnetIsReliable);
      }
      if (SentMs != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(SentMs);
      }
      if (UserId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(UserId);
      }
      if (UserIp != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(UserIp);
      }
      if (UserSessionId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(UserSessionId);
      }
      if (RecvTimeMs != 0UL) {
        output.WriteRawTag(168, 1);
        output.WriteUInt64(RecvTimeMs);
      }
      if (RpcBeginTimeMs != 0) {
        output.WriteRawTag(176, 1);
        output.WriteUInt32(RpcBeginTimeMs);
      }
      extMap_.WriteTo(output, _map_extMap_codec);
      if (SenderAppId != 0) {
        output.WriteRawTag(192, 1);
        output.WriteUInt32(SenderAppId);
      }
      if (SourceService != 0) {
        output.WriteRawTag(248, 1);
        output.WriteUInt32(SourceService);
      }
      if (TargetService != 0) {
        output.WriteRawTag(128, 2);
        output.WriteUInt32(TargetService);
      }
      serviceAppIdMap_.WriteTo(output, _map_serviceAppIdMap_codec);
      if (IsSetGameThread != false) {
        output.WriteRawTag(144, 2);
        output.WriteBool(IsSetGameThread);
      }
      if (GameThreadIndex != 0) {
        output.WriteRawTag(152, 2);
        output.WriteUInt32(GameThreadIndex);
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
      if (PacketId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PacketId);
      }
      if (RpcId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(RpcId);
      }
      if (ClientSequenceId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ClientSequenceId);
      }
      if (EnetChannelId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EnetChannelId);
      }
      if (EnetIsReliable != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(EnetIsReliable);
      }
      if (SentMs != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(SentMs);
      }
      if (UserId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(UserId);
      }
      if (UserIp != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(UserIp);
      }
      if (UserSessionId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(UserSessionId);
      }
      if (RecvTimeMs != 0UL) {
        output.WriteRawTag(168, 1);
        output.WriteUInt64(RecvTimeMs);
      }
      if (RpcBeginTimeMs != 0) {
        output.WriteRawTag(176, 1);
        output.WriteUInt32(RpcBeginTimeMs);
      }
      extMap_.WriteTo(ref output, _map_extMap_codec);
      if (SenderAppId != 0) {
        output.WriteRawTag(192, 1);
        output.WriteUInt32(SenderAppId);
      }
      if (SourceService != 0) {
        output.WriteRawTag(248, 1);
        output.WriteUInt32(SourceService);
      }
      if (TargetService != 0) {
        output.WriteRawTag(128, 2);
        output.WriteUInt32(TargetService);
      }
      serviceAppIdMap_.WriteTo(ref output, _map_serviceAppIdMap_codec);
      if (IsSetGameThread != false) {
        output.WriteRawTag(144, 2);
        output.WriteBool(IsSetGameThread);
      }
      if (GameThreadIndex != 0) {
        output.WriteRawTag(152, 2);
        output.WriteUInt32(GameThreadIndex);
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
      if (PacketId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PacketId);
      }
      if (RpcId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RpcId);
      }
      if (ClientSequenceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClientSequenceId);
      }
      if (EnetChannelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EnetChannelId);
      }
      if (EnetIsReliable != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EnetIsReliable);
      }
      if (SentMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(SentMs);
      }
      if (UserId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UserId);
      }
      if (UserIp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UserIp);
      }
      if (UserSessionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UserSessionId);
      }
      if (RecvTimeMs != 0UL) {
        size += 2 + pb::CodedOutputStream.ComputeUInt64Size(RecvTimeMs);
      }
      if (RpcBeginTimeMs != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(RpcBeginTimeMs);
      }
      size += extMap_.CalculateSize(_map_extMap_codec);
      if (SenderAppId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(SenderAppId);
      }
      if (SourceService != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(SourceService);
      }
      if (TargetService != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(TargetService);
      }
      size += serviceAppIdMap_.CalculateSize(_map_serviceAppIdMap_codec);
      if (IsSetGameThread != false) {
        size += 2 + 1;
      }
      if (GameThreadIndex != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(GameThreadIndex);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PacketHead other) {
      if (other == null) {
        return;
      }
      if (other.PacketId != 0) {
        PacketId = other.PacketId;
      }
      if (other.RpcId != 0) {
        RpcId = other.RpcId;
      }
      if (other.ClientSequenceId != 0) {
        ClientSequenceId = other.ClientSequenceId;
      }
      if (other.EnetChannelId != 0) {
        EnetChannelId = other.EnetChannelId;
      }
      if (other.EnetIsReliable != 0) {
        EnetIsReliable = other.EnetIsReliable;
      }
      if (other.SentMs != 0UL) {
        SentMs = other.SentMs;
      }
      if (other.UserId != 0) {
        UserId = other.UserId;
      }
      if (other.UserIp != 0) {
        UserIp = other.UserIp;
      }
      if (other.UserSessionId != 0) {
        UserSessionId = other.UserSessionId;
      }
      if (other.RecvTimeMs != 0UL) {
        RecvTimeMs = other.RecvTimeMs;
      }
      if (other.RpcBeginTimeMs != 0) {
        RpcBeginTimeMs = other.RpcBeginTimeMs;
      }
      extMap_.Add(other.extMap_);
      if (other.SenderAppId != 0) {
        SenderAppId = other.SenderAppId;
      }
      if (other.SourceService != 0) {
        SourceService = other.SourceService;
      }
      if (other.TargetService != 0) {
        TargetService = other.TargetService;
      }
      serviceAppIdMap_.Add(other.serviceAppIdMap_);
      if (other.IsSetGameThread != false) {
        IsSetGameThread = other.IsSetGameThread;
      }
      if (other.GameThreadIndex != 0) {
        GameThreadIndex = other.GameThreadIndex;
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
            PacketId = input.ReadUInt32();
            break;
          }
          case 16: {
            RpcId = input.ReadUInt32();
            break;
          }
          case 24: {
            ClientSequenceId = input.ReadUInt32();
            break;
          }
          case 32: {
            EnetChannelId = input.ReadUInt32();
            break;
          }
          case 40: {
            EnetIsReliable = input.ReadUInt32();
            break;
          }
          case 48: {
            SentMs = input.ReadUInt64();
            break;
          }
          case 88: {
            UserId = input.ReadUInt32();
            break;
          }
          case 96: {
            UserIp = input.ReadUInt32();
            break;
          }
          case 104: {
            UserSessionId = input.ReadUInt32();
            break;
          }
          case 168: {
            RecvTimeMs = input.ReadUInt64();
            break;
          }
          case 176: {
            RpcBeginTimeMs = input.ReadUInt32();
            break;
          }
          case 186: {
            extMap_.AddEntriesFrom(input, _map_extMap_codec);
            break;
          }
          case 192: {
            SenderAppId = input.ReadUInt32();
            break;
          }
          case 248: {
            SourceService = input.ReadUInt32();
            break;
          }
          case 256: {
            TargetService = input.ReadUInt32();
            break;
          }
          case 266: {
            serviceAppIdMap_.AddEntriesFrom(input, _map_serviceAppIdMap_codec);
            break;
          }
          case 272: {
            IsSetGameThread = input.ReadBool();
            break;
          }
          case 280: {
            GameThreadIndex = input.ReadUInt32();
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
            PacketId = input.ReadUInt32();
            break;
          }
          case 16: {
            RpcId = input.ReadUInt32();
            break;
          }
          case 24: {
            ClientSequenceId = input.ReadUInt32();
            break;
          }
          case 32: {
            EnetChannelId = input.ReadUInt32();
            break;
          }
          case 40: {
            EnetIsReliable = input.ReadUInt32();
            break;
          }
          case 48: {
            SentMs = input.ReadUInt64();
            break;
          }
          case 88: {
            UserId = input.ReadUInt32();
            break;
          }
          case 96: {
            UserIp = input.ReadUInt32();
            break;
          }
          case 104: {
            UserSessionId = input.ReadUInt32();
            break;
          }
          case 168: {
            RecvTimeMs = input.ReadUInt64();
            break;
          }
          case 176: {
            RpcBeginTimeMs = input.ReadUInt32();
            break;
          }
          case 186: {
            extMap_.AddEntriesFrom(ref input, _map_extMap_codec);
            break;
          }
          case 192: {
            SenderAppId = input.ReadUInt32();
            break;
          }
          case 248: {
            SourceService = input.ReadUInt32();
            break;
          }
          case 256: {
            TargetService = input.ReadUInt32();
            break;
          }
          case 266: {
            serviceAppIdMap_.AddEntriesFrom(ref input, _map_serviceAppIdMap_codec);
            break;
          }
          case 272: {
            IsSetGameThread = input.ReadBool();
            break;
          }
          case 280: {
            GameThreadIndex = input.ReadUInt32();
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
