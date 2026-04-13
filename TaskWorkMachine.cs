namespace AmsModels;

public partial class TaskWorkMachine
{
    [Key]
    public int TaskWorkMachineId { get; set; }
    public int TaskWorkId { get; set; }
    public int MachineId { get; set; }

    public required Machine Machine { get; set; }
    public required TaskWork TaskWork { get; set; }
}