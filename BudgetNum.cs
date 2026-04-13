namespace AmsModels;

public partial class BudgetNum
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BudgetNumId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required]
    [Display(Name = "Year")]
    public int YearId { get; set; }

    [Required]
    [Display(Name = "Version")]
    public int PlanningVersionId { get; set; }

    [Display(Name = "Date of Approval")]
    public DateTime? ApprovalDate { get; set; } = null;

    [Display(Name = "Approved by")]
    public int? ApprovedById { get; set; }

    [Display(Name = "Budget closed")]
    public bool Closed { get; set; } = false;

    [MaxLength(250)]
    public string Description { get; set; } = "";


    [Display(Name = "Version")]
    public string VersionL => PlanningVersion != null ? PlanningVersion.VersionNumber.ToString() : "-";

    [Display(Name = "Version")]
    public string BudgetTotal => Budgets != null ? Budgets.Sum(b => b.Total).ToString("N2") : "-";
    public string ApprovalDateL => ApprovalDate.HasValue ? ApprovalDate.Value.ToShortDateString() : "-";
    public string ApprovedByL => ApprovedById.HasValue ? User?.Name?.FullName ?? "-" : "-";
    public bool Approved => ApprovedById is not null;

    public required Field Field { get; set; }
    public required PlanningVersion PlanningVersion { get; set; }
    public required Year Year { get; set; }

    public User? User { get; set; }

    public virtual ICollection<Budget> Budgets { get; set; } = [];
}