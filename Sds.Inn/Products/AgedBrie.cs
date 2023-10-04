using System;
namespace Sds.Inn.Products
{
	public class AgedBrie: SdsItem
	{
		public AgedBrie( int sellIn, int quality) : base(SDSItemNames.AGED_BRIE, sellIn, quality)
		{
		}
        public override void SettleItemStatus(int qualityDegradeFactor =1)
        {
            SellIn--;
            if (Quality < Constants.MAX_QUALITY)
            {
                Quality++;
            }
        }
    }
}

