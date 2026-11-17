using Microsoft.EntityFrameworkCore;

public class Bai6Context(DbContextOptions<Bai6Context> options) : DbContext(options)
{
    public DbSet<Bai6.Models.Product> Product { get; set; } = default!;
    public DbSet<Bai6.Models.Genre> Genre { get; set; } = default!;
    public DbSet<Bai6.Models.Movie> Movies { get; set; } = default!;
}
