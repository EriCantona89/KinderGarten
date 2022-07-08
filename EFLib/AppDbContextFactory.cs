using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFLib;

public class AppDbContextFactory:IDesignTimeDbContextFactory<AppDbContext>
{
    /// <summary>
    /// Create AppDbContext instance db with all 
    /// </summary>
    /// <param name="args">options</param>
    /// <returns>AppDbContext</returns>
    public AppDbContext CreateDbContext(string[] args = null)
    {
        var options = new DbContextOptionsBuilder<AppDbContext>();
        options.UseSqlServer("Server=(localdb)\\KinderGarten.; Database=KinderGarten; Trusted_Connection=True");
        return new AppDbContext(options.Options);
    }
}