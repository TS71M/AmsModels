namespace AmsModels;

public partial class DiseaseGrassType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DiseaseGrassTypeId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int DiseaseId { get; set; }
    public int GrassTypeId { get; set; }

    public required Disease Disease { get; set; }
    public required GrassType GrassType { get; set; }
}
