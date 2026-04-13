namespace AmsModels;

[Index(nameof(SoiTesId), nameof(ChemId), IsUnique = true)]
public class SoilTestChem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SoilTestChemId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int SoiTesId { get; set; }

    [Required]
    public int ChemId { get; set; }

    public decimal Value { get; set; }
    public int? UnitId { get; set; }

    public required Chemical Chem { get; set; }
    public required SoilTest SoiTes { get; set; }
    public Unit? Unit { get; set; }
}