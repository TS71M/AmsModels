namespace AmsModels;

public class StaffPlannerMonth
{
    [Key]
    public int StaPlaMonthId { get; set; }
    public int StaPlaId { get; set; }
    public int MonthId { get; set; }
    public decimal Salary { get; set; }

    public required Month Month { get; set; }
    public required StaffPlanner StaPla { get; set; }
}
