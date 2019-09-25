// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: MessageToSend.proto
#pragma warning disable 1591, 0612, 3021, CS8604, CS8610
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tests {

  /// <summary>Holder for reflection information generated from MessageToSend.proto</summary>
  public static partial class MessageToSendReflection {

    #region Descriptor
    /// <summary>File descriptor for MessageToSend.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageToSendReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNNZXNzYWdlVG9TZW5kLnByb3RvEhNQcm90b0J1Zkdvb2dsZVRlc3RzIiEK",
            "DU1lc3NhZ2VUb1NlbmQSEAoIUHJvcGVydHkYASABKAlCCKoCBVRlc3RzYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tests.MessageToSend), global::Tests.MessageToSend.Parser, new[]{ "Property" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MessageToSend : pb::IMessage<MessageToSend> {
    private static readonly pb::MessageParser<MessageToSend> _parser = new pb::MessageParser<MessageToSend>(() => new MessageToSend());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MessageToSend> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tests.MessageToSendReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageToSend() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageToSend(MessageToSend other) : this() {
      property_ = other.property_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageToSend Clone() {
      return new MessageToSend(this);
    }

    /// <summary>Field number for the "Property" field.</summary>
    public const int PropertyFieldNumber = 1;
    private string property_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Property {
      get { return property_; }
      set {
        property_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MessageToSend);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MessageToSend other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Property != other.Property) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Property.Length != 0) hash ^= Property.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Property.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Property);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Property.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Property);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MessageToSend other) {
      if (other == null) {
        return;
      }
      if (other.Property.Length != 0) {
        Property = other.Property;
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
            Property = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
