namespace AmsModels;

public partial class ShiftPlanner
{
    [Key]
    public int ShiftPlannerId { get; set; }
    public int FieldId { get; set; }
    public int StaffId { get; set; }
    public bool Booked { get; set; }
    public int YearId { get; set; }
    public int MonthId { get; set; }
    public DateOnly WorkDate { get; set; }
    public int ShiftId { get; set; }

    public required Field Field { get; set; }
    public required Month Month { get; set; }
    public required Shift Shift { get; set; }
    public required Staff Staff { get; set; }
    public required Year Year { get; set; }
}