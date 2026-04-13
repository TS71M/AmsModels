using Lib.Images;

namespace AmsModels;

public partial class Architect
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ArchitectId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int? NameId { get; set; }
    public int? AddressId { get; set; }
    public int? ContactId { get; set; }
    public int? ImageId { get; set; }

    public string Image => ImageX.ImageToString(AppImage?.ImageFile, ImageX.StandardImage.NoPerson);

    public Address? Address { get; set; }
    public AppImage? AppImage { get; set; }
    public ContactDetail? Contact { get; set; }
    public Name? Name { get; set; }

    public virtual ICollection<Field> Fields { get; set; } = [];
    public virtual ICollection<Ibu> Ibus { get; set; } = [];
}