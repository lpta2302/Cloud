using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("TPointHis")]
public class TPointHis
{
    [Key]
    public int Id { get; set; }
    [Required]
    public virtual Student Student { get; set; }
    [Required]
    public int Point { get; set; }
    [StringLength(2000)]
    public string? Content { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    public TPointHis()
    {
        Student = new Student();
    }
    public TPointHis(Student student, int point, string? content)
    {
        Student = student;
        Point = point;
        Content = content;
        CreatedAt = DateTime.Now;
    }
}