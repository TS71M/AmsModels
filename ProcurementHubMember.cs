namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ProcurementHubSettingId), nameof(UserId), IsUnique = true)]
public class ProcurementHubMember
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProcurementHubMemberId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int ProcurementHubSettingId { get; set; }
    public int UserId { get; set; }
    public bool Active { get; set; } = true;
    public bool IsPrimary { get; set; }

    [MaxLength(100)]
    public string Role { get; set; } = "Manager";

    public required ProcurementHubSetting HubSetting { get; set; }
    public required User User { get; set; }
}
