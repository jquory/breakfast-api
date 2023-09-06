namespace BuberBreakfast.Contracts.Breakfast;

public record CreateBreakfastRequest(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDate,
    DateTime EndDate,
    DateTime LastModifiedTime,
    List<string> Savory,
    List<string> Sweet
)