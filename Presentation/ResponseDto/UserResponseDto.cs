namespace Presentation.ResponseDto;

public record UserResponseDto(
    Guid Id,
    string? Username,
    DateTime? CreatedDate,
    string? Email
);