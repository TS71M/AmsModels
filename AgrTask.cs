namespace AmsModels;

public partial class AgrTask
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AgrTaskId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int YearId { get; set; }

    [Required]
    public int AreaId { get; set; }

    [Required]
    public int JobId { get; set; }
    public string Holes { get; set; } = "";

    [NotMapped]
    public virtual string AreaName => Area != null ? Area.AreaName : "";

    [NotMapped]
    public virtual string JobDes => Job != null ? Job.JobDes : "";

    [NotMapped]
    public virtual string JobDesHoles => JobDes + " " + Holes;

    [NotMapped]
    public virtual string AreaJobDes => AreaName + " " + JobDes;

    [NotMapped]
    public virtual string AreaJobDesHoles => AreaName + " " + JobDes + (Holes.Length > 0 ? " - " + Holes : "");

    public required Area Area { get; set; }
    public required Job Job { get; set; }
    public required Year Year { get; set; }

    public virtual ICollection<AgrTaskHole> AgrTaskHoles { get; set; } = [];
    public virtual ICollection<AgrTaskWeek> AgrTaskWeeks { get; set; } = [];
    public virtual ICollection<AgrAppTask> AgrAppTasks { get; set; } = [];
    public virtual ICollection<AppPlan> AppPlans { get; set; } = [];
}