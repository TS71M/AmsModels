namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IrrigationAreaId), IsUnique = true)]
public sealed class IrrigationAreaBoundary
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationAreaBoundaryId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationAreaId { get; set; }
    public int CreatedByUserId { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public required IrrigationArea IrrigationArea { get; set; }
    public ICollection<IrrigationAreaBoundaryPoint> Points { get; set; } = [];
}
