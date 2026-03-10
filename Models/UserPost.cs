namespace demoproject.Models;

/// <summary>
/// Represents a post created by a user.
/// </summary>
/// <param name="Id">The unique identifier of the post.</param>
/// <param name="UserId">The identifier of the user who created the post.</param>
/// <param name="Content">The content of the post.</param>
/// <param name="CreatedAt">The date and time when the post was created.</param>
public record UserPost(int Id, int UserId, string Content, DateTime CreatedAt);