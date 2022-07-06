using EFLib.Models;
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
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Children>().HasKey(x => x.Id);
        modelBuilder.Entity<Teacher>().HasKey(x => x.Id);
        modelBuilder.Entity<Present>().HasKey(x => x.Id);
        modelBuilder.Entity<Parent>().HasKey(x => x.Id);
    }
    
    public DbSet<Children> Childrens { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Present> Presents { get; set; }
    public DbSet<Parent> Parents { get; set; }

    
}