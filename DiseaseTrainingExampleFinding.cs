namespace AmsModels;

public partial class DiseaseTrainingExampleFinding
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DiseaseTrainingExampleFindingId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int DiseaseTrainingExampleId { get; set; }

    public int? DiseaseId { get; set; }

    [Required]
    [MaxLength(250)]
    public string ConditionName { get; set; } = "";

    [Required]
    [MaxLength(50)]
    public string Role { get; set; } = "Secondary";

    [Precision(5, 4)]
    public decimal? Confidence { get; set; }

    [MaxLength(1000)]
    public string? Note { get; set; }

    public int SortOrder { get; set; }

    public DiseaseTrainingExample? DiseaseTrainingExample { get; set; }
    public Disease? Disease { get; set; }
}
