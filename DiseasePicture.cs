using Lib.Images;

namespace AmsModels;

public partial class DiseasePicture
{
    [Key]
    public int DiseasePictureId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int DiseaseId { get; set; }
    public int? ImageId { get; set; }

    public string Image => ImageX.ImageToString(AppImage?.ImageFile, ImageX.StandardImage.NoImage);

    public AppImage? AppImage { get; set; }
    public required Disease Disease { get; set; }
}
