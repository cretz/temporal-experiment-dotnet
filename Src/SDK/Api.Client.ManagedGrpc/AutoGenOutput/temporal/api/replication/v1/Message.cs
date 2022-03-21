// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: temporal/api/replication/v1/message.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Temporal.Api.Replication.V1 {

  /// <summary>Holder for reflection information generated from temporal/api/replication/v1/message.proto</summary>
  public static partial class MessageReflection {

    #region Descriptor
    /// <summary>File descriptor for temporal/api/replication/v1/message.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cil0ZW1wb3JhbC9hcGkvcmVwbGljYXRpb24vdjEvbWVzc2FnZS5wcm90bxIb",
            "dGVtcG9yYWwuYXBpLnJlcGxpY2F0aW9uLnYxGiV0ZW1wb3JhbC9hcGkvZW51",
            "bXMvdjEvbmFtZXNwYWNlLnByb3RvIjAKGENsdXN0ZXJSZXBsaWNhdGlvbkNv",
            "bmZpZxIUCgxjbHVzdGVyX25hbWUYASABKAkiugEKGk5hbWVzcGFjZVJlcGxp",
            "Y2F0aW9uQ29uZmlnEhsKE2FjdGl2ZV9jbHVzdGVyX25hbWUYASABKAkSRwoI",
            "Y2x1c3RlcnMYAiADKAsyNS50ZW1wb3JhbC5hcGkucmVwbGljYXRpb24udjEu",
            "Q2x1c3RlclJlcGxpY2F0aW9uQ29uZmlnEjYKBXN0YXRlGAMgASgOMicudGVt",
            "cG9yYWwuYXBpLmVudW1zLnYxLlJlcGxpY2F0aW9uU3RhdGVCngEKHmlvLnRl",
            "bXBvcmFsLmFwaS5yZXBsaWNhdGlvbi52MUIMTWVzc2FnZVByb3RvUAFaLWdv",
            "LnRlbXBvcmFsLmlvL2FwaS9yZXBsaWNhdGlvbi92MTtyZXBsaWNhdGlvbqoC",
            "G1RlbXBvcmFsLkFwaS5SZXBsaWNhdGlvbi5WMeoCHlRlbXBvcmFsOjpBcGk6",
            "OlJlcGxpY2F0aW9uOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Temporal.Api.Enums.V1.NamespaceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Temporal.Api.Replication.V1.ClusterReplicationConfig), global::Temporal.Api.Replication.V1.ClusterReplicationConfig.Parser, new[]{ "ClusterName" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Temporal.Api.Replication.V1.NamespaceReplicationConfig), global::Temporal.Api.Replication.V1.NamespaceReplicationConfig.Parser, new[]{ "ActiveClusterName", "Clusters", "State" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClusterReplicationConfig : pb::IMessage<ClusterReplicationConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClusterReplicationConfig> _parser = new pb::MessageParser<ClusterReplicationConfig>(() => new ClusterReplicationConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClusterReplicationConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Temporal.Api.Replication.V1.MessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClusterReplicationConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClusterReplicationConfig(ClusterReplicationConfig other) : this() {
      clusterName_ = other.clusterName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClusterReplicationConfig Clone() {
      return new ClusterReplicationConfig(this);
    }

    /// <summary>Field number for the "cluster_name" field.</summary>
    public const int ClusterNameFieldNumber = 1;
    private string clusterName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClusterName {
      get { return clusterName_; }
      set {
        clusterName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ClusterReplicationConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClusterReplicationConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClusterName != other.ClusterName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ClusterName.Length != 0) hash ^= ClusterName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ClusterName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClusterName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ClusterName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClusterName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ClusterName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClusterName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ClusterReplicationConfig other) {
      if (other == null) {
        return;
      }
      if (other.ClusterName.Length != 0) {
        ClusterName = other.ClusterName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ClusterName = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ClusterName = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class NamespaceReplicationConfig : pb::IMessage<NamespaceReplicationConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NamespaceReplicationConfig> _parser = new pb::MessageParser<NamespaceReplicationConfig>(() => new NamespaceReplicationConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NamespaceReplicationConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Temporal.Api.Replication.V1.MessageReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NamespaceReplicationConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NamespaceReplicationConfig(NamespaceReplicationConfig other) : this() {
      activeClusterName_ = other.activeClusterName_;
      clusters_ = other.clusters_.Clone();
      state_ = other.state_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NamespaceReplicationConfig Clone() {
      return new NamespaceReplicationConfig(this);
    }

    /// <summary>Field number for the "active_cluster_name" field.</summary>
    public const int ActiveClusterNameFieldNumber = 1;
    private string activeClusterName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ActiveClusterName {
      get { return activeClusterName_; }
      set {
        activeClusterName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "clusters" field.</summary>
    public const int ClustersFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Temporal.Api.Replication.V1.ClusterReplicationConfig> _repeated_clusters_codec
        = pb::FieldCodec.ForMessage(18, global::Temporal.Api.Replication.V1.ClusterReplicationConfig.Parser);
    private readonly pbc::RepeatedField<global::Temporal.Api.Replication.V1.ClusterReplicationConfig> clusters_ = new pbc::RepeatedField<global::Temporal.Api.Replication.V1.ClusterReplicationConfig>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Temporal.Api.Replication.V1.ClusterReplicationConfig> Clusters {
      get { return clusters_; }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 3;
    private global::Temporal.Api.Enums.V1.ReplicationState state_ = global::Temporal.Api.Enums.V1.ReplicationState.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Temporal.Api.Enums.V1.ReplicationState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NamespaceReplicationConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NamespaceReplicationConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ActiveClusterName != other.ActiveClusterName) return false;
      if(!clusters_.Equals(other.clusters_)) return false;
      if (State != other.State) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ActiveClusterName.Length != 0) hash ^= ActiveClusterName.GetHashCode();
      hash ^= clusters_.GetHashCode();
      if (State != global::Temporal.Api.Enums.V1.ReplicationState.Unspecified) hash ^= State.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ActiveClusterName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ActiveClusterName);
      }
      clusters_.WriteTo(output, _repeated_clusters_codec);
      if (State != global::Temporal.Api.Enums.V1.ReplicationState.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) State);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ActiveClusterName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ActiveClusterName);
      }
      clusters_.WriteTo(ref output, _repeated_clusters_codec);
      if (State != global::Temporal.Api.Enums.V1.ReplicationState.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) State);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ActiveClusterName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ActiveClusterName);
      }
      size += clusters_.CalculateSize(_repeated_clusters_codec);
      if (State != global::Temporal.Api.Enums.V1.ReplicationState.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NamespaceReplicationConfig other) {
      if (other == null) {
        return;
      }
      if (other.ActiveClusterName.Length != 0) {
        ActiveClusterName = other.ActiveClusterName;
      }
      clusters_.Add(other.clusters_);
      if (other.State != global::Temporal.Api.Enums.V1.ReplicationState.Unspecified) {
        State = other.State;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ActiveClusterName = input.ReadString();
            break;
          }
          case 18: {
            clusters_.AddEntriesFrom(input, _repeated_clusters_codec);
            break;
          }
          case 24: {
            State = (global::Temporal.Api.Enums.V1.ReplicationState) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ActiveClusterName = input.ReadString();
            break;
          }
          case 18: {
            clusters_.AddEntriesFrom(ref input, _repeated_clusters_codec);
            break;
          }
          case 24: {
            State = (global::Temporal.Api.Enums.V1.ReplicationState) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code