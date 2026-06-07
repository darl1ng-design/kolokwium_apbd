namespace kolos.dto;

public class GalleryExhibitonDto
{
    public int galleryId { get; set; }
    public string name { get; set; }
    public DateTime establishedDate { get; set; }
    public ExhibitionInfo exhibitions { get; set; }
}


public class ExhibitionInfo
{
    public string title { get; set; }
    public DateTime startDate { get; set; }
    public DateTime? endDate { get; set; }
    public int numberOfArtworks  { get; set; }
    public List<ArtworkInfo> artworks { get; set; }
}


public class ArtworkInfo
{
    public string title { get; set; }
    public int yearCreated { get; set; }
    public double insuranceValue { get; set; }
    public ArtistInfo artist  { get; set; }
}

public class ArtistInfo
{
    public string firstName  { get; set; }
    public string lastName  { get; set; }
    public DateTime birthDate { get; set; }
}