namespace AmsModels;

public partial class GeneralRemark
{
    [Key]
    public int GeneralRemarkId { get; set; }
    public int IbuId { get; set; }
    public int YearId { get; set; }
    public int Week { get; set; }

    [Required, MaxLength(5000)]
    public string GeneralRemarkText { get; set; } = "";

    public required Ibu Ibu { get; set; }
    public required Year Year { get; set; }
}