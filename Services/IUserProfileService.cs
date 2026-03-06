using CodeLensAI.Models;
using System.Threading.Tasks;

namespace CodeLensAI.Services;

/// <summary>
/// Defines the contract for retrieving user profile information.
/// </summary>
public interface IUserProfileService
{
    /// <summary>
    /// Asynchronously retrieves the user's profile.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains the <see cref="UserProfile"/>.</returns>
    Task<UserProfile> GetUserProfileAsync();
}
