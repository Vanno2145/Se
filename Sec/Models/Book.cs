using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Book
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string Author { get; set; }

    [Required]
    public string Genre { get; set; }

    [Required]
    [Range(0.01, 1000.00)]
    public decimal Price { get; set; }

    public ICollection<Comment> Comments { get; set; }
}