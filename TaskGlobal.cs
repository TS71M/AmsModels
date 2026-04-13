namespace AmsModels;

public partial class TaskGlobal
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GlobalId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int FieldId { get; set; }
    public DateTime TaskGlobalDate { get; set; }

    public required Field Field { get; set; }

    public virtual ICollection<PinPosition> PinPositions { get; set; } = [];
    public virtual ICollection<TaskArea> TaskAreas { get; set; } = [];
    public virtual ICollection<TaskWork> TaskWorks { get; set; } = [];
    public virtual ICollection<WeekPlanner> WeekPlanners { get; set; } = [];
}