namespace csharp
{
    public class Item
    {
        protected readonly int MAX_QUALITY = 50;
        protected readonly int MIN_QUALITY = 0;

        protected virtual int QUALITY_DROP_VALUE { get { return 1; } }

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return Name + ", " + SellIn + ", " + Quality;
        }

        public virtual void UpdateQuality()
        {
            SellIn--;

            if (BeforeSellInDay()) Quality -= QUALITY_DROP_VALUE;
            else Quality -= QUALITY_DROP_VALUE * 2;

            if (QualityIsLessThanMin()) Quality = MIN_QUALITY;
        }

        protected bool QualityExceedsMax()
        {
            return Quality > MAX_QUALITY;
        }

        protected bool QualityIsLessThanMin()
        {
            return Quality < MIN_QUALITY;
        }

        protected bool BeforeSellInDay()
        {
            return SellIn >= 0;
        }
    }
}
