using Microsoft.AspNetCore.Identity;
namespace AmsModels;

public class Role : IdentityRole<int>
{
    public Role() : base() { }

    public Role(string roleName) : base()
    {
        Name = roleName;
        NormalizedName = roleName.ToUpperInvariant();
    }

    public virtual ICollection<UserRole> UserRole { get; set; } = [];
    public virtual ICollection<RoleGroupRole> RoleGroupRoles { get; set; } = [];

}