using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("KeyAnswer")]
public class KeyAnswer
{
    [Key]
    public int Id { get; set; }
    [Required]
    public virtual Answer Answer { get; set; }
    public KeyAnswer()
    {
        Answer = new Answer();
    }
    public KeyAnswer(Answer answer)
    {
        Answer = answer;
    }
}