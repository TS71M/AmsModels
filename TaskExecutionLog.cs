namespace AmsModels;

public class TaskExecutionLog
{
    [Key]
    public int TaskExecutionLogId { get; set; }

    public int TaskWorkId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    [MaxLength(500)]
    public string? Note { get; set; }
    public bool IsManualEntry { get; set; } = false;

    public required TaskWork TaskWork { get; set; }

    public virtual TimeSpan ExecutionTime => EndTime - StartTime;
}
