using System.ComponentModel.DataAnnotations;

namespace MovieSite.Services.DTO
{
    public class MovieEditModel : MovieAddModel
    {
        [Required]
        public int Id { get; set; }
    }
}
