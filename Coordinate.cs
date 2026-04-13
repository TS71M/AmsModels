namespace AmsModels;

public partial class Coordinate
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CoordinatesId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IbuId { get; set; }

    [Range(-90.0000000, 90.0000000)]
    [DisplayFormat(DataFormatString = "{0:0.00000}", ApplyFormatInEditMode = true)]
    public decimal Latitude { get; set; }

    [Range(-180.0000000, 80.000000)]
    [DisplayFormat(DataFormatString = "{0:0.00000}", ApplyFormatInEditMode = true)]
    public decimal Longitude { get; set; }

    public required Ibu Ibu { get; set; }
}