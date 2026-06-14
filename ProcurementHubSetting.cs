namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(HubIbuId), IsUnique = true)]
public class ProcurementHubSetting
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProcurementHubSettingId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int HubIbuId { get; set; }
    public bool Active { get; set; } = true;
    public bool AllowDirectSupplierOrderingDefault { get; set; } = true;
    public bool ConsolidateRequisitionsDefault { get; set; }

    [MaxLength(500)]
    public string Notes { get; set; } = "";

    public required Ibu HubIbu { get; set; }
    public virtual ICollection<ProcurementHubMember> Members { get; set; } = [];
}
