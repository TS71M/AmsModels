namespace AmsModels;

public partial class ManagerOnDuty
{
    [Key]
    public int ManagerOnDutyId { get; set; }
    public int FieldId { get; set; }
    public DateTime Date { get; set; }
    public int UserId { get; set; }

    public required Field Field { get; set; }
    public required User User { get; set; }
}
