namespace AmsModels;

public partial class Diary
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DiaryId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int FieldId { get; set; }
    public DateTime DiaryDate { get; set; }
    public decimal TempMax { get; set; } = 0;
    public decimal TempMin { get; set; } = 0;
    public decimal HumMax { get; set; } = 0;
    public decimal HumMin { get; set; } = 0;
    public decimal Rain { get; set; } = 0;
    public decimal Clippings { get; set; } = 0;
    public bool Cloudy { get; set; } = false;
    public decimal WindMax { get; set; } = 0;
    public decimal WindMin { get; set; } = 0;
    public decimal SolarRadiation { get; set; } = 0;
    public decimal TempAvg { get; set; } = 0;
    public decimal HumAvg { get; set; } = 0;
    public decimal WindAvg { get; set; } = 0;
    public string Icon { get; set; } = "01d.png";

    public virtual decimal DailyAverageTemp => ((2 * TempMax) + TempMin) / 3;

    public required Field Field { get; set; }
}