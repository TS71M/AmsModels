namespace AmsModels;

[Index(nameof(FieldId), IsUnique = true)]
public sealed class DollarSpotEarlyWarningSetting
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DollarSpotEarlyWarningSettingId { get; set; }

    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required]
    public bool Enabled { get; set; }

    public bool? DollarSpotHistoryKnown { get; set; }

    [Required]
    [MaxLength(48)]
    public string ModelRevision { get; set; } = "canopy-adjusted-v0.1";

    [MaxLength(16)]
    public string? AutomaticSeasonState { get; set; }

    [Range(0, 7)]
    public int AutomaticOutsideWindowDays { get; set; }

    public DateOnly? AutomaticSeasonLastEvaluatedDateLocal { get; set; }

    public DateTime? EnabledUtc { get; set; }
    public int? EnabledByUserId { get; set; }
    public int? ResponsibleUserId { get; set; }

    [Required]
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;

    [Required]
    public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;

    public Field Field { get; set; } = null!;
    public User? EnabledByUser { get; set; }
    public User? ResponsibleUser { get; set; }
}

[Index(nameof(FieldId), nameof(ObservationDateLocal), IsUnique = true)]
public sealed class DollarSpotDailyObservation
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DollarSpotDailyObservationId { get; set; }

    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required]
    public DateOnly ObservationDateLocal { get; set; }

    public bool? MorningMyceliumObserved { get; set; }
    public bool? LeafLesionsObserved { get; set; }
    public bool? ActiveExpansionObserved { get; set; }
    public bool? LdsOrHydrophobicityPresent { get; set; }
    public bool? DewManuallyRemoved { get; set; }
    public TimeOnly? DewRemovedAtLocal { get; set; }
    public TimeOnly? DewRemovalStartedAtLocal { get; set; }
    public TimeOnly? DewRemovalCompletedAtLocal { get; set; }

    [Range(0, 100)]
    public decimal? DewRemovalCoveragePct { get; set; }

    [Required]
    public int SubmittedByUserId { get; set; }

    [Required]
    public DateTime SubmittedUtc { get; set; } = DateTime.UtcNow;

    [Required]
    public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;

    public Field Field { get; set; } = null!;
    public User SubmittedByUser { get; set; } = null!;
}

[Index(nameof(FieldId), nameof(UserId), IsUnique = true)]
public sealed class DollarSpotReminderPreference
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DollarSpotReminderPreferenceId { get; set; }

    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    public bool ReminderEnabled { get; set; } = true;

    [Required]
    [MaxLength(16)]
    public string SeasonMode { get; set; } = "automatic";

    [Required]
    public TimeOnly ReminderLocalTime { get; set; } = new(7, 30);

    [MaxLength(48)]
    public string? LastOnboardingModelRevision { get; set; }

    public DateTime? OnboardingDismissedUtc { get; set; }

    [Required]
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;

    [Required]
    public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;

    public Field Field { get; set; } = null!;
    public User User { get; set; } = null!;
}

[Index(nameof(FieldId), nameof(NotificationDateLocal), nameof(Kind), IsUnique = true)]
public sealed class DollarSpotNotificationDelivery
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DollarSpotNotificationDeliveryId { get; set; }

    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    public DateOnly NotificationDateLocal { get; set; }

    [Required]
    [MaxLength(32)]
    public string Kind { get; set; } = "dailyCheck";

    [Required]
    [MaxLength(16)]
    public string Status { get; set; } = "pending";

    public DateTime? AttemptedUtc { get; set; }
    public DateTime? SentUtc { get; set; }

    [MaxLength(512)]
    public string? Error { get; set; }

    public Field Field { get; set; } = null!;
    public User User { get; set; } = null!;
}
