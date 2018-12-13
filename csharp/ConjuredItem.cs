using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ConjuredItem : Item
    {
        public override void UpdateQuality()
        {
            SellIn--;

            if (Quality > 0 && SellIn >= 0)
            {
                Quality = Quality - 2;
            }
            else if (Quality > 3 && SellIn < 0)
            {
                Quality = Quality - 4;
            }
            else
            {
                Quality = 0;
            }
        }
    }
}
