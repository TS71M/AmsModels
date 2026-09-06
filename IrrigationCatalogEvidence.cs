using Lib.Enums;

namespace AmsModels;

public sealed class IrrigationCatalogSourceDocument
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationCatalogSourceDocumentId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(120)]
    public string ManufacturerName { get; set; } = "";

    [Required, MaxLength(300)]
    public string Title { get; set; } = "";

    [Required, MaxLength(120)]
    public string DocumentNumber { get; set; } = "";

    [MaxLength(80)]
    public string Revision { get; set; } = "";

    [Required, MaxLength(500)]
    public string SourceUrl { get; set; } = "";

    [Required, MaxLength(40)]
    public string SourceUrlStatus { get; set; } = IrrigationCatalogSourceTraceStatuses.Unavailable;

    [MaxLength(2000)]
    public string SourceTraceNotes { get; set; } = "";

    [Required, MaxLength(64)]
    public string ContentSha256 { get; set; } = "";

    public bool Active { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public ICollection<IrrigationHydraulicPlatformComponent> PlatformComponents { get; set; } = [];
    public ICollection<IrrigationDocumentedNozzleSet> DocumentedNozzleSets { get; set; } = [];
    public ICollection<IrrigationDocumentedNozzleSetPerformance> PerformanceRows { get; set; } = [];
    public ICollection<IrrigationCatalogComponentPerformance> ComponentPerformanceRows { get; set; } = [];
    public ICollection<IrrigationCatalogComponentReferenceImage> ComponentReferenceImages { get; set; } = [];
}

public sealed class IrrigationHydraulicPlatform
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationHydraulicPlatformId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(120)]
    public string ManufacturerName { get; set; } = "";

    [Required, MaxLength(120)]
    public string PlatformCode { get; set; } = "";

    [Required, MaxLength(200)]
    public string Name { get; set; } = "";

    [MaxLength(2000)]
    public string Description { get; set; } = "";

    public bool Active { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public ICollection<IrrigationSprinklerModel> SprinklerModels { get; set; } = [];
    public ICollection<IrrigationHydraulicPlatformComponent> Components { get; set; } = [];
    public ICollection<IrrigationDocumentedNozzleSet> DocumentedNozzleSets { get; set; } = [];
}

public sealed class IrrigationCatalogComponent
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationCatalogComponentId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(120)]
    public string ManufacturerName { get; set; } = "";

    [Required, MaxLength(80)]
    public string PartNumber { get; set; } = "";

    [MaxLength(80)]
    public string ManufacturerNumber { get; set; } = "";

    [Required, MaxLength(80)]
    public string ComponentType { get; set; } = "";

    [Required, MaxLength(200)]
    public string Name { get; set; } = "";

    [MaxLength(80)]
    public string Color { get; set; } = "";

    [MaxLength(2000)]
    public string Notes { get; set; } = "";

    public bool Active { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public ICollection<IrrigationHydraulicPlatformComponent> PlatformApplications { get; set; } = [];
    public ICollection<IrrigationDocumentedNozzleSetComponent> NozzleSetApplications { get; set; } = [];
    public ICollection<IrrigationSprinklerNozzleOption> ModelNozzleOptions { get; set; } = [];
    public ICollection<IrrigationCatalogComponentPerformance> PerformanceRows { get; set; } = [];
    public ICollection<IrrigationCatalogComponentReferenceImage> ReferenceImages { get; set; } = [];
}

public sealed class IrrigationCatalogComponentPerformance
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationCatalogComponentPerformanceId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationCatalogComponentId { get; set; }
    public int IrrigationCatalogSourceDocumentId { get; set; }

    [Required, MaxLength(200)]
    public string UniquenessKey { get; set; } = "";

    [Required, MaxLength(80)]
    public string RoleCode { get; set; } = "";

    public IrrigationNozzlePositionKind? PositionKind { get; set; }

    [Precision(6, 3), Range(typeof(decimal), "0.001", "100")]
    public decimal PressureBar { get; set; }

    [Precision(10, 4), Range(typeof(decimal), "0.0001", "1000")]
    public decimal FlowM3H { get; set; }

    [Precision(8, 3), Range(typeof(decimal), "0.001", "200")]
    public decimal RadiusM { get; set; }

    [Precision(6, 2), Range(typeof(decimal), "0", "90")]
    public decimal? TrajectoryDegrees { get; set; }

    [MaxLength(500)]
    public string OperatingContext { get; set; } = "";

    [Range(1, 10000)]
    public int SourcePage { get; set; }

    public IrrigationCompatibilityEvidenceLevel EvidenceLevel { get; set; }
    public bool Active { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public required IrrigationCatalogComponent Component { get; set; }
    public required IrrigationCatalogSourceDocument SourceDocument { get; set; }
}

