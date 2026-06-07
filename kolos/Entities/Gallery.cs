using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolos.Entities;

[Table("Gallery")]
public class Gallery
{
    [Key]
    public int GalleryId { get; set; }
    
    [MaxLength(50)]
    public string Name { get; set; } = null!;
    
    public DateTime EstablishedDate { get; set; }
    
    public ICollection<Exhibition> Exhibitions { get; set; } = null!;
}