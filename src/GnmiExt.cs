// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: github.com/openconfig/gnmi/proto/gnmi_ext/gnmi_ext.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GnmiExt {

  /// <summary>Holder for reflection information generated from github.com/openconfig/gnmi/proto/gnmi_ext/gnmi_ext.proto</summary>
  public static partial class GnmiExtReflection {

    #region Descriptor
    /// <summary>File descriptor for github.com/openconfig/gnmi/proto/gnmi_ext/gnmi_ext.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GnmiExtReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjhnaXRodWIuY29tL29wZW5jb25maWcvZ25taS9wcm90by9nbm1pX2V4dC9n",
            "bm1pX2V4dC5wcm90bxIIZ25taV9leHQihgEKCUV4dGVuc2lvbhI3Cg5yZWdp",
            "c3RlcmVkX2V4dBgBIAEoCzIdLmdubWlfZXh0LlJlZ2lzdGVyZWRFeHRlbnNp",
            "b25IABI5ChJtYXN0ZXJfYXJiaXRyYXRpb24YAiABKAsyGy5nbm1pX2V4dC5N",
            "YXN0ZXJBcmJpdHJhdGlvbkgAQgUKA2V4dCJFChNSZWdpc3RlcmVkRXh0ZW5z",
            "aW9uEiEKAmlkGAEgASgOMhUuZ25taV9leHQuRXh0ZW5zaW9uSUQSCwoDbXNn",
            "GAIgASgMIlkKEU1hc3RlckFyYml0cmF0aW9uEhwKBHJvbGUYASABKAsyDi5n",
            "bm1pX2V4dC5Sb2xlEiYKC2VsZWN0aW9uX2lkGAIgASgLMhEuZ25taV9leHQu",
            "VWludDEyOCIkCgdVaW50MTI4EgwKBGhpZ2gYASABKAQSCwoDbG93GAIgASgE",
            "IhIKBFJvbGUSCgoCaWQYASABKAkqMwoLRXh0ZW5zaW9uSUQSDQoJRUlEX1VO",
            "U0VUEAASFQoQRUlEX0VYUEVSSU1FTlRBTBDnB2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::GnmiExt.ExtensionID), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GnmiExt.Extension), global::GnmiExt.Extension.Parser, new[]{ "RegisteredExt", "MasterArbitration" }, new[]{ "Ext" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GnmiExt.RegisteredExtension), global::GnmiExt.RegisteredExtension.Parser, new[]{ "Id", "Msg" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GnmiExt.MasterArbitration), global::GnmiExt.MasterArbitration.Parser, new[]{ "Role", "ElectionId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GnmiExt.Uint128), global::GnmiExt.Uint128.Parser, new[]{ "High", "Low" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GnmiExt.Role), global::GnmiExt.Role.Parser, new[]{ "Id" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// RegisteredExtension is an enumeration acting as a registry for extensions
  /// defined by external sources.
  /// </summary>
  public enum ExtensionID {
    /// <summary>
    /// New extensions are to be defined within this enumeration - their definition
    /// MUST link to a reference describing their implementation.
    /// </summary>
    [pbr::OriginalName("EID_UNSET")] EidUnset = 0,
    /// <summary>
    /// An experimental extension that may be used during prototyping of a new
    /// extension.
    /// </summary>
    [pbr::OriginalName("EID_EXPERIMENTAL")] EidExperimental = 999,
  }

  #endregion

  #region Messages
  /// <summary>
  /// The Extension message contains a single gNMI extension.
  /// </summary>
  public sealed partial class Extension : pb::IMessage<Extension> {
    private static readonly pb::MessageParser<Extension> _parser = new pb::MessageParser<Extension>(() => new Extension());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Extension> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GnmiExt.GnmiExtReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Extension() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Extension(Extension other) : this() {
      switch (other.ExtCase) {
        case ExtOneofCase.RegisteredExt:
          RegisteredExt = other.RegisteredExt.Clone();
          break;
        case ExtOneofCase.MasterArbitration:
          MasterArbitration = other.MasterArbitration.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Extension Clone() {
      return new Extension(this);
    }

    /// <summary>Field number for the "registered_ext" field.</summary>
    public const int RegisteredExtFieldNumber = 1;
    /// <summary>
    /// A registered extension.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GnmiExt.RegisteredExtension RegisteredExt {
      get { return extCase_ == ExtOneofCase.RegisteredExt ? (global::GnmiExt.RegisteredExtension) ext_ : null; }
      set {
        ext_ = value;
        extCase_ = value == null ? ExtOneofCase.None : ExtOneofCase.RegisteredExt;
      }
    }

    /// <summary>Field number for the "master_arbitration" field.</summary>
    public const int MasterArbitrationFieldNumber = 2;
    /// <summary>
    /// Well known extensions.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GnmiExt.MasterArbitration MasterArbitration {
      get { return extCase_ == ExtOneofCase.MasterArbitration ? (global::GnmiExt.MasterArbitration) ext_ : null; }
      set {
        ext_ = value;
        extCase_ = value == null ? ExtOneofCase.None : ExtOneofCase.MasterArbitration;
      }
    }

    private object ext_;
    /// <summary>Enum of possible cases for the "ext" oneof.</summary>
    public enum ExtOneofCase {
      None = 0,
      RegisteredExt = 1,
      MasterArbitration = 2,
    }
    private ExtOneofCase extCase_ = ExtOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExtOneofCase ExtCase {
      get { return extCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearExt() {
      extCase_ = ExtOneofCase.None;
      ext_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Extension);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Extension other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RegisteredExt, other.RegisteredExt)) return false;
      if (!object.Equals(MasterArbitration, other.MasterArbitration)) return false;
      if (ExtCase != other.ExtCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (extCase_ == ExtOneofCase.RegisteredExt) hash ^= RegisteredExt.GetHashCode();
      if (extCase_ == ExtOneofCase.MasterArbitration) hash ^= MasterArbitration.GetHashCode();
      hash ^= (int) extCase_;
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
      if (extCase_ == ExtOneofCase.RegisteredExt) {
        output.WriteRawTag(10);
        output.WriteMessage(RegisteredExt);
      }
      if (extCase_ == ExtOneofCase.MasterArbitration) {
        output.WriteRawTag(18);
        output.WriteMessage(MasterArbitration);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (extCase_ == ExtOneofCase.RegisteredExt) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RegisteredExt);
      }
      if (extCase_ == ExtOneofCase.MasterArbitration) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MasterArbitration);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Extension other) {
      if (other == null) {
        return;
      }
      switch (other.ExtCase) {
        case ExtOneofCase.RegisteredExt:
          if (RegisteredExt == null) {
            RegisteredExt = new global::GnmiExt.RegisteredExtension();
          }
          RegisteredExt.MergeFrom(other.RegisteredExt);
          break;
        case ExtOneofCase.MasterArbitration:
          if (MasterArbitration == null) {
            MasterArbitration = new global::GnmiExt.MasterArbitration();
          }
          MasterArbitration.MergeFrom(other.MasterArbitration);
          break;
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
            global::GnmiExt.RegisteredExtension subBuilder = new global::GnmiExt.RegisteredExtension();
            if (extCase_ == ExtOneofCase.RegisteredExt) {
              subBuilder.MergeFrom(RegisteredExt);
            }
            input.ReadMessage(subBuilder);
            RegisteredExt = subBuilder;
            break;
          }
          case 18: {
            global::GnmiExt.MasterArbitration subBuilder = new global::GnmiExt.MasterArbitration();
            if (extCase_ == ExtOneofCase.MasterArbitration) {
              subBuilder.MergeFrom(MasterArbitration);
            }
            input.ReadMessage(subBuilder);
            MasterArbitration = subBuilder;
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The RegisteredExtension message defines an extension which is defined outside
  /// of this file.
  /// </summary>
  public sealed partial class RegisteredExtension : pb::IMessage<RegisteredExtension> {
    private static readonly pb::MessageParser<RegisteredExtension> _parser = new pb::MessageParser<RegisteredExtension>(() => new RegisteredExtension());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RegisteredExtension> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GnmiExt.GnmiExtReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisteredExtension() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisteredExtension(RegisteredExtension other) : this() {
      id_ = other.id_;
      msg_ = other.msg_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisteredExtension Clone() {
      return new RegisteredExtension(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private global::GnmiExt.ExtensionID id_ = 0;
    /// <summary>
    /// The unique ID assigned to this extension.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GnmiExt.ExtensionID Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "msg" field.</summary>
    public const int MsgFieldNumber = 2;
    private pb::ByteString msg_ = pb::ByteString.Empty;
    /// <summary>
    /// The binary-marshalled protobuf extension payload.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Msg {
      get { return msg_; }
      set {
        msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RegisteredExtension);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RegisteredExtension other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Msg != other.Msg) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Msg.Length != 0) hash ^= Msg.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Id);
      }
      if (Msg.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Msg);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Id);
      }
      if (Msg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Msg);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RegisteredExtension other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Msg.Length != 0) {
        Msg = other.Msg;
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
            id_ = (global::GnmiExt.ExtensionID) input.ReadEnum();
            break;
          }
          case 18: {
            Msg = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// MasterArbitration is used to select the master among multiple gNMI clients
  /// with the same Roles. The client with the largest election_id is honored as
  /// the master.
  /// The document about gNMI master arbitration can be found at
  /// https://github.com/openconfig/reference/blob/master/rpc/gnmi/gnmi-master-arbitration.md
  /// </summary>
  public sealed partial class MasterArbitration : pb::IMessage<MasterArbitration> {
    private static readonly pb::MessageParser<MasterArbitration> _parser = new pb::MessageParser<MasterArbitration>(() => new MasterArbitration());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MasterArbitration> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GnmiExt.GnmiExtReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterArbitration() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterArbitration(MasterArbitration other) : this() {
      role_ = other.role_ != null ? other.role_.Clone() : null;
      electionId_ = other.electionId_ != null ? other.electionId_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterArbitration Clone() {
      return new MasterArbitration(this);
    }

    /// <summary>Field number for the "role" field.</summary>
    public const int RoleFieldNumber = 1;
    private global::GnmiExt.Role role_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GnmiExt.Role Role {
      get { return role_; }
      set {
        role_ = value;
      }
    }

    /// <summary>Field number for the "election_id" field.</summary>
    public const int ElectionIdFieldNumber = 2;
    private global::GnmiExt.Uint128 electionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GnmiExt.Uint128 ElectionId {
      get { return electionId_; }
      set {
        electionId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MasterArbitration);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MasterArbitration other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Role, other.Role)) return false;
      if (!object.Equals(ElectionId, other.ElectionId)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (role_ != null) hash ^= Role.GetHashCode();
      if (electionId_ != null) hash ^= ElectionId.GetHashCode();
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
      if (role_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Role);
      }
      if (electionId_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ElectionId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (role_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Role);
      }
      if (electionId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ElectionId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MasterArbitration other) {
      if (other == null) {
        return;
      }
      if (other.role_ != null) {
        if (role_ == null) {
          role_ = new global::GnmiExt.Role();
        }
        Role.MergeFrom(other.Role);
      }
      if (other.electionId_ != null) {
        if (electionId_ == null) {
          electionId_ = new global::GnmiExt.Uint128();
        }
        ElectionId.MergeFrom(other.ElectionId);
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
            if (role_ == null) {
              role_ = new global::GnmiExt.Role();
            }
            input.ReadMessage(role_);
            break;
          }
          case 18: {
            if (electionId_ == null) {
              electionId_ = new global::GnmiExt.Uint128();
            }
            input.ReadMessage(electionId_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Representation of unsigned 128-bit integer.
  /// </summary>
  public sealed partial class Uint128 : pb::IMessage<Uint128> {
    private static readonly pb::MessageParser<Uint128> _parser = new pb::MessageParser<Uint128>(() => new Uint128());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Uint128> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GnmiExt.GnmiExtReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Uint128() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Uint128(Uint128 other) : this() {
      high_ = other.high_;
      low_ = other.low_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Uint128 Clone() {
      return new Uint128(this);
    }

    /// <summary>Field number for the "high" field.</summary>
    public const int HighFieldNumber = 1;
    private ulong high_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong High {
      get { return high_; }
      set {
        high_ = value;
      }
    }

    /// <summary>Field number for the "low" field.</summary>
    public const int LowFieldNumber = 2;
    private ulong low_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Low {
      get { return low_; }
      set {
        low_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Uint128);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Uint128 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (High != other.High) return false;
      if (Low != other.Low) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (High != 0UL) hash ^= High.GetHashCode();
      if (Low != 0UL) hash ^= Low.GetHashCode();
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
      if (High != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(High);
      }
      if (Low != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Low);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (High != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(High);
      }
      if (Low != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Low);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Uint128 other) {
      if (other == null) {
        return;
      }
      if (other.High != 0UL) {
        High = other.High;
      }
      if (other.Low != 0UL) {
        Low = other.Low;
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
            High = input.ReadUInt64();
            break;
          }
          case 16: {
            Low = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// There can be one master for each role. The role is identified by its id.
  /// </summary>
  public sealed partial class Role : pb::IMessage<Role> {
    private static readonly pb::MessageParser<Role> _parser = new pb::MessageParser<Role>(() => new Role());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Role> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GnmiExt.GnmiExtReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Role() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Role(Role other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Role Clone() {
      return new Role(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// More fields can be added if needed, for example, to specify what paths the
    /// role can read/write.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Role);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Role other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Role other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
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
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
