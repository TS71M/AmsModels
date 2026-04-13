namespace AmsModels;

[Index(nameof(FieldId), nameof(GeneratedAtUtc), IsUnique = true)]
public class FieldRiskSummary
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FieldRiskSummaryId { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required]
    public Field Field { get; set; } = null!;

    [Required]
    public DateTime GeneratedAtUtc { get; set; }

    [MaxLength(32)]
    public string ModelVersion { get; set; } = "risk-v1";

    // JSON payload of RiskSummaryDto
    [Required]
    public string SummaryJson { get; set; } = string.Empty;

    // Optional: to avoid writing identical snapshots
    [MaxLength(64)]
    public string? InputsHash { get; set; }
}