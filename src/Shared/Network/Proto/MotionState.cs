// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MotionState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from MotionState.proto</summary>
  public static partial class MotionStateReflection {

    #region Descriptor
    /// <summary>File descriptor for MotionState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MotionStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFNb3Rpb25TdGF0ZS5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29y",
            "ay5Qcm90byqUDQoLTW90aW9uU3RhdGUSFQoRTU9USU9OX1NUQVRFX05PTkUQ",
            "ABIWChJNT1RJT05fU1RBVEVfUkVTRVQQARIYChRNT1RJT05fU1RBVEVfU1RB",
            "TkRCWRACEh0KGU1PVElPTl9TVEFURV9TVEFOREJZX01PVkUQAxIVChFNT1RJ",
            "T05fU1RBVEVfV0FMSxAEEhQKEE1PVElPTl9TVEFURV9SVU4QBRIVChFNT1RJ",
            "T05fU1RBVEVfREFTSBAGEhYKEk1PVElPTl9TVEFURV9DTElNQhAHEhsKF01P",
            "VElPTl9TVEFURV9DTElNQl9KVU1QEAgSIQodTU9USU9OX1NUQVRFX1NUQU5E",
            "QllfVE9fQ0xJTUIQCRIWChJNT1RJT05fU1RBVEVfRklHSFQQChIVChFNT1RJ",
            "T05fU1RBVEVfSlVNUBALEhUKEU1PVElPTl9TVEFURV9EUk9QEAwSFAoQTU9U",
            "SU9OX1NUQVRFX0ZMWRANEhoKFk1PVElPTl9TVEFURV9TV0lNX01PVkUQDhIa",
            "ChZNT1RJT05fU1RBVEVfU1dJTV9JRExFEA8SGgoWTU9USU9OX1NUQVRFX1NX",
            "SU1fREFTSBAQEhoKFk1PVElPTl9TVEFURV9TV0lNX0pVTVAQERIVChFNT1RJ",
            "T05fU1RBVEVfU0xJUBASEhwKGE1PVElPTl9TVEFURV9HT19VUFNUQUlSUxAT",
            "Eh8KG01PVElPTl9TVEFURV9GQUxMX09OX0dST1VORBAUEikKJU1PVElPTl9T",
            "VEFURV9KVU1QX1VQX1dBTExfRk9SX1NUQU5EQlkQFRIeChpNT1RJT05fU1RB",
            "VEVfSlVNUF9PRkZfV0FMTBAWEhwKGE1PVElPTl9TVEFURV9QT1dFUkVEX0ZM",
            "WRAXEhwKGE1PVElPTl9TVEFURV9MQURERVJfSURMRRAYEhwKGE1PVElPTl9T",
            "VEFURV9MQURERVJfTU9WRRAZEhwKGE1PVElPTl9TVEFURV9MQURERVJfU0xJ",
            "UBAaEiIKHk1PVElPTl9TVEFURV9TVEFOREJZX1RPX0xBRERFUhAbEiIKHk1P",
            "VElPTl9TVEFURV9MQURERVJfVE9fU1RBTkRCWRAcEh8KG01PVElPTl9TVEFU",
            "RV9EQU5HRVJfU1RBTkRCWRAdEiQKIE1PVElPTl9TVEFURV9EQU5HRVJfU1RB",
            "TkRCWV9NT1ZFEB4SHAoYTU9USU9OX1NUQVRFX0RBTkdFUl9XQUxLEB8SGwoX",
            "TU9USU9OX1NUQVRFX0RBTkdFUl9SVU4QIBIcChhNT1RJT05fU1RBVEVfREFO",
            "R0VSX0RBU0gQIRIcChhNT1RJT05fU1RBVEVfQ1JPVUNIX0lETEUQIhIcChhN",
            "T1RJT05fU1RBVEVfQ1JPVUNIX01PVkUQIxIcChhNT1RJT05fU1RBVEVfQ1JP",
            "VUNIX1JPTEwQJBIXChNNT1RJT05fU1RBVEVfTk9USUZZECUSGwoXTU9USU9O",
            "X1NUQVRFX0xBTkRfU1BFRUQQJhIeChpNT1RJT05fU1RBVEVfTU9WRV9GQUlM",
            "X0FDSxAnEhoKFk1PVElPTl9TVEFURV9XQVRFUkZBTEwQKBIiCh5NT1RJT05f",
            "U1RBVEVfREFTSF9CRUZPUkVfU0hBS0UQKRIZChVNT1RJT05fU1RBVEVfU0lU",
            "X0lETEUQKhIeChpNT1RJT05fU1RBVEVfRk9SQ0VfU0VUX1BPUxArEiEKHU1P",
            "VElPTl9TVEFURV9RVUVTVF9GT1JDRV9EUkFHECwSHQoZTU9USU9OX1NUQVRF",
            "X0ZPTExPV19ST1VURRAtEh8KG01PVElPTl9TVEFURV9TS0lGRl9CT0FSRElO",
            "RxAuEh0KGU1PVElPTl9TVEFURV9TS0lGRl9OT1JNQUwQLxIbChdNT1RJT05f",
            "U1RBVEVfU0tJRkZfREFTSBAwEiMKH01PVElPTl9TVEFURV9TS0lGRl9QT1dF",
            "UkVEX0RBU0gQMRIgChxNT1RJT05fU1RBVEVfREVTVFJPWV9WRUhJQ0xFEDIS",
            "GQoVTU9USU9OX1NUQVRFX0ZMWV9JRExFEDMSGQoVTU9USU9OX1NUQVRFX0ZM",
            "WV9TTE9XEDQSGQoVTU9USU9OX1NUQVRFX0ZMWV9GQVNUEDUSGQoVTU9USU9O",
            "X1NUQVRFX0FJTV9NT1ZFEDYSIQodTU9USU9OX1NUQVRFX0FJUl9DT01QRU5T",
            "QVRJT04QNxIUChBNT1RJT05fU1RBVEVfTlVNEDhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.MotionState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MotionState {
    [pbr::OriginalName("MOTION_STATE_NONE")] None = 0,
    [pbr::OriginalName("MOTION_STATE_RESET")] Reset = 1,
    [pbr::OriginalName("MOTION_STATE_STANDBY")] Standby = 2,
    [pbr::OriginalName("MOTION_STATE_STANDBY_MOVE")] StandbyMove = 3,
    [pbr::OriginalName("MOTION_STATE_WALK")] Walk = 4,
    [pbr::OriginalName("MOTION_STATE_RUN")] Run = 5,
    [pbr::OriginalName("MOTION_STATE_DASH")] Dash = 6,
    [pbr::OriginalName("MOTION_STATE_CLIMB")] Climb = 7,
    [pbr::OriginalName("MOTION_STATE_CLIMB_JUMP")] ClimbJump = 8,
    [pbr::OriginalName("MOTION_STATE_STANDBY_TO_CLIMB")] StandbyToClimb = 9,
    [pbr::OriginalName("MOTION_STATE_FIGHT")] Fight = 10,
    [pbr::OriginalName("MOTION_STATE_JUMP")] Jump = 11,
    [pbr::OriginalName("MOTION_STATE_DROP")] Drop = 12,
    [pbr::OriginalName("MOTION_STATE_FLY")] Fly = 13,
    [pbr::OriginalName("MOTION_STATE_SWIM_MOVE")] SwimMove = 14,
    [pbr::OriginalName("MOTION_STATE_SWIM_IDLE")] SwimIdle = 15,
    [pbr::OriginalName("MOTION_STATE_SWIM_DASH")] SwimDash = 16,
    [pbr::OriginalName("MOTION_STATE_SWIM_JUMP")] SwimJump = 17,
    [pbr::OriginalName("MOTION_STATE_SLIP")] Slip = 18,
    [pbr::OriginalName("MOTION_STATE_GO_UPSTAIRS")] GoUpstairs = 19,
    [pbr::OriginalName("MOTION_STATE_FALL_ON_GROUND")] FallOnGround = 20,
    [pbr::OriginalName("MOTION_STATE_JUMP_UP_WALL_FOR_STANDBY")] JumpUpWallForStandby = 21,
    [pbr::OriginalName("MOTION_STATE_JUMP_OFF_WALL")] JumpOffWall = 22,
    [pbr::OriginalName("MOTION_STATE_POWERED_FLY")] PoweredFly = 23,
    [pbr::OriginalName("MOTION_STATE_LADDER_IDLE")] LadderIdle = 24,
    [pbr::OriginalName("MOTION_STATE_LADDER_MOVE")] LadderMove = 25,
    [pbr::OriginalName("MOTION_STATE_LADDER_SLIP")] LadderSlip = 26,
    [pbr::OriginalName("MOTION_STATE_STANDBY_TO_LADDER")] StandbyToLadder = 27,
    [pbr::OriginalName("MOTION_STATE_LADDER_TO_STANDBY")] LadderToStandby = 28,
    [pbr::OriginalName("MOTION_STATE_DANGER_STANDBY")] DangerStandby = 29,
    [pbr::OriginalName("MOTION_STATE_DANGER_STANDBY_MOVE")] DangerStandbyMove = 30,
    [pbr::OriginalName("MOTION_STATE_DANGER_WALK")] DangerWalk = 31,
    [pbr::OriginalName("MOTION_STATE_DANGER_RUN")] DangerRun = 32,
    [pbr::OriginalName("MOTION_STATE_DANGER_DASH")] DangerDash = 33,
    [pbr::OriginalName("MOTION_STATE_CROUCH_IDLE")] CrouchIdle = 34,
    [pbr::OriginalName("MOTION_STATE_CROUCH_MOVE")] CrouchMove = 35,
    [pbr::OriginalName("MOTION_STATE_CROUCH_ROLL")] CrouchRoll = 36,
    [pbr::OriginalName("MOTION_STATE_NOTIFY")] Notify = 37,
    [pbr::OriginalName("MOTION_STATE_LAND_SPEED")] LandSpeed = 38,
    [pbr::OriginalName("MOTION_STATE_MOVE_FAIL_ACK")] MoveFailAck = 39,
    [pbr::OriginalName("MOTION_STATE_WATERFALL")] Waterfall = 40,
    [pbr::OriginalName("MOTION_STATE_DASH_BEFORE_SHAKE")] DashBeforeShake = 41,
    [pbr::OriginalName("MOTION_STATE_SIT_IDLE")] SitIdle = 42,
    [pbr::OriginalName("MOTION_STATE_FORCE_SET_POS")] ForceSetPos = 43,
    [pbr::OriginalName("MOTION_STATE_QUEST_FORCE_DRAG")] QuestForceDrag = 44,
    [pbr::OriginalName("MOTION_STATE_FOLLOW_ROUTE")] FollowRoute = 45,
    [pbr::OriginalName("MOTION_STATE_SKIFF_BOARDING")] SkiffBoarding = 46,
    [pbr::OriginalName("MOTION_STATE_SKIFF_NORMAL")] SkiffNormal = 47,
    [pbr::OriginalName("MOTION_STATE_SKIFF_DASH")] SkiffDash = 48,
    [pbr::OriginalName("MOTION_STATE_SKIFF_POWERED_DASH")] SkiffPoweredDash = 49,
    [pbr::OriginalName("MOTION_STATE_DESTROY_VEHICLE")] DestroyVehicle = 50,
    [pbr::OriginalName("MOTION_STATE_FLY_IDLE")] FlyIdle = 51,
    [pbr::OriginalName("MOTION_STATE_FLY_SLOW")] FlySlow = 52,
    [pbr::OriginalName("MOTION_STATE_FLY_FAST")] FlyFast = 53,
    [pbr::OriginalName("MOTION_STATE_AIM_MOVE")] AimMove = 54,
    [pbr::OriginalName("MOTION_STATE_AIR_COMPENSATION")] AirCompensation = 55,
    [pbr::OriginalName("MOTION_STATE_NUM")] Num = 56,
  }

  #endregion

}

#endregion Designer generated code
