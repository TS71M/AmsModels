namespace AmsModels;

public partial class FerTyp
{
    [Key]
    public int FerTypId { get; set; }
    public bool Active { get; set; } = true;
    public string FerTypName { get; set; } = "";

    public virtual ICollection<ProductFertilizerType> ProductFertTypes { get; set; } = [];
}