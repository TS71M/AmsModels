namespace AmsModels;

public partial class BanHol
{
    [Key]
    public int BanHolId { get; set; }

    [Required]
    public int IbuId { get; set; }

    [Required]
    public string BanHolDes { get; set; } = "";

    [Required]
    public DateTime BanHolDat { get; set; }
    public bool Yearly { get; set; }
    public bool MembersEvent { get; set; }
    public bool SocialEvent { get; set; }
    public bool CorporateEvent { get; set; }
    public bool EgfEvent { get; set; }
    public bool TOEvent { get; set; }
    public string EventDate => BanHolDat.ToShortDateString();

    public required Ibu Ibu { get; set; }
}