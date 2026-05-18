namespace AmsModels;

public sealed class UserReportingLine
{
    public int UserReportingLineId { get; set; }
    public Guid PubId { get; set; }
    public int UserId { get; set; }
    public int ManagerUserId { get; set; }
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;

    public User? User { get; set; }
    public User? ManagerUser { get; set; }
}
