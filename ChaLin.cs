namespace AmsModels;

public partial class ChaLin
{
    [Key]
    public int ChaLinId { get; set; }

    [Required]
    public int IbuId { get; set; }

    [Required]
    [MaxLength(250)]
    public string ClName { get; set; } = "";
    public int ClValue { get; set; }
    public int ClColor { get; set; }

    public required Ibu Ibu { get; set; }
}