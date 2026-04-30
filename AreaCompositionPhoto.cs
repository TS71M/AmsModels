namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(AreaId))]
[Index(nameof(SurfaceId))]
[Index(nameof(ImageId), IsUnique = true)]
public class AreaCompositionPhoto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AreaCompositionPhotoId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public bool Active { get; set; } = true;

    [Required]
    public DateTime CreatedAtUtc { get; set; }

    [Required]
    public DateTime UpdatedAtUtc { get; set; }

    [Required]
    public int AreaId { get; set; }

    public int? SurfaceId { get; set; }

    [Required]
    public int ImageId { get; set; }

    [ForeignKey(nameof(AreaId))]
    public Area Area { get; set; } = default!;

    [ForeignKey(nameof(SurfaceId))]
    public Surface? Surface { get; set; }

    [ForeignKey(nameof(ImageId))]
    public AppImage AppImage { get; set; } = default!;
}
