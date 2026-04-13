namespace AmsModels;

public partial class SizFra
{
    [Key]
    public int SizFraId { get; set; }

    [Required, MaxLength(100)]
    public string SizFraName { get; set; } = "";

    public virtual ICollection<Sample> Samples { get; set; } = [];

}