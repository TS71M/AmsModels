using Lib.Enums;

namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
public partial class GrassType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GrassTypeId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(250)]
    public string GrassTypeName { get; set; } = "";

    [Required]
    public PhotosyntheticPathway Pathway { get; set; }

    [MaxLength(500)]
    public string? Description { get; set; }

    public decimal OptimalTemperature { get; set; }
    public decimal Variation { get; set; }

    public virtual ICollection<DiseaseGrassType> DiseaseGrassTypes { get; set; } = [];
    public virtual ICollection<GrassSpecies> GrassSpecies { get; set; } = [];
}
