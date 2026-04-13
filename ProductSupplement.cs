namespace AmsModels;

public class ProductSupplement
{
    [Key]
    public int ProductSupplementId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int ProductId { get; set; }

    [Required, MaxLength(150)]
    public string Name { get; set; } = "";

    [MaxLength(50)]
    public string Category { get; set; } = "";

    public decimal? Amount { get; set; }

    [MaxLength(50)]
    public string UnitText { get; set; } = "";

    [MaxLength(500)]
    public string Notes { get; set; } = "";

    public required Product Product { get; set; }
}
