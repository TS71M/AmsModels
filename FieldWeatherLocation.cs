namespace AmsModels;

public static class FieldWeatherLocationConstraints
{
    public const int MaxAdditionalLocations = 2;
    public const int MaxNameLength = 80;
}

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(FieldId), nameof(DisplayOrder), IsUnique = true)]
public sealed class FieldWeatherLocation
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FieldWeatherLocationId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required]
    public Field Field { get; set; } = null!;

    [Required, MaxLength(FieldWeatherLocationConstraints.MaxNameLength)]
    public string Name { get; set; } = string.Empty;

    [Precision(10, 7)]
    public decimal Latitude { get; set; }

    [Precision(10, 7)]
    public decimal Longitude { get; set; }

    [Range(1, FieldWeatherLocationConstraints.MaxAdditionalLocations)]
    public int DisplayOrder { get; set; }

    [Required]
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    [Required]
    public DateTime UpdatedAtUtc { get; set; } = DateTime.UtcNow;
}
