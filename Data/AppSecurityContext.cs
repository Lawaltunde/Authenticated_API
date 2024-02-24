using IdentityAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace AUTHENTICATED_API.Data;

public class AppSecurityContext : IdentityDbContext<ShoppingCartModel>
{
    public AppSecurityContext(DbContextOptions<AppSecurityContext> options)
        : base(options)
        {}
}