namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(Status), nameof(SubmittedUtc))]
[Index(nameof(IbuId), nameof(SubmittedUtc))]
[Index(nameof(UserId), nameof(SubmittedUtc))]
public sealed class MobileBugReport
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MobileBugReportId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int? IbuId { get; set; }
    public Ibu? Ibu { get; set; }

    public int? UserId { get; set; }
    public User? User { get; set; }

    public DateTime SubmittedUtc { get; set; }

    [Required, MaxLength(40)]
    public string Status { get; set; } = "New";

    [Required, MaxLength(200)]
    public string Title { get; set; } = "";

    [Required, MaxLength(4000)]
    public string Description { get; set; } = "";

    [MaxLength(80)]
    public string? Category { get; set; }

    [MaxLength(40)]
    public string? Severity { get; set; }

    [MaxLength(160)]
    public string? PageName { get; set; }

    [MaxLength(40)]
    public string? AppVersion { get; set; }

    [MaxLength(40)]
    public string? AppBuild { get; set; }

    [MaxLength(40)]
    public string? Platform { get; set; }

    [MaxLength(120)]
    public string? DeviceModel { get; set; }

    [MaxLength(120)]
    public string? Manufacturer { get; set; }

    [MaxLength(80)]
    public string? OsVersion { get; set; }

    [MaxLength(40)]
    public string? Idiom { get; set; }

    [MaxLength(180)]
    public string? ScreenshotFileName { get; set; }

    [MaxLength(80)]
    public string? ScreenshotContentType { get; set; }

    public byte[]? ScreenshotBytes { get; set; }

    public bool EmailSent { get; set; }
    public DateTime? EmailSentUtc { get; set; }

    [MaxLength(500)]
    public string? EmailError { get; set; }

    public DateTime? LastAutomationCheckUtc { get; set; }

    [MaxLength(4000)]
    public string? AutomationNotes { get; set; }
}
