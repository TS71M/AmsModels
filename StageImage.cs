using Lib.Images;

namespace AmsModels;

public class StageImage
{
    [Key]
    public int StageImageId { get; set; }
    public int StageId { get; set; }
    public int ImageId { get; set; }

    public string Image => ImageX.ImageToString(AppImage?.ImageFile, ImageX.StandardImage.NoImage);

    public required Stage Stage { get; set; }
    public AppImage? AppImage { get; set; }
}