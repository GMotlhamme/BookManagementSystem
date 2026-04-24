using BookManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagementSystem.Data
{
    public class BookManagementSystemDbContext : DbContext
    {
        public BookManagementSystemDbContext(DbContextOptions<BookManagementSystemDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
