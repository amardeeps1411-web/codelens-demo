using CodeLensAI.Models;
using CodeLensAI.Services;
using System.Threading.Tasks;

namespace CodeLensAI.Services;

/// <summary>
/// Provides mock user profile data for development and testing purposes.
/// Uses a primary constructor, aligning with modern C# practices.
/// </summary>
public class MockUserProfileService : IUserProfileService
{
    // Primary constructor: Even without explicit parameters, it's good practice for consistency
    // and future-proofing if dependencies are later added.
    public MockUserProfileService() { }

    /// <inheritdoc/>
    public Task<UserProfile> GetUserProfileAsync()
    {
        // Simulate an asynchronous operation by returning a completed task with mock data.
        var mockProfile = new UserProfile(
            Name: "Jane Doe",
            Email: "jane.doe@example.com"
        );
        return Task.FromResult(mockProfile);
    }
}
