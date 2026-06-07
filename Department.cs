namespace AmsModels;

public class Department
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DepartmentId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int IbuId { get; set; }
    public int? FieldId { get; set; }

    [MaxLength(45)]
    public string DepartmentName { get; set; } = "";

    [MaxLength(500)]
    public string Description { get; set; } = "";

    public required Ibu Ibu { get; set; }
    public Field? Field { get; set; }

    public virtual ICollection<UserPosition> UserPositions { get; set; } = [];

}
