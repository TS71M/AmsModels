namespace AmsModels;

public partial class StaPay
{
    [Key]
    public int StaPayId { get; set; }
    public int StaffId { get; set; }
    public int PayrollId { get; set; }
    public decimal CurWag { get; set; }
    public DateTime ValSin { get; set; }
    public decimal Bonus { get; set; }
    public int? DueTimId { get; set; }

    public required Staff Staff { get; set; }
    public required Payroll Payroll { get; set; }
    public DueTim? DueTim { get; set; }
}