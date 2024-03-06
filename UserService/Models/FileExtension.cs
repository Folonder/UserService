using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserService.Models;

[Table("file_extensions")]
public class FileExtension
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("file_extension_id")]
    public int FileExtensionId { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
}