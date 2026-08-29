namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IbuId))]
[Index(nameof(IbuId), nameof(FileSha256), IsUnique = true)]
public sealed class LynxImport
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LynxImportId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IbuId { get; set; }
    public int? ImportedById { get; set; }

    [Required, MaxLength(260)]
    public string OriginalFileName { get; set; } = "";

    [Required, StringLength(64, MinimumLength = 64)]
    public string FileSha256 { get; set; } = "";

    public long FileSize { get; set; }

    [MaxLength(40)]
    public string? ArchiveVersion { get; set; }

    public DateTime ImportedUtc { get; set; }
    public int ConfiguredStationCount { get; set; }
    public int MappedStationCount { get; set; }
    public int MapPointCount { get; set; }

    [MaxLength(4000)]
    public string? WarningMessage { get; set; }

    public bool Active { get; set; } = true;

    public required Ibu Ibu { get; set; }
    public User? ImportedBy { get; set; }
    public ICollection<LynxImportStation> Stations { get; set; } = [];
}
