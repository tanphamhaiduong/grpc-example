// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: messages.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace VacationTrackerAdmin.ProtocolBuffers {

  /// <summary>Holder for reflection information generated from messages.proto</summary>
  public static partial class MessagesReflection {

    #region Descriptor
    /// <summary>File descriptor for messages.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessagesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5tZXNzYWdlcy5wcm90byKkAQoIRW1wbG95ZWUSCgoCaWQYASABKAUSEwoL",
            "YmFkZ2VOdW1iZXIYAiABKAUSEQoJZmlyc3ROYW1lGAMgASgJEhAKCGxhc3RO",
            "YW1lGAQgASgJEhsKE3ZhY2F0aW9uQWNjcnVhbFJhdGUYBSABKAISFwoPdmFj",
            "YXRpb25BY2NydWVkGAYgASgCEhwKCXZhY2F0aW9ucxgHIAMoCzIJLlZhY2F0",
            "aW9uIlAKCFZhY2F0aW9uEgoKAmlkGAEgASgFEhEKCXN0YXJ0RGF0ZRgCIAEo",
            "AxIQCghkdXJhdGlvbhgDIAEoAhITCgtpc0NhbmNlbGxlZBgEIAEoCCIPCg1H",
            "ZXRBbGxSZXF1ZXN0Ii4KF0dldEJ5QmFkZ2VOdW1iZXJSZXF1ZXN0EhMKC2Jh",
            "ZGdlTnVtYmVyGAEgASgFIi4KD0VtcGxveWVlUmVxdWVzdBIbCghlbXBsb3ll",
            "ZRgBIAEoCzIJLkVtcGxveWVlIi8KEEVtcGxveWVlUmVzcG9uc2USGwoIZW1w",
            "bG95ZWUYASABKAsyCS5FbXBsb3llZTLiAQoPRW1wbG95ZWVTZXJ2aWNlEi0K",
            "BkdldEFsbBIOLkdldEFsbFJlcXVlc3QaES5FbXBsb3llZVJlc3BvbnNlMAES",
            "PwoQR2V0QnlCYWRnZU51bWJlchIYLkdldEJ5QmFkZ2VOdW1iZXJSZXF1ZXN0",
            "GhEuRW1wbG95ZWVSZXNwb25zZRIrCgRTYXZlEhAuRW1wbG95ZWVSZXF1ZXN0",
            "GhEuRW1wbG95ZWVSZXNwb25zZRIyCgdTYXZlQWxsEhAuRW1wbG95ZWVSZXF1",
            "ZXN0GhEuRW1wbG95ZWVSZXNwb25zZSgBMAFCOVoQcHMvdmFjdHJhY2tlci9w",
            "YqoCJFZhY2F0aW9uVHJhY2tlckFkbWluLlByb3RvY29sQnVmZmVyc2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::VacationTrackerAdmin.ProtocolBuffers.Employee), global::VacationTrackerAdmin.ProtocolBuffers.Employee.Parser, new[]{ "Id", "BadgeNumber", "FirstName", "LastName", "VacationAccrualRate", "VacationAccrued", "Vacations" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::VacationTrackerAdmin.ProtocolBuffers.Vacation), global::VacationTrackerAdmin.ProtocolBuffers.Vacation.Parser, new[]{ "Id", "StartDate", "Duration", "IsCancelled" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::VacationTrackerAdmin.ProtocolBuffers.GetAllRequest), global::VacationTrackerAdmin.ProtocolBuffers.GetAllRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::VacationTrackerAdmin.ProtocolBuffers.GetByBadgeNumberRequest), global::VacationTrackerAdmin.ProtocolBuffers.GetByBadgeNumberRequest.Parser, new[]{ "BadgeNumber" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::VacationTrackerAdmin.ProtocolBuffers.EmployeeRequest), global::VacationTrackerAdmin.ProtocolBuffers.EmployeeRequest.Parser, new[]{ "Employee" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::VacationTrackerAdmin.ProtocolBuffers.EmployeeResponse), global::VacationTrackerAdmin.ProtocolBuffers.EmployeeResponse.Parser, new[]{ "Employee" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Employee : pb::IMessage<Employee> {
    private static readonly pb::MessageParser<Employee> _parser = new pb::MessageParser<Employee>(() => new Employee());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Employee> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::VacationTrackerAdmin.ProtocolBuffers.MessagesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employee() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employee(Employee other) : this() {
      id_ = other.id_;
      badgeNumber_ = other.badgeNumber_;
      firstName_ = other.firstName_;
      lastName_ = other.lastName_;
      vacationAccrualRate_ = other.vacationAccrualRate_;
      vacationAccrued_ = other.vacationAccrued_;
      vacations_ = other.vacations_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employee Clone() {
      return new Employee(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "badgeNumber" field.</summary>
    public const int BadgeNumberFieldNumber = 2;
    private int badgeNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BadgeNumber {
      get { return badgeNumber_; }
      set {
        badgeNumber_ = value;
      }
    }

    /// <summary>Field number for the "firstName" field.</summary>
    public const int FirstNameFieldNumber = 3;
    private string firstName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FirstName {
      get { return firstName_; }
      set {
        firstName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lastName" field.</summary>
    public const int LastNameFieldNumber = 4;
    private string lastName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LastName {
      get { return lastName_; }
      set {
        lastName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "vacationAccrualRate" field.</summary>
    public const int VacationAccrualRateFieldNumber = 5;
    private float vacationAccrualRate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float VacationAccrualRate {
      get { return vacationAccrualRate_; }
      set {
        vacationAccrualRate_ = value;
      }
    }

    /// <summary>Field number for the "vacationAccrued" field.</summary>
    public const int VacationAccruedFieldNumber = 6;
    private float vacationAccrued_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float VacationAccrued {
      get { return vacationAccrued_; }
      set {
        vacationAccrued_ = value;
      }
    }

    /// <summary>Field number for the "vacations" field.</summary>
    public const int VacationsFieldNumber = 7;
    private static readonly pb::FieldCodec<global::VacationTrackerAdmin.ProtocolBuffers.Vacation> _repeated_vacations_codec
        = pb::FieldCodec.ForMessage(58, global::VacationTrackerAdmin.ProtocolBuffers.Vacation.Parser);
    private readonly pbc::RepeatedField<global::VacationTrackerAdmin.ProtocolBuffers.Vacation> vacations_ = new pbc::RepeatedField<global::VacationTrackerAdmin.ProtocolBuffers.Vacation>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::VacationTrackerAdmin.ProtocolBuffers.Vacation> Vacations {
      get { return vacations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Employee);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Employee other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (BadgeNumber != other.BadgeNumber) return false;
      if (FirstName != other.FirstName) return false;
      if (LastName != other.LastName) return false;
      if (VacationAccrualRate != other.VacationAccrualRate) return false;
      if (VacationAccrued != other.VacationAccrued) return false;
      if(!vacations_.Equals(other.vacations_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (BadgeNumber != 0) hash ^= BadgeNumber.GetHashCode();
      if (FirstName.Length != 0) hash ^= FirstName.GetHashCode();
      if (LastName.Length != 0) hash ^= LastName.GetHashCode();
      if (VacationAccrualRate != 0F) hash ^= VacationAccrualRate.GetHashCode();
      if (VacationAccrued != 0F) hash ^= VacationAccrued.GetHashCode();
      hash ^= vacations_.GetHashCode();
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
        output.WriteInt32(Id);
      }
      if (BadgeNumber != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(BadgeNumber);
      }
      if (FirstName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(FirstName);
      }
      if (LastName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LastName);
      }
      if (VacationAccrualRate != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(VacationAccrualRate);
      }
      if (VacationAccrued != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(VacationAccrued);
      }
      vacations_.WriteTo(output, _repeated_vacations_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (BadgeNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BadgeNumber);
      }
      if (FirstName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FirstName);
      }
      if (LastName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LastName);
      }
      if (VacationAccrualRate != 0F) {
        size += 1 + 4;
      }
      if (VacationAccrued != 0F) {
        size += 1 + 4;
      }
      size += vacations_.CalculateSize(_repeated_vacations_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Employee other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.BadgeNumber != 0) {
        BadgeNumber = other.BadgeNumber;
      }
      if (other.FirstName.Length != 0) {
        FirstName = other.FirstName;
      }
      if (other.LastName.Length != 0) {
        LastName = other.LastName;
      }
      if (other.VacationAccrualRate != 0F) {
        VacationAccrualRate = other.VacationAccrualRate;
      }
      if (other.VacationAccrued != 0F) {
        VacationAccrued = other.VacationAccrued;
      }
      vacations_.Add(other.vacations_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            BadgeNumber = input.ReadInt32();
            break;
          }
          case 26: {
            FirstName = input.ReadString();
            break;
          }
          case 34: {
            LastName = input.ReadString();
            break;
          }
          case 45: {
            VacationAccrualRate = input.ReadFloat();
            break;
          }
          case 53: {
            VacationAccrued = input.ReadFloat();
            break;
          }
          case 58: {
            vacations_.AddEntriesFrom(input, _repeated_vacations_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Vacation : pb::IMessage<Vacation> {
    private static readonly pb::MessageParser<Vacation> _parser = new pb::MessageParser<Vacation>(() => new Vacation());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Vacation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::VacationTrackerAdmin.ProtocolBuffers.MessagesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vacation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vacation(Vacation other) : this() {
      id_ = other.id_;
      startDate_ = other.startDate_;
      duration_ = other.duration_;
      isCancelled_ = other.isCancelled_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vacation Clone() {
      return new Vacation(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "startDate" field.</summary>
    public const int StartDateFieldNumber = 2;
    private long startDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long StartDate {
      get { return startDate_; }
      set {
        startDate_ = value;
      }
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 3;
    private float duration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Duration {
      get { return duration_; }
      set {
        duration_ = value;
      }
    }

    /// <summary>Field number for the "isCancelled" field.</summary>
    public const int IsCancelledFieldNumber = 4;
    private bool isCancelled_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsCancelled {
      get { return isCancelled_; }
      set {
        isCancelled_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Vacation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Vacation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (StartDate != other.StartDate) return false;
      if (Duration != other.Duration) return false;
      if (IsCancelled != other.IsCancelled) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (StartDate != 0L) hash ^= StartDate.GetHashCode();
      if (Duration != 0F) hash ^= Duration.GetHashCode();
      if (IsCancelled != false) hash ^= IsCancelled.GetHashCode();
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
        output.WriteInt32(Id);
      }
      if (StartDate != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(StartDate);
      }
      if (Duration != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Duration);
      }
      if (IsCancelled != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsCancelled);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (StartDate != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(StartDate);
      }
      if (Duration != 0F) {
        size += 1 + 4;
      }
      if (IsCancelled != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Vacation other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.StartDate != 0L) {
        StartDate = other.StartDate;
      }
      if (other.Duration != 0F) {
        Duration = other.Duration;
      }
      if (other.IsCancelled != false) {
        IsCancelled = other.IsCancelled;
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
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            StartDate = input.ReadInt64();
            break;
          }
          case 29: {
            Duration = input.ReadFloat();
            break;
          }
          case 32: {
            IsCancelled = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetAllRequest : pb::IMessage<GetAllRequest> {
    private static readonly pb::MessageParser<GetAllRequest> _parser = new pb::MessageParser<GetAllRequest>(() => new GetAllRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAllRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::VacationTrackerAdmin.ProtocolBuffers.MessagesReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllRequest(GetAllRequest other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllRequest Clone() {
      return new GetAllRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetAllRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAllRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetAllRequest other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  public sealed partial class GetByBadgeNumberRequest : pb::IMessage<GetByBadgeNumberRequest> {
    private static readonly pb::MessageParser<GetByBadgeNumberRequest> _parser = new pb::MessageParser<GetByBadgeNumberRequest>(() => new GetByBadgeNumberRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetByBadgeNumberRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::VacationTrackerAdmin.ProtocolBuffers.MessagesReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetByBadgeNumberRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetByBadgeNumberRequest(GetByBadgeNumberRequest other) : this() {
      badgeNumber_ = other.badgeNumber_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetByBadgeNumberRequest Clone() {
      return new GetByBadgeNumberRequest(this);
    }

    /// <summary>Field number for the "badgeNumber" field.</summary>
    public const int BadgeNumberFieldNumber = 1;
    private int badgeNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BadgeNumber {
      get { return badgeNumber_; }
      set {
        badgeNumber_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetByBadgeNumberRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetByBadgeNumberRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BadgeNumber != other.BadgeNumber) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BadgeNumber != 0) hash ^= BadgeNumber.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (BadgeNumber != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(BadgeNumber);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BadgeNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BadgeNumber);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetByBadgeNumberRequest other) {
      if (other == null) {
        return;
      }
      if (other.BadgeNumber != 0) {
        BadgeNumber = other.BadgeNumber;
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
          case 8: {
            BadgeNumber = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class EmployeeRequest : pb::IMessage<EmployeeRequest> {
    private static readonly pb::MessageParser<EmployeeRequest> _parser = new pb::MessageParser<EmployeeRequest>(() => new EmployeeRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EmployeeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::VacationTrackerAdmin.ProtocolBuffers.MessagesReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmployeeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmployeeRequest(EmployeeRequest other) : this() {
      Employee = other.employee_ != null ? other.Employee.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmployeeRequest Clone() {
      return new EmployeeRequest(this);
    }

    /// <summary>Field number for the "employee" field.</summary>
    public const int EmployeeFieldNumber = 1;
    private global::VacationTrackerAdmin.ProtocolBuffers.Employee employee_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::VacationTrackerAdmin.ProtocolBuffers.Employee Employee {
      get { return employee_; }
      set {
        employee_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EmployeeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EmployeeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Employee, other.Employee)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (employee_ != null) hash ^= Employee.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (employee_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Employee);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (employee_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Employee);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EmployeeRequest other) {
      if (other == null) {
        return;
      }
      if (other.employee_ != null) {
        if (employee_ == null) {
          employee_ = new global::VacationTrackerAdmin.ProtocolBuffers.Employee();
        }
        Employee.MergeFrom(other.Employee);
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
            if (employee_ == null) {
              employee_ = new global::VacationTrackerAdmin.ProtocolBuffers.Employee();
            }
            input.ReadMessage(employee_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class EmployeeResponse : pb::IMessage<EmployeeResponse> {
    private static readonly pb::MessageParser<EmployeeResponse> _parser = new pb::MessageParser<EmployeeResponse>(() => new EmployeeResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EmployeeResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::VacationTrackerAdmin.ProtocolBuffers.MessagesReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmployeeResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmployeeResponse(EmployeeResponse other) : this() {
      Employee = other.employee_ != null ? other.Employee.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmployeeResponse Clone() {
      return new EmployeeResponse(this);
    }

    /// <summary>Field number for the "employee" field.</summary>
    public const int EmployeeFieldNumber = 1;
    private global::VacationTrackerAdmin.ProtocolBuffers.Employee employee_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::VacationTrackerAdmin.ProtocolBuffers.Employee Employee {
      get { return employee_; }
      set {
        employee_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EmployeeResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EmployeeResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Employee, other.Employee)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (employee_ != null) hash ^= Employee.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (employee_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Employee);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (employee_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Employee);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EmployeeResponse other) {
      if (other == null) {
        return;
      }
      if (other.employee_ != null) {
        if (employee_ == null) {
          employee_ = new global::VacationTrackerAdmin.ProtocolBuffers.Employee();
        }
        Employee.MergeFrom(other.Employee);
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
            if (employee_ == null) {
              employee_ = new global::VacationTrackerAdmin.ProtocolBuffers.Employee();
            }
            input.ReadMessage(employee_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
