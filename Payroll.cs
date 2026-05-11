namespace AmsModels;

public partial class Payroll
{
    [Key]
    public int PayrollId { get; set; }

    [Required, MaxLength(50)]
    public string PayDes { get; set; } = "";

    public virtual ICollection<Incentive> Incentives { get; set; } = [];
    public virtual ICollection<UserPosition> UserPositions { get; set; } = [];
}
