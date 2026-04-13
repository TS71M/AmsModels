namespace AmsModels;

public class RoleGroupRole
{
    public int RoleGroupId { get; set; }
    public int RoleId { get; set; }

    public RoleGroup RoleGroup { get; set; } = null!;
    public Role Role { get; set; } = null!;
}