using Microsoft.EntityFrameworkCore;
namespace Example
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=OCTIAN\SQLEXPRESS;Database=MovieConDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

    }
}
