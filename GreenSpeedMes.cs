namespace AmsModels;

public partial class GreenSpeedMes
{
    [Key]
    public int GreenSpeedMesId { get; set; }
    public int GreenSpeedId { get; set; }
    public DateTime MesTime { get; set; }
    public decimal MesSpeed { get; set; }
    public virtual int AreaId => GreenSpeed.AreaId;

    public required GreenSpeed GreenSpeed { get; set; }
}