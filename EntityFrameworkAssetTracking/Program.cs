using Microsoft.EntityFrameworkCore;

Console.WriteLine("Welcome to Jurassic Park");

public class Asset
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int OfficeId { get; set; }
}

public class Office
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Asset> Assets { get; set; }
}

public class AssetsDbContext : DbContext
{
    public DbSet<Asset> Assets { get; set; }
    public DbSet<Office> Offices { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");
    }
}