public sealed class IrrigationCatalogComponentReferenceImage
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationCatalogComponentReferenceImageId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationCatalogComponentId { get; set; }
    public int IrrigationCatalogSourceDocumentId { get; set; }

    [Range(1, 10000)]
    public int SourcePage { get; set; }

    [Required, MaxLength(100)]
    public string ContentType { get; set; } = "image/png";

    [Required]
    public byte[] ImageBytes { get; set; } = [];

    [Required, MaxLength(64)]
    public string ContentSha256 { get; set; } = "";

    [MaxLength(500)]
    public string Description { get; set; } = "";

    public IrrigationCompatibilityEvidenceLevel EvidenceLevel { get; set; }
    public bool IsFocused { get; set; }
    public bool Active { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public required IrrigationCatalogComponent Component { get; set; }
    public required IrrigationCatalogSourceDocument SourceDocument { get; set; }
}

public sealed class IrrigationHydraulicPlatformComponent
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationHydraulicPlatformComponentId { get; set; }

    public int IrrigationHydraulicPlatformId { get; set; }
    public int IrrigationCatalogComponentId { get; set; }
    public int? IrrigationCatalogSourceDocumentId { get; set; }

    [Required, MaxLength(80)]
    public string RoleCode { get; set; } = "";

    public IrrigationNozzlePositionKind? PositionKind { get; set; }
    public IrrigationCompatibilityEvidenceLevel EvidenceLevel { get; set; }

    [Range(1, 10000)]
    public int? SourcePage { get; set; }

    [MaxLength(2000)]
    public string Notes { get; set; } = "";

    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public required IrrigationHydraulicPlatform Platform { get; set; }
    public required IrrigationCatalogComponent Component { get; set; }
    public IrrigationCatalogSourceDocument? SourceDocument { get; set; }
}

public sealed class IrrigationDocumentedNozzleSet
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationDocumentedNozzleSetId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationHydraulicPlatformId { get; set; }
    public int IrrigationCatalogSourceDocumentId { get; set; }

    [Required, MaxLength(80)]
    public string SetCode { get; set; } = "";

    [Required, MaxLength(200)]
    public string Name { get; set; } = "";

    [MaxLength(80)]
    public string MainNozzleNumber { get; set; } = "";

    [MaxLength(120)]
    public string GenerationCode { get; set; } = "";

    public DateOnly? ValidFrom { get; set; }
    public DateOnly? ValidUntil { get; set; }

    public IrrigationCompatibilityEvidenceLevel EvidenceLevel { get; set; }

    [Range(1, 10000)]
    public int SourcePage { get; set; }

    [MaxLength(2000)]
    public string Notes { get; set; } = "";

    public bool Active { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public required IrrigationHydraulicPlatform Platform { get; set; }
    public required IrrigationCatalogSourceDocument SourceDocument { get; set; }
    public ICollection<IrrigationDocumentedNozzleSetComponent> Components { get; set; } = [];
    public ICollection<IrrigationDocumentedNozzleSetPerformance> PerformanceRows { get; set; } = [];
    public ICollection<IrrigationNozzleConfiguration> NozzleConfigurations { get; set; } = [];
}

public sealed class IrrigationDocumentedNozzleSetComponent
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationDocumentedNozzleSetComponentId { get; set; }

    public int IrrigationDocumentedNozzleSetId { get; set; }
    public int IrrigationCatalogComponentId { get; set; }

    [Required, MaxLength(80)]
    public string RoleCode { get; set; } = "";

    [Range(1, 5)]
    public int? Position { get; set; }

    public IrrigationNozzlePositionKind? PositionKind { get; set; }

    [Range(typeof(decimal), "-180", "180")]
    public decimal? RecommendedInstallationAngleDegrees { get; set; }

    public bool IsRequired { get; set; } = true;

    public required IrrigationDocumentedNozzleSet NozzleSet { get; set; }
    public required IrrigationCatalogComponent Component { get; set; }
}

