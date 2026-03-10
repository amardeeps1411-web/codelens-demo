using demoproject.Models;

namespace demoproject.Interfaces;

/// <summary>
/// Interface for dashboard service operations.
/// </summary>
public interface IDashboardService
{
    /// <summary>
    /// Gets the dashboard data including recent posts, comments, and login history.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains the dashboard data.</returns>
    Task<UserActivityDashboard> GetDashboardDataAsync();
}