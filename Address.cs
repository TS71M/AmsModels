namespace AmsModels;

public enum ParentEntityType
{
    Ibu,
    Address,
    Architect,
    Coordinates,
    DoG,
    Field,
    Supplier,
    User
}

public partial class Address
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AddressId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int? IbuId { get; set; }

    [Required]
    [MaxLength(250)]
    public string Address1 { get; set; } = "";

    [MaxLength(250)]
    public string? Address2 { get; set; }

    [MaxLength(100)]
    public string? State { get; set; }

    [Required]
    [MaxLength(60)]
    public string Town { get; set; } = "";

    [Required]
    [MaxLength(60)]
    public string Zip { get; set; } = "";
    public int CountryId { get; set; }

    public Ibu? Ibu { get; set; }
    public Country? Country { get; set; }

    public virtual ICollection<SupplierAddress> SupplierAddresses { get; set; } = [];

}
