using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Movie
    {
        public int Id { get; set; } //primary key 
        public string? Title { get; set; } // movie title
        // release date
        [DataType(DataType.Date)] 
        public DateTime ReleaseDate { get; set; } // release date

        public string? Genre { get; set; }  // movie category
        public decimal Price { get; set; } // movie price
    }
}
