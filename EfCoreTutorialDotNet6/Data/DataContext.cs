using EfCoreTutorialDotNet6.Include.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreTutorialDotNet6.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comic>().Navigation(c => c.Teams).AutoInclude();
            modelBuilder.Entity<Team>().Navigation(t => t.SuperHeroes).AutoInclude();

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "The Hitchhiker's Guide to the Galaxy" },
                new Product { Id = 2, Name = "Ready Player One" },
                new Product { Id = 3, Name = "1984" },
                new Product { Id = 4, Name = "The Matrix Resurrections" },
                new Product { Id = 5, Name = "Diablo 2: Resurrected" },
                new Product { Id = 6, Name = "Super Nintendo Entertainment System" },
                new Product { Id = 7, Name = "Day of the Tentacle" },
                new Product { Id = 8, Name = "Back to the Future" },
                new Product { Id = 9, Name = "Toy Story" },
                new Product { Id = 10, Name = "Brave New World" }
                );


            modelBuilder.Entity<Comic>().HasData(
                new Comic { Id=1,Name="Marvel"},
                new Comic { Id=2,Name="DC"});

            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "Avengers",ComicId=1 },
                new Team { Id = 2, Name = "Justice League" ,ComicId=2});

            modelBuilder.Entity<SuperHero>().HasData(
                new SuperHero { Id = 1, Name = "Spiderman",TeamId=1 },
                new SuperHero { Id = 2, Name = "Ironman" ,TeamId=1},
                new SuperHero { Id = 3, Name = "Batman" , TeamId = 2},
                new SuperHero { Id = 4, Name = "Wonder Woman" , TeamId = 2});
        }

        public DbSet<Product>? Products { get; set; }
        public DbSet<Comic>? Comics { get; set; }
        public DbSet<Team>? Teams { get; set; }
        public DbSet<SuperHero>? SuperHeroes { get; set; }
    }
}
