using Lib.Images;

namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(JurisdictionId))]
public partial class Ibu
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IbuId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public string BusinessUnitName { get; set; } = "";
    public int? FieldTypeId { get; set; }
    public int? JurisdictionId { get; set; }
    public int? MainAddressId { get; set; }
    public int? ContactDetailsId { get; set; }
    public int? CoordinateId { get; set; }
    public int? ImageId { get; set; }
    public int? VisualizationTempUnitId { get; set; }
    public int? VisualizationRainUnitId { get; set; }
    public int? VisualizationWindUnitId { get; set; }
    public DateTime RegistrationDate { get; set; }
    public DateTime? UpdatedDate { get; set; } = null;
    public string Image => ImageX.ImageToString(AppImage?.ImageFile, ImageX.StandardImage.NoImage);
    public string FieldTypeName => FieldType?.FieldTypeName ?? string.Empty;
    public string MarkerColor => FieldType?.MarkerColor ?? string.Empty;
    public string MarkerIconUrl => FieldType?.MarkerIconUrl ?? string.Empty;

    public AppImage? AppImage { get; set; }
    public Address? MainAddress { get; set; }
    public Coordinate? Coordinate { get; set; }
    public ContactDetail? Contact { get; set; }
    public FieldType? FieldType { get; set; }
    public Jurisdiction? Jurisdiction { get; set; }
    public Unit? VisualizationTempUnit { get; set; }
    public Unit? VisualizationRainUnit { get; set; }
    public Unit? VisualizationWindUnit { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = [];
    public virtual ICollection<AppImage> AppImages { get; set; } = [];
    public virtual ICollection<ChaLin> ChaLins { get; set; } = [];
    public virtual ICollection<Event> Events { get; set; } = [];
    public virtual ICollection<Field> Fields { get; set; } = [];
    public virtual ICollection<GeneralRemark> GeneralRemarks { get; set; } = [];
    public virtual ICollection<IbuYearActive> IbuYearActives { get; set; } = [];
    public virtual ICollection<LicenseHistory> LicenseHistories { get; set; } = [];
    public virtual ICollection<LicenseIbu> LicenseIbus { get; set; } = [];
    public virtual ICollection<LoginLog> Logins { get; set; } = [];
    public virtual ICollection<Name> Names { get; set; } = [];
    public virtual ICollection<Product> Products { get; set; } = [];
    public virtual ICollection<Supplier> Suppliers { get; set; } = [];
    public virtual ICollection<User> Users { get; set; } = [];

}
