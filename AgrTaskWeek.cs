namespace AmsModels;

public partial class AgrTaskWeek
{
    [Key]
    public int AgrTaskWeekId { get; set; }
    public int AgrTaskId { get; set; }
    public int StartWeek { get; set; }
    public int EndWeek { get; set; }
    public int Repetition { get; set; }
    public bool Declined { get; set; }
    public string? Comment { get; set; }
    public double Progress { get; set; }
    public int DayType { get; set; }

    public virtual int YearId => AgrTask?.YearId ?? 0;
    public virtual int AreaId => AgrTask?.AreaId ?? 0;
    public virtual string Area1 => AgrTask != null && AgrTask.Area != null ? AgrTask.Area.AreaName : "";
    public virtual string JobDes => AgrTask?.Job != null ? AgrTask.Job.JobDes : "";
    public string Holes => AgrTask != null ? AgrTask.Holes : "";
    public virtual string JobDesHoles => JobDes + " " + Holes;

    public required AgrTask AgrTask { get; set; }

    public virtual ICollection<AgrTaskWeekHole> AgrTaskWeekHoles { get; set; } = [];
    public virtual ICollection<ConBil> ConBils { get; set; } = [];
    public virtual ICollection<WeekPlanner> WeekPlanners { get; set; } = [];
    public virtual ICollection<AgrApp> AgrApps { get; set; } = [];
    public virtual ICollection<TaskWork> TaskWorks { get; set; } = [];
}