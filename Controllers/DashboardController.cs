using Microsoft.AspNetCore.Mvc;
using demoproject.Interfaces;
using demoproject.Models;

namespace demoproject.Controllers;

/// <summary>
/// Controller for dashboard operations.
/// </summary>
/// <param name="dashboardService">The dashboard service.</param>
[ApiController]
[Route("api/[controller]")]
public class DashboardController(IDashboardService dashboardService) : ControllerBase
{
    /// <summary>
    /// Gets the user activity dashboard data.
    /// </summary>
    /// <returns>The dashboard data.</returns>
    [HttpGet]
    [ProducesResponseType(typeof(UserActivityDashboard), StatusCodes.Status200OK)]
    public async Task<ActionResult<UserActivityDashboard>> GetDashboard()
    {
        var dashboardData = await dashboardService.GetDashboardDataAsync();
        return Ok(dashboardData);
    }
}