using Microsoft.EntityFrameworkCore;

Console.WriteLine("Welcome to the asset manager");
return;

public class Asset
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int OfficeId { get; set; }
    public Office Office { get; set; }
}

public class Office
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Asset> Assets { get; set; } = new List<Asset>();
}

public class MyDbContext : DbContext
{
    public DbSet<Office> Offices { get; set; }
    public DbSet<Asset> Assets { get; set; }
}