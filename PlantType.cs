namespace AmsModels;

public partial class PlantType
{
    [Key]
    public int PlantTypeId { get; set; }

    [Required, MaxLength(250)]
    public string PlantTypeName { get; set; } = "";
}