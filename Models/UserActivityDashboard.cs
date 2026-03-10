namespace demoproject.Models;

/// <summary>
/// DTO representing the user activity dashboard data.
/// </summary>
/// <param name="RecentPosts">A collection of recent user posts.</param>
/// <param name="RecentComments">A collection of recent user comments.</param>
/// <param name="RecentLogins">A collection of recent user login events.</param>
public record UserActivityDashboard(
    IEnumerable<UserPost> RecentPosts,
    IEnumerable<UserComment> RecentComments,
    IEnumerable<LoginHistory> RecentLogins
);