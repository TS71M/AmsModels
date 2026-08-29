namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IrrigationAreaId))]
[Index(nameof(IrrigationHeadId))]
[Index(nameof(IrrigationAreaId), nameof(IrrigationHeadId), IsUnique = true)]
public sealed class IrrigationAreaHead
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationAreaHeadId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationAreaId { get; set; }
    public int IrrigationHeadId { get; set; }
    public bool IsPrimary { get; set; }
    public bool Active { get; set; } = true;

    public required IrrigationArea IrrigationArea { get; set; }
    public required IrrigationHead IrrigationHead { get; set; }
}
