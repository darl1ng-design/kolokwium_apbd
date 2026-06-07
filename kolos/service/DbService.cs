using kolos.Data;
using kolos.dto;
using kolos.exception;
using Microsoft.EntityFrameworkCore;

namespace kolos.service;

public class DbService : IDBService
{
    private readonly DatabaseContext _dbContext;

    public DbService(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<GalleryExhibitonDto> getExhibitionsByGalleryId(int id)
    {
        var gallery = await _dbContext.Exhibitions
            .Select(g => new GalleryExhibitonDto
            {
                galleryId = g.GalleryId,
                name = g.Gallery.Name,
                establishedDate = g.Gallery.EstablishedDate,
                exhibitions = new ExhibitionInfo()
                {
                    title = g.Title,
                    startDate = g.StartDate,
                    endDate = g.EndDate,
                    numberOfArtworks = g.NumberOfArtworks,
                    artworks = g.ExhibitionArtworks.Select(a => new ArtworkInfo()
                    {
                        title = a.Artwork.Title,
                        yearCreated = a.Artwork.YearCreated,
                        insuranceValue = a.InsuranceValue,
                        artist = new ArtistInfo()
                        {
                            firstName = a.Artwork.Artist.FirstName,
                            lastName = a.Artwork.Artist.LastName,
                            birthDate = a.Artwork.Artist.BirthDate
                        }
                    }).ToList()
                }
            }).FirstOrDefaultAsync(g => g.galleryId == id);

        if (gallery is null)
        {
            throw new NotFoundException();
        }
        
        return gallery;
    }

    public async Task createExhibition(PostDTO dto) {
    }
}