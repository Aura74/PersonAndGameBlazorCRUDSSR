using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCRUDSSR.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? City { get; set; }

        public int? BirthYear { get; set; }



        public VideoGame? FavoriteGame { get; set; }
    }
}
