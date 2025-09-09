using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class BookStoreContext : DbContext
{
    public BookStoreContext(DbContextOptions<BookStoreContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Comment> Comments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasMany(b => b.Comments).WithOne(c => c.Book).HasForeignKey(c => c.BookId);
    }
}