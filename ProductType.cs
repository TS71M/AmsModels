namespace AmsModels;

public class ProductType
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductTypeId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public bool IsActive { get; set; } = true;

    [Required, MaxLength(45), Display(Name = "Type")]
    public string ProductTypeName { get; set; } = "";

    public virtual ICollection<Product> Products { get; set; } = [];
}