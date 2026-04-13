using Lib.Images;

namespace AmsModels;

public partial class Account
{
    [Key]
    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AccountId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int AccountGroupId { get; set; }

    [Display(Name = "Account Number")]
    public int AccNum { get; set; }

    [Display(Name = "Account Name")]
    public string AccDes { get; set; } = "";
    public int? ImageId { get; set; }

    public string Image => ImageX.ImageToString(AppImage?.ImageFile, ImageX.StandardImage.NoImage);

    public AccountGroup? AccountGroup { get; set; }
    public AppImage? AppImage { get; set; }

    public virtual ICollection<Product> Products { get; set; } = [];
    public virtual ICollection<Expense> Expenses { get; set; } = [];
    public virtual ICollection<Budget> Budgets { get; set; } = [];
    public virtual ICollection<StaffPlanner> StaPlas { get; set; } = [];
}