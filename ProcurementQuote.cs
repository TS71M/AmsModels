using Lib.Enums;

namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(PurchaseRequisitionId), nameof(SupplierId), IsUnique = true)]
public class ProcurementQuote
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProcurementQuoteId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int PurchaseRequisitionId { get; set; }
    public int SupplierId { get; set; }
    public ProcurementQuoteStatus Status { get; set; } = ProcurementQuoteStatus.Requested;
    public DateTime RequestedDt { get; set; } = DateTime.UtcNow;
    public DateTime? ReceivedDt { get; set; }
    public DateTime? ValidUntilDate { get; set; }

    [MaxLength(3)]
    public string CurrencyCode { get; set; } = "";

    [MaxLength(500)]
    public string Terms { get; set; } = "";

    [MaxLength(1000)]
    public string Notes { get; set; } = "";

    [ConcurrencyCheck]
    public Guid ConcurrencyToken { get; set; } = Guid.NewGuid();

    public required PurchaseRequisition PurchaseRequisition { get; set; }
    public required Supplier Supplier { get; set; }
    public virtual ICollection<ProcurementQuoteLine> Lines { get; set; } = [];
}
