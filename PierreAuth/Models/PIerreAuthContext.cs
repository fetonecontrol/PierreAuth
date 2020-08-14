using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierreAuth.Models
{
    public class PierreAuthContext : IdentityDbContext<ApplicationUser>
    {
      public DbSet<Treat> Treats {get;set;}
      public DbSet<Flavor> Flavors {get;set;}
      public DbSet<FlavorTreat> FlavorTreats {get;set;}
      public PierreAuthContext(DbContextOptions options) : base(options) {}
    }
}