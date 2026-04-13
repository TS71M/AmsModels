namespace AmsModels;

public class ProductNutrient
{
    public int ProductNutrientId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int ProductId { get; set; }
    public int NutrientId { get; set; }
    public decimal Amount { get; set; }

    public required Nutrient Nutrient { get; set; }
    public required Product Product { get; set; }
}
