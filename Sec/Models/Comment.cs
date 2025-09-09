using System.ComponentModel.DataAnnotations;

public class Comment
{
    public int Id { get; set; }

    [Required]
    public string Text { get; set; }

    [Required]
    public int BookId { get; set; }

    public Book Book { get; set; }
}