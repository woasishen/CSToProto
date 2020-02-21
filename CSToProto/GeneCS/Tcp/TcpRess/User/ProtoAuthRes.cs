// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Tcp/TcpRess/User/Proto_AuthRes.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Proto.ProtoInterface {

  /// <summary>Holder for reflection information generated from Tcp/TcpRess/User/Proto_AuthRes.proto</summary>
  public static partial class ProtoAuthResReflection {

    #region Descriptor
    /// <summary>File descriptor for Tcp/TcpRess/User/Proto_AuthRes.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtoAuthResReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRUY3AvVGNwUmVzcy9Vc2VyL1Byb3RvX0F1dGhSZXMucHJvdG8aFlByb3Rv",
            "X01zZ1Jlc0luZm8ucHJvdG8icQoNUHJvdG9fQXV0aFJlcxIRCglTZWNyZXRL",
            "ZXkYASABKAwSFAoMSm9pbmVkR2FtZUlkGAIgASgSEiUKCk1zZ1Jlc0luZm8Y",
            "AyABKAsyES5Qcm90b19Nc2dSZXNJbmZvEhAKCFRpbWVUaWNrGAQgASgSQheq",
            "AhRQcm90by5Qcm90b0ludGVyZmFjZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Proto.ProtoInterface.ProtoMsgResInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.ProtoInterface.Proto_AuthRes), global::Proto.ProtoInterface.Proto_AuthRes.Parser, new[]{ "SecretKey", "JoinedGameId", "MsgResInfo", "TimeTick" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Proto_AuthRes : pb::IMessage<Proto_AuthRes> {
    private static readonly pb::MessageParser<Proto_AuthRes> _parser = new pb::MessageParser<Proto_AuthRes>(() => new Proto_AuthRes());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Proto_AuthRes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.ProtoInterface.ProtoAuthResReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Proto_AuthRes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Proto_AuthRes(Proto_AuthRes other) : this() {
      secretKey_ = other.secretKey_;
      joinedGameId_ = other.joinedGameId_;
      msgResInfo_ = other.msgResInfo_ != null ? other.msgResInfo_.Clone() : null;
      timeTick_ = other.timeTick_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Proto_AuthRes Clone() {
      return new Proto_AuthRes(this);
    }

    /// <summary>Field number for the "SecretKey" field.</summary>
    public const int SecretKeyFieldNumber = 1;
    private pb::ByteString secretKey_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString SecretKey {
      get { return secretKey_; }
      set {
        secretKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "JoinedGameId" field.</summary>
    public const int JoinedGameIdFieldNumber = 2;
    private long joinedGameId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long JoinedGameId {
      get { return joinedGameId_; }
      set {
        joinedGameId_ = value;
      }
    }

    /// <summary>Field number for the "MsgResInfo" field.</summary>
    public const int MsgResInfoFieldNumber = 3;
    private global::Proto.ProtoInterface.Proto_MsgResInfo msgResInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.ProtoInterface.Proto_MsgResInfo MsgResInfo {
      get { return msgResInfo_; }
      set {
        msgResInfo_ = value;
      }
    }

    /// <summary>Field number for the "TimeTick" field.</summary>
    public const int TimeTickFieldNumber = 4;
    private long timeTick_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TimeTick {
      get { return timeTick_; }
      set {
        timeTick_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Proto_AuthRes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Proto_AuthRes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SecretKey != other.SecretKey) return false;
      if (JoinedGameId != other.JoinedGameId) return false;
      if (!object.Equals(MsgResInfo, other.MsgResInfo)) return false;
      if (TimeTick != other.TimeTick) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SecretKey.Length != 0) hash ^= SecretKey.GetHashCode();
      if (JoinedGameId != 0L) hash ^= JoinedGameId.GetHashCode();
      if (msgResInfo_ != null) hash ^= MsgResInfo.GetHashCode();
      if (TimeTick != 0L) hash ^= TimeTick.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SecretKey.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(SecretKey);
      }
      if (JoinedGameId != 0L) {
        output.WriteRawTag(16);
        output.WriteSInt64(JoinedGameId);
      }
      if (msgResInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MsgResInfo);
      }
      if (TimeTick != 0L) {
        output.WriteRawTag(32);
        output.WriteSInt64(TimeTick);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SecretKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(SecretKey);
      }
      if (JoinedGameId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeSInt64Size(JoinedGameId);
      }
      if (msgResInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MsgResInfo);
      }
      if (TimeTick != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeSInt64Size(TimeTick);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Proto_AuthRes other) {
      if (other == null) {
        return;
      }
      if (other.SecretKey.Length != 0) {
        SecretKey = other.SecretKey;
      }
      if (other.JoinedGameId != 0L) {
        JoinedGameId = other.JoinedGameId;
      }
      if (other.msgResInfo_ != null) {
        if (msgResInfo_ == null) {
          MsgResInfo = new global::Proto.ProtoInterface.Proto_MsgResInfo();
        }
        MsgResInfo.MergeFrom(other.MsgResInfo);
      }
      if (other.TimeTick != 0L) {
        TimeTick = other.TimeTick;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            SecretKey = input.ReadBytes();
            break;
          }
          case 16: {
            JoinedGameId = input.ReadSInt64();
            break;
          }
          case 26: {
            if (msgResInfo_ == null) {
              MsgResInfo = new global::Proto.ProtoInterface.Proto_MsgResInfo();
            }
            input.ReadMessage(MsgResInfo);
            break;
          }
          case 32: {
            TimeTick = input.ReadSInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
