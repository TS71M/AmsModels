namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(FieldId), nameof(Active))]
[Index(nameof(FieldId), nameof(ZoneType))]
public sealed class FieldZone
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FieldZoneId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int FieldId { get; set; }
    public Field Field { get; set; } = null!;

    [Required, MaxLength(120)]
    public string ZoneName { get; set; } = "";

    public FieldZoneType ZoneType { get; set; } = FieldZoneType.Unknown;

    [Required]
    public string GeoJson { get; set; } = "";

    public bool Active { get; set; } = true;

    public ICollection<FieldZoneSatelliteSnapshot> SatelliteSnapshots { get; set; } = [];
}
