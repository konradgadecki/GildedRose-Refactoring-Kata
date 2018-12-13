using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class BackstageItem : Item
    {
        public override void UpdateQuality()
        {
            SellIn--;

            if (SellIn < 0)
            {
                Quality = 0;
            }
            else if (SellIn < 5)
            {
                Quality = Quality + 3;
            }
            else if (SellIn < 10)
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
