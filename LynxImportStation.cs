namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(LynxImportId))]
[Index(nameof(LynxImportId), nameof(SourceSystemUniqueId), IsUnique = true)]
public sealed class LynxImportStation
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LynxImportStationId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int LynxImportId { get; set; }
    public int SourceStationId { get; set; }
    public long SourceSystemUniqueId { get; set; }
    public int SatelliteNumber { get; set; }
    public int StationNumber { get; set; }

    [Required, MaxLength(120)]
    public string StationTag { get; set; } = "";

    [MaxLength(200)]
    public string? HardwareDescriptor { get; set; }

    public int? SourceNozzleId { get; set; }
    public int? SourceSprinklerId { get; set; }

    [MaxLength(200)]
    public string? SprinklerModel { get; set; }

    [MaxLength(120)]
    public string? NozzleNumber { get; set; }

    public int MapPointCount { get; set; }
    public bool Active { get; set; } = true;

    public required LynxImport LynxImport { get; set; }
    public ICollection<LynxImportMapPoint> MapPoints { get; set; } = [];
}
