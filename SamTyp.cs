namespace AmsModels;

public partial class SamTyp
{
    [Key]
    public int SamTypId { get; set; }

    [Required, MaxLength(50)]
    public string SamTypName { get; set; } = "";

    public virtual ICollection<SamNum> SamNums { get; set; } = [];
}