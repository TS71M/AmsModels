namespace AmsModels;

public class ClubhousePublic
{
    [Key]
    public Guid IdClubhouse { get; set; }
    public byte[] IbuHash { get; set; } = [];
    public byte[] Salt { get; set; } = [];
}