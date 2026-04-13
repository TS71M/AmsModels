using Lib.Enums;

namespace AmsModels;

public partial class TaskWork
{
    [Key]
    public int TaskWorkId { get; set; }
    public int Task { get; set; }
    public int GlobalId { get; set; }
    public int StaffId { get; set; }
    public int AgrTaskWeekId { get; set; }
    public int JobN { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public string Remarks { get; set; } = "";
    public bool Executed { get; set; }
    public string RemarksExecuted { get; set; } = "";
    public bool Booked { get; set; } = false;
    public bool? Print { get; set; }
    public bool MarkedToBook;

    public virtual string HolesPlanned => string.Join(", ", TaskWorkHoles
        .Where(twhp => twhp.HoleType == TaskWorkHoleType.Planned)
        .Select(twhp => twhp.Hole.HolShoNam)
        .ToList());
    public virtual string HolesExecuted => string.Join(", ", TaskWorkHoles
        .Where(twhp => twhp.HoleType == TaskWorkHoleType.Executed)
        .Select(twhe => twhe.Hole.HolShoNam)
        .ToList());
    public virtual string TaskWorkJobDesHolesPlanned => $"{AgrTaskWeek.AgrTask.AreaName} {AgrTaskWeek.AgrTask.JobDes} {HolesPlanned}";
    public virtual string TaskWorkJobDesHolesExecuted => $"{AgrTaskWeek.AgrTask.AreaName} {AgrTaskWeek.AgrTask.JobDes} {HolesExecuted}";
    public virtual string StartTimeJobBoard => $"{StartTime.Hours}:{StartTime.Minutes}";
    public virtual TimeSpan ExecutedTime => TaskExecutionLogs.Count > 0 ? TimeSpan.FromTicks(TaskExecutionLogs.Sum(tel => tel.ExecutionTime.Ticks)) : TimeSpan.Zero;
    public virtual string PlannedTimeH => $"{new TimeSpan(EndTime.Ticks - StartTime.Ticks).TotalHours:N1}h";
    public virtual string ExecutedTimeH => $"{ExecutedTime.TotalHours:N1}h";

    public required AgrTaskWeek AgrTaskWeek { get; set; }
    public required Staff Staff { get; set; }
    public required TaskGlobal TaskGlobal { get; set; }

    public virtual ICollection<TaskExecutionLog> TaskExecutionLogs { get; set; } = [];
    public virtual ICollection<TaskWorkHole> TaskWorkHoles { get; set; } = [];
    public virtual ICollection<TaskWorkMachine> TaskWorkMachines { get; set; } = [];
}