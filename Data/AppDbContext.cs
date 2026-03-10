using Microsoft.EntityFrameworkCore;
using demoproject.Models;

namespace demoproject.Data;

/// <summary>
/// Database context for the application.
/// </summary>
/// <param name="options">The context options.</param>
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    /// <summary>
    /// Gets or sets the user profiles.
    /// </summary>
    public DbSet<UserProfile> UserProfiles => Set<UserProfile>();

    /// <summary>
    /// Gets or sets the user posts.
    /// </summary>
    public DbSet<UserPost> UserPosts => Set<UserPost>();

    /// <summary>
    /// Gets or sets the user comments.
    /// </summary>
    public DbSet<UserComment> UserComments => Set<UserComment>();

    /// <summary>
    /// Gets or sets the login history records.
    /// </summary>
    public DbSet<LoginHistory> LoginHistories => Set<LoginHistory>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<UserProfile>().HasKey(u => u.Id);
        modelBuilder.Entity<UserPost>().HasKey(p => p.Id);
        modelBuilder.Entity<UserComment>().HasKey(c => c.Id);
        modelBuilder.Entity<LoginHistory>().HasKey(l => l.Id);
    }
}