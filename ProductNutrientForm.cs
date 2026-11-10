namespace AmsModels;

// Declared share of the parent nutrient, never another nutrient contribution.
public sealed class ProductNutrientForm
{
    public int ProductNutrientId { get; set; }
    public string FormCode { get; set; } = "";
    public string Label { get; set; } = "";
    public decimal Amount { get; set; }
    public bool IsMinimum { get; set; }
}
