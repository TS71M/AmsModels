namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(FieldId), nameof(WatTesDat), nameof(WatTesTitle))]
public partial class WatTes
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int WatTesId { get; set; }

    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int FieldId { get; set; }

    [Required, MaxLength(250)]
    public string WatTesTitle { get; set; } = "";

    public DateTime WatTesDat { get; set; }
    public DateTime? SampleReceivedDat { get; set; }
    public DateTime? SampleTakenDat { get; set; }

    [MaxLength(100)]
    public string? ReportNumber { get; set; }

    [MaxLength(100)]
    public string? AnalysisNumber { get; set; }

    [MaxLength(250)]
    public string? ProjectName { get; set; }

    [MaxLength(100)]
    public string? CustomerNumber { get; set; }

    [MaxLength(150)]
    public string? SamplerName { get; set; }

    public bool Ignore { get; set; }

    public required Field Field { get; set; }

    public virtual ICollection<WatTesChem> WatTesChems { get; set; } = [];
}
