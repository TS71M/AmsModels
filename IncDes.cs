namespace AmsModels;

public partial class IncDes
{
    [Key]
    public int IncDesId { get; set; }
    public int FieldId { get; set; }

    [Required, MaxLength(250)]
    public string IncDescription { get; set; } = "";

    public required Field Field { get; set; }

    public virtual ICollection<Incentive> Incentives { get; set; } = [];
}