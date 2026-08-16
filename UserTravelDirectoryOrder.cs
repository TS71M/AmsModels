namespace AmsModels;

public enum TravelDirectoryKind
{
    Locations = 1,
    Contacts = 2
}

[Index(nameof(UserId), nameof(FieldId), nameof(DirectoryKind), IsUnique = true)]
[Index(nameof(FieldId))]
public sealed class UserTravelDirectoryOrder
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserTravelDirectoryOrderId { get; set; }

    public int UserId { get; set; }
    public int FieldId { get; set; }
    public TravelDirectoryKind DirectoryKind { get; set; }

    [Required, MaxLength(16000)]
    public string OrderedPubIdsJson { get; set; } = "[]";

    public User User { get; set; } = null!;
    public Field Field { get; set; } = null!;
}
