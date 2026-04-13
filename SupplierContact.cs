using Lib.Images;

namespace AmsModels;

public class SupplierContact
{
    [Key]
    public int SupplierContactId { get; set; }
    public int SupplierId { get; set; }
    public int? NameId { get; set; }
    public int? ContactId { get; set; }
    public int? ImageId { get; set; }
    [Required, MaxLength(100)]
    public string Position { get; set; } = "";
    public bool IsPrimary { get; set; }
    public bool IsActive { get; set; } = true;

    public string FullName => Name?.FullName ?? "";
    public string Image => ImageX.ImageToString(AppImage?.ImageFile, ImageX.StandardImage.NoPerson);

    public AppImage? AppImage { get; set; }
    public ContactDetail? Contact { get; set; }
    public Name? Name { get; set; }
    public required Supplier Supplier { get; set; }
}
