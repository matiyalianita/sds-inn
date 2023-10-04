using System;
namespace Sds.Inn.Products
{
    public class BackstagePasses : SdsItem
    {
        public BackstagePasses(int sellIn, int quality) : base(SDSItemNames.BACKSTAGE_PASSES, sellIn, quality)
        {
        }

        public override void SettleItemStatus(int qualityDegradeFactor =1)
        {
            SellIn--;

            if (SellIn < 0)
            {
                Quality = 0;
            }
            else
            {
                int qualityIncreaseBy = SellIn <= 5 ? 3 : (SellIn <= 10 ? 2 : 1);
                int newQuality = Quality + qualityIncreaseBy;

                Quality = newQuality > Constants.MAX_QUALITY ? Constants.MAX_QUALITY : newQuality;
            }

        }
    }
}

