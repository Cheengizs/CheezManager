namespace Presentation.RequestDto;

public record GoalRequestDto(
    Guid Id,
    string ShortName,
    string Description,
    DateTime CreatedDate,
    DateTime EndDate,
    DateTime EstimatedEndDate,
    int Amount,
    bool IsCompleted
);
