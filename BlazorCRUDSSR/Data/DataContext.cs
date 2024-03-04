using BlazorCRUDSSR.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDSSR.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame { Id = 1, Title = "CyberPunk", Publisher = "CD Project", ReleaseYear = 1998},
                new VideoGame { Id = 2, Title = "ElderRing", Publisher = "X-Corp", ReleaseYear = 1999 },
                new VideoGame { Id = 3, Title = "Zelda", Publisher = "Nintendo", ReleaseYear = 1988 }

                );

            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, FirstName = "Lars", LastName = "Asplund", City = "Ljusne", BirthYear = 1974 },
                new Person { Id = 2, FirstName = "Nisse", LastName = "Manpower", City = "Sandarne", BirthYear = 1964 },
                new Person { Id = 3, FirstName = "Frida", LastName = "Edvinsson", City = "Vallvik", BirthYear = 1988 }

    );
        }

        public DbSet<VideoGame> VideoGames { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}

//https://www.youtube.com/watch?v=EqSgqm4qWjo
