using Lib.Enums;

namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(FieldId), IsUnique = true)]
[Index(nameof(ProcurementHubIbuId))]
public class FieldProcurementSetting
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FieldProcurementSettingId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int FieldId { get; set; }
    public ProcurementMode ProcurementMode { get; set; } = ProcurementMode.Local;
    public int? ProcurementHubIbuId { get; set; }
    public int? ProcurementSupplierId { get; set; }
    public int? ProcurementManagerUserId { get; set; }
    public bool AllowDirectSupplierOrdering { get; set; } = true;
    public bool ConsolidateRequisitions { get; set; } = true;

    [MaxLength(500)]
    public string Notes { get; set; } = "";

    public required Field Field { get; set; }
    public Ibu? ProcurementHubIbu { get; set; }
    public Supplier? ProcurementSupplier { get; set; }
    public User? ProcurementManagerUser { get; set; }
}
