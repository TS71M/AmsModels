namespace AmsModels;

public enum SurfaceMapApprovalState { Draft, Submitted, Approved, Rejected }
public enum SurfaceMapRingKind { Exterior, Exclusion }

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(SurfaceId), nameof(Name), IsUnique = true)]
public sealed class SurfaceMapSubsection
{
    [Key] public int SurfaceMapSubsectionId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public int SurfaceId { get; set; }
    [MaxLength(120)] public string Name { get; set; } = "";
    public int SortOrder { get; set; }
    public Surface Surface { get; set; } = null!;
    public ICollection<SurfaceMapRawPoint> RawPoints { get; set; } = [];
}

/// <summary>Append-only evidence received from a mapping device. Refinement never edits these rows.</summary>
[Index(nameof(CaptureId), IsUnique = true)]
[Index(nameof(SurfaceMapSubsectionId), nameof(RingId), nameof(PointOrder), IsUnique = true)]
public sealed class SurfaceMapRawPoint
{
    [Key] public long SurfaceMapRawPointId { get; set; }
    public Guid CaptureId { get; set; }
    public int SurfaceMapSubsectionId { get; set; }
    public Guid RingId { get; set; }
    public SurfaceMapRingKind RingKind { get; set; }
    public int PointOrder { get; set; }
    [Precision(9, 6)] public decimal Latitude { get; set; }
    [Precision(9, 6)] public decimal Longitude { get; set; }
    [Precision(8, 2)] public decimal? HorizontalAccuracyMetres { get; set; }
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
    [MaxLength(40)] public string? GpsFixQuality { get; set; }
    public int? SatelliteCount { get; set; }
    public bool GpsValid { get; set; }
    [Precision(8, 3)] public decimal BoundaryVwcPercent { get; set; } = -1m;
    public DateTimeOffset CapturedAtUtc { get; set; }
    public SurfaceMapSubsection Subsection { get; set; } = null!;
}

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IdempotencyKey), IsUnique = true)]
[Index(nameof(SurfaceId), nameof(RevisionNumber), IsUnique = true)]
public sealed class SurfaceMapRevision
{
    [Key] public long SurfaceMapRevisionId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public Guid IdempotencyKey { get; set; }
    public int SurfaceId { get; set; }
    public int RevisionNumber { get; set; }
    public string GrossGeoJson { get; set; } = "{}";
    public string DeductionGeoJson { get; set; } = "{}";
    public string EffectiveGeoJson { get; set; } = "{}";
    [Precision(14, 2)] public decimal GrossAreaM2 { get; set; }
    [Precision(14, 2)] public decimal DeductionAreaM2 { get; set; }
    [Precision(14, 2)] public decimal EffectiveAreaM2 { get; set; }
    public SurfaceMapApprovalState ApprovalState { get; set; }
    public DateTimeOffset CreatedAtUtc { get; set; }
    public int CreatedByUserId { get; set; }
    public DateTimeOffset? ApprovedAtUtc { get; set; }
    public int? ApprovedByUserId { get; set; }
    public string WarningsJson { get; set; } = "[]";
    public Surface Surface { get; set; } = null!;
}
