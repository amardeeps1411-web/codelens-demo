namespace demoproject.Models;

/// <summary>
/// Represents a comment made by a user.
/// </summary>
/// <param name="Id">The unique identifier of the comment.</param>
/// <param name="UserId">The identifier of the user who made the comment.</param>
/// <param name="Content">The content of the comment.</param>
/// <param name="CreatedAt">The date and time when the comment was made.</param>
public record UserComment(int Id, int UserId, string Content, DateTime CreatedAt);