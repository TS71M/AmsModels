namespace AmsModels;

[Table("Logs")]
[Index(nameof(Level), nameof(TimeStamp))]
[Index(nameof(TimeStamp))]
public sealed class LogEntry
{
    [Key]
    public int Id { get; set; }

    public string? Message { get; set; }
    public string? MessageTemplate { get; set; }

    [Column("Level")]
    public string? Level { get; set; }

    public DateTime TimeStamp { get; set; }

    public string? Exception { get; set; }
    public string? Properties { get; set; }
}