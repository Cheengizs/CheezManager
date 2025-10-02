namespace Presentation.ResponseDto;

public record GoalResponseDto(
    Guid Id,
    string ShortName,
    string Description,
    DateTime CreatedDate,
    DateTime EndDate,
    DateTime EstimatedEndDate,
    int Amount,
    bool IsCompleted
);