public sealed class IrrigationDocumentedNozzleSetPerformance
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationDocumentedNozzleSetPerformanceId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationDocumentedNozzleSetId { get; set; }
    public int IrrigationCatalogSourceDocumentId { get; set; }

    [Required, MaxLength(200)]
    public string UniquenessKey { get; set; } = "";

    [Precision(6, 3), Range(typeof(decimal), "0.001", "100")]
    public decimal PressureBar { get; set; }

    [Precision(10, 4), Range(typeof(decimal), "0.0001", "1000")]
    public decimal FlowM3H { get; set; }

    [Precision(8, 3), Range(typeof(decimal), "0.001", "200")]
    public decimal RadiusM { get; set; }

    [Precision(8, 3), Range(typeof(decimal), "0", "10000")]
    public decimal? PrecipitationRateMmH { get; set; }

    [Precision(6, 2), Range(typeof(decimal), "0", "90")]
    public decimal? TrajectoryDegrees { get; set; }

    [Precision(10, 3), Range(typeof(decimal), "0.001", "3600")]
    public decimal? RotationSeconds { get; set; }

    [Range(1, 10000)]
    public int SourcePage { get; set; }

    public IrrigationCompatibilityEvidenceLevel EvidenceLevel { get; set; }
    public bool Active { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public required IrrigationDocumentedNozzleSet NozzleSet { get; set; }
    public required IrrigationCatalogSourceDocument SourceDocument { get; set; }
}

public sealed class IrrigationCatalogImportBatch
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationCatalogImportBatchId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(120)]
    public string ManufacturerName { get; set; } = "";

    [Required, MaxLength(300)]
    public string DocumentTitle { get; set; } = "";

    [Required, MaxLength(120)]
    public string DocumentNumber { get; set; } = "";

    [MaxLength(80)]
    public string Revision { get; set; } = "";

    [Required, MaxLength(500)]
    public string SourceUrl { get; set; } = "";

    [Required, MaxLength(40)]
    public string SourceUrlStatus { get; set; } = IrrigationCatalogSourceTraceStatuses.Unavailable;

    [MaxLength(2000)]
    public string SourceTraceNotes { get; set; } = "";

    [Required, MaxLength(255)]
    public string OriginalFileName { get; set; } = "";

    [Required, MaxLength(64)]
    public string ContentSha256 { get; set; } = "";

    [Required]
    public byte[] SourcePdf { get; set; } = [];

    [Required, MaxLength(40)]
    public string Status { get; set; } = IrrigationCatalogImportStatuses.Queued;

    [MaxLength(120)]
    public string ExtractorModel { get; set; } = "";

    [MaxLength(40)]
    public string PromptVersion { get; set; } = "";

    [MaxLength(2000)]
    public string FailureSummary { get; set; } = "";

    public int CandidateCount { get; set; }
    // Reuse the durable import queue for additive set discovery, without replacing earlier reviews.
    public bool SetDiscoveryOnly { get; set; }
    public DateTime? SetDiscoveryCompletedAtUtc { get; set; }
    public int SetDiscoveryAddedCount { get; set; }
    public int SetDiscoveryConfirmedCount { get; set; }
    public Guid? ProcessingToken { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public ICollection<IrrigationCatalogImportCandidate> Candidates { get; set; } = [];
}

public sealed class IrrigationCatalogImportCandidate
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationCatalogImportCandidateId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationCatalogImportBatchId { get; set; }

    [Required, MaxLength(40)]
    public string CandidateType { get; set; } = "";

    [Required, MaxLength(64)]
    public string Fingerprint { get; set; } = "";

    [Range(1, 10000)]
    public int SourcePage { get; set; }

    [Required, MaxLength(500)]
    public string DisplaySummary { get; set; } = "";

    [Required]
    public string PayloadJson { get; set; } = "{}";

    [MaxLength(2000)]
    public string Warnings { get; set; } = "";

    [Precision(5, 4), Range(typeof(decimal), "0", "1")]
    public decimal ExtractionConfidence { get; set; }

    public IrrigationCompatibilityEvidenceLevel EvidenceLevel { get; set; }

    [Required, MaxLength(40)]
    public string Status { get; set; } = IrrigationCatalogCandidateStatuses.Pending;

    [MaxLength(2000)]
    public string ReviewerNotes { get; set; } = "";

    public int? ReviewedByUserId { get; set; }
    public DateTime? ReviewedAtUtc { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public required IrrigationCatalogImportBatch Batch { get; set; }
    public User? ReviewedByUser { get; set; }
}
