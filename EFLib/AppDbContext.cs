using Microsoft.EntityFrameworkCore;

namespace EFLib;

public class AppDbContext:DbContext
{
    public AppDbContext()
    {
    }
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    
}