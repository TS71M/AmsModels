namespace AmsModels;

public partial class AgrAppTask
{
    [Key]
    public int AgrAppTaskId { get; set; }

    [Required]
    public int AgrTaskId { get; set; }

    [Required]
    public int AgrAppProductId { get; set; }

    [Required]
    public int VersionId { get; set; }

    public required AgrTask AgrTask { get; set; }
    public required AgrAppProduct AgrAppProduct { get; set; }
    public required PlanningVersion PlanningVersion { get; set; }

    public virtual ICollection<AgrApp> AgrApps { get; set; } = [];
}