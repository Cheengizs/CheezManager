namespace Presentation.RequestDto;

public record CategoryRequestDto(
    Guid Id,
    string ShortName,
    string Description
);