namespace AmsModels;

public class IbuAccessProfile
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IbuAccessProfileId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IbuId { get; set; }

    [Required, MaxLength(160)]
    public string ProfileName { get; set; } = "";

    [MaxLength(500)]
    public string Description { get; set; } = "";

    public bool IsDefault { get; set; }
    public bool Active { get; set; } = true;
    public int SortOrder { get; set; }

    public required Ibu Ibu { get; set; }

    public virtual ICollection<IbuAccessProfilePermission> Permissions { get; set; } = [];
    public virtual ICollection<UserPosition> DefaultForUserPositions { get; set; } = [];
    public virtual ICollection<User> Users { get; set; } = [];
}
