namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ClientIbuId), nameof(DecidedAtUtc))]
[Index(nameof(HubIbuId), nameof(DecidedAtUtc))]
public sealed class ClientProcurementDefaultProposal
{
    public int ClientProcurementDefaultProposalId { get; set; }
    public Guid PubId { get; set; }
    public int ClientIbuId { get; set; }
    public int HubIbuId { get; set; }
    public int RelationshipId { get; set; }
    public int ProposedByUserId { get; set; }
    public DateTime ProposedAtUtc { get; set; }
    public int? DecidedByUserId { get; set; }
    public DateTime? DecidedAtUtc { get; set; }
    public bool Approved { get; set; }
    public bool IncludeFutureFields { get; set; }
    public DateTime? FutureEndedAtUtc { get; set; }
    public int? FutureEndedByUserId { get; set; }
    [MaxLength(64)] public string ReviewToken { get; set; } = "";
    // Frozen public IDs of fields changed by this approval; existing overrides are not rewritten.
    [MaxLength(20000)] public string AppliedFieldsJson { get; set; } = "[]";
    public Ibu ClientIbu { get; set; } = null!;
    public Ibu HubIbu { get; set; } = null!;
    public IbuRelationship Relationship { get; set; } = null!;
}
