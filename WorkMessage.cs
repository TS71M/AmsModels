namespace AmsModels;

public sealed class WorkMessage
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int WorkMessageId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int WorkConversationId { get; set; }
    public int SenderUserId { get; set; }
    public int? AppImageId { get; set; }

    [Required, MaxLength(2000)]
    public string Body { get; set; } = "";

    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public bool Deleted { get; set; }

    public WorkConversation? Conversation { get; set; }
    public User? SenderUser { get; set; }
    public AppImage? AppImage { get; set; }
}
