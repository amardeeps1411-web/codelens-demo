namespace CodeLensAI.Models;

/// <summary>
/// Represents the basic user profile information.
/// This model also serves as the entity for the database table structure.
/// </summary>
public record UserProfile
{
    /// <summary>
    /// Gets or sets the unique identifier for the user profile.
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Gets or sets the full name of the user.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Gets or sets the email address of the user.
    /// </summary>
    public required string Email { get; init; }
}
