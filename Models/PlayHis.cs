using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("PlayHis")]
public class PlayHis
{
    [Key]
    public int Id { get; set; }
    [Required]
    public virtual Game Game { get; set; }
    [Required]
    public virtual Student Student { get; set; }
    [Required]
    public int Point { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    public PlayHis()
    {
        Game = new Game();
        Student = new Student();
    }
    public PlayHis(Game game, Student student, int point)
    {
        Game = game;
        Student = student;
        Point = point;
        CreatedAt = DateTime.Now;
    }
}