using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksAuthor.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; } 
        public Author? Author { get; set; }
        public string? BookName { get; set; }    
    }
}
