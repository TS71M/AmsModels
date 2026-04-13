namespace AmsModels;

public partial class Sample
{
    [Key]
    public int SampleId { get; set; }
    public int SamNumId { get; set; }
    public int SizFraId { get; set; }
    public decimal ByWeight { get; set; }
    public decimal CumRetBySie { get; set; }

    public required SamNum SamNum { get; set; }
    public required SizFra SizFra { get; set; }

}