using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UserService.Models;


[Table("users")]
[Index(nameof(Name), IsUnique = true)]
public class User
{
    [Column("user_id")]
    [Key]
    public string UserId { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("password_hash")]
    public string PasswordHash { get; set; }
    
    [Column("registration_date", TypeName = "Date")]
    public DateTime RegistrationDate { get; set; }
}