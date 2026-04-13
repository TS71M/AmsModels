namespace AmsModels;

public class Department
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DepartmentId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int FieldId { get; set; }

    [MaxLength(45)]
    public string DepartmentName { get; set; } = "";

    [MaxLength(500)]
    public string Description { get; set; } = "";

    public required Field Field { get; set; }

    public virtual ICollection<StaPos> StaPoses { get; set; } = [];
    public virtual ICollection<User> Users { get; set; } = [];

}