namespace AmsModels;

public sealed class ProductAdditionalField
{
    public int ProductId { get; set; }
    public int FieldId { get; set; }
    public Field Field { get; set; } = null!;
}
