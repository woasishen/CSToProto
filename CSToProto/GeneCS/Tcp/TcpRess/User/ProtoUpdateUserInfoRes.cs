// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Tcp/TcpRess/User/Proto_UpdateUserInfoRes.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Proto.ProtoInterface {

  /// <summary>Holder for reflection information generated from Tcp/TcpRess/User/Proto_UpdateUserInfoRes.proto</summary>
  public static partial class ProtoUpdateUserInfoResReflection {

    #region Descriptor
    /// <summary>File descriptor for Tcp/TcpRess/User/Proto_UpdateUserInfoRes.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtoUpdateUserInfoResReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5UY3AvVGNwUmVzcy9Vc2VyL1Byb3RvX1VwZGF0ZVVzZXJJbmZvUmVzLnBy",
            "b3RvGhZQcm90b19Nc2dSZXNJbmZvLnByb3RvImEKF1Byb3RvX1VwZGF0ZVVz",
            "ZXJJbmZvUmVzEg0KBU1vbmV5GAEgASgREiUKCk1zZ1Jlc0luZm8YAiABKAsy",
            "ES5Qcm90b19Nc2dSZXNJbmZvEhAKCFRpbWVUaWNrGAMgASgSQheqAhRQcm90",
            "by5Qcm90b0ludGVyZmFjZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Proto.ProtoInterface.ProtoMsgResInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.ProtoInterface.Proto_UpdateUserInfoRes), global::Proto.ProtoInterface.Proto_UpdateUserInfoRes.Parser, new[]{ "Money", "MsgResInfo", "TimeTick" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Proto_UpdateUserInfoRes : pb::IMessage<Proto_UpdateUserInfoRes> {
    private static readonly pb::MessageParser<Proto_UpdateUserInfoRes> _parser = new pb::MessageParser<Proto_UpdateUserInfoRes>(() => new Proto_UpdateUserInfoRes());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Proto_UpdateUserInfoRes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.ProtoInterface.ProtoUpdateUserInfoResReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Proto_UpdateUserInfoRes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Proto_UpdateUserInfoRes(Proto_UpdateUserInfoRes other) : this() {
      money_ = other.money_;
      msgResInfo_ = other.msgResInfo_ != null ? other.msgResInfo_.Clone() : null;
      timeTick_ = other.timeTick_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Proto_UpdateUserInfoRes Clone() {
      return new Proto_UpdateUserInfoRes(this);
    }

    /// <summary>Field number for the "Money" field.</summary>
    public const int MoneyFieldNumber = 1;
    private int money_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Money {
      get { return money_; }
      set {
        money_ = value;
      }
    }

    /// <summary>Field number for the "MsgResInfo" field.</summary>
    public const int MsgResInfoFieldNumber = 2;
    private global::Proto.ProtoInterface.Proto_MsgResInfo msgResInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.ProtoInterface.Proto_MsgResInfo MsgResInfo {
      get { return msgResInfo_; }
      set {
        msgResInfo_ = value;
      }
    }

    /// <summary>Field number for the "TimeTick" field.</summary>
    public const int TimeTickFieldNumber = 3;
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
      return Equals(other as Proto_UpdateUserInfoRes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Proto_UpdateUserInfoRes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Money != other.Money) return false;
      if (!object.Equals(MsgResInfo, other.MsgResInfo)) return false;
      if (TimeTick != other.TimeTick) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Money != 0) hash ^= Money.GetHashCode();
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
      if (Money != 0) {
        output.WriteRawTag(8);
        output.WriteSInt32(Money);
      }
      if (msgResInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MsgResInfo);
      }
      if (TimeTick != 0L) {
        output.WriteRawTag(24);
        output.WriteSInt64(TimeTick);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Money != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(Money);
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
    public void MergeFrom(Proto_UpdateUserInfoRes other) {
      if (other == null) {
        return;
      }
      if (other.Money != 0) {
        Money = other.Money;
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
          case 8: {
            Money = input.ReadSInt32();
            break;
          }
          case 18: {
            if (msgResInfo_ == null) {
              MsgResInfo = new global::Proto.ProtoInterface.Proto_MsgResInfo();
            }
            input.ReadMessage(MsgResInfo);
            break;
          }
          case 24: {
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
