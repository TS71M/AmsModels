namespace AmsModels;

public partial class LicenseHistory
{
    [Key]
    public int LicenseHistoryId { get; set; }
    public int IbuId { get; set; }
    public int LicenseId { get; set; }
    public DateTime PurchaseDate { get; set; }

    public required Ibu Ibu { get; set; }
    public required License License { get; set; }

}