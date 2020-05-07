using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage = "Title is Required.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Author is Required.")]
        public string Author { get; set; }

        public string Description { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }

        [Required(ErrorMessage = "Total Pages is Required.")]
        [Range(0, 10000)]
        [Display(Name ="Total pages of Book")]
        public int? TotalPages { get; set; }
    }
}
