namespace AmsModels;

public partial class Sprayer
{
    [Key]
    public int SprayerId { get; set; }
    public int FieldId { get; set; }

    [Required, MaxLength(250)]
    public string SprDes { get; set; } = "";
    public decimal TanSiz { get; set; }
    public int UniWeiId { get; set; }
    public decimal SprayRate { get; set; }
    public int SprayRateUniSurId { get; set; }
    public int SprayRateUniWeiId { get; set; }
    public bool Active { get; set; } = true;
    public bool Preferred { get; set; }
    public string SprayerDetails => SprDes + " @" + SprayRate.ToString("N1") + " " + SprayRateUniWei.UnitShort + "/" + SprayRateUniSur.UnitShort;
    public string SprayerUnits => SprayRateUniWei.UnitShort + '/' + SprayRateUniSur.UnitShort;
    public string SprayerSize => TanSiz + UniWei.UnitShort;

    public required Field Field { get; set; }
    public required Unit SprayRateUniSur { get; set; }
    public required Unit SprayRateUniWei { get; set; }
    public required Unit UniWei { get; set; }

}