namespace Presentation.RequestDto;

public record UserRequestDto(
    Guid? UserId,
    string? Username,
    DateTime? CreatedDate,
    string? Email
);