using Lib.Images;

namespace AmsModels;

public partial class MachinePicture
{
    [Key]
    public int MachinePictureId { get; set; }
    public int MachineId { get; set; }
    public int? ImageId { get; set; }

    public string Image => ImageX.ImageToString(AppImage?.ImageFile, ImageX.StandardImage.NoImage);

    public AppImage? AppImage { get; set; }
    public required Machine Machine { get; set; }
}