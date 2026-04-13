namespace AmsModels;

public partial class PlanningVersion
{
    [Key]
    public int PlanningVersionId { get; set; }
    public int FieldId { get; set; }
    public int YearId { get; set; }
    public int VersionNumber { get; set; }
    public bool AgrCal { get; set; }
    public bool AgrApp { get; set; }
    public bool Budget { get; set; }

    [Required, MaxLength(250)]
    public string Description { get; set; } = "";

    public string Display => $"{VersionNumber} {Description}";

    public required Field Field { get; set; }
    public required Year Year { get; set; }

    public virtual ICollection<AgrAppTask> AgrAppTasks { get; set; } = [];
    public virtual ICollection<BudgetNum> BudgetNums { get; set; } = [];
}