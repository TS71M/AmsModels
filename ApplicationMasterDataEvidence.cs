using Lib.Enums;

namespace AmsModels;

/// <summary>
/// Immutable source evidence for exactly one product or machine. Extraction may
/// propose facts, but only a reviewed owning-service command may update a master.
/// </summary>
public sealed class ApplicationEvidenceSource
{
    public int ApplicationEvidenceSourceId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public int IbuId { get; set; }
    public int? ProductId { get; set; }
    public int? MachineId { get; set; }
    public ApplicationEvidenceKind EvidenceKind { get; set; }
    public ApplicationEvidenceSourceKind SourceKind { get; set; }
    public ApplicationEvidenceTrustLevel TrustLevel { get; set; }
    public ApplicationEvidenceReviewStatus ReviewStatus { get; set; }
    public ApplicationEvidenceReviewOrigin ReviewOrigin { get; set; }
    [MaxLength(250)] public string Title { get; set; } = "";
    [MaxLength(1000)] public string SourceUri { get; set; } = "";
    [MaxLength(253)] public string SourceHost { get; set; } = "";
    [MaxLength(1000)] public string StorageReference { get; set; } = "";
    [MaxLength(120)] public string ContentType { get; set; } = "";
    public long? ContentLengthBytes { get; set; }
    [MaxLength(64)] public string ContentSha256 { get; set; } = "";
    [MaxLength(80)] public string DocumentRevision { get; set; } = "";
    [MaxLength(80)] public string JurisdictionCode { get; set; } = "";
    public DateOnly? EffectiveFrom { get; set; }
    public DateOnly? EffectiveTo { get; set; }
    public DateTime RetrievedAtUtc { get; set; }
    public ApplicationEvidenceFreshnessStatus FreshnessStatus { get; set; }
    public DateTime? SourceCheckedAtUtc { get; set; }
    public DateTime? SourceCheckDueAtUtc { get; set; }
    public DateTime? SourceContentChangedAtUtc { get; set; }
    public int SourceCheckFailureCount { get; set; }
    [MaxLength(64)] public string ObservedContentSha256 { get; set; } = "";
    [MaxLength(120)] public string ExtractionModel { get; set; } = "";
    [Precision(5, 4)] public decimal ExtractionConfidence { get; set; }
    [MaxLength(8000)] public string ExtractionWarningsJson { get; set; } = "[]";
    public int CreatedByUserId { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public int? ReviewedByUserId { get; set; }
    public DateTime? ReviewedAtUtc { get; set; }
    public int? SupersedesEvidenceSourceId { get; set; }
    public bool Active { get; set; } = true;
    public Guid ConcurrencyToken { get; set; } = Guid.NewGuid();

    public required Ibu Ibu { get; set; }
    public Product? Product { get; set; }
    public Machine? Machine { get; set; }
    public required User CreatedByUser { get; set; }
    public User? ReviewedByUser { get; set; }
    public ApplicationEvidenceSource? SupersedesEvidenceSource { get; set; }
    public ICollection<ApplicationEvidenceSource> SupersededBy { get; set; } = [];
    public ApplicationEvidenceContent? Content { get; set; }
    public ICollection<ApplicationEvidenceSuggestion> Suggestions { get; set; } = [];
    public ICollection<ProductRegulatoryProfile> ProductRegulatoryProfiles { get; set; } = [];
    public ICollection<MachineApplicationProfile> MachineApplicationProfiles { get; set; } = [];
}

/// <summary>
/// Original bytes for user-uploaded evidence. Kept in a separate one-to-one
/// table so ordinary evidence queries never materialize large documents.
/// </summary>
public sealed class ApplicationEvidenceContent
{
    public int ApplicationEvidenceSourceId { get; set; }
    public byte[] ContentBytes { get; set; } = [];
    public DateTime CreatedAtUtc { get; set; }

