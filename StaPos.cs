namespace AmsModels;

public partial class StaPos
{
    [Key]
    public int StaPosId { get; set; }

    [Required]
    public int IbuId { get; set; }
    public int? FieldId { get; set; }
    public int DepartmentId { get; set; }

    [Required, DisplayName("Staff Positions"), MaxLength(250)]
    public string StaPosDes { get; set; } = "";
    public int PayrollId { get; set; } = 1;
    public decimal EstSal { get; set; }
    public bool Active { get; set; } = true;

    public required Department Department { get; set; }
    public Field? Field { get; set; }
    public required Ibu Ibu { get; set; }
    public required Payroll Payroll { get; set; }

    public virtual ICollection<StaffPlanner> StaPlas { get; set; } = [];
    public virtual ICollection<Staff> Staffs { get; set; } = [];
}