using System;
using System.Xml.Linq;

namespace Sds.Inn.Products
{
	public class Sulfuras: SdsItem
    {
		public Sulfuras( int sellIn, int quality): base(SDSItemNames.SUFURAS, sellIn, quality)

        {
		}
        public override void SettleItemStatus(int qualityDegradeFactor =1)
        {
           
        }
    }
}

