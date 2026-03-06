using CodeLensAI.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeLensAI.Data;

/// <summary>
/// Represents the database context for the CodeLensAI application.
/// Defines the structure for the UserProfile table in SQLite.
/// </summary>
/// <param name="options">The options for this context injected via primary constructor.</param>
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    /// <summary>
    /// Gets or sets the DbSet for User Profiles.
    /// This defines the 'UserProfile' table in the SQLite database.
    /// </summary>
    public DbSet<UserProfile> UserProfiles { get; set; }

    /// <summary>
    /// Configures the model that was discovered by convention from the entity types.
    /// </summary>
    /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure UserProfile entity
        modelBuilder.Entity<UserProfile>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(256);
            entity.Property(e => e.Email).IsRequired().HasMaxLength(256);
            // Add unique constraint for email if desired in future phases
            // entity.HasIndex(e => e.Email).IsUnique();

            // Seed data for initial development (optional, but good for testing setup)
            // This isn't strictly part of the 'mock data phase' but defines an initial state if DB were used.
            // For this phase, ProfileService still explicitly returns mock data.
            entity.HasData(
                new UserProfile { Id = 1, Name = "Jane Doe", Email = "jane.doe@example.com" }
            );
        });
    }
}
