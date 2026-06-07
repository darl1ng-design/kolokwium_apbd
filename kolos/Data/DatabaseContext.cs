using kolos.Entities;

namespace kolos.Data;
using Microsoft.EntityFrameworkCore;

public class DatabaseContext : DbContext
{
    
    public DbSet<Artwork> Artworks { get; set; } = null!;
    public DbSet<Artist> Artists { get; set; } = null!;
    public DbSet<Exhibition> Exhibitions { get; set; } = null!;
    public DbSet<ExhibitionArtwork> ExhibitionArtworks { get; set; } = null!;
    public DbSet<Gallery> Galleries { get; set; } = null!;
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Artwork>().HasData(new List<Artwork>()
            {
             new Artwork() {ArtworkId = 1, ArtistId = 1, Title = "Artwork 1", YearCreated = 2025},
             new Artwork() {ArtworkId = 2, ArtistId = 2, Title = "Artwork 2", YearCreated = 2003},
             new Artwork() {ArtworkId = 3, ArtistId = 1, Title = "Artwork 3", YearCreated = 1992}
            });


        modelBuilder.Entity<Artist>().HasData(new List<Artist>()
        {
            new Artist() {ArtistId = 1, FirstName = "John", LastName = "Doe", BirthDate = new DateTime(1990, 1, 1)},
            new Artist() {ArtistId = 2, FirstName = "Marian", LastName = "Gostek", BirthDate = new DateTime(2003, 2, 10)},
        });


        modelBuilder.Entity<Exhibition>().HasData(new List<Exhibition>()
        {
            new Exhibition()
            {
                ExhibitionId = 1, GalleryId = 1, Title = "Exhibition 1", StartDate = new DateTime(1990, 1, 1),
                EndDate = new DateTime(2003, 2, 10), NumberOfArtworks = 2
            },
            new Exhibition()
            {
                ExhibitionId = 2, GalleryId = 2, Title = "Exhibition 2", StartDate = new DateTime(2025, 2, 2),
                EndDate = new DateTime(2026, 1, 1), NumberOfArtworks = 5
            },
        });

        modelBuilder.Entity<Gallery>().HasData(new List<Gallery>()
        {
            new Gallery() { GalleryId = 1, Name = "Gallery 1", EstablishedDate = new DateTime(2023, 2, 5) },
            new Gallery() { GalleryId = 2, Name = "Gallery 2", EstablishedDate = new DateTime(2024, 7, 15) },
            new Gallery() { GalleryId = 3, Name = "Gallery 3", EstablishedDate = new DateTime(2021, 5, 25) },
        });


        modelBuilder.Entity<ExhibitionArtwork>().HasData(new List<ExhibitionArtwork>()
        {
            new ExhibitionArtwork() { ExhibitionId = 1, ArtworkId = 1, InsuranceValue = 1999.5 },
            new ExhibitionArtwork() { ExhibitionId = 2, ArtworkId = 3, InsuranceValue = 9000.23 },
        });
    }
}