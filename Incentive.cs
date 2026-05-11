namespace AmsModels;

public partial class Incentive
{
    [Key]
    public int IncentiveId { get; set; }
    public int DueTimId { get; set; }
    public int UserId { get; set; }
    public int IncDesId { get; set; }
    public decimal Amount { get; set; }

    public required DueTim DueTim { get; set; }
    public required IncDes IncDes { get; set; }
    public required User User { get; set; }

}
