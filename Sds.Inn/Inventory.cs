using Sds.Inn.DoNotChange;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Sds.Inn.Products;

namespace Sds.Inn;

public class Inventory
{
    private readonly IItemProvider<SdsItem> _itemProvider;

    public Inventory(IItemProvider<SdsItem> itemProvider)
    {
        _itemProvider = itemProvider;
    }

    public void UpdateQuality()
    {
        List<SdsItem> items = _itemProvider.GetItems().ToList();

        items.ForEach(item => item.SettleItemStatus());
    }
}
