namespace AmsModels;

public partial class StaffPlanner
{
    [Key]
    public int StaPlaId { get; set; }
    public int AccountId { get; set; }
    public int YearId { get; set; }
    public int StaPosId { get; set; }
    public decimal EstSal { get; set; }
    public decimal CalSal { get; set; }
    //public decimal Jan { get; set; }
    //public decimal Feb { get; set; }
    //public decimal Mar { get; set; }
    //public decimal Apr { get; set; }
    //public decimal May { get; set; }
    //public decimal Jun { get; set; }
    //public decimal Jul { get; set; }
    //public decimal Aug { get; set; }
    //public decimal Sep { get; set; }
    //public decimal Oct { get; set; }
    //public decimal Nov { get; set; }
    //public decimal Dec { get; set; }

    public required Account Account { get; set; }
    public required StaPos StaPos { get; set; }
    public required Year Year { get; set; }

    public virtual ICollection<StaffPlannerMonth> StaPlaMonths { get; set; } = [];
}