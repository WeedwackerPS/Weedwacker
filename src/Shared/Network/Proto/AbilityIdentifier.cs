// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityIdentifier.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AbilityIdentifier.proto</summary>
  public static partial class AbilityIdentifierReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityIdentifier.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityIdentifierReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdBYmlsaXR5SWRlbnRpZmllci5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90byK8AQoRQWJpbGl0eUlkZW50aWZpZXISHAoUaW5zdGFu",
            "Y2VkX2FiaWxpdHlfaWQYBCABKA0SGwoTVW5rMzMwMF9JSENLSktMQ0lDSRgK",
            "IAEoDRIeChZpc19zZXJ2ZXJidWZmX21vZGlmaWVyGA4gASgIEhAKCGxvY2Fs",
            "X2lkGAcgASgFEhsKE1VuazMzMDBfT09PTEVMUEJESEoYASABKA0SHQoVaW5z",
            "dGFuY2VkX21vZGlmaWVyX2lkGAUgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AbilityIdentifier), global::Weedwacker.Shared.Network.Proto.AbilityIdentifier.Parser, new[]{ "InstancedAbilityId", "Unk3300IHCKJKLCICI", "IsServerbuffModifier", "LocalId", "Unk3300OOOLELPBDHJ", "InstancedModifierId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityIdentifier : pb::IMessage<AbilityIdentifier>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityIdentifier> _parser = new pb::MessageParser<AbilityIdentifier>(() => new AbilityIdentifier());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityIdentifier> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AbilityIdentifierReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityIdentifier() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityIdentifier(AbilityIdentifier other) : this() {
      instancedAbilityId_ = other.instancedAbilityId_;
      unk3300IHCKJKLCICI_ = other.unk3300IHCKJKLCICI_;
      isServerbuffModifier_ = other.isServerbuffModifier_;
      localId_ = other.localId_;
      unk3300OOOLELPBDHJ_ = other.unk3300OOOLELPBDHJ_;
      instancedModifierId_ = other.instancedModifierId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityIdentifier Clone() {
      return new AbilityIdentifier(this);
    }

    /// <summary>Field number for the "instanced_ability_id" field.</summary>
    public const int InstancedAbilityIdFieldNumber = 4;
    private uint instancedAbilityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint InstancedAbilityId {
      get { return instancedAbilityId_; }
      set {
        instancedAbilityId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_IHCKJKLCICI" field.</summary>
    public const int Unk3300IHCKJKLCICIFieldNumber = 10;
    private uint unk3300IHCKJKLCICI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300IHCKJKLCICI {
      get { return unk3300IHCKJKLCICI_; }
      set {
        unk3300IHCKJKLCICI_ = value;
      }
    }

    /// <summary>Field number for the "is_serverbuff_modifier" field.</summary>
    public const int IsServerbuffModifierFieldNumber = 14;
    private bool isServerbuffModifier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsServerbuffModifier {
      get { return isServerbuffModifier_; }
      set {
        isServerbuffModifier_ = value;
      }
    }

    /// <summary>Field number for the "local_id" field.</summary>
    public const int LocalIdFieldNumber = 7;
    private int localId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int LocalId {
      get { return localId_; }
      set {
        localId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_OOOLELPBDHJ" field.</summary>
    public const int Unk3300OOOLELPBDHJFieldNumber = 1;
    private uint unk3300OOOLELPBDHJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300OOOLELPBDHJ {
      get { return unk3300OOOLELPBDHJ_; }
      set {
        unk3300OOOLELPBDHJ_ = value;
      }
    }

    /// <summary>Field number for the "instanced_modifier_id" field.</summary>
    public const int InstancedModifierIdFieldNumber = 5;
    private uint instancedModifierId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint InstancedModifierId {
      get { return instancedModifierId_; }
      set {
        instancedModifierId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityIdentifier);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityIdentifier other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (InstancedAbilityId != other.InstancedAbilityId) return false;
      if (Unk3300IHCKJKLCICI != other.Unk3300IHCKJKLCICI) return false;
      if (IsServerbuffModifier != other.IsServerbuffModifier) return false;
      if (LocalId != other.LocalId) return false;
      if (Unk3300OOOLELPBDHJ != other.Unk3300OOOLELPBDHJ) return false;
      if (InstancedModifierId != other.InstancedModifierId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (InstancedAbilityId != 0) hash ^= InstancedAbilityId.GetHashCode();
      if (Unk3300IHCKJKLCICI != 0) hash ^= Unk3300IHCKJKLCICI.GetHashCode();
      if (IsServerbuffModifier != false) hash ^= IsServerbuffModifier.GetHashCode();
      if (LocalId != 0) hash ^= LocalId.GetHashCode();
      if (Unk3300OOOLELPBDHJ != 0) hash ^= Unk3300OOOLELPBDHJ.GetHashCode();
      if (InstancedModifierId != 0) hash ^= InstancedModifierId.GetHashCode();
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
      if (Unk3300OOOLELPBDHJ != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300OOOLELPBDHJ);
      }
      if (InstancedAbilityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(InstancedAbilityId);
      }
      if (InstancedModifierId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(InstancedModifierId);
      }
      if (LocalId != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(LocalId);
      }
      if (Unk3300IHCKJKLCICI != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300IHCKJKLCICI);
      }
      if (IsServerbuffModifier != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsServerbuffModifier);
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
      if (Unk3300OOOLELPBDHJ != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300OOOLELPBDHJ);
      }
      if (InstancedAbilityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(InstancedAbilityId);
      }
      if (InstancedModifierId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(InstancedModifierId);
      }
      if (LocalId != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(LocalId);
      }
      if (Unk3300IHCKJKLCICI != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300IHCKJKLCICI);
      }
      if (IsServerbuffModifier != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsServerbuffModifier);
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
      if (InstancedAbilityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InstancedAbilityId);
      }
      if (Unk3300IHCKJKLCICI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300IHCKJKLCICI);
      }
      if (IsServerbuffModifier != false) {
        size += 1 + 1;
      }
      if (LocalId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LocalId);
      }
      if (Unk3300OOOLELPBDHJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300OOOLELPBDHJ);
      }
      if (InstancedModifierId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InstancedModifierId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityIdentifier other) {
      if (other == null) {
        return;
      }
      if (other.InstancedAbilityId != 0) {
        InstancedAbilityId = other.InstancedAbilityId;
      }
      if (other.Unk3300IHCKJKLCICI != 0) {
        Unk3300IHCKJKLCICI = other.Unk3300IHCKJKLCICI;
      }
      if (other.IsServerbuffModifier != false) {
        IsServerbuffModifier = other.IsServerbuffModifier;
      }
      if (other.LocalId != 0) {
        LocalId = other.LocalId;
      }
      if (other.Unk3300OOOLELPBDHJ != 0) {
        Unk3300OOOLELPBDHJ = other.Unk3300OOOLELPBDHJ;
      }
      if (other.InstancedModifierId != 0) {
        InstancedModifierId = other.InstancedModifierId;
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
            Unk3300OOOLELPBDHJ = input.ReadUInt32();
            break;
          }
          case 32: {
            InstancedAbilityId = input.ReadUInt32();
            break;
          }
          case 40: {
            InstancedModifierId = input.ReadUInt32();
            break;
          }
          case 56: {
            LocalId = input.ReadInt32();
            break;
          }
          case 80: {
            Unk3300IHCKJKLCICI = input.ReadUInt32();
            break;
          }
          case 112: {
            IsServerbuffModifier = input.ReadBool();
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
            Unk3300OOOLELPBDHJ = input.ReadUInt32();
            break;
          }
          case 32: {
            InstancedAbilityId = input.ReadUInt32();
            break;
          }
          case 40: {
            InstancedModifierId = input.ReadUInt32();
            break;
          }
          case 56: {
            LocalId = input.ReadInt32();
            break;
          }
          case 80: {
            Unk3300IHCKJKLCICI = input.ReadUInt32();
            break;
          }
          case 112: {
            IsServerbuffModifier = input.ReadBool();
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
