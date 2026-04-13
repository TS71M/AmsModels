namespace AmsModels;

public class Nutrient
{
    [Key]
    public int NutrientId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(45)]
    public string NutrientName { get; set; } = "";
    public int OrderNumber { get; set; }

    public virtual ICollection<ProductNutrient> ProductNutrients { get; set; } = [];
}
