using Lib.Images;

namespace AmsModels;

public partial class AccountGroup
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AccountGroupId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int OrderNumber { get; set; }

    [Required, MaxLength(250)]
    public string AccountGroupName { get; set; } = "";
    public int? ImageId { get; set; }

    public string Image => ImageX.ImageToString(AppImage?.ImageFile, ImageX.StandardImage.NoImage);

    public AppImage? AppImage { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = [];

}