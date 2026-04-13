namespace AmsModels;

public class Event
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int EventId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int IbuId { get; set; }
    public int? FieldId { get; set; }
    public DateTime EventDate { get; set; }

    [Required]
    public int EventTypeId { get; set; }

    [Required, MaxLength(250)]
    public string EventName { get; set; } = "";

    [Required, MaxLength(1000)]
    public string EventDescription { get; set; } = "";

    public string EventDateTxt => EventDate.ToShortDateString();
    public int CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    public Field? Field { get; set; }
    public required Ibu Ibu { get; set; }
    public required EventType EventType { get; set; }
    public required User User { get; set; }
}