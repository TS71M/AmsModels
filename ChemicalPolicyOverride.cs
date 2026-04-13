namespace AmsModels;

public enum ChemPolicyOwnerType { Ibu = 1, Field = 2 }

[Index(nameof(OwnerType), nameof(OwnerId), nameof(ChemId), IsUnique = true)]
[Index(nameof(OwnerType), nameof(OwnerId))]
[Index(nameof(ChemId))]
public class ChemicalPolicyOverride
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ChemicalPolicyOverrideId { get; set; }

    public ChemPolicyOwnerType OwnerType { get; set; }

    [Required]
    public int OwnerId { get; set; }           // IbuId or FieldId

    [Required]
    public int ChemId { get; set; }
    public bool Allowed { get; set; }

    [MaxLength(500)]
    public string? Reason { get; set; }
}
