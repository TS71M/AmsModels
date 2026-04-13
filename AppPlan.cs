namespace AmsModels;

public class AppPlan
{
    [Key]
    public int AppPlanId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int AgrAppProductId { get; set; }

    [Required]
    public int AgrTaskId { get; set; }

    [Required]
    public int WeekNumber { get; set; }

    public required AgrAppProduct AgrAppProduct { get; set; }
    public required AgrTask AgrTask { get; set; }

}