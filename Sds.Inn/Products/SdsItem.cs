using System;
using Sds.Inn.DoNotChange;

namespace Sds.Inn.Products
{
    public class SdsItem : Item, ISettleItemStatus
    {
        public SdsItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }



        public virtual void SettleItemStatus(int qualityDegradeFactor = 1)
        {
            SellIn--;
            if (qualityDegradeFactor > 0)
            {
                int newQuality = 0;
                if (Quality > 0)
                {
                    newQuality = SellIn < 0 ? Quality - 2*qualityDegradeFactor : Quality- qualityDegradeFactor;
                }

                Quality = newQuality < 0 ? 0 : newQuality;
            }

        }
    }
}

