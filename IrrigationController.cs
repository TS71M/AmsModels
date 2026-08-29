namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IrrigationSystemId))]
[Index(nameof(IrrigationSystemId), nameof(Name), IsUnique = true)]
[Index(nameof(IrrigationSystemId), nameof(ControllerNumber), IsUnique = true)]
public sealed class IrrigationController
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationControllerId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationSystemId { get; set; }

    [Required, MaxLength(160)]
    public string Name { get; set; } = "";

    [Range(0, int.MaxValue)]
    public int? ControllerNumber { get; set; }

    public bool Active { get; set; } = true;

    public required IrrigationSystem IrrigationSystem { get; set; }
    public ICollection<IrrigationHead> Heads { get; set; } = [];
    public ICollection<IrrigationSourceReference> SourceReferences { get; set; } = [];
}
