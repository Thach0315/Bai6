using System.ComponentModel.DataAnnotations;

namespace Bai6.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Loi, vui long nhap tu 3 den 100 ky tu")]
        public String Name { get; set; }

        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}
