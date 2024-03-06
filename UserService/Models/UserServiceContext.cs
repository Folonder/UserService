using Microsoft.EntityFrameworkCore;

namespace UserService.Models;

public class UserServiceContext : DbContext
{
    public UserServiceContext(DbContextOptions<UserServiceContext> options) : base(options)
    {
        
    }
    
    public DbSet<User> Users { get; set; }

    public DbSet<File> Files { get; set; }
    
    public DbSet<ConversionStatus> ConversionStatuses { get; set; }
    
    public DbSet<FileExtension> FileExtensions { get; set; }
}