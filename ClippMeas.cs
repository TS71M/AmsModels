namespace AmsModels;

public partial class ClippMeas
{
    [Key]
    public int ClippMeasId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int SurfaceId { get; set; }

    [Required]
    public DateTime MesTime { get; set; }
    public decimal MesQua { get; set; }

    /// <summary>
    /// Snapshot of the completely mown Surface area used to normalize the
    /// collected clipping volume. Nullable only for legacy measurements whose
    /// Surface area was not configured when they were recorded.
    /// </summary>
    public decimal? SampleAreaM2 { get; set; }

    public required Surface Surface { get; set; }
}
