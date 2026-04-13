namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ChemTypeName), IsUnique = true)]
public partial class ChemicalType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ChemTypeId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(100)]
    public string ChemTypeName { get; set; } = "";

    public bool Active { get; set; } = true;

    public bool DefaultBlockInProtectedZone { get; set; } = false;

    public virtual ICollection<Chemical> Chems { get; set; } = [];
}