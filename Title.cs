namespace AmsModels;

public partial class Title
{
    [Key]
    public int TitleId { get; set; }

    [Required, MaxLength(10)]
    public string TitleName { get; set; } = "";
}