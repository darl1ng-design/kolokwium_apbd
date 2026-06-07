using kolos.dto;

namespace kolos.service;

public interface IDBService
{
    Task<GalleryExhibitonDto> getExhibitionsByGalleryId(int id);
    Task createExhibition(PostDTO dto);
}