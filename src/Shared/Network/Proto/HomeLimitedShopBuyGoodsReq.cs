// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeLimitedShopBuyGoodsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeLimitedShopBuyGoodsReq.proto</summary>
  public static partial class HomeLimitedShopBuyGoodsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeLimitedShopBuyGoodsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeLimitedShopBuyGoodsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBIb21lTGltaXRlZFNob3BCdXlHb29kc1JlcS5wcm90bxIfV2VlZHdhY2tl",
            "ci5TaGFyZWQuTmV0d29yay5Qcm90bxoaSG9tZUxpbWl0ZWRTaG9wR29vZHMu",
            "cHJvdG8idQoaSG9tZUxpbWl0ZWRTaG9wQnV5R29vZHNSZXESRAoFZ29vZHMY",
            "BiABKAsyNS5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLkhvbWVM",
            "aW1pdGVkU2hvcEdvb2RzEhEKCWJ1eV9jb3VudBgNIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.HomeLimitedShopGoodsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeLimitedShopBuyGoodsReq), global::Weedwacker.Shared.Network.Proto.HomeLimitedShopBuyGoodsReq.Parser, new[]{ "Goods", "BuyCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4574;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class HomeLimitedShopBuyGoodsReq : pb::IMessage<HomeLimitedShopBuyGoodsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeLimitedShopBuyGoodsReq> _parser = new pb::MessageParser<HomeLimitedShopBuyGoodsReq>(() => new HomeLimitedShopBuyGoodsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeLimitedShopBuyGoodsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeLimitedShopBuyGoodsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopBuyGoodsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopBuyGoodsReq(HomeLimitedShopBuyGoodsReq other) : this() {
      goods_ = other.goods_ != null ? other.goods_.Clone() : null;
      buyCount_ = other.buyCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopBuyGoodsReq Clone() {
      return new HomeLimitedShopBuyGoodsReq(this);
    }

    /// <summary>Field number for the "goods" field.</summary>
    public const int GoodsFieldNumber = 6;
    private global::Weedwacker.Shared.Network.Proto.HomeLimitedShopGoods goods_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.HomeLimitedShopGoods Goods {
      get { return goods_; }
      set {
        goods_ = value;
      }
    }

    /// <summary>Field number for the "buy_count" field.</summary>
    public const int BuyCountFieldNumber = 13;
    private uint buyCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuyCount {
      get { return buyCount_; }
      set {
        buyCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeLimitedShopBuyGoodsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeLimitedShopBuyGoodsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Goods, other.Goods)) return false;
      if (BuyCount != other.BuyCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (goods_ != null) hash ^= Goods.GetHashCode();
      if (BuyCount != 0) hash ^= BuyCount.GetHashCode();
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
      if (goods_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Goods);
      }
      if (BuyCount != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(BuyCount);
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
      if (goods_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Goods);
      }
      if (BuyCount != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(BuyCount);
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
      if (goods_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Goods);
      }
      if (BuyCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuyCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeLimitedShopBuyGoodsReq other) {
      if (other == null) {
        return;
      }
      if (other.goods_ != null) {
        if (goods_ == null) {
          Goods = new global::Weedwacker.Shared.Network.Proto.HomeLimitedShopGoods();
        }
        Goods.MergeFrom(other.Goods);
      }
      if (other.BuyCount != 0) {
        BuyCount = other.BuyCount;
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
          case 50: {
            if (goods_ == null) {
              Goods = new global::Weedwacker.Shared.Network.Proto.HomeLimitedShopGoods();
            }
            input.ReadMessage(Goods);
            break;
          }
          case 104: {
            BuyCount = input.ReadUInt32();
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
          case 50: {
            if (goods_ == null) {
              Goods = new global::Weedwacker.Shared.Network.Proto.HomeLimitedShopGoods();
            }
            input.ReadMessage(Goods);
            break;
          }
          case 104: {
            BuyCount = input.ReadUInt32();
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
