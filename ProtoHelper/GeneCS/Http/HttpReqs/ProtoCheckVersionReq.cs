// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Http/HttpReqs/Proto_CheckVersionReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Proto.ProtoInterface {

  /// <summary>Holder for reflection information generated from Http/HttpReqs/Proto_CheckVersionReq.proto</summary>
  public static partial class ProtoCheckVersionReqReflection {

    #region Descriptor
    /// <summary>File descriptor for Http/HttpReqs/Proto_CheckVersionReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtoCheckVersionReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilIdHRwL0h0dHBSZXFzL1Byb3RvX0NoZWNrVmVyc2lvblJlcS5wcm90bxoW",
            "UHJvdG9fTXNnUmVxSW5mby5wcm90byJ3ChVQcm90b19DaGVja1ZlcnNpb25S",
            "ZXESEQoJQ1NWZXJzaW9uGAEgASgJEhIKCkx1YVZlcnNpb24YAiABKAkSJQoK",
            "TXNnUmVxSW5mbxgDIAEoCzIRLlByb3RvX01zZ1JlcUluZm8SEAoIVGltZVRp",
            "Y2sYBCABKBJCF6oCFFByb3RvLlByb3RvSW50ZXJmYWNlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Proto.ProtoInterface.ProtoMsgReqInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.ProtoInterface.Proto_CheckVersionReq), global::Proto.ProtoInterface.Proto_CheckVersionReq.Parser, new[]{ "CSVersion", "LuaVersion", "MsgReqInfo", "TimeTick" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Proto_CheckVersionReq : pb::IMessage<Proto_CheckVersionReq> {
    private static readonly pb::MessageParser<Proto_CheckVersionReq> _parser = new pb::MessageParser<Proto_CheckVersionReq>(() => new Proto_CheckVersionReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Proto_CheckVersionReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.ProtoInterface.ProtoCheckVersionReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Proto_CheckVersionReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Proto_CheckVersionReq(Proto_CheckVersionReq other) : this() {
      cSVersion_ = other.cSVersion_;
      luaVersion_ = other.luaVersion_;
      msgReqInfo_ = other.msgReqInfo_ != null ? other.msgReqInfo_.Clone() : null;
      timeTick_ = other.timeTick_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Proto_CheckVersionReq Clone() {
      return new Proto_CheckVersionReq(this);
    }

    /// <summary>Field number for the "CSVersion" field.</summary>
    public const int CSVersionFieldNumber = 1;
    private string cSVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CSVersion {
      get { return cSVersion_; }
      set {
        cSVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LuaVersion" field.</summary>
    public const int LuaVersionFieldNumber = 2;
    private string luaVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LuaVersion {
      get { return luaVersion_; }
      set {
        luaVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "MsgReqInfo" field.</summary>
    public const int MsgReqInfoFieldNumber = 3;
    private global::Proto.ProtoInterface.Proto_MsgReqInfo msgReqInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.ProtoInterface.Proto_MsgReqInfo MsgReqInfo {
      get { return msgReqInfo_; }
      set {
        msgReqInfo_ = value;
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
      return Equals(other as Proto_CheckVersionReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Proto_CheckVersionReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CSVersion != other.CSVersion) return false;
      if (LuaVersion != other.LuaVersion) return false;
      if (!object.Equals(MsgReqInfo, other.MsgReqInfo)) return false;
      if (TimeTick != other.TimeTick) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CSVersion.Length != 0) hash ^= CSVersion.GetHashCode();
      if (LuaVersion.Length != 0) hash ^= LuaVersion.GetHashCode();
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
      if (CSVersion.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CSVersion);
      }
      if (LuaVersion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LuaVersion);
      }
      if (msgReqInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MsgReqInfo);
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
      if (CSVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CSVersion);
      }
      if (LuaVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LuaVersion);
      }
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
    public void MergeFrom(Proto_CheckVersionReq other) {
      if (other == null) {
        return;
      }
      if (other.CSVersion.Length != 0) {
        CSVersion = other.CSVersion;
      }
      if (other.LuaVersion.Length != 0) {
        LuaVersion = other.LuaVersion;
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
            CSVersion = input.ReadString();
            break;
          }
          case 18: {
            LuaVersion = input.ReadString();
            break;
          }
          case 26: {
            if (msgReqInfo_ == null) {
              MsgReqInfo = new global::Proto.ProtoInterface.Proto_MsgReqInfo();
            }
            input.ReadMessage(MsgReqInfo);
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
