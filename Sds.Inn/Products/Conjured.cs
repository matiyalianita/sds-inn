using System;
namespace Sds.Inn.Products
{
    public class Conjured : SdsItem
    {
        public Conjured(int sellIn, int quality) : base(SDSItemNames.CONJURED, sellIn, quality)
        {

        }
        public override void SettleItemStatus(int qualityDegradeFactor)
        {
            base.SettleItemStatus(2);
            
        }
    }
}


