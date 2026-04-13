namespace AmsModels;

public partial class UnitType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UnitTypeId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(20)]
    public string UnitTypeName { get; set; } = "";


    [JsonIgnore]
    public virtual ICollection<Unit> Units { get; set; } = [];
}
