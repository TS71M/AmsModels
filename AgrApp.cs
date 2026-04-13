namespace AmsModels;

public partial class AgrApp
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AgrAppId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int AgrAppTaskId { get; set; }
    public int AgrTaskWeekId { get; set; }
    public decimal RatePlanned { get; set; }

    public required AgrAppTask AgrAppTask { get; set; }
    public required AgrTaskWeek AgrTaskWeek { get; set; }
}