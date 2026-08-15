namespace AmsModels;

/// <summary>
/// Maps one IBU-owned, area-independent Job to one globally comparable task.
/// </summary>
public sealed class JobComparableTaskMapping
{
    [Key]
    public int JobComparableTaskMappingId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int JobId { get; set; }
    public int ComparableTaskId { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public required Job Job { get; set; }
    public required ComparableTask ComparableTask { get; set; }
}
