namespace AmsModels;

[Index(nameof(GrassSpeciesChartGroupId))]
[Index(nameof(Term), IsUnique = true)]
public class GrassSpeciesChartGroupTerm
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GrassSpeciesChartGroupTermId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public bool Active { get; set; } = true;

    [Required]
    public DateTime CreatedAtUtc { get; set; }

    [Required]
    public DateTime UpdatedAtUtc { get; set; }

    [Required]
    public int GrassSpeciesChartGroupId { get; set; }

    [Required, MaxLength(120)]
    public string Term { get; set; } = "";

    public int SortOrder { get; set; }

    [ForeignKey(nameof(GrassSpeciesChartGroupId))]
    public GrassSpeciesChartGroup ChartGroup { get; set; } = default!;
}