    public required ApplicationEvidenceSource EvidenceSource { get; set; }
}

/// <summary>A source-local proposed fact. Approved does not itself mutate a master.</summary>
public sealed class ApplicationEvidenceSuggestion
{
    public int ApplicationEvidenceSuggestionId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public int ApplicationEvidenceSourceId { get; set; }
    [MaxLength(120)] public string FieldKey { get; set; } = "";
    [MaxLength(16000)] public string ProposedValueJson { get; set; } = "null";
    [MaxLength(16000)] public string? ReviewedValueJson { get; set; }
    [MaxLength(64)] public string NormalizedValueSha256 { get; set; } = "";
    [MaxLength(40)] public string UnitCode { get; set; } = "";
    [MaxLength(250)] public string SourceLocation { get; set; } = "";
    [Precision(5, 4)] public decimal Confidence { get; set; }
    public bool IsSafetyCritical { get; set; }
    public ApplicationEvidenceReviewStatus ReviewStatus { get; set; }
    public ApplicationEvidenceReviewOrigin ReviewOrigin { get; set; }
    public int? ReviewedByUserId { get; set; }
    public DateTime? ReviewedAtUtc { get; set; }
    [MaxLength(1000)] public string ReviewNote { get; set; } = "";
    public DateTime CreatedAtUtc { get; set; }
    public Guid ConcurrencyToken { get; set; } = Guid.NewGuid();

    public required ApplicationEvidenceSource EvidenceSource { get; set; }
    public User? ReviewedByUser { get; set; }
}

/// <summary>One reviewed product-label/regulatory version for one jurisdiction.</summary>
public sealed class ProductRegulatoryProfile
{
    public int ProductRegulatoryProfileId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public int ProductId { get; set; }
    public int ApplicationEvidenceSourceId { get; set; }
    [MaxLength(80)] public string JurisdictionCode { get; set; } = "";
    [MaxLength(80)] public string Revision { get; set; } = "";
    public DateOnly? EffectiveFrom { get; set; }
    public DateOnly? EffectiveTo { get; set; }
    public bool IsCurrent { get; set; }
    [MaxLength(80)] public string PhysicalForm { get; set; } = "";
    [MaxLength(80)] public string SignalWord { get; set; } = "";
    [MaxLength(16000)] public string HazardsJson { get; set; } = "[]";
    [MaxLength(16000)] public string PpeJson { get; set; } = "[]";
    [MaxLength(32000)] public string UseRulesJson { get; set; } = "[]";
    [MaxLength(16000)] public string WeatherRestrictionsJson { get; set; } = "[]";
    [MaxLength(16000)] public string MixingSequenceJson { get; set; } = "[]";
    [MaxLength(4000)] public string CleanupInstructions { get; set; } = "";
    [MaxLength(4000)] public string DisposalInstructions { get; set; } = "";
    [MaxLength(16000)] public string CompatibilityJson { get; set; } = "[]";
    public int ApprovedByUserId { get; set; }
    public DateTime ApprovedAtUtc { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public Guid ConcurrencyToken { get; set; } = Guid.NewGuid();

    public required Product Product { get; set; }
    public required ApplicationEvidenceSource EvidenceSource { get; set; }
    public required User ApprovedByUser { get; set; }
}

/// <summary>One reviewed application configuration for a machine.</summary>
public sealed class MachineApplicationProfile
{
    public int MachineApplicationProfileId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public int MachineId { get; set; }
    public int ApplicationEvidenceSourceId { get; set; }
    [MaxLength(80)] public string Revision { get; set; } = "";
    public DateOnly? EffectiveFrom { get; set; }
    public DateOnly? EffectiveTo { get; set; }
    public bool IsCurrent { get; set; }
    [Precision(12, 3)] public decimal? MinimumOperatingVolumeLitres { get; set; }
    public bool? HasAgitation { get; set; }
    public bool? HasTankRinse { get; set; }
    [MaxLength(32000)] public string ApplicationConfigurationJson { get; set; } = "{}";
    [MaxLength(32000)] public string CalibrationEvidenceJson { get; set; } = "{}";
    [MaxLength(4000)] public string SupportedProductFormsJson { get; set; } = "[]";
    [MaxLength(120)] public string TelemetryProvider { get; set; } = "";
    [MaxLength(250)] public string TelemetryAssetKey { get; set; } = "";
    public int ApprovedByUserId { get; set; }
    public DateTime ApprovedAtUtc { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public Guid ConcurrencyToken { get; set; } = Guid.NewGuid();

    public required Machine Machine { get; set; }
    public required ApplicationEvidenceSource EvidenceSource { get; set; }
    public required User ApprovedByUser { get; set; }
}
