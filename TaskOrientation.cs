using Lib.Images;

namespace AmsModels;

public partial class TaskOrientation
{
    [Key]
    public int OriPicId { get; set; }

    [Required, MaxLength(50)]
    public string OriPicName { get; set; } = "";
    public int? OriPicImgId { get; set; }

    public string Image => ImageX.ImageToString(AppImage?.ImageFile, ImageX.StandardImage.NoImage);

    public AppImage? AppImage { get; set; }

    public virtual ICollection<TaskArea> TaskAreas { get; set; } = [];
}