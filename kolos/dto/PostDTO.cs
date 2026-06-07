namespace kolos.dto;

public class PostDTO
{
    public string title {get; set;}
    public string gallery {get; set;}
    public DateTime startDate {get; set;}
    public DateTime? endDate {get; set;}
    public ArtworkInfoPost artworks { get; set; }
}

public class ArtworkInfoPost
{
    public ArtworkInfoPost(int artworkId, double insuranceValue)
    {
        this.artworkId = artworkId;
        this.insuranceValue = insuranceValue;
    }

    public int artworkId {get; set;}
    public double insuranceValue { get; set; }
}