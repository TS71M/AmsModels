namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(FieldZoneId), nameof(CapturedUtc))]
[Index(nameof(FieldZoneId), nameof(Active))]
public sealed class FieldZoneSatelliteSnapshot
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FieldZoneSatelliteSnapshotId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int FieldZoneId { get; set; }
    public FieldZone FieldZone { get; set; } = null!;

    public DateTime CapturedUtc { get; set; }

    [Required, MaxLength(40)]
    public string Source { get; set; } = "";

    [Precision(9, 4)]
    public decimal? NdviMean { get; set; }

    [Precision(9, 4)]
    public decimal? NdviMin { get; set; }

    [Precision(9, 4)]
    public decimal? NdviMax { get; set; }

    [Precision(9, 4)]
    public decimal? NdviStdDev { get; set; }

    [Precision(9, 4)]
    public decimal? NdreMean { get; set; }

    [Precision(9, 4)]
    public decimal? MoistureIndexMean { get; set; }

    [Precision(5, 2)]
    public decimal? CloudCoveragePercent { get; set; }

    public bool Active { get; set; } = true;
}
