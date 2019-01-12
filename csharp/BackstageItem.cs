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

            if (!BeforeSellInDay()) Quality = MIN_QUALITY;
            else IncreaseQuality();

            if (QualityExceedsMax()) Quality = MAX_QUALITY;
        }

        private void IncreaseQuality()
        {
            Quality++;
            if (LessThan10DaysToConcert()) Quality++;
            if (LessThan5DaysToConcert()) Quality++;
        }


        private bool LessThan5DaysToConcert()
        {
            return SellIn < 5;
        }


        private bool LessThan10DaysToConcert()
        {
            return SellIn < 10;
        }
    }
}
