namespace AmsModels;

public partial class DirectorOfGolf
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DirectorOfGolfId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int IbuId { get; set; }
    public int? NameId { get; set; }
    public int? ContactId { get; set; }
    public int? ImageId { get; set; }

    public AppImage? AppImage { get; set; }
    public ContactDetail? Contact { get; set; }
    public required Ibu Ibu { get; set; }
    public Name? Name { get; set; }

    public virtual ICollection<Field> Fields { get; set; } = [];
}