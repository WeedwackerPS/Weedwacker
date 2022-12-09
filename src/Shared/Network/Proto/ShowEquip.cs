// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ShowEquip.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ShowEquip.proto</summary>
  public static partial class ShowEquipReflection {

    #region Descriptor
    /// <summary>File descriptor for ShowEquip.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ShowEquipReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9TaG93RXF1aXAucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsu",
            "UHJvdG8aD1JlbGlxdWFyeS5wcm90bxoMV2VhcG9uLnByb3RvIqIBCglTaG93",
            "RXF1aXASDwoHaXRlbV9pZBgBIAEoDRI/CglyZWxpcXVhcnkYAiABKAsyKi5X",
            "ZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLlJlbGlxdWFyeUgAEjkK",
            "BndlYXBvbhgDIAEoCzInLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJv",
            "dG8uV2VhcG9uSABCCAoGZGV0YWlsYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ReliquaryReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.WeaponReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ShowEquip), global::Weedwacker.Shared.Network.Proto.ShowEquip.Parser, new[]{ "ItemId", "Reliquary", "Weapon" }, new[]{ "Detail" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ShowEquip : pb::IMessage<ShowEquip>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ShowEquip> _parser = new pb::MessageParser<ShowEquip>(() => new ShowEquip());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ShowEquip> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ShowEquipReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShowEquip() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShowEquip(ShowEquip other) : this() {
      itemId_ = other.itemId_;
      switch (other.DetailCase) {
        case DetailOneofCase.Reliquary:
          Reliquary = other.Reliquary.Clone();
          break;
        case DetailOneofCase.Weapon:
          Weapon = other.Weapon.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShowEquip Clone() {
      return new ShowEquip(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private uint itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "reliquary" field.</summary>
    public const int ReliquaryFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Reliquary Reliquary {
      get { return detailCase_ == DetailOneofCase.Reliquary ? (global::Weedwacker.Shared.Network.Proto.Reliquary) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.Reliquary;
      }
    }

    /// <summary>Field number for the "weapon" field.</summary>
    public const int WeaponFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Weapon Weapon {
      get { return detailCase_ == DetailOneofCase.Weapon ? (global::Weedwacker.Shared.Network.Proto.Weapon) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.Weapon;
      }
    }

    private object detail_;
    /// <summary>Enum of possible cases for the "detail" oneof.</summary>
    public enum DetailOneofCase {
      None = 0,
      Reliquary = 2,
      Weapon = 3,
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
      return Equals(other as ShowEquip);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ShowEquip other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (!object.Equals(Reliquary, other.Reliquary)) return false;
      if (!object.Equals(Weapon, other.Weapon)) return false;
      if (DetailCase != other.DetailCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (detailCase_ == DetailOneofCase.Reliquary) hash ^= Reliquary.GetHashCode();
      if (detailCase_ == DetailOneofCase.Weapon) hash ^= Weapon.GetHashCode();
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
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ItemId);
      }
      if (detailCase_ == DetailOneofCase.Reliquary) {
        output.WriteRawTag(18);
        output.WriteMessage(Reliquary);
      }
      if (detailCase_ == DetailOneofCase.Weapon) {
        output.WriteRawTag(26);
        output.WriteMessage(Weapon);
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
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ItemId);
      }
      if (detailCase_ == DetailOneofCase.Reliquary) {
        output.WriteRawTag(18);
        output.WriteMessage(Reliquary);
      }
      if (detailCase_ == DetailOneofCase.Weapon) {
        output.WriteRawTag(26);
        output.WriteMessage(Weapon);
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
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemId);
      }
      if (detailCase_ == DetailOneofCase.Reliquary) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reliquary);
      }
      if (detailCase_ == DetailOneofCase.Weapon) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Weapon);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ShowEquip other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      switch (other.DetailCase) {
        case DetailOneofCase.Reliquary:
          if (Reliquary == null) {
            Reliquary = new global::Weedwacker.Shared.Network.Proto.Reliquary();
          }
          Reliquary.MergeFrom(other.Reliquary);
          break;
        case DetailOneofCase.Weapon:
          if (Weapon == null) {
            Weapon = new global::Weedwacker.Shared.Network.Proto.Weapon();
          }
          Weapon.MergeFrom(other.Weapon);
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
          case 8: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 18: {
            global::Weedwacker.Shared.Network.Proto.Reliquary subBuilder = new global::Weedwacker.Shared.Network.Proto.Reliquary();
            if (detailCase_ == DetailOneofCase.Reliquary) {
              subBuilder.MergeFrom(Reliquary);
            }
            input.ReadMessage(subBuilder);
            Reliquary = subBuilder;
            break;
          }
          case 26: {
            global::Weedwacker.Shared.Network.Proto.Weapon subBuilder = new global::Weedwacker.Shared.Network.Proto.Weapon();
            if (detailCase_ == DetailOneofCase.Weapon) {
              subBuilder.MergeFrom(Weapon);
            }
            input.ReadMessage(subBuilder);
            Weapon = subBuilder;
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
            ItemId = input.ReadUInt32();
            break;
          }
          case 18: {
            global::Weedwacker.Shared.Network.Proto.Reliquary subBuilder = new global::Weedwacker.Shared.Network.Proto.Reliquary();
            if (detailCase_ == DetailOneofCase.Reliquary) {
              subBuilder.MergeFrom(Reliquary);
            }
            input.ReadMessage(subBuilder);
            Reliquary = subBuilder;
            break;
          }
          case 26: {
            global::Weedwacker.Shared.Network.Proto.Weapon subBuilder = new global::Weedwacker.Shared.Network.Proto.Weapon();
            if (detailCase_ == DetailOneofCase.Weapon) {
              subBuilder.MergeFrom(Weapon);
            }
            input.ReadMessage(subBuilder);
            Weapon = subBuilder;
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
