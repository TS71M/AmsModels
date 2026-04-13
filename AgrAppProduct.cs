namespace AmsModels;

public partial class AgrAppProduct
{
    [Key]
    public int AgrAppProductId { get; set; }
    public int YearId { get; set; }
    public int ProductId { get; set; }
    public decimal Dosage { get; set; }
    public decimal Price { get; set; }

    public decimal Quantity = 0;
    public required Year Year { get; set; }
    public required Product Product { get; set; }

    public virtual ICollection<AgrAppTask> AgrAppTasks { get; set; } = [];
    public virtual ICollection<AppPlan> AppPlans { get; set; } = [];
}