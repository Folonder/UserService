using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace UserService.Models;

[Table("conversion_status")]
public class ConversionStatus
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("conversion_status_id")]
    public int ConversionStatusId { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
}