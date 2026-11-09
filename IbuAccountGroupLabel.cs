namespace AmsModels;

public sealed class IbuAccountGroupLabel
{
    public int IbuId { get; set; }
    public Ibu Ibu { get; set; } = null!;
    public int AccountGroupId { get; set; }
    public AccountGroup AccountGroup { get; set; } = null!;
    public string Name { get; set; } = "";
    public long Version { get; set; }
    public DateTime UpdatedAtUtc { get; set; }
    public int UpdatedByUserId { get; set; }
}
