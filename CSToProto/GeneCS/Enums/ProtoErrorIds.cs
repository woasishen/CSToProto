// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Enums/Proto_ErrorIds.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Proto.ProtoInterface {

  /// <summary>Holder for reflection information generated from Enums/Proto_ErrorIds.proto</summary>
  public static partial class ProtoErrorIdsReflection {

    #region Descriptor
    /// <summary>File descriptor for Enums/Proto_ErrorIds.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtoErrorIdsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpFbnVtcy9Qcm90b19FcnJvcklkcy5wcm90byqrAQoOUHJvdG9fRXJyb3JJ",
            "ZHMSCAoETm9uZRAAEg8KC1VuS25vd0Vycm9yEAESDQoJSnNvbkVycm9yEAIS",
            "DwoLQXV0aEZhaWx1cmUQAxILCgdOb01zZ0lkEAQSEQoNTXNnSWROb3RWYWxp",
            "ZBAFEg4KClZlcnNpb25FcnIQBhIYChRVc2VyTmFtZUFscmVhZHlFeGlzdBAH",
            "EhQKEFVzZXJOYW1lTm90RXhpc3QQCEIXqgIUUHJvdG8uUHJvdG9JbnRlcmZh",
            "Y2ViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Proto.ProtoInterface.Proto_ErrorIds), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum Proto_ErrorIds {
    [pbr::OriginalName("None")] None = 0,
    [pbr::OriginalName("UnKnowError")] UnKnowError = 1,
    [pbr::OriginalName("JsonError")] JsonError = 2,
    [pbr::OriginalName("AuthFailure")] AuthFailure = 3,
    [pbr::OriginalName("NoMsgId")] NoMsgId = 4,
    [pbr::OriginalName("MsgIdNotValid")] MsgIdNotValid = 5,
    [pbr::OriginalName("VersionErr")] VersionErr = 6,
    [pbr::OriginalName("UserNameAlreadyExist")] UserNameAlreadyExist = 7,
    [pbr::OriginalName("UserNameNotExist")] UserNameNotExist = 8,
  }

  #endregion

}

#endregion Designer generated code