namespace AmsModels;

public partial class Year
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int YearId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Display(Name = "Year")]
    public int YearNumber { get; set; }

    public bool IsCurrent { get; set; }

    public bool IsVisible { get; set; } = true;

    public bool IsClosed { get; set; }

    public virtual ICollection<AgrAppProduct> AgrAppProducts { get; set; } = [];
    public virtual ICollection<AgrTask> AgrTasks { get; set; } = [];
    public virtual ICollection<BudgetNum> BudgetNums { get; set; } = [];
    public virtual ICollection<ConBilNum> ConBilNums { get; set; } = [];
    public virtual ICollection<DelBilNum> DelBilNums { get; set; } = [];
    public virtual ICollection<Expense> Expenses { get; set; } = [];
    public virtual ICollection<GeneralRemark> GeneralRemarks { get; set; } = [];
    public virtual ICollection<IbuYearActive> IbuYearActives { get; set; } = [];
    public virtual ICollection<Operation> Operations { get; set; } = [];
    public virtual ICollection<OrdNum> OrdNums { get; set; } = [];
    public virtual ICollection<PlanningVersion> PlanningVersions { get; set; } = [];
    public virtual ICollection<PriInqNum> PriInqNums { get; set; } = [];
    public virtual ICollection<ShiftPlanner> ShiftPlanners { get; set; } = [];

}
