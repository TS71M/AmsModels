namespace AmsModels;

public partial class Job
{
    [Key]
    public int JobId { get; set; }

    [Required]
    public int IbuId { get; set; }
    public int? FieldId { get; set; }

    [Display(Name = "Job Descritpion")]
    public string JobDes { get; set; } = "";

    [Display(Name = "Job Remarks")]
    public string JobRem { get; set; } = "";
    public bool Active { get; set; } = true;

    [Display(Name = "Using in Application Planner?")]
    public bool IsAppPlan { get; set; }

    [Display(Name = "Standard Duration")]
    [RegularExpression(@"^([01]\d|2[0-3]):(00|15|30|45)$", ErrorMessage = "Time must be in 15-minute steps from 00:00 to 23:45")]
    public TimeSpan StdDuration { get; set; }

    public Field? Field { get; set; }
    public required Ibu Ibu { get; set; }

    public virtual ICollection<AgrTask> AgrTasks { get; set; } = [];
    public virtual ICollection<Operation> Operations { get; set; } = [];
    public virtual ICollection<Skill> Skillss { get; set; } = [];
}