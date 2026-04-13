namespace AmsModels;

public partial class WeekPlanner
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int WeekPlannerId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int TaskGlobalId { get; set; }
    public int AgrTaskWeekId { get; set; }

    public string AreaJobDesHoles => AgrTaskWeek.AgrTask.AreaJobDesHoles;
    public string JobDesHoles => AgrTaskWeek.AgrTask.JobDesHoles;
    public string AreaName => AgrTaskWeek.AgrTask.AreaName;

    public required AgrTaskWeek AgrTaskWeek { get; set; }
    public required TaskGlobal TaskGlobal { get; set; }
}