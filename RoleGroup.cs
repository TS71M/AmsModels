namespace AmsModels;

public class RoleGroup
{
    [Key]
    public int RoleGroupId { get; set; }
    public required string GroupName { get; set; }

    public virtual ICollection<Role> Roles { get; set; } = [];
    public virtual ICollection<RoleGroupRole> RoleGroupRoles { get; set; } = [];
}