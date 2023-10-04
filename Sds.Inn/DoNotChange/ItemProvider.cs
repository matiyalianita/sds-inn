using Sds.Inn.Products;

namespace Sds.Inn.DoNotChange;

public class ItemProvider : IItemProvider<SdsItem>
{
    private IList<SdsItem> _items = new List<SdsItem>
    {
        new SdsItem(SDSItemNames.DEXTERITY_VEST, 10, 20),
        new AgedBrie( 2, 0),
        new SdsItem (SDSItemNames.ELIXIR_OF_THE_MONGOOSE, 5, 7),
        new Sulfuras( 0, 80),
        new BackstagePasses( 15, 20),
        new Conjured( 3, 6)
    };

    public IEnumerable<SdsItem> GetItems()
    {
        return _items.ToArray();
    }
}
