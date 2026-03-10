namespace demoproject.Models;

/// <summary>
/// Represents a user login event.
/// </summary>
/// <param name="Id">The unique identifier of the login history record.</param>
/// <param name="UserId">The identifier of the user who logged in.</param>
/// <param name="Timestamp">The date and time of the login.</param>
/// <param name="IpAddress">The IP address from which the user logged in.</param>
public record LoginHistory(int Id, int UserId, DateTime Timestamp, string IpAddress);