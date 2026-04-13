namespace AmsModels;

public partial class LicenseIbu
{
    [Key]
    public int LicenseIbuId { get; set; }
    public int LicenseId { get; set; }
    public int IbuId { get; set; }
    public DateTime PurchaseDate { get; set; }

    public required Ibu Ibu { get; set; }
    public required License License { get; set; }

}