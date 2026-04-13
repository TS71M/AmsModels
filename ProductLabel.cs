using Lib.Images;

namespace AmsModels;

public partial class ProductLabel
{
    [Key]
    public int ProductLabelId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int ProductId { get; set; }

    [Required, MaxLength(250)]
    public string ProLabName { get; set; } = "";

    [Required, MaxLength(1000)]
    public string ProLabPath { get; set; } = "";
    public int? ProductLabelImgId { get; set; }
    public DateTime UploadDT { get; set; }
    public int ProLabSize { get; set; }

    public string Image => ImageX.ImageToString(AppImage?.ImageFile, ImageX.StandardImage.NoLabel);

    public AppImage? AppImage { get; set; }
    public required Product Product { get; set; }

}
