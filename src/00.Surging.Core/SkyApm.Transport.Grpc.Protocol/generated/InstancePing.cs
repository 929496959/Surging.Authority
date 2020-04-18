// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: register/InstancePing.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SkyWalking.NetworkProtocol {

  /// <summary>Holder for reflection information generated from register/InstancePing.proto</summary>
  public static partial class InstancePingReflection {

    #region Descriptor
    /// <summary>File descriptor for register/InstancePing.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InstancePingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtyZWdpc3Rlci9JbnN0YW5jZVBpbmcucHJvdG8aE2NvbW1vbi9jb21tb24u",
            "cHJvdG8iXgoWU2VydmljZUluc3RhbmNlUGluZ1BrZxIZChFzZXJ2aWNlSW5z",
            "dGFuY2VJZBgBIAEoBRIMCgR0aW1lGAIgASgDEhsKE3NlcnZpY2VJbnN0YW5j",
            "ZVVVSUQYAyABKAkyRQoTU2VydmljZUluc3RhbmNlUGluZxIuCgZkb1BpbmcS",
            "Fy5TZXJ2aWNlSW5zdGFuY2VQaW5nUGtnGgkuQ29tbWFuZHMiAEJOCi1vcmcu",
            "YXBhY2hlLnNreXdhbGtpbmcuYXBtLm5ldHdvcmsucmVnaXN0ZXIudjJQAaoC",
            "GlNreVdhbGtpbmcuTmV0d29ya1Byb3RvY29sYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::SkyWalking.NetworkProtocol.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SkyWalking.NetworkProtocol.ServiceInstancePingPkg), global::SkyWalking.NetworkProtocol.ServiceInstancePingPkg.Parser, new[]{ "ServiceInstanceId", "Time", "ServiceInstanceUUID" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ServiceInstancePingPkg : pb::IMessage<ServiceInstancePingPkg> {
    private static readonly pb::MessageParser<ServiceInstancePingPkg> _parser = new pb::MessageParser<ServiceInstancePingPkg>(() => new ServiceInstancePingPkg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServiceInstancePingPkg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SkyWalking.NetworkProtocol.InstancePingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServiceInstancePingPkg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServiceInstancePingPkg(ServiceInstancePingPkg other) : this() {
      serviceInstanceId_ = other.serviceInstanceId_;
      time_ = other.time_;
      serviceInstanceUUID_ = other.serviceInstanceUUID_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServiceInstancePingPkg Clone() {
      return new ServiceInstancePingPkg(this);
    }

    /// <summary>Field number for the "serviceInstanceId" field.</summary>
    public const int ServiceInstanceIdFieldNumber = 1;
    private int serviceInstanceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ServiceInstanceId {
      get { return serviceInstanceId_; }
      set {
        serviceInstanceId_ = value;
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 2;
    private long time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "serviceInstanceUUID" field.</summary>
    public const int ServiceInstanceUUIDFieldNumber = 3;
    private string serviceInstanceUUID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ServiceInstanceUUID {
      get { return serviceInstanceUUID_; }
      set {
        serviceInstanceUUID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServiceInstancePingPkg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServiceInstancePingPkg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServiceInstanceId != other.ServiceInstanceId) return false;
      if (Time != other.Time) return false;
      if (ServiceInstanceUUID != other.ServiceInstanceUUID) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ServiceInstanceId != 0) hash ^= ServiceInstanceId.GetHashCode();
      if (Time != 0L) hash ^= Time.GetHashCode();
      if (ServiceInstanceUUID.Length != 0) hash ^= ServiceInstanceUUID.GetHashCode();
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
      if (ServiceInstanceId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ServiceInstanceId);
      }
      if (Time != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Time);
      }
      if (ServiceInstanceUUID.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ServiceInstanceUUID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ServiceInstanceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ServiceInstanceId);
      }
      if (Time != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time);
      }
      if (ServiceInstanceUUID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServiceInstanceUUID);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServiceInstancePingPkg other) {
      if (other == null) {
        return;
      }
      if (other.ServiceInstanceId != 0) {
        ServiceInstanceId = other.ServiceInstanceId;
      }
      if (other.Time != 0L) {
        Time = other.Time;
      }
      if (other.ServiceInstanceUUID.Length != 0) {
        ServiceInstanceUUID = other.ServiceInstanceUUID;
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
            ServiceInstanceId = input.ReadInt32();
            break;
          }
          case 16: {
            Time = input.ReadInt64();
            break;
          }
          case 26: {
            ServiceInstanceUUID = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
