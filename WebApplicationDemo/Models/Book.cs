using System.ComponentModel.DataAnnotations;

namespace WebApplicationDemo.Models
{
    public class Book
    {
        [Required(ErrorMessage = "Book id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Book Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(minimum: 500, maximum: 1000, ErrorMessage = "Book Price is out of range")]
        [Display(Name = "Book Price")]
        public Double Price  { get; set; }

        [Required(ErrorMessage = "Aurhor is required")]
      
        public string AuthorName { get; set; }

       

    }
}
