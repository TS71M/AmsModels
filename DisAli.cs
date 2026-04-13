namespace AmsModels;

public partial class DisAli
{
    [Key]
    public int DisAliId { get; set; }
    public int DiseaseId { get; set; }

    [Required]
    [MaxLength(250)]
    public string DisAliNam { get; set; } = "";

    public required Disease Disease { get; set; }
}