namespace AmsModels;

public partial class UserPosition
{
    [Key]
    public int UserPositionId { get; set; }

    [Required]
    public int IbuId { get; set; }
    public int? FieldId { get; set; }
    public int DepartmentId { get; set; }
    public int? ParentUserPositionId { get; set; }
    public int? DefaultAccessProfileId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, DisplayName("User Positions"), MaxLength(250)]
    public string UserPositionName { get; set; } = "";
    [MaxLength(80)]
    public string PositionCode { get; set; } = "";
    public int? PayrollId { get; set; }
    public decimal EstSal { get; set; }
    public int HierarchyLevel { get; set; }
    public int SortOrder { get; set; }
    public bool IsLeadership { get; set; }
    public bool Active { get; set; } = true;
    [MaxLength(16)]
    public string ColorHex { get; set; } = "";

    public required Department Department { get; set; }
    public Field? Field { get; set; }
    public required Ibu Ibu { get; set; }
    public Payroll? Payroll { get; set; }
    public UserPosition? ParentUserPosition { get; set; }
    public IbuAccessProfile? DefaultAccessProfile { get; set; }

    public virtual ICollection<User> Users { get; set; } = [];
    public virtual ICollection<UserPosition> ChildUserPositions { get; set; } = [];
}
