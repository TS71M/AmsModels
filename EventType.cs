namespace AmsModels;

public partial class EventType
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int EventTypeId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(20)]
    public string EventTypeName { get; set; } = "";

    [MaxLength(500)]
    public string EventTypeDes { get; set; } = "";
    public bool IsActive { get; set; } = true;

    [Required]
    public int CreatedBy { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }


    public required User User { get; set; }

    public ICollection<Event> Events { get; set; } = [];
}