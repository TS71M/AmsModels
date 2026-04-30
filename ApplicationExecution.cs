namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(AnnualApplicationPlanId), nameof(ExecutedDate))]
[Index(nameof(ApplicationPlanItemId))]
public class ApplicationExecution
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ApplicationExecutionId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int AnnualApplicationPlanId { get; set; }

    public int? ApplicationPlanItemId { get; set; }
    public DateTime ExecutedDate { get; set; }
    public int? ActualProductId { get; set; }

    [Precision(10, 3)]
    public decimal ActualRate { get; set; }

    [Precision(12, 2)]
    public decimal ActualCost { get; set; }

    [MaxLength(4000)]
    public string WeatherAtExecutionJson { get; set; } = "";

    [MaxLength(2000)]
    public string Notes { get; set; } = "";

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public required AnnualApplicationPlan AnnualApplicationPlan { get; set; }
    public ApplicationPlanItem? ApplicationPlanItem { get; set; }
    public Product? ActualProduct { get; set; }
}
