using Lib.Images;

namespace AmsModels;

public class Stage
{
    [Key]
    public int StageId { get; set; }
    public int ProjectId { get; set; }

    [Required, MaxLength(50)]
    public string StageName { get; set; } = string.Empty;
    public DateTime StageDate { get; set; } = DateTime.Now;

    [Required, MaxLength(1000)]
    public string Description { get; set; } = string.Empty;

    public AppImage? FirstImage => StageImages.OrderBy(si => si.ImageId).FirstOrDefault()?.AppImage;

    public string Image => ImageX.ImageToString(FirstImage?.ImageFile, ImageX.StandardImage.NoImage);

    public required Project Project { get; set; }

    public virtual ICollection<StageImage> StageImages { get; set; } = [];
}