using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PierreAuth.Models
{
  public class PierreAuthContextFactory : IDesignTimeDbContextFactory<PierreAuthContext>
  {

    PierreAuthContext IDesignTimeDbContextFactory<PierreAuthContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<PierreAuthContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new PierreAuthContext(builder.Options);
    }
  }
}