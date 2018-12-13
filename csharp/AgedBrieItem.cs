using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class AgedBrieItem : Item
    {
        public override void UpdateQuality()
        {
            SellIn--;

            if (SellIn < 0)
            {
                Quality = Quality + 2;
            }
            else
            {
                Quality++;
            }

            if (Quality > 50) Quality = 50;
        }
    }
}
