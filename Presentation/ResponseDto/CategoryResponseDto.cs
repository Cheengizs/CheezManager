namespace Presentation.ResponseDto;

public record CategoryResponseDto(
    Guid Id,
    string ShortName,
    string Description
);