using Microsoft.EntityFrameworkCore;

public class CityInfoContext : DbContext
{
    public CityInfoContext(DbContextOptions<CityInfoContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
    //One way to provide connection string
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlServer("connectionString");
    //     base.OnConfiguring(optionsBuilder);
    // }
    public DbSet<City> Cities { get; set; }
    public DbSet<PointOfInterest> PointOfInterest { get; set; }
}