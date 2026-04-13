namespace AmsModels;

public class ProductFertilizerType
{
    [Key]
    public int ProductFertTypeId { get; set; }
    public int ProductId { get; set; }
    public int FerTypId { get; set; }

    public required FerTyp FerTyp { get; set; }
    public required Product Product { get; set; }

}