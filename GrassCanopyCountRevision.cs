namespace AmsModels;

// Manual point counts have their own provenance. They are never AI results or verified references.
[Index(nameof(AreaCompositionPhotoId), nameof(Revision), IsUnique = true)]
[Index(nameof(PubId), IsUnique = true)]
public sealed class GrassCanopyCountRevision
{
    [Key] public int GrassCanopyCountRevisionId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public int AreaCompositionPhotoId { get; set; }
    public int Revision { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public int ReviewerUserId { get; set; }
    [Required, MaxLength(64)] public string SourceHash { get; set; } = "";
    [Required, MaxLength(180000)] public string PlanJson { get; set; } = "";
    [Required, MaxLength(1300000)] public string AnnotationsJson { get; set; } = "";
    public AreaCompositionPhoto Photo { get; set; } = null!;
    public User Reviewer { get; set; } = null!;
}
