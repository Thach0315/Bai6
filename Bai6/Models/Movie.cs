using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bai6.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public String Title { get; set; }
        public DateTime ReleaseData { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price {  get; set; }
        public int GenreID { get; set; }
        public Genre? Genre { get; set; }
    }
}
