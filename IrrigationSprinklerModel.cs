namespace AmsModels;

public sealed class IrrigationSprinklerModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationSprinklerModelId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(120)]
    public string ManufacturerName { get; set; } = "";

    [Required, MaxLength(160)]
    public string ModelName { get; set; } = "";

    [MaxLength(80)]
    public string ModelCode { get; set; } = "";

    [Range(1, 5)]
    public int MaximumNozzleCount { get; set; } = 1;

    [MaxLength(500)]
    public string? SourceUrl { get; set; }

    [MaxLength(2000)]
    public string ReferenceNotes { get; set; } = "";

    public bool IsLegacy { get; set; }
    public bool IsAiDiscovered { get; set; }
    public bool Active { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public ICollection<IrrigationNozzleConfiguration> NozzleConfigurations { get; set; } = [];
    public ICollection<IrrigationSprinklerNozzleOption> NozzleOptions { get; set; } = [];
    public ICollection<SurfaceSprinkler> SurfaceSprinklers { get; set; } = [];
}
