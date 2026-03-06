using CodeLensAI.Models;

namespace CodeLensAI.Services;

/// <summary>
/// Defines the contract for retrieving user profile information.
/// </summary>
public interface IProfileService
{
    /// <summary>
    /// Retrieves the user profile for a given user ID.
    /// </summary>
    /// <param name="userId">The unique identifier of the user.</param>
    /// <returns>A <see cref="UserProfile"/> object if found, otherwise null.</returns>
    Task<UserProfile?> GetUserProfileAsync(int userId);
}
