// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Tcp/TcpReqs/Users/Proto_UpdateUserInfoReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Proto.ProtoInterface {

  /// <summary>Holder for reflection information generated from Tcp/TcpReqs/Users/Proto_UpdateUserInfoReq.proto</summary>
  public static partial class ProtoUpdateUserInfoReqReflection {

    #region Descriptor
    /// <summary>File descriptor for Tcp/TcpReqs/Users/Proto_UpdateUserInfoReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtoUpdateUserInfoReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9UY3AvVGNwUmVxcy9Vc2Vycy9Qcm90b19VcGRhdGVVc2VySW5mb1JlcS5w",
            "cm90bxoWUHJvdG9fTXNnUmVxSW5mby5wcm90byJSChdQcm90b19VcGRhdGVV",
            "c2VySW5mb1JlcRIlCgpNc2dSZXFJbmZvGAEgASgLMhEuUHJvdG9fTXNnUmVx",
            "SW5mbxIQCghUaW1lVGljaxgCIAEoEkIXqgIUUHJvdG8uUHJvdG9JbnRlcmZh",
            "Y2ViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Proto.ProtoInterface.ProtoMsgReqInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.ProtoInterface.Proto_UpdateUserInfoReq), global::Proto.ProtoInterface.Proto_UpdateUserInfoReq.Parser, new[]{ "MsgReqInfo", "TimeTick" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Proto_UpdateUserInfoReq : pb::IMessage<Proto_UpdateUserInfoReq> {
    private static readonly pb::MessageParser<Proto_UpdateUserInfoReq> _parser = new pb::MessageParser<Proto_UpdateUserInfoReq>(() => new Proto_UpdateUserInfoReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Proto_UpdateUserInfoReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.ProtoInterface.ProtoUpdateUserInfoReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Proto_UpdateUserInfoReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Proto_UpdateUserInfoReq(Proto_UpdateUserInfoReq other) : this() {
      msgReqInfo_ = other.msgReqInfo_ != null ? other.msgReqInfo_.Clone() : null;
      timeTick_ = other.timeTick_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Proto_UpdateUserInfoReq Clone() {
      return new Proto_UpdateUserInfoReq(this);
    }

    /// <summary>Field number for the "MsgReqInfo" field.</summary>
    public const int MsgReqInfoFieldNumber = 1;
    private global::Proto.ProtoInterface.Proto_MsgReqInfo msgReqInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.ProtoInterface.Proto_MsgReqInfo MsgReqInfo {
      get { return msgReqInfo_; }
      set {
        msgReqInfo_ = value;
      }
    }

    /// <summary>Field number for the "TimeTick" field.</summary>
    public const int TimeTickFieldNumber = 2;
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
      return Equals(other as Proto_UpdateUserInfoReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Proto_UpdateUserInfoReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(MsgReqInfo, other.MsgReqInfo)) return false;
      if (TimeTick != other.TimeTick) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (msgReqInfo_ != null) hash ^= MsgReqInfo.GetHashCode();
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
      if (msgReqInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MsgReqInfo);
      }
      if (TimeTick != 0L) {
        output.WriteRawTag(16);
        output.WriteSInt64(TimeTick);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (msgReqInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MsgReqInfo);
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
    public void MergeFrom(Proto_UpdateUserInfoReq other) {
      if (other == null) {
        return;
      }
      if (other.msgReqInfo_ != null) {
        if (msgReqInfo_ == null) {
          MsgReqInfo = new global::Proto.ProtoInterface.Proto_MsgReqInfo();
        }
        MsgReqInfo.MergeFrom(other.MsgReqInfo);
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
            if (msgReqInfo_ == null) {
              MsgReqInfo = new global::Proto.ProtoInterface.Proto_MsgReqInfo();
            }
            input.ReadMessage(MsgReqInfo);
            break;
          }
          case 16: {
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
