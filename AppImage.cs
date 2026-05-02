namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IbuId))]
[Index(nameof(UploadedById))]
public partial class AppImage
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ImageId { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int? IbuId { get; set; }

    [Required]
    public string ImageName { get; set; } = "";

    public string RelativePath { get; set; } = "";
    [NotMapped]
    public byte[]? ImageFile { get; set; }
    public DateTime UploadDate { get; set; }
    public int ImageSize { get; set; }
    public int UploadedById { get; set; }

    [NotMapped]
    public bool IsGlobal => IbuId == null;

    public Ibu? Ibu { get; set; }
    public User? UploadedBy { get; set; }


    public GrassSpecies? GrassSpeciesMainImageFor { get; set; }
    public ICollection<AreaCompositionPhoto> AreaCompositionPhotos { get; set; } = [];
    public ICollection<DiseasePicture> DiseasePictures { get; set; } = [];
    public ICollection<DiseaseTrainingExample> DiseaseTrainingExamples { get; set; } = [];

    public ICollection<GrassSpeciesPic> GrassSpeciesPics { get; set; } = [];
}
