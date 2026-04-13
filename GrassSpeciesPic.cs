namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(GrassSpeciesId))]
[Index(nameof(ImageId), IsUnique = true)]
public partial class GrassSpeciesPic
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GrassSpeciesPicId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public bool Active { get; set; } = true;

    [Required]
    public DateTime CreatedAtUtc { get; set; }

    [Required]
    public DateTime UpdatedAtUtc { get; set; }

    [Required]
    public int GrassSpeciesId { get; set; }

    [Required]
    public int ImageId { get; set; }


    [ForeignKey(nameof(ImageId))]
    public AppImage AppImage { get; set; } = default!;

    [ForeignKey(nameof(GrassSpeciesId))]
    public GrassSpecies GrassSpecies { get; set; } = default!;
}