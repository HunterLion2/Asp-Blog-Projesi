using Microsoft.EntityFrameworkCore;

namespace BlogUygulaması.Models;


public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<WordModel> WordModels { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<WordModel>().HasData(
            new List<WordModel>
            {
                
            }
        );

    }

}



