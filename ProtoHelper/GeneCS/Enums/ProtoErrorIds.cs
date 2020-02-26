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
            "ChpFbnVtcy9Qcm90b19FcnJvcklkcy5wcm90byqPBgoOUHJvdG9fRXJyb3JJ",
            "ZHMSCAoETm9uZRAAEg8KC1VuS25vd0Vycm9yEAESDQoJSnNvbkVycm9yEAIS",
            "DwoLQXV0aEZhaWx1cmUQAxILCgdOb01zZ0lkEAQSEQoNTXNnSWROb3RWYWxp",
            "ZBAFEg4KClZlcnNpb25FcnIQBhIYChRVc2VyTmFtZUFscmVhZHlFeGlzdBAH",
            "EhQKEFVzZXJOYW1lTm90RXhpc3QQCBISCg5Vc2VySWROb3RFeGlzdBAJEhIK",
            "DlVzZXJJZE5vdE1hdGNoEAoSFAoQUGFzc3dvcmROb3RNYXRjaBALEhEKDVRv",
            "a2VuTm90TWF0Y2gQDBIRCg1BbHJlYWR5SW5Sb29tEA0SFgoSUm9vbUNvbmZp",
            "Z05vdFZhbGlkEA4SFQoRUmV0dXJuUm9vbU5vdEV4aXQQDxIQCgxSb29tTm90",
            "RXhpc3QQEBISCg5Ob3RJblJvb21FeGlzdBAREg4KClJvb21Jc0Z1bGwQEhIN",
            "CglOb3RJblJvb20QExIYChRTdGFydFJvb21DYW5ub3RMZWF2ZRAUEhQKEE93",
            "bmVyQ2Fubm90TGVhdmUQFRITCg9Ob3RZb3VyUGxheVRpbWUQFhIUChBQbGF5",
            "SXRlbU5vdEV4aXN0EBcSDwoLV2FpdEZvclBsYXkQGBIPCgtOb3RJblNpZ25V",
            "cBAZEgwKCE5vRmFUb0ZhEBoSFAoQTm90RW5vdWdoRm9yR2FuZxAbEhMKD05v",
            "Q2FuSHVNaW5nVGFuZxAcEgwKCENhbm5vdEh1EB0SGAoUT3RoZXJEZXZpY2VD",
            "b25uZWN0ZWQQHhIUChBMb2dVcGxvYWRTdWNjZWVkEB8SEgoOR2FtZUlkTm90",
            "RXhpc3QQIBISCg5Nb25leU5vdEVub3VnaBAhEhMKD0FscmVhZHlNYXRjaGlu",
            "ZxAiEhEKDU5vdEluTWF0Y2hpbmcQIxIYChRNb25leU5vdEVub3VnaFRvR2l2",
            "ZRAkEhYKElVzZXJNb25leU5vdEVub3VnaBAlEhQKEFBob25lVGNwTm90RXhp",
            "c3QQJkIXqgIUUHJvdG8uUHJvdG9JbnRlcmZhY2ViBnByb3RvMw=="));
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
    [pbr::OriginalName("UserIdNotExist")] UserIdNotExist = 9,
    [pbr::OriginalName("UserIdNotMatch")] UserIdNotMatch = 10,
    [pbr::OriginalName("PasswordNotMatch")] PasswordNotMatch = 11,
    [pbr::OriginalName("TokenNotMatch")] TokenNotMatch = 12,
    [pbr::OriginalName("AlreadyInRoom")] AlreadyInRoom = 13,
    [pbr::OriginalName("RoomConfigNotValid")] RoomConfigNotValid = 14,
    [pbr::OriginalName("ReturnRoomNotExit")] ReturnRoomNotExit = 15,
    [pbr::OriginalName("RoomNotExist")] RoomNotExist = 16,
    [pbr::OriginalName("NotInRoomExist")] NotInRoomExist = 17,
    [pbr::OriginalName("RoomIsFull")] RoomIsFull = 18,
    [pbr::OriginalName("NotInRoom")] NotInRoom = 19,
    [pbr::OriginalName("StartRoomCannotLeave")] StartRoomCannotLeave = 20,
    [pbr::OriginalName("OwnerCannotLeave")] OwnerCannotLeave = 21,
    [pbr::OriginalName("NotYourPlayTime")] NotYourPlayTime = 22,
    [pbr::OriginalName("PlayItemNotExist")] PlayItemNotExist = 23,
    [pbr::OriginalName("WaitForPlay")] WaitForPlay = 24,
    [pbr::OriginalName("NotInSignUp")] NotInSignUp = 25,
    [pbr::OriginalName("NoFaToFa")] NoFaToFa = 26,
    [pbr::OriginalName("NotEnoughForGang")] NotEnoughForGang = 27,
    [pbr::OriginalName("NoCanHuMingTang")] NoCanHuMingTang = 28,
    [pbr::OriginalName("CannotHu")] CannotHu = 29,
    [pbr::OriginalName("OtherDeviceConnected")] OtherDeviceConnected = 30,
    [pbr::OriginalName("LogUploadSucceed")] LogUploadSucceed = 31,
    [pbr::OriginalName("GameIdNotExist")] GameIdNotExist = 32,
    [pbr::OriginalName("MoneyNotEnough")] MoneyNotEnough = 33,
    [pbr::OriginalName("AlreadyMatching")] AlreadyMatching = 34,
    [pbr::OriginalName("NotInMatching")] NotInMatching = 35,
    [pbr::OriginalName("MoneyNotEnoughToGive")] MoneyNotEnoughToGive = 36,
    [pbr::OriginalName("UserMoneyNotEnough")] UserMoneyNotEnough = 37,
    [pbr::OriginalName("PhoneTcpNotExist")] PhoneTcpNotExist = 38,
  }

  #endregion

}

#endregion Designer generated code