using Lib.Flags;

namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(GrassSpeciesId), nameof(ChemId), IsUnique = true)]
[Index(nameof(GrassSpeciesId))]
[Index(nameof(ChemId))]
public partial class GrassSpeciesChemical
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GrassSpeciesChemId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int GrassSpeciesId { get; set; }

    [Required]
    public int ChemId { get; set; }

    public bool Active { get; set; } = true;

    public ChemUseMode UseMode { get; set; }
    public string? Notes { get; set; }

    public Chemical? Chem { get; set; }
    public GrassSpecies? GrassSpecieses { get; set; }
}