using CodeLensAI.Models;
using CodeLensAI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace CodeLensAI.Pages;

/// <summary>
/// PageModel for the user profile page.
/// Uses a primary constructor for dependency injection of the user profile service,
/// aligning with .NET 9 features.
/// </summary>
public class ProfileModel(IUserProfileService userProfileService) : PageModel
{
    private readonly IUserProfileService _userProfileService = userProfileService;

    /// <summary>
    /// Gets or sets the UserProfile to be displayed on the page.
    /// This property will hold the data retrieved from the service.
    /// </summary>
    [BindProperty(SupportsGet = true)] 
    public UserProfile UserProfile { get; set; } = default!;

    /// <summary>
    /// Handles the HTTP GET request for the profile page.
    /// Retrieves user profile data using the injected service.
    /// </summary>
    public async Task OnGetAsync()
    {
        UserProfile = await _userProfileService.GetUserProfileAsync();
    }
}
