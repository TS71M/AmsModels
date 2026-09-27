namespace AmsModels;

/// <summary>One deliberately selected operational revision per field and planning year.</summary>
public sealed class ApplicationPlanOperationalSelection
{
    public int FieldId { get; set; }
    public int Year { get; set; }
    public int ApplicationPlanRevisionId { get; set; }
    public Guid ConcurrencyToken { get; set; }
    public DateTime SelectedAtUtc { get; set; }
    public required Field Field { get; set; }
    public required ApplicationPlanRevision ApplicationPlanRevision { get; set; }
}
