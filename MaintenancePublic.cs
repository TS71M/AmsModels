namespace AmsModels;

public class MaintenancePublic
{
    [Key]
    public Guid IdMaintenance { get; set; }
    public byte[] IbuHash { get; set; } = [];
    public byte[] Salt { get; set; } = [];
}