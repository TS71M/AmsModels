namespace AmsModels;

public sealed class WorkConversationParticipant
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int WorkConversationParticipantId { get; set; }

    public int WorkConversationId { get; set; }
    public int UserId { get; set; }

    [Required, MaxLength(40)]
    public string Relationship { get; set; } = "";

    public DateTime JoinedUtc { get; set; } = DateTime.UtcNow;
    public DateTime? LastReadUtc { get; set; }

    public WorkConversation? Conversation { get; set; }
    public User? User { get; set; }
}
