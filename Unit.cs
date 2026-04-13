namespace AmsModels;

[Index(nameof(UnitTypeId), nameof(UnitShort), IsUnique = true)]
[Index(nameof(UnitTypeId))]
public partial class Unit
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UnitId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int UnitTypeId { get; set; }

    [Required, MaxLength(10)]
    public string UnitShort { get; set; } = "";

    [Required, MaxLength(50)]
    public string UnitName { get; set; } = "";

    public bool IsBase { get; set; }
    public decimal ConversionFactor { get; set; } = 1;
    public decimal Offset { get; set; }
    public int Precision { get; set; }


    public required UnitType UnitType { get; set; }

}
