using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Opticsoft.Infrastructure.Identity;

public class AppUser : IdentityUser<Guid>
{
    public string? FullName { get; set; }
    public Guid SucursalId { get; set; }
    public Guid TenantId { get; set; }
}