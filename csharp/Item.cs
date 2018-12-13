namespace csharp
{
    public class Item
    {
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

            if (Quality > 0 && SellIn >= 0)
            {
                Quality--;
            }
            else if (Quality > 1 && SellIn < 0)
            {
                Quality = Quality - 2;
            }
            else
            {
                Quality = 0;
            }
        }
    }
}
