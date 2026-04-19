using Lib.Images;

namespace AmsModels;

public partial class Supplier
{

    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SupplierId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int IbuId { get; set; }
    public int? FieldId { get; set; }
    public bool Active { get; set; } = true;

    [Required, Display(Name = "Supplier Name")]
    public string SupNam { get; set; } = "";
    public int? ImageId { get; set; }
    public int? AddressId { get; set; }
    public int? ContactId { get; set; }
    public bool IsVisible { get; set; } = true;

    public string Image => ImageX.ImageToString(AppImage?.ImageFile, ImageX.StandardImage.NoImage);
    public bool IsFieldScoped => FieldId.HasValue;

    public Address? Address { get; set; }
    public AppImage? AppImage { get; set; }
    public ContactDetail? Contact { get; set; }
    public Field? Field { get; set; }
    public required Ibu Ibu { get; set; }

    public virtual ICollection<FieldProcurementSetting> FieldProcurementSettings { get; set; } = [];
    public virtual ICollection<Expense> Expenses { get; set; } = [];
    public virtual ICollection<Machine> Machineries { get; set; } = [];
    public virtual ICollection<OrdNum> OrdNums { get; set; } = [];
    public virtual ICollection<ProductSupplier> ProductSuppliers { get; set; } = [];
    public virtual ICollection<RequestSupplier> RequestSuppliers { get; set; } = [];
    public virtual ICollection<SupplierAddress> SupplierAddresses { get; set; } = [];
    public virtual ICollection<SupplierContact> SupplierContacts { get; set; } = [];
}
