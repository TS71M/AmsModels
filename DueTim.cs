namespace AmsModels;

public partial class DueTim
{
    [Key]
    public int DueTimId { get; set; }
    public string DueTimName { get; set; } = "";

    public virtual ICollection<Incentive> Incentives { get; set; } = [];
}
