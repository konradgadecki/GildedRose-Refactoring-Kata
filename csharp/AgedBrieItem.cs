using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class AgedBrieItem : Item
    {
        private readonly int QUALITY_INCREASE_VALUE = 1;

        public override void UpdateQuality()
        {
            SellIn--;

            if (BeforeSellInDay()) Quality+=QUALITY_INCREASE_VALUE;
            else Quality += QUALITY_INCREASE_VALUE * 2;

            if (QualityExceedsMax()) Quality = MAX_QUALITY;
        }
    }
}
