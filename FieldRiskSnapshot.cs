using static Lib.Enums.RiskLevels;

namespace AmsModels;

[Index(nameof(FieldId), nameof(GeneratedAtUtc), IsUnique = true)]
public class FieldRiskSnapshot
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FieldRiskSnapshotId { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required]
    public DateTime GeneratedAtUtc { get; set; }

    [MaxLength(50)]
    public RiskLevel Level { get; set; } = RiskLevel.None;

    [Required]
    public string ItemsJson { get; set; } = "[]";


    public Field Field { get; set; } = null!;
}