using Lib.Images;

namespace AmsModels;

public class Project
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProjectId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int FieldId { get; set; }
    public int? ImageId { get; set; }

    [Required, MaxLength(45)]
    public string ProjectName { get; set; } = "";
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime EndDate { get; set; } = DateTime.Now;
    public bool Completed { get; set; } = false;

    [Required, MaxLength(1000)]
    public string Description { get; set; } = "";

    public string Image => ImageX.ImageToString(AppImage?.ImageFile, ImageX.StandardImage.NoImage);
    public string NumberOfStages => Stages.Count.ToString();

    public required Field Field { get; set; }
    public AppImage? AppImage { get; set; }

    public ICollection<Stage> Stages { get; set; } = [];
}