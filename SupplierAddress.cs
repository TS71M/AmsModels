namespace AmsModels;

public class SupplierAddress
{
    [Key]
    public int SupplierAddressId { get; set; }
    public int SupplierId { get; set; }
    public int AddressId { get; set; }

    [Required, MaxLength(50)]
    public string AddressType { get; set; } = "Main";

    public bool IsPrimary { get; set; }
    public bool IsActive { get; set; } = true;

    public required Address Address { get; set; }
    public required Supplier Supplier { get; set; }
}
