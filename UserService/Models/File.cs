using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserService.Models;

[Table("files")]
public class File
{
    
    [Key]
    [Column("file_id")]
    [MaxLength(32)]
    public string FileId { get; set; }
    
    [Column("file_name")]
    public string FileName { get; set; }
    
    [Column("upload_datetime")]
    public DateTime UploadDateTime { get; set; }
    
    [ForeignKey("User")]
    public string UserId { get; set; }
    
    public User User { get; set; }
    
    [ForeignKey("conversion_status_id")]
    public int ConversionStatusId { get; set; }
    
    public ConversionStatus ConversionStatus { get; set; }
    
    [ForeignKey("origin_extension_id")]
    public int OriginExtensionId { get; set; }
    
    public FileExtension OriginExtension { get; set; }
    
    [ForeignKey("target_extension_id")]
    public int TargetExtensionId { get; set; }
    
    public FileExtension TargetExtension { get; set; }
}