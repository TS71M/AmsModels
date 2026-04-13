namespace AmsModels;

public partial class Shift
{
    [Key]
    public int ShiftId { get; set; }

    [Required]
    public int IbuId { get; set; }
    public int? FieldId { get; set; }

    [Required, MaxLength(250)]
    public string ShiftName { get; set; } = "";
    public TimeSpan ShiftStart { get; set; }
    public TimeSpan ShiftEnd { get; set; }
    public bool Active { get; set; } = true;
    public bool Standard { get; set; }
    public bool Obligate { get; set; }

    public Field? Field { get; set; }
    public required Ibu Ibu { get; set; }

    public virtual ICollection<ShiftPlanner> ShiftPlanners { get; set; } = [];
}