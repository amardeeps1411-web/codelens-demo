using demoproject.Data;
using demoproject.Interfaces;
using demoproject.Models;
using Microsoft.EntityFrameworkCore;

namespace demoproject.Services;

/// <summary>
/// Implementation of the dashboard service.
/// </summary>
/// <param name="dbContext">The database context.</param>
public class DashboardService(AppDbContext dbContext) : IDashboardService
{
    /// <inheritdoc />
    public async Task<UserActivityDashboard> GetDashboardDataAsync()
    {
        var recentPosts = await dbContext.UserPosts
            .OrderByDescending(p => p.CreatedAt)
            .Take(10)
            .ToListAsync();

        var recentComments = await dbContext.UserComments
            .OrderByDescending(c => c.CreatedAt)
            .Take(10)
            .ToListAsync();

        var recentLogins = await dbContext.LoginHistories
            .OrderByDescending(l => l.Timestamp)
            .Take(10)
            .ToListAsync();

        return new UserActivityDashboard(recentPosts, recentComments, recentLogins);
    }
}