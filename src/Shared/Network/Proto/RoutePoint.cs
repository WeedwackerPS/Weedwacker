// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RoutePoint.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from RoutePoint.proto</summary>
  public static partial class RoutePointReflection {

    #region Descriptor
    /// <summary>File descriptor for RoutePoint.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoutePointReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBSb3V0ZVBvaW50LnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3Jr",
            "LlByb3RvGhRNYXRoUXVhdGVybmlvbi5wcm90bxoMVmVjdG9yLnByb3RvIokD",
            "CgpSb3V0ZVBvaW50EjkKCHBvc2l0aW9uGAEgASgLMicuV2VlZHdhY2tlci5T",
            "aGFyZWQuTmV0d29yay5Qcm90by5WZWN0b3ISFAoMYXJyaXZlX3JhbmdlGAIg",
            "ASgCEhcKD2hhc19yZWFjaF9ldmVudBgDIAEoCBISCgh2ZWxvY2l0eRgLIAEo",
            "AkgAEg4KBHRpbWUYDCABKAJIABI7Cghyb3RhdGlvbhgVIAEoCzInLldlZWR3",
            "YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uVmVjdG9ySAESSQoOcm90YXRp",
            "b25fc3BlZWQYFiABKAsyLy5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlBy",
            "b3RvLk1hdGhRdWF0ZXJuaW9uSAESRQoKYXhpc19zcGVlZBgXIAEoCzIvLldl",
            "ZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uTWF0aFF1YXRlcm5pb25I",
            "AUINCgttb3ZlX3BhcmFtc0IPCg1yb3RhdGVfcGFyYW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.MathQuaternionReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.RoutePoint), global::Weedwacker.Shared.Network.Proto.RoutePoint.Parser, new[]{ "Position", "ArriveRange", "HasReachEvent", "Velocity", "Time", "Rotation", "RotationSpeed", "AxisSpeed" }, new[]{ "MoveParams", "RotateParams" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RoutePoint : pb::IMessage<RoutePoint>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RoutePoint> _parser = new pb::MessageParser<RoutePoint>(() => new RoutePoint());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RoutePoint> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.RoutePointReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoutePoint() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoutePoint(RoutePoint other) : this() {
      position_ = other.position_ != null ? other.position_.Clone() : null;
      arriveRange_ = other.arriveRange_;
      hasReachEvent_ = other.hasReachEvent_;
      switch (other.MoveParamsCase) {
        case MoveParamsOneofCase.Velocity:
          Velocity = other.Velocity;
          break;
        case MoveParamsOneofCase.Time:
          Time = other.Time;
          break;
      }

      switch (other.RotateParamsCase) {
        case RotateParamsOneofCase.Rotation:
          Rotation = other.Rotation.Clone();
          break;
        case RotateParamsOneofCase.RotationSpeed:
          RotationSpeed = other.RotationSpeed.Clone();
          break;
        case RotateParamsOneofCase.AxisSpeed:
          AxisSpeed = other.AxisSpeed.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoutePoint Clone() {
      return new RoutePoint(this);
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 1;
    private global::Weedwacker.Shared.Network.Proto.Vector position_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    /// <summary>Field number for the "arrive_range" field.</summary>
    public const int ArriveRangeFieldNumber = 2;
    private float arriveRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float ArriveRange {
      get { return arriveRange_; }
      set {
        arriveRange_ = value;
      }
    }

    /// <summary>Field number for the "has_reach_event" field.</summary>
    public const int HasReachEventFieldNumber = 3;
    private bool hasReachEvent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasReachEvent {
      get { return hasReachEvent_; }
      set {
        hasReachEvent_ = value;
      }
    }

    /// <summary>Field number for the "velocity" field.</summary>
    public const int VelocityFieldNumber = 11;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Velocity {
      get { return moveParamsCase_ == MoveParamsOneofCase.Velocity ? (float) moveParams_ : 0F; }
      set {
        moveParams_ = value;
        moveParamsCase_ = MoveParamsOneofCase.Velocity;
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 12;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Time {
      get { return moveParamsCase_ == MoveParamsOneofCase.Time ? (float) moveParams_ : 0F; }
      set {
        moveParams_ = value;
        moveParamsCase_ = MoveParamsOneofCase.Time;
      }
    }

    /// <summary>Field number for the "rotation" field.</summary>
    public const int RotationFieldNumber = 21;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Rotation {
      get { return rotateParamsCase_ == RotateParamsOneofCase.Rotation ? (global::Weedwacker.Shared.Network.Proto.Vector) rotateParams_ : null; }
      set {
        rotateParams_ = value;
        rotateParamsCase_ = value == null ? RotateParamsOneofCase.None : RotateParamsOneofCase.Rotation;
      }
    }

    /// <summary>Field number for the "rotation_speed" field.</summary>
    public const int RotationSpeedFieldNumber = 22;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.MathQuaternion RotationSpeed {
      get { return rotateParamsCase_ == RotateParamsOneofCase.RotationSpeed ? (global::Weedwacker.Shared.Network.Proto.MathQuaternion) rotateParams_ : null; }
      set {
        rotateParams_ = value;
        rotateParamsCase_ = value == null ? RotateParamsOneofCase.None : RotateParamsOneofCase.RotationSpeed;
      }
    }

    /// <summary>Field number for the "axis_speed" field.</summary>
    public const int AxisSpeedFieldNumber = 23;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.MathQuaternion AxisSpeed {
      get { return rotateParamsCase_ == RotateParamsOneofCase.AxisSpeed ? (global::Weedwacker.Shared.Network.Proto.MathQuaternion) rotateParams_ : null; }
      set {
        rotateParams_ = value;
        rotateParamsCase_ = value == null ? RotateParamsOneofCase.None : RotateParamsOneofCase.AxisSpeed;
      }
    }

    private object moveParams_;
    /// <summary>Enum of possible cases for the "move_params" oneof.</summary>
    public enum MoveParamsOneofCase {
      None = 0,
      Velocity = 11,
      Time = 12,
    }
    private MoveParamsOneofCase moveParamsCase_ = MoveParamsOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MoveParamsOneofCase MoveParamsCase {
      get { return moveParamsCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMoveParams() {
      moveParamsCase_ = MoveParamsOneofCase.None;
      moveParams_ = null;
    }

    private object rotateParams_;
    /// <summary>Enum of possible cases for the "rotate_params" oneof.</summary>
    public enum RotateParamsOneofCase {
      None = 0,
      Rotation = 21,
      RotationSpeed = 22,
      AxisSpeed = 23,
    }
    private RotateParamsOneofCase rotateParamsCase_ = RotateParamsOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RotateParamsOneofCase RotateParamsCase {
      get { return rotateParamsCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearRotateParams() {
      rotateParamsCase_ = RotateParamsOneofCase.None;
      rotateParams_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RoutePoint);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RoutePoint other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Position, other.Position)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArriveRange, other.ArriveRange)) return false;
      if (HasReachEvent != other.HasReachEvent) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Velocity, other.Velocity)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Time, other.Time)) return false;
      if (!object.Equals(Rotation, other.Rotation)) return false;
      if (!object.Equals(RotationSpeed, other.RotationSpeed)) return false;
      if (!object.Equals(AxisSpeed, other.AxisSpeed)) return false;
      if (MoveParamsCase != other.MoveParamsCase) return false;
      if (RotateParamsCase != other.RotateParamsCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (position_ != null) hash ^= Position.GetHashCode();
      if (ArriveRange != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArriveRange);
      if (HasReachEvent != false) hash ^= HasReachEvent.GetHashCode();
      if (moveParamsCase_ == MoveParamsOneofCase.Velocity) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Velocity);
      if (moveParamsCase_ == MoveParamsOneofCase.Time) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Time);
      if (rotateParamsCase_ == RotateParamsOneofCase.Rotation) hash ^= Rotation.GetHashCode();
      if (rotateParamsCase_ == RotateParamsOneofCase.RotationSpeed) hash ^= RotationSpeed.GetHashCode();
      if (rotateParamsCase_ == RotateParamsOneofCase.AxisSpeed) hash ^= AxisSpeed.GetHashCode();
      hash ^= (int) moveParamsCase_;
      hash ^= (int) rotateParamsCase_;
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
      if (position_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Position);
      }
      if (ArriveRange != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(ArriveRange);
      }
      if (HasReachEvent != false) {
        output.WriteRawTag(24);
        output.WriteBool(HasReachEvent);
      }
      if (moveParamsCase_ == MoveParamsOneofCase.Velocity) {
        output.WriteRawTag(93);
        output.WriteFloat(Velocity);
      }
      if (moveParamsCase_ == MoveParamsOneofCase.Time) {
        output.WriteRawTag(101);
        output.WriteFloat(Time);
      }
      if (rotateParamsCase_ == RotateParamsOneofCase.Rotation) {
        output.WriteRawTag(170, 1);
        output.WriteMessage(Rotation);
      }
      if (rotateParamsCase_ == RotateParamsOneofCase.RotationSpeed) {
        output.WriteRawTag(178, 1);
        output.WriteMessage(RotationSpeed);
      }
      if (rotateParamsCase_ == RotateParamsOneofCase.AxisSpeed) {
        output.WriteRawTag(186, 1);
        output.WriteMessage(AxisSpeed);
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
      if (position_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Position);
      }
      if (ArriveRange != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(ArriveRange);
      }
      if (HasReachEvent != false) {
        output.WriteRawTag(24);
        output.WriteBool(HasReachEvent);
      }
      if (moveParamsCase_ == MoveParamsOneofCase.Velocity) {
        output.WriteRawTag(93);
        output.WriteFloat(Velocity);
      }
      if (moveParamsCase_ == MoveParamsOneofCase.Time) {
        output.WriteRawTag(101);
        output.WriteFloat(Time);
      }
      if (rotateParamsCase_ == RotateParamsOneofCase.Rotation) {
        output.WriteRawTag(170, 1);
        output.WriteMessage(Rotation);
      }
      if (rotateParamsCase_ == RotateParamsOneofCase.RotationSpeed) {
        output.WriteRawTag(178, 1);
        output.WriteMessage(RotationSpeed);
      }
      if (rotateParamsCase_ == RotateParamsOneofCase.AxisSpeed) {
        output.WriteRawTag(186, 1);
        output.WriteMessage(AxisSpeed);
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
      if (position_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
      }
      if (ArriveRange != 0F) {
        size += 1 + 4;
      }
      if (HasReachEvent != false) {
        size += 1 + 1;
      }
      if (moveParamsCase_ == MoveParamsOneofCase.Velocity) {
        size += 1 + 4;
      }
      if (moveParamsCase_ == MoveParamsOneofCase.Time) {
        size += 1 + 4;
      }
      if (rotateParamsCase_ == RotateParamsOneofCase.Rotation) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Rotation);
      }
      if (rotateParamsCase_ == RotateParamsOneofCase.RotationSpeed) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(RotationSpeed);
      }
      if (rotateParamsCase_ == RotateParamsOneofCase.AxisSpeed) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(AxisSpeed);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RoutePoint other) {
      if (other == null) {
        return;
      }
      if (other.position_ != null) {
        if (position_ == null) {
          Position = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Position.MergeFrom(other.Position);
      }
      if (other.ArriveRange != 0F) {
        ArriveRange = other.ArriveRange;
      }
      if (other.HasReachEvent != false) {
        HasReachEvent = other.HasReachEvent;
      }
      switch (other.MoveParamsCase) {
        case MoveParamsOneofCase.Velocity:
          Velocity = other.Velocity;
          break;
        case MoveParamsOneofCase.Time:
          Time = other.Time;
          break;
      }

      switch (other.RotateParamsCase) {
        case RotateParamsOneofCase.Rotation:
          if (Rotation == null) {
            Rotation = new global::Weedwacker.Shared.Network.Proto.Vector();
          }
          Rotation.MergeFrom(other.Rotation);
          break;
        case RotateParamsOneofCase.RotationSpeed:
          if (RotationSpeed == null) {
            RotationSpeed = new global::Weedwacker.Shared.Network.Proto.MathQuaternion();
          }
          RotationSpeed.MergeFrom(other.RotationSpeed);
          break;
        case RotateParamsOneofCase.AxisSpeed:
          if (AxisSpeed == null) {
            AxisSpeed = new global::Weedwacker.Shared.Network.Proto.MathQuaternion();
          }
          AxisSpeed.MergeFrom(other.AxisSpeed);
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
          case 10: {
            if (position_ == null) {
              Position = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Position);
            break;
          }
          case 21: {
            ArriveRange = input.ReadFloat();
            break;
          }
          case 24: {
            HasReachEvent = input.ReadBool();
            break;
          }
          case 93: {
            Velocity = input.ReadFloat();
            break;
          }
          case 101: {
            Time = input.ReadFloat();
            break;
          }
          case 170: {
            global::Weedwacker.Shared.Network.Proto.Vector subBuilder = new global::Weedwacker.Shared.Network.Proto.Vector();
            if (rotateParamsCase_ == RotateParamsOneofCase.Rotation) {
              subBuilder.MergeFrom(Rotation);
            }
            input.ReadMessage(subBuilder);
            Rotation = subBuilder;
            break;
          }
          case 178: {
            global::Weedwacker.Shared.Network.Proto.MathQuaternion subBuilder = new global::Weedwacker.Shared.Network.Proto.MathQuaternion();
            if (rotateParamsCase_ == RotateParamsOneofCase.RotationSpeed) {
              subBuilder.MergeFrom(RotationSpeed);
            }
            input.ReadMessage(subBuilder);
            RotationSpeed = subBuilder;
            break;
          }
          case 186: {
            global::Weedwacker.Shared.Network.Proto.MathQuaternion subBuilder = new global::Weedwacker.Shared.Network.Proto.MathQuaternion();
            if (rotateParamsCase_ == RotateParamsOneofCase.AxisSpeed) {
              subBuilder.MergeFrom(AxisSpeed);
            }
            input.ReadMessage(subBuilder);
            AxisSpeed = subBuilder;
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
            if (position_ == null) {
              Position = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Position);
            break;
          }
          case 21: {
            ArriveRange = input.ReadFloat();
            break;
          }
          case 24: {
            HasReachEvent = input.ReadBool();
            break;
          }
          case 93: {
            Velocity = input.ReadFloat();
            break;
          }
          case 101: {
            Time = input.ReadFloat();
            break;
          }
          case 170: {
            global::Weedwacker.Shared.Network.Proto.Vector subBuilder = new global::Weedwacker.Shared.Network.Proto.Vector();
            if (rotateParamsCase_ == RotateParamsOneofCase.Rotation) {
              subBuilder.MergeFrom(Rotation);
            }
            input.ReadMessage(subBuilder);
            Rotation = subBuilder;
            break;
          }
          case 178: {
            global::Weedwacker.Shared.Network.Proto.MathQuaternion subBuilder = new global::Weedwacker.Shared.Network.Proto.MathQuaternion();
            if (rotateParamsCase_ == RotateParamsOneofCase.RotationSpeed) {
              subBuilder.MergeFrom(RotationSpeed);
            }
            input.ReadMessage(subBuilder);
            RotationSpeed = subBuilder;
            break;
          }
          case 186: {
            global::Weedwacker.Shared.Network.Proto.MathQuaternion subBuilder = new global::Weedwacker.Shared.Network.Proto.MathQuaternion();
            if (rotateParamsCase_ == RotateParamsOneofCase.AxisSpeed) {
              subBuilder.MergeFrom(AxisSpeed);
            }
            input.ReadMessage(subBuilder);
            AxisSpeed = subBuilder;
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
