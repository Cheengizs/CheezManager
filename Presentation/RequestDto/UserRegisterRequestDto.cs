namespace Presentation.RequestDto;

public record UserRegisterRequestDto(
    string? Username,
    string Email,
    string? Password
    );
