namespace AmsModels;

/// <summary>
/// A globally comparable, area-independent work action. The area is attached
/// later by the planning model (for example, through AgrTask.AreaId).
/// </summary>
public sealed class ComparableTask
{
    [Key]
    public int ComparableTaskId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(50)]
    public string Code { get; set; } = "";

    [Required, MaxLength(120)]
    public string Name { get; set; } = "";

    [MaxLength(1000)]
    public string Description { get; set; } = "";

    public bool Active { get; set; } = true;

    public ICollection<JobComparableTaskMapping> JobMappings { get; set; } = [];
}
