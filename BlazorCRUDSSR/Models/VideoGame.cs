using System.ComponentModel.DataAnnotations;

namespace BlazorCRUDSSR.Models
{
    public class VideoGame
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Publisher { get; set; }
        public int? ReleaseYear { get; set; }
        
    }
}
