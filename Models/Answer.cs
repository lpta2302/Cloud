using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Answer")]
public class Answer
{
    [Key]
    public int Id { get; set; }
    [StringLength(2000)]
    public string Content { get; set; }
    [Required]
    public virtual Question Question{get;set;}
    public Answer(string content = "")
    {
        Content = content;
        Question = new Question();
    }
}