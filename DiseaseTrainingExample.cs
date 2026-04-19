namespace AmsModels;

public partial class DiseaseTrainingExample
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DiseaseTrainingExampleId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int DiseaseId { get; set; }

    [Required]
    public int ImageId { get; set; }

    public int? SubmittedById { get; set; }
    public int? ReviewedById { get; set; }

    [Required]
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public DateTime? ReviewedAtUtc { get; set; }

    [MaxLength(250)]
    public string? AiPredictedCondition { get; set; }

    [MaxLength(250)]
    public string? FinalCondition { get; set; }

    [MaxLength(250)]
    public string? SeasonTag { get; set; }

    [MaxLength(250)]
    public string? WeatherTag { get; set; }

    [Precision(5, 4)]
    public decimal? Confidence { get; set; }

    [MaxLength(4000)]
    public string? ReviewNote { get; set; }

    public bool IsApproved { get; set; }
    public bool UseForLearning { get; set; } = true;
    public bool UseForRetrieval { get; set; } = true;
    public bool Active { get; set; } = true;

    public required Disease Disease { get; set; }
    public required AppImage AppImage { get; set; }
    public User? SubmittedBy { get; set; }
    public User? ReviewedBy { get; set; }
    public virtual ICollection<DiseaseTrainingExampleFinding> Findings { get; set; } = [];
}
