namespace AmsModels;

public partial class MachineCategory
{
    [Key]
    public int MachineCategoryId { get; set; }

    [Required, MaxLength(250)]
    public string CategoryName { get; set; } = "";

    public virtual ICollection<Machine> Machineries { get; set; } = [];
}