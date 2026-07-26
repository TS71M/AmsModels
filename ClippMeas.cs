namespace AmsModels;

public partial class ClippMeas
{
    [Key]
    public int ClippMeasId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int SurfaceId { get; set; }

    [Required]
    public DateTime MesTime { get; set; }
    public decimal MesQua { get; set; }

    public required Surface Surface { get; set; }
}
