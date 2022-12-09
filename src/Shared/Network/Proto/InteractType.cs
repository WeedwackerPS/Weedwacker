// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InteractType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from InteractType.proto</summary>
  public static partial class InteractTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for InteractType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InteractTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJJbnRlcmFjdFR5cGUucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdv",
            "cmsuUHJvdG8qjAQKDEludGVyYWN0VHlwZRIWChJJTlRFUkFDVF9UWVBFX05P",
            "TkUQABIbChdJTlRFUkFDVF9UWVBFX1BJQ0tfSVRFTRABEhgKFElOVEVSQUNU",
            "X1RZUEVfR0FUSEVSEAISHAoYSU5URVJBQ1RfVFlQRV9PUEVOX0NIRVNUEAMS",
            "HQoZSU5URVJBQ1RfVFlQRV9PUEVOX1NUQVRVRRAEEhkKFUlOVEVSQUNUX1RZ",
            "UEVfQ09OU1VNRRAFEiAKHElOVEVSQUNUX1RZUEVfTVBfUExBWV9SRVdBUkQQ",
            "BhIWChJJTlRFUkFDVF9UWVBFX1ZJRVcQBxIgChxJTlRFUkFDVF9UWVBFX0dF",
            "TkVSQUxfUkVXQVJEEAgSHgoaSU5URVJBQ1RfVFlQRV9NSVJBQ0xFX1JJTkcQ",
            "CRIcChhJTlRFUkFDVF9UWVBFX0ZPVU5EQVRJT04QChIcChhJTlRFUkFDVF9U",
            "WVBFX0VDSE9fU0hFTEwQCxIdChlJTlRFUkFDVF9UWVBFX0hPTUVfR0FUSEVS",
            "EAwSHAoYSU5URVJBQ1RfVFlQRV9FTlZfQU5JTUFMEA0SHgoaSU5URVJBQ1Rf",
            "VFlQRV9RVUVTVF9HQURHRVQQDhIdChlJTlRFUkFDVF9UWVBFX1VJX0lOVEVS",
            "QUNUEA8SIQodSU5URVJBQ1RfVFlQRV9ERVNIUkVUX09CRUxJU0sQEGIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.InteractType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum InteractType {
    [pbr::OriginalName("INTERACT_TYPE_NONE")] None = 0,
    [pbr::OriginalName("INTERACT_TYPE_PICK_ITEM")] PickItem = 1,
    [pbr::OriginalName("INTERACT_TYPE_GATHER")] Gather = 2,
    [pbr::OriginalName("INTERACT_TYPE_OPEN_CHEST")] OpenChest = 3,
    [pbr::OriginalName("INTERACT_TYPE_OPEN_STATUE")] OpenStatue = 4,
    [pbr::OriginalName("INTERACT_TYPE_CONSUME")] Consume = 5,
    [pbr::OriginalName("INTERACT_TYPE_MP_PLAY_REWARD")] MpPlayReward = 6,
    [pbr::OriginalName("INTERACT_TYPE_VIEW")] View = 7,
    [pbr::OriginalName("INTERACT_TYPE_GENERAL_REWARD")] GeneralReward = 8,
    [pbr::OriginalName("INTERACT_TYPE_MIRACLE_RING")] MiracleRing = 9,
    [pbr::OriginalName("INTERACT_TYPE_FOUNDATION")] Foundation = 10,
    [pbr::OriginalName("INTERACT_TYPE_ECHO_SHELL")] EchoShell = 11,
    [pbr::OriginalName("INTERACT_TYPE_HOME_GATHER")] HomeGather = 12,
    [pbr::OriginalName("INTERACT_TYPE_ENV_ANIMAL")] EnvAnimal = 13,
    [pbr::OriginalName("INTERACT_TYPE_QUEST_GADGET")] QuestGadget = 14,
    [pbr::OriginalName("INTERACT_TYPE_UI_INTERACT")] UiInteract = 15,
    [pbr::OriginalName("INTERACT_TYPE_DESHRET_OBELISK")] DeshretObelisk = 16,
  }

  #endregion

}

#endregion Designer generated code
