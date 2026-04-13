namespace AmsModels;

public partial class SoilType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SoilTypeId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(100)]
    public string SoiTypName { get; set; } = "";
    public bool Active { get; set; } = true;
}