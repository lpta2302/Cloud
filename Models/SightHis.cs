using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("SightHis")]
public class SightHis
{
    [Key]
    public int Id { get; set; }
    [Required]
    public virtual Sight  Sight { get; set; }
    [Required]
    public virtual Student  Student { get; set; }
    [Required]
    public int Point { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    public SightHis()
    {
        Sight = new Sight();
        Student = new Student();
    }

    public SightHis(Sight sight, Student student, int point)
    {
        Sight = sight;
        Student = student;
        Point = point;
        CreatedAt = DateTime.Now;
    }
}