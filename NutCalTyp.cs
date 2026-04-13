namespace AmsModels;

public partial class NutCalTyp
{
    [Key]
    public int NutCalTypId { get; set; }

    [Required, MaxLength(250)]
    public string NutCalTypName { get; set; } = "";
}