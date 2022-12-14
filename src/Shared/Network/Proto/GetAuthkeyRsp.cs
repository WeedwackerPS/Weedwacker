// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetAuthkeyRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GetAuthkeyRsp.proto</summary>
  public static partial class GetAuthkeyRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetAuthkeyRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetAuthkeyRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNHZXRBdXRoa2V5UnNwLnByb3RvIn8KDUdldEF1dGhrZXlSc3ASDwoHcmV0",
            "Y29kZRgIIAEoBRIPCgdhdXRoa2V5GAYgASgJEhMKC2F1dGhrZXlfdmVyGA0g",
            "ASgNEhEKCXNpZ25fdHlwZRgDIAEoDRISCgphdXRoX2FwcGlkGAcgASgJEhAK",
            "CGdhbWVfYml6GAEgASgJQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3Jr",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GetAuthkeyRsp), global::Weedwacker.Shared.Network.Proto.GetAuthkeyRsp.Parser, new[]{ "Retcode", "Authkey", "AuthkeyVer", "SignType", "AuthAppid", "GameBiz" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1478;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class GetAuthkeyRsp : pb::IMessage<GetAuthkeyRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAuthkeyRsp> _parser = new pb::MessageParser<GetAuthkeyRsp>(() => new GetAuthkeyRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetAuthkeyRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GetAuthkeyRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAuthkeyRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAuthkeyRsp(GetAuthkeyRsp other) : this() {
      retcode_ = other.retcode_;
      authkey_ = other.authkey_;
      authkeyVer_ = other.authkeyVer_;
      signType_ = other.signType_;
      authAppid_ = other.authAppid_;
      gameBiz_ = other.gameBiz_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAuthkeyRsp Clone() {
      return new GetAuthkeyRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "authkey" field.</summary>
    public const int AuthkeyFieldNumber = 6;
    private string authkey_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Authkey {
      get { return authkey_; }
      set {
        authkey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "authkey_ver" field.</summary>
    public const int AuthkeyVerFieldNumber = 13;
    private uint authkeyVer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AuthkeyVer {
      get { return authkeyVer_; }
      set {
        authkeyVer_ = value;
      }
    }

    /// <summary>Field number for the "sign_type" field.</summary>
    public const int SignTypeFieldNumber = 3;
    private uint signType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SignType {
      get { return signType_; }
      set {
        signType_ = value;
      }
    }

    /// <summary>Field number for the "auth_appid" field.</summary>
    public const int AuthAppidFieldNumber = 7;
    private string authAppid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AuthAppid {
      get { return authAppid_; }
      set {
        authAppid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "game_biz" field.</summary>
    public const int GameBizFieldNumber = 1;
    private string gameBiz_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GameBiz {
      get { return gameBiz_; }
      set {
        gameBiz_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetAuthkeyRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetAuthkeyRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (Authkey != other.Authkey) return false;
      if (AuthkeyVer != other.AuthkeyVer) return false;
      if (SignType != other.SignType) return false;
      if (AuthAppid != other.AuthAppid) return false;
      if (GameBiz != other.GameBiz) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Authkey.Length != 0) hash ^= Authkey.GetHashCode();
      if (AuthkeyVer != 0) hash ^= AuthkeyVer.GetHashCode();
      if (SignType != 0) hash ^= SignType.GetHashCode();
      if (AuthAppid.Length != 0) hash ^= AuthAppid.GetHashCode();
      if (GameBiz.Length != 0) hash ^= GameBiz.GetHashCode();
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
      if (GameBiz.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(GameBiz);
      }
      if (SignType != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SignType);
      }
      if (Authkey.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Authkey);
      }
      if (AuthAppid.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(AuthAppid);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (AuthkeyVer != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(AuthkeyVer);
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
      if (GameBiz.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(GameBiz);
      }
      if (SignType != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SignType);
      }
      if (Authkey.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Authkey);
      }
      if (AuthAppid.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(AuthAppid);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (AuthkeyVer != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(AuthkeyVer);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (Authkey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Authkey);
      }
      if (AuthkeyVer != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AuthkeyVer);
      }
      if (SignType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SignType);
      }
      if (AuthAppid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AuthAppid);
      }
      if (GameBiz.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GameBiz);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetAuthkeyRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Authkey.Length != 0) {
        Authkey = other.Authkey;
      }
      if (other.AuthkeyVer != 0) {
        AuthkeyVer = other.AuthkeyVer;
      }
      if (other.SignType != 0) {
        SignType = other.SignType;
      }
      if (other.AuthAppid.Length != 0) {
        AuthAppid = other.AuthAppid;
      }
      if (other.GameBiz.Length != 0) {
        GameBiz = other.GameBiz;
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
          case 10: {
            GameBiz = input.ReadString();
            break;
          }
          case 24: {
            SignType = input.ReadUInt32();
            break;
          }
          case 50: {
            Authkey = input.ReadString();
            break;
          }
          case 58: {
            AuthAppid = input.ReadString();
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 104: {
            AuthkeyVer = input.ReadUInt32();
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
            GameBiz = input.ReadString();
            break;
          }
          case 24: {
            SignType = input.ReadUInt32();
            break;
          }
          case 50: {
            Authkey = input.ReadString();
            break;
          }
          case 58: {
            AuthAppid = input.ReadString();
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 104: {
            AuthkeyVer = input.ReadUInt32();
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
