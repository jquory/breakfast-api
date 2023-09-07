using BuberBreakfast.Models;
using BuberBreakfast.Services.Breakfasts;

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

    public Breakfast GetBreakfast(Guid id)
    {
        return _breakfast[id];
    }
}