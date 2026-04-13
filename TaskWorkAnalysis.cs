namespace AmsModels;

public class TaskWorkAnalysis
{
    public int TaskWorkAnalysisId { get; set; }
    public int TaskWorkId { get; set; }
    public double PlannedHours { get; set; }
    public double ActualHours { get; set; }
    public double Deviation => ActualHours - PlannedHours;
    public string? Suggestion { get; set; }
}