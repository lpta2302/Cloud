using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("Account")]
public class Account
{
    [Key]
    [StringLength(20)]
    public int Id { get; set; }
    [Required]
    [StringLength(20)]
    public string Username { get; set; }
    [Required]
    [StringLength(20)]
    public string Password { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    public Account(string username = "", string password ="", string name = "")
    {
        Username = username;
        Password = password;
        Name = name;
    }
}
