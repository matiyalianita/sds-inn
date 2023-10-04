namespace Sds.Inn.DoNotChange;

public interface IItemProvider<T> where T : Item
{
    IEnumerable<T> GetItems();
}