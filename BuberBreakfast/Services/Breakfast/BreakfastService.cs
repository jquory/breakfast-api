using BuberBreakfast.Models;
using BuberBreakfast.ServiceErrors;
using BuberBreakfast.Services.Breakfasts;
using ErrorOr;

public class BreakfastService : IBreakfastService
{
    private static readonly Dictionary<Guid, Breakfast> _breakfast = new();
    public void CreateBreakfast(Breakfast breakfast)
    {
        _breakfast.Add(breakfast.Id, breakfast);
    }

    public void UpsertBreakfast(Breakfast breakfast)
    {
        _breakfast[breakfast.Id] = breakfast;
    }

    public Breakfast DeleteBreakfast(Guid id)
    {
        var deletedBreakfast = _breakfast[id];
        _breakfast.Remove(id);
        return deletedBreakfast;
    }

    public ErrorOr<Breakfast> GetBreakfast(Guid id)
    {
        if (_breakfast.TryGetValue(id, out var breakfast))
        {
            return breakfast;
        }

        return Errors.Breakfast.NotFound;
    }
}