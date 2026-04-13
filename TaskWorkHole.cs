using Lib.Enums;

namespace AmsModels;

public partial class TaskWorkHole
{
    [Key]
    public int TaskWorkHoleId { get; set; }
    public int TaskWorkId { get; set; }
    public int HoleId { get; set; }
    public int SurfaceId { get; set; }
    public TaskWorkHoleType HoleType { get; set; }

    public required Hole Hole { get; set; }
    public required Surface Surface { get; set; }
    public required TaskWork TaskWork { get; set; }
}