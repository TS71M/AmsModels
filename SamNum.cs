namespace AmsModels;

public partial class SamNum
{
    [Key]
    public int SamNumId { get; set; }
    public int FieldId { get; set; }

    [Required, MaxLength(250)]
    public string SamNumName { get; set; } = "";
    public DateTime SamNumDat { get; set; }
    public int SamTypId { get; set; }

    public required Field Field { get; set; }
    public required SamTyp SamTyp { get; set; }

    public virtual ICollection<Sample> Samples { get; set; } = [];
}