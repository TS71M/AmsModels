namespace AmsModels;

[Index(nameof(FieldId), IsUnique = true)]
[Index(nameof(Active), nameof(HistoryBackfilledUtc), nameof(LastRunUtc))]
public class FieldRiskDiaryBackfillState
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FieldRiskDiaryBackfillStateId { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required]
    public Field Field { get; set; } = null!;

    public DateTime? LastProcessedGeneratedAtUtc { get; set; }

    public DateTime? HistoryBackfilledUtc { get; set; }

    [Required]
    [MaxLength(32)]
    public string LogicVersion { get; set; } = "risk-diary-v1";

    public DateTime? LastRunUtc { get; set; }

    [MaxLength(2000)]
    public string? LastError { get; set; }

    [Required]
    public bool Active { get; set; } = true;
}
