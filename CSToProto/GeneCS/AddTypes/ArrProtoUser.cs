// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AddTypes/_Arr_Proto_User.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Proto.ProtoInterface {

  /// <summary>Holder for reflection information generated from AddTypes/_Arr_Proto_User.proto</summary>
  public static partial class ArrProtoUserReflection {

    #region Descriptor
    /// <summary>File descriptor for AddTypes/_Arr_Proto_User.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ArrProtoUserReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5BZGRUeXBlcy9fQXJyX1Byb3RvX1VzZXIucHJvdG8aGUVudGl0aWVzL1By",
            "b3RvX1VzZXIucHJvdG8iMgoPX0Fycl9Qcm90b19Vc2VyEh8KClByb3RvX1Vz",
            "ZXIYASADKAsyCy5Qcm90b19Vc2VyQheqAhRQcm90by5Qcm90b0ludGVyZmFj",
            "ZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Proto.ProtoInterface.ProtoUserReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.ProtoInterface._Arr_Proto_User), global::Proto.ProtoInterface._Arr_Proto_User.Parser, new[]{ "ProtoUser" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class _Arr_Proto_User : pb::IMessage<_Arr_Proto_User> {
    private static readonly pb::MessageParser<_Arr_Proto_User> _parser = new pb::MessageParser<_Arr_Proto_User>(() => new _Arr_Proto_User());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<_Arr_Proto_User> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.ProtoInterface.ArrProtoUserReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public _Arr_Proto_User() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public _Arr_Proto_User(_Arr_Proto_User other) : this() {
      protoUser_ = other.protoUser_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public _Arr_Proto_User Clone() {
      return new _Arr_Proto_User(this);
    }

    /// <summary>Field number for the "Proto_User" field.</summary>
    public const int ProtoUserFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Proto.ProtoInterface.Proto_User> _repeated_protoUser_codec
        = pb::FieldCodec.ForMessage(10, global::Proto.ProtoInterface.Proto_User.Parser);
    private readonly pbc::RepeatedField<global::Proto.ProtoInterface.Proto_User> protoUser_ = new pbc::RepeatedField<global::Proto.ProtoInterface.Proto_User>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Proto.ProtoInterface.Proto_User> ProtoUser {
      get { return protoUser_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as _Arr_Proto_User);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(_Arr_Proto_User other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!protoUser_.Equals(other.protoUser_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= protoUser_.GetHashCode();
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
      protoUser_.WriteTo(output, _repeated_protoUser_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += protoUser_.CalculateSize(_repeated_protoUser_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(_Arr_Proto_User other) {
      if (other == null) {
        return;
      }
      protoUser_.Add(other.protoUser_);
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
            protoUser_.AddEntriesFrom(input, _repeated_protoUser_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code