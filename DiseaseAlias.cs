namespace AmsModels;

public partial class DiseaseAlias
{
    [Key]
    public int DiseaseAliasId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int DiseaseId { get; set; }

    [Required]
    [MaxLength(250)]
    public string AliasName { get; set; } = "";

    public required Disease Disease { get; set; }
}
