// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ScheduledTaskWrapper.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NServiceBus.ProtoBufGoogle {

  /// <summary>Holder for reflection information generated from ScheduledTaskWrapper.proto</summary>
  public static partial class ScheduledTaskWrapperReflection {

    #region Descriptor
    /// <summary>File descriptor for ScheduledTaskWrapper.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScheduledTaskWrapperReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpTY2hlZHVsZWRUYXNrV3JhcHBlci5wcm90bxIaTlNlcnZpY2VCdXMuUHJv",
            "dG9CdWZHb29nbGUiQwoUU2NoZWR1bGVkVGFza1dyYXBwZXISDgoGVGFza0lk",
            "GAEgASgJEgwKBE5hbWUYAiABKAkSDQoFRXZlcnkYAyABKAlCHaoCGk5TZXJ2",
            "aWNlQnVzLlByb3RvQnVmR29vZ2xlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NServiceBus.ProtoBufGoogle.ScheduledTaskWrapper), global::NServiceBus.ProtoBufGoogle.ScheduledTaskWrapper.Parser, new[]{ "TaskId", "Name", "Every" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ScheduledTaskWrapper : pb::IMessage<ScheduledTaskWrapper> {
    private static readonly pb::MessageParser<ScheduledTaskWrapper> _parser = new pb::MessageParser<ScheduledTaskWrapper>(() => new ScheduledTaskWrapper());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ScheduledTaskWrapper> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NServiceBus.ProtoBufGoogle.ScheduledTaskWrapperReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ScheduledTaskWrapper() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ScheduledTaskWrapper(ScheduledTaskWrapper other) : this() {
      taskId_ = other.taskId_;
      name_ = other.name_;
      every_ = other.every_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ScheduledTaskWrapper Clone() {
      return new ScheduledTaskWrapper(this);
    }

    /// <summary>Field number for the "TaskId" field.</summary>
    public const int TaskIdFieldNumber = 1;
    private string taskId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TaskId {
      get { return taskId_; }
      set {
        taskId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Every" field.</summary>
    public const int EveryFieldNumber = 3;
    private string every_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Every {
      get { return every_; }
      set {
        every_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ScheduledTaskWrapper);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ScheduledTaskWrapper other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TaskId != other.TaskId) return false;
      if (Name != other.Name) return false;
      if (Every != other.Every) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TaskId.Length != 0) hash ^= TaskId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Every.Length != 0) hash ^= Every.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (TaskId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TaskId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Every.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Every);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TaskId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TaskId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Every.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Every);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ScheduledTaskWrapper other) {
      if (other == null) {
        return;
      }
      if (other.TaskId.Length != 0) {
        TaskId = other.TaskId;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Every.Length != 0) {
        Every = other.Every;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            TaskId = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Every = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
