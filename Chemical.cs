namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ChemName), IsUnique = true)]
[Index(nameof(ChemTypeId))]
[Index(nameof(ChemTypeId), nameof(ChemName), IsUnique = true)]
[Index(nameof(UnitTypeId))]
public partial class Chemical
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ChemId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public bool Active { get; set; } = true;

    [Required]
    public int ChemTypeId { get; set; }

    [Required]
    [MaxLength(250)]
    public string ChemName { get; set; } = "";

    [MaxLength(50)]
    public string? ChemicalFormula { get; set; }

    [Required]
    public bool IsElemental { get; set; } = false;
    public int? UnitTypeId { get; set; }

    public ChemicalType? ChemType { get; set; }
    public UnitType? UnitType { get; set; }

    public virtual ICollection<GrassSpeciesChemical> GrassSpeciesChemicals { get; set; } = [];
    public virtual ICollection<ProductChemical> ProdChems { get; set; } = [];
    public virtual ICollection<SoilTestChem> SoiTesChems { get; set; } = [];
    public virtual ICollection<SoiTesSatChem> SoiTesSatChems { get; set; } = [];

}
