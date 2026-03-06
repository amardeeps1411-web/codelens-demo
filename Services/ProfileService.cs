using CodeLensAI.Models;
using Microsoft.Extensions.Logging;

namespace CodeLensAI.Services;

/// <summary>
/// Provides services for retrieving user profile information.
/// In Phase 1, this service returns mock data.
/// </summary>
/// <param name="logger">The logger instance injected via primary constructor.</param>
public class ProfileService(ILogger<ProfileService> logger) : IProfileService
{
    /// <summary>
    /// Retrieves the user profile for a given user ID (mock data implementation).
    /// </summary>
    /// <param name="userId">The unique identifier of the user.</param>
    /// <returns>A <see cref="UserProfile"/> object containing mock data.</returns>
    public Task<UserProfile?> GetUserProfileAsync(int userId)
    {
        logger.LogInformation("Retrieving mock user profile for userId: {UserId}", userId);

        // Phase 1: Return mock data
        var mockProfile = new UserProfile
        {
            Id = userId,
            Name = "John Doe",
            Email = "john.doe@example.com"
        };
        
        return Task.FromResult<UserProfile?>(mockProfile);
    }
}
