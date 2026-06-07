using Lib.Enums;

namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IbuId), nameof(Status))]
[Index(nameof(FieldId), nameof(Status))]
[Index(nameof(ProcurementHubIbuId), nameof(Status))]
public class PurchaseRequisition
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PurchaseRequisitionId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IbuId { get; set; }
    public int FieldId { get; set; }
    public int RequestedByUserId { get; set; }
    public int? ProcurementHubIbuId { get; set; }
    public int? ProcurementManagerUserId { get; set; }
    public PurchaseRequisitionStatus Status { get; set; } = PurchaseRequisitionStatus.Draft;
    public DateTime RequestedDt { get; set; } = DateTime.UtcNow;
    public DateTime? NeedByDate { get; set; }
    public DateTime? ReviewedDt { get; set; }

    [MaxLength(100)]
    public string ReferenceNo { get; set; } = "";

    [MaxLength(250)]
    public string Title { get; set; } = "";

    [MaxLength(1000)]
    public string Notes { get; set; } = "";

    [MaxLength(1000)]
    public string DecisionNotes { get; set; } = "";

    public required Ibu Ibu { get; set; }
    public required Field Field { get; set; }
    public required User RequestedByUser { get; set; }
    public Ibu? ProcurementHubIbu { get; set; }
    public User? ProcurementManagerUser { get; set; }

    public virtual ICollection<PurchaseRequisitionLine> Lines { get; set; } = [];
}
