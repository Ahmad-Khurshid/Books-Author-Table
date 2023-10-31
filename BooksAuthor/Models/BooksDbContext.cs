using Microsoft.EntityFrameworkCore;
namespace BooksAuthor.Models
{
    public class BooksDbContext : DbContext
    {
        public BooksDbContext(DbContextOptions options) : base(options) 
        {

        } 
        public DbSet<Books> Books_Table { get; set; }
        public DbSet<Author> Author_Table { get; set; }
    }
}
