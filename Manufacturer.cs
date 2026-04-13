namespace AmsModels;

public partial class Manufacturer
{
    [Key]
    public int ManufacturerId { get; set; }

    [Required, MaxLength(250)]
    public string Name { get; set; } = "";

    [Required, Url(ErrorMessage = "Please enter a valid URL."), MaxLength(250)]
    public string WebSite { get; set; } = "";

    public virtual ICollection<Machine> Machineries { get; set; } = [];
}