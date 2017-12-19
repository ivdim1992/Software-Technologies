using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace IMDB.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(1)]
        public string Name { get; set; }
        [Required]
        [MinLength(1)]
        public string Genre { get; set; }
        [Required]
        [MinLength(1)]
        public string Director { get; set; }
        [Required]
        [Range(1800,2100)]
        public string Year { get; set; }
    }
}