namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(Code), IsUnique = true)]
[Index(nameof(DefaultName), IsUnique = true)]
public sealed class Weed
{
    public int WeedId { get; set; }

    [Required]
    public Guid PubId { get; set; }

    [Required, MinLength(2), MaxLength(100)]
    public string Code { get; set; } = null!;

    [Required, MinLength(2), MaxLength(200)]
    public string DefaultName { get; set; } = null!;

    [Required]
    public bool Active { get; set; } = true;

    [Required]
    public int SortOrder { get; set; }

    [Precision(9, 1)]
    public decimal PreferredFromGts { get; set; }

    [Precision(9, 1)]
    public decimal PreferredToGts { get; set; }

    [Precision(9, 1)]
    public decimal AcceptableFromGts { get; set; }

    [Precision(9, 1)]
    public decimal AcceptableToGts { get; set; }

    [MaxLength(1000)]
    public string? ManagementNote { get; set; }

    public ICollection<FieldWeedTimingOverride> FieldWeedTimingOverrides { get; set; } = [];
}