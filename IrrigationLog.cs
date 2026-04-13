namespace AmsModels;

public partial class IrrigationLog
{
    [Key]
    public int IrrLogId { get; set; }

    [Display(Name = "Date")]
    public DateTime IrrDate { get; set; }

    [Display(Name = "Area")]
    public int AreaId { get; set; }

    [Display(Name = "per Surface")]
    public decimal Et { get; set; }
    public decimal Quantity { get; set; }
    public int UniWeiId { get; set; }

    [Display(Name = "Amount")]
    public virtual string QuantityL => Quantity + UniWei.UnitShort;
    public virtual string UniSurL => Area?.Field?.SurfaceUniId is null ? string.Empty : Area.Field.SurfaceUniId == 1 ? "mm" : "in";

    [Display(Name = "per Surface")]
    public virtual string EtL => Et + UniSurL;

    public required Area Area { get; set; }
    public required Unit UniWei { get; set; }
}