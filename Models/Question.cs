using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.DependencyInjection;

[Table("Question")]
public class Question
{
    [Key]
    public int Id { get; set; }
    [StringLength(2000)]
    public string Content { get; set; }
    public virtual List<Answer> Answers { get; set; }
    [Required]
    public virtual Sight Sight { get; set; }
    public Question()
    {
        Content = "";
        Answers = new List<Answer>();
        Sight = new Sight();
    }
    public Question(string content, List<Answer> answers, Sight sight)
    {
        Content = content;
        Answers = answers;
        Sight = sight;
    }
}