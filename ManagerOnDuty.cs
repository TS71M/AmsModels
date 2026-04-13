namespace AmsModels;

public partial class ManagerOnDuty
{
    [Key]
    public int ManagerOnDutyId { get; set; }
    public int FieldId { get; set; }
    public DateTime Date { get; set; }
    public int StaffId { get; set; }

    public required Field Field { get; set; }
    public required Staff Staff { get; set; }
}