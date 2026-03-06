using CodeLensAI.Models;
using CodeLensAI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeLensAI.Controllers;

/// <summary>
/// API controller for managing user profiles.
/// This simulates the backend endpoint for a User Profile page.
/// </summary>
/// <param name="profileService">The profile service injected via primary constructor.</param>
/// <param name="logger">The logger instance injected via primary constructor.</param>
[ApiController]
[Route("[controller]")]
public class UserProfileController(IProfileService profileService, ILogger<UserProfileController> logger) : ControllerBase
{
    /// <summary>
    /// Retrieves the basic user profile information for the current user.
    /// </summary>
    /// <returns>An action result containing the user profile data.</returns>
    [HttpGet]
    [Route("{userId:int}")] // Example route to fetch by ID
    [ProducesResponseType(typeof(UserProfile), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetUserProfile(int userId)
    {
        logger.LogInformation("Request received for user profile with ID: {UserId}", userId);

        // For Phase 1, we are using mock data, so the userId might not strictly matter
        // if the service always returns the same mock data, but we pass it for consistency.
        var userProfile = await profileService.GetUserProfileAsync(userId);

        if (userProfile is null)
        {
            logger.LogWarning("User profile not found for ID: {UserId}", userId);
            return NotFound($"User profile with ID {userId} not found.");
        }

        logger.LogInformation("Returning user profile for ID: {UserId}", userId);
        return Ok(userProfile);
    }
}
