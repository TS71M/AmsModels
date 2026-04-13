namespace AmsModels;

public partial class Budget
{
    [Key]
    public int BudgetId { get; set; }

    [Required]
    public int BudgetNumId { get; set; }

    [Required]
    [Display(Name = "Account")]
    public int AccountId { get; set; }

    [Required]
    [Display(Name = "Description")]
    public string BudDes { get; set; } = "";
    public decimal Jan { get; set; } = 0;
    public decimal Feb { get; set; } = 0;
    public decimal Mar { get; set; } = 0;
    public decimal Apr { get; set; } = 0;
    public decimal May { get; set; } = 0;
    public decimal Jun { get; set; } = 0;
    public decimal Jul { get; set; } = 0;
    public decimal Aug { get; set; } = 0;
    public decimal Sep { get; set; } = 0;
    public decimal Oct { get; set; } = 0;
    public decimal Nov { get; set; } = 0;
    public decimal Dec { get; set; } = 0;
    public decimal Total => Jan + Feb + Mar + Apr + May + Jun + Jul + Aug + Sep + Oct + Nov + Dec;

    public required Account Account { get; set; }
    public required BudgetNum BudgetNum { get; set; }

}