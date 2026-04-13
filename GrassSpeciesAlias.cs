namespace AmsModels;

public partial class GrassSpeciesAlias
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AliasId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int GraCulId { get; set; }

    [Required, MaxLength(1000)]
    public string Alias { get; set; } = "";

    public required GrassSpecies GraCul { get; set; }
}