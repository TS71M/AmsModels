namespace AmsModels;

[Index(nameof(PlanTriggerEventId), nameof(ApplicationPlanItemId), IsUnique = true)]
public class PlanTriggerAffectedApplication
{
    public int PlanTriggerEventId { get; set; }
    public int ApplicationPlanItemId { get; set; }

    public required PlanTriggerEvent PlanTriggerEvent { get; set; }
    public required ApplicationPlanItem ApplicationPlanItem { get; set; }
}
