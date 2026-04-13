namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(FieldId))]
[Index(nameof(WeedId))]
[Index(nameof(FieldId), nameof(WeedId), IsUnique = true)]
public sealed class FieldWeedTimingOverride
{
    [Key]
    public int FieldWeedTimingOverrideId { get; set; }

    [Required]
    public Guid PubId { get; set; }

    [Required]
    public int FieldId { get; set; }

    [ForeignKey(nameof(FieldId))]
    public Field Field { get; set; } = null!;

    [Required]
    public int WeedId { get; set; }

    [ForeignKey(nameof(WeedId))]
    public Weed Weed { get; set; } = null!;

    [Precision(6, 1)]
    public decimal? PreferredFromGts { get; set; }

    [Precision(6, 1)]
    public decimal? PreferredToGts { get; set; }

    [Precision(6, 1)]
    public decimal? AcceptableFromGts { get; set; }

    [Precision(6, 1)]
    public decimal? AcceptableToGts { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Required]
    public bool Active { get; set; } = true;
}