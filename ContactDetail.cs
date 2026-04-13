namespace AmsModels;

public class ContactDetail
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ContactId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int IbuId { get; set; }

    [Phone]
    [MaxLength(60)]
    public string? Phone { get; set; }

    [EmailAddress]
    [MaxLength(60)]
    public string? Email { get; set; }

    [Url]
    [MaxLength(200)]
    public string? Website { get; set; }


    public required Ibu Ibu { get; set; }
}