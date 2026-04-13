namespace AmsModels;

public partial class ClippMeas
{
    [Key]
    public int ClippMeasId { get; set; }

    [Required]
    public int ClippAreaId { get; set; }

    [Required]
    public DateTime MesTime { get; set; }
    public decimal MesQua { get; set; }

    public required ClippArea ClippArea { get; set; }
}