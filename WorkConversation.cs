namespace AmsModels;

public sealed class WorkConversation
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int WorkConversationId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IbuId { get; set; }

    [Required, MaxLength(30)]
    public string Type { get; set; } = "";

    [Required, MaxLength(180)]
    public string Title { get; set; } = "";

    [MaxLength(60)]
    public string? ContextType { get; set; }

    public Guid? ContextPubId { get; set; }
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;

    public Ibu? Ibu { get; set; }
    public ICollection<WorkConversationParticipant> Participants { get; set; } = [];
    public ICollection<WorkMessage> Messages { get; set; } = [];
}
