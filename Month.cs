namespace AmsModels;

public partial class Month
{
    [Key]
    public int MonthId { get; set; }

    [Required, MaxLength(250)]
    public string MonthName { get; set; } = "";

    [Required, MaxLength(3)]
    public string MonthShort { get; set; } = "";

    public virtual ICollection<Expense> Expenses { get; set; } = [];
    public virtual ICollection<ShiftPlanner> ShiftPlanners { get; set; } = [];
    public virtual ICollection<StaffPlannerMonth> StaPlaMonths { get; set; } = [];

}