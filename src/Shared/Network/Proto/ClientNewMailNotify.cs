// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ClientNewMailNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ClientNewMailNotify.proto</summary>
  public static partial class ClientNewMailNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ClientNewMailNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientNewMailNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlDbGllbnROZXdNYWlsTm90aWZ5LnByb3RvEh9XZWVkd2Fja2VyLlNoYXJl",
            "ZC5OZXR3b3JrLlByb3RvIk8KE0NsaWVudE5ld01haWxOb3RpZnkSGwoTVW5r",
            "MzMwMF9GQkRHQ0ZBQUxGThgNIAEoDRIbChNVbmszMzAwX01BTkpNQ1BFTExK",
            "GAIgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ClientNewMailNotify), global::Weedwacker.Shared.Network.Proto.ClientNewMailNotify.Parser, new[]{ "Unk3300FBDGCFAALFN", "Unk3300MANJMCPELLJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1457;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class ClientNewMailNotify : pb::IMessage<ClientNewMailNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClientNewMailNotify> _parser = new pb::MessageParser<ClientNewMailNotify>(() => new ClientNewMailNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClientNewMailNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ClientNewMailNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientNewMailNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientNewMailNotify(ClientNewMailNotify other) : this() {
      unk3300FBDGCFAALFN_ = other.unk3300FBDGCFAALFN_;
      unk3300MANJMCPELLJ_ = other.unk3300MANJMCPELLJ_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientNewMailNotify Clone() {
      return new ClientNewMailNotify(this);
    }

    /// <summary>Field number for the "Unk3300_FBDGCFAALFN" field.</summary>
    public const int Unk3300FBDGCFAALFNFieldNumber = 13;
    private uint unk3300FBDGCFAALFN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300FBDGCFAALFN {
      get { return unk3300FBDGCFAALFN_; }
      set {
        unk3300FBDGCFAALFN_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_MANJMCPELLJ" field.</summary>
    public const int Unk3300MANJMCPELLJFieldNumber = 2;
    private uint unk3300MANJMCPELLJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300MANJMCPELLJ {
      get { return unk3300MANJMCPELLJ_; }
      set {
        unk3300MANJMCPELLJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ClientNewMailNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClientNewMailNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300FBDGCFAALFN != other.Unk3300FBDGCFAALFN) return false;
      if (Unk3300MANJMCPELLJ != other.Unk3300MANJMCPELLJ) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300FBDGCFAALFN != 0) hash ^= Unk3300FBDGCFAALFN.GetHashCode();
      if (Unk3300MANJMCPELLJ != 0) hash ^= Unk3300MANJMCPELLJ.GetHashCode();
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
      if (Unk3300MANJMCPELLJ != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300MANJMCPELLJ);
      }
      if (Unk3300FBDGCFAALFN != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300FBDGCFAALFN);
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
      if (Unk3300MANJMCPELLJ != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300MANJMCPELLJ);
      }
      if (Unk3300FBDGCFAALFN != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300FBDGCFAALFN);
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
      if (Unk3300FBDGCFAALFN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300FBDGCFAALFN);
      }
      if (Unk3300MANJMCPELLJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300MANJMCPELLJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ClientNewMailNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300FBDGCFAALFN != 0) {
        Unk3300FBDGCFAALFN = other.Unk3300FBDGCFAALFN;
      }
      if (other.Unk3300MANJMCPELLJ != 0) {
        Unk3300MANJMCPELLJ = other.Unk3300MANJMCPELLJ;
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
          case 16: {
            Unk3300MANJMCPELLJ = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk3300FBDGCFAALFN = input.ReadUInt32();
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
          case 16: {
            Unk3300MANJMCPELLJ = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk3300FBDGCFAALFN = input.ReadUInt32();
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
