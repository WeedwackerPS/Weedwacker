// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FireworksLaunchParamType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FireworksLaunchParamType.proto</summary>
  public static partial class FireworksLaunchParamTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for FireworksLaunchParamType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FireworksLaunchParamTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5GaXJld29ya3NMYXVuY2hQYXJhbVR5cGUucHJvdG8SH1dlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG8qjgIKGEZpcmV3b3Jrc0xhdW5jaFBhcmFt",
            "VHlwZRIkCiBGSVJFV09SS1NfTEFVTkNIX1BBUkFNX1RZUEVfTk9ORRAAEiYK",
            "IkZJUkVXT1JLU19MQVVOQ0hfUEFSQU1fVFlQRV9SRVBFQVQQARIoCiRGSVJF",
            "V09SS1NfTEFVTkNIX1BBUkFNX1RZUEVfSU5URVJWQUwQAhIlCiFGSVJFV09S",
            "S1NfTEFVTkNIX1BBUkFNX1RZUEVfREVMQVkQAxIuCipGSVJFV09SS1NfTEFV",
            "TkNIX1BBUkFNX1RZUEVfUk9VTkRfSU5URVJWQUwQBBIjCh9GSVJFV09SS1Nf",
            "TEFVTkNIX1BBUkFNX1RZUEVfTUFYEAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.FireworksLaunchParamType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum FireworksLaunchParamType {
    [pbr::OriginalName("FIREWORKS_LAUNCH_PARAM_TYPE_NONE")] None = 0,
    [pbr::OriginalName("FIREWORKS_LAUNCH_PARAM_TYPE_REPEAT")] Repeat = 1,
    [pbr::OriginalName("FIREWORKS_LAUNCH_PARAM_TYPE_INTERVAL")] Interval = 2,
    [pbr::OriginalName("FIREWORKS_LAUNCH_PARAM_TYPE_DELAY")] Delay = 3,
    [pbr::OriginalName("FIREWORKS_LAUNCH_PARAM_TYPE_ROUND_INTERVAL")] RoundInterval = 4,
    [pbr::OriginalName("FIREWORKS_LAUNCH_PARAM_TYPE_MAX")] Max = 5,
  }

  #endregion

}

#endregion Designer generated code
