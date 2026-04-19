using Lib.Images;

namespace AmsModels;

public partial class Disease
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DiseaseId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public string Name { get; set; } = "";

    [ForeignKey(nameof(IndicatorPicture))]
    public int IndicatorPictureId { get; set; }
    public string History { get; set; } = "";
    public string SymptomsAndSigns { get; set; } = "";
    public string CausalAgent { get; set; } = "";

    [ForeignKey(nameof(DiseaseCyclePicture))]
    public int DiseaseCyclePictureId { get; set; }
    public string DiseasePictureDescription { get; set; } = "";
    public string Epidemiology { get; set; } = "";
    public string DiseaseManagement { get; set; } = "";
    public decimal TempMax { get; set; }
    public decimal TempMin { get; set; }
    public decimal TempNight { get; set; }
    public bool Wet { get; set; }
    public bool Humid { get; set; }
    public bool Dry { get; set; }
    public bool VeryDry { get; set; }

    public bool IsValid => TempMin < TempMax;
    public string DiseaseCyclePictureImage => ImageX.ImageToString(DiseaseCyclePicture?.ImageFile, ImageX.StandardImage.NoImage);
    public string IndicatorPictureImage => ImageX.ImageToString(IndicatorPicture?.ImageFile, ImageX.StandardImage.NoImage);

    public AppImage? DiseaseCyclePicture { get; set; }
    public AppImage? IndicatorPicture { get; set; }

    public virtual ICollection<DiseaseAlias> DiseaseAliases { get; set; } = [];
    public virtual ICollection<DiseasePicture> DiseasePictures { get; set; } = [];
    public virtual ICollection<DiseaseGrassType> DiseaseGrassTypes { get; set; } = [];
    public virtual ICollection<DiseaseTrainingExample> DiseaseTrainingExamples { get; set; } = [];
}
