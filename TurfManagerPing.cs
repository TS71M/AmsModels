using Lib.Enums;

namespace AmsModels;

public class TurfManagerPing
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public DateTime ObservedAtUtc { get; set; }

    [Required]
    public int StatusCode { get; set; }

    [MaxLength(32)]
    public string? StatusText { get; set; }

    [MaxLength(256)]
    public string? ErrorMessage { get; set; }

    [Required]
    public PingDirection Direction { get; set; }
}