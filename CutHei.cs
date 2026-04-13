namespace AmsModels;

public partial class CutHei
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CutHeiId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int AreaId { get; set; }
    public DateTime HeiDate { get; set; }
    public decimal Height { get; set; }

    public required Area Area { get; set; }
}