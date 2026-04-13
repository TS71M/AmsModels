using Lib.Images;

namespace AmsModels;

public partial class Disease
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DiseaseId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public string DisNam { get; set; } = "";

    [ForeignKey(nameof(IndPic))]
    public int IndPicId { get; set; }
    public string History { get; set; } = "";
    public string SymAndSig { get; set; } = "";
    public string CauAge { get; set; } = "";

    [ForeignKey(nameof(DisCycPic))]
    public int DisCycPicId { get; set; }
    public string DisPicDes { get; set; } = "";
    public string Epidemology { get; set; } = "";
    public string DisMgt { get; set; } = "";
    public decimal TempMax { get; set; }
    public decimal TempMin { get; set; }
    public decimal TempNight { get; set; }
    public bool Wet { get; set; }
    public bool Humid { get; set; }
    public bool Dry { get; set; }
    public bool VeryDry { get; set; }

    public bool IsValid => TempMin < TempMax;
    public string DisCycPicImg => ImageX.ImageToString(DisCycPic?.ImageFile, ImageX.StandardImage.NoImage);
    public string IndPicImg => ImageX.ImageToString(IndPic?.ImageFile, ImageX.StandardImage.NoImage);

    public AppImage? DisCycPic { get; set; }
    public AppImage? IndPic { get; set; }

    public virtual ICollection<DisAli> DisAlis { get; set; } = [];
    public virtual ICollection<DisPic> DisPics { get; set; } = [];

}