namespace AmsModels;

public partial class DieseaseGrassType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DiseaseGrassTypeId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int DiseaseId { get; set; }
    public int GraTypId { get; set; }

    public required GrassSpecies GrassSpecieses { get; set; }
    public required GrassType GrassTypes { get; set; }

}