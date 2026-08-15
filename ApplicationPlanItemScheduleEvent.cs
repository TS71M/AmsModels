namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ApplicationPlanItemId), nameof(CreatedAtUtc))]
public sealed class ApplicationPlanItemScheduleEvent
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ApplicationPlanItemScheduleEventId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int ApplicationPlanItemId { get; set; }
    public ApplicationPlanItemScheduleEventType EventType { get; set; }
    public ApplicationPlanItemScheduleStatus FromStatus { get; set; }
    public ApplicationPlanItemScheduleStatus ToStatus { get; set; }
    public DateOnly FromScheduledLocalDate { get; set; }
    public DateOnly? ToScheduledLocalDate { get; set; }
    public ApplicationPlanItemScheduleReason Reason { get; set; }

    [Required, MaxLength(1000)]
    public string Note { get; set; } = "";

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public int CreatedByUserId { get; set; }

    public required ApplicationPlanItem ApplicationPlanItem { get; set; }
    public required User CreatedByUser { get; set; }
}
