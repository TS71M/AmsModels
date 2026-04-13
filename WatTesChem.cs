namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(WatTesId), nameof(ResultCode), IsUnique = true)]
public class WatTesChem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int WatTesChemId { get; set; }

    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int WatTesId { get; set; }

    [Required, MaxLength(100)]
    public string ResultCode { get; set; } = "";

    public decimal? Value { get; set; }

    [MaxLength(100)]
    public string? TextValue { get; set; }

    public int SortOrder { get; set; }

    public required WatTes WatTes { get; set; }
}
