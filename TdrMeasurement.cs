namespace AmsModels;

[Index(nameof(ClientMeasurementId), IsUnique = true)]
[Index(nameof(FieldId), nameof(CapturedAtUtc))]
public sealed class TdrMeasurement
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long TdrMeasurementId { get; set; }
    [Required] public Guid PubId { get; set; } = Guid.NewGuid();
    [Required] public Guid ClientMeasurementId { get; set; }
    public int IbuId { get; set; }
    public int FieldId { get; set; }
    public int? CreatedByUserId { get; set; }
    public Guid? ZonePubId { get; set; }
    public Guid? SessionId { get; set; }
    [MaxLength(128)] public string? DeviceSerialNumber { get; set; }
    [MaxLength(128)] public string? DeviceBluetoothAddress { get; set; }
    public DateTime CapturedAtUtc { get; set; }
    public DateTime TriggeredAtUtc { get; set; }
    public DateTime CaptureStartedUtc { get; set; }
    public DateTime CaptureCompletedUtc { get; set; }
    [Precision(8, 3)] public decimal? VwcPercent { get; set; }
    public int? Period { get; set; }
    [Precision(10, 3)] public decimal? BulkEc { get; set; }
    [Precision(7, 3)] public decimal? SoilTemperatureC { get; set; }
    [Precision(7, 3)] public decimal? IrTemperatureC { get; set; }
    [Precision(11, 8)] public decimal? Latitude { get; set; }
    [Precision(11, 8)] public decimal? Longitude { get; set; }
    [Precision(11, 8)] public decimal? PhoneLatitude { get; set; }
    [Precision(11, 8)] public decimal? PhoneLongitude { get; set; }
    [Precision(8, 2)] public decimal? PhoneHorizontalAccuracyMetres { get; set; }
    public DateTimeOffset? PhoneCapturedAtUtc { get; set; }
    [Precision(11, 8)] public decimal? PreferredLatitude { get; set; }
    [Precision(11, 8)] public decimal? PreferredLongitude { get; set; }
    [Required, MaxLength(32)] public string PositionSource { get; set; } = "Tdr";
    [Precision(10, 2)] public decimal? SourceDistanceMetres { get; set; }
    public bool PositionWarning { get; set; }
    [Required, MaxLength(64)] public string PositionStatus { get; set; } = "TdrOnly";
    [MaxLength(64)] public string? RawLatitude { get; set; }
    [MaxLength(64)] public string? RawLongitude { get; set; }
    public int? SatelliteCount { get; set; }
    [MaxLength(64)] public string? GpsFix { get; set; }
    [Required, MaxLength(48)] public string GpsQuality { get; set; } = "NoFix";
    [MaxLength(64)] public string? RodLength { get; set; }
    [MaxLength(128)] public string? SoilType { get; set; }
    public int? BatteryLevel { get; set; }
    [Required, MaxLength(64)] public string ProtocolVersion { get; set; } = "fieldscout-ble-v1";
    [Required, MaxLength(32)] public string ParserVersion { get; set; } = "1.0";
    public int PayloadSchemaVersion { get; set; } = 1;
    [Required] public string RawBlePayloadJson { get; set; } = "{}";
    [Required] public string UnavailableFieldsJson { get; set; } = "[]";
    [Precision(10, 3)] public decimal? DistanceFromFieldKm { get; set; }
    public bool LocationWarning { get; set; }
    [Required, MaxLength(48)] public string LocationCheckStatus { get; set; } = "NotChecked";
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;

    public Ibu Ibu { get; set; } = null!;
    public Field Field { get; set; } = null!;
    public User? CreatedByUser { get; set; }
}
