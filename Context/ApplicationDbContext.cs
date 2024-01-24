using EnumUseWithParametr.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

public class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=DESKTOP-UQPST9J;initial Catalog=EnumBookDb;integrated security=true;TrustServerCertificate=true");
    }
    public DbSet<MenuItem> MenuItems { get; set; }

    
}





