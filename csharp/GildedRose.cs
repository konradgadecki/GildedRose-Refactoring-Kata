using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace csharp
{
    public class GildedRose
    {
        private IList<Item> _items;

        public GildedRose(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                if (item.Name.Equals("Sulfuras, Hand of Ragnaros")) continue;

                item.SellIn--;

                switch (item.Name)
                {
                    case "Aged Brie":
                        UpdateAgedBrie(item);
                        break;

                    case "Backstage passes to a TAFKAL80ETC concert":
                        UpdateBackstage(item);
                        break;

                    case "Conjured Mana Cake":
                        UpdateConjured(item);
                        break;

                    default:
                        UpdateAnyItem(item);
                        break;
                }
            }
        }

        private void UpdateAnyItem(Item item)
        {
            if (item.Quality > 0 && item.SellIn >= 0)
            {
                item.Quality--;
            }
            else if (item.Quality > 1 && item.SellIn < 0)
            {
                item.Quality = item.Quality - 2;
            }
            else
            {
                item.Quality = 0;
            }
        }

        private void UpdateConjured(Item item)
        {
            if (item.Quality > 0 && item.SellIn >= 0)
            {
                item.Quality = item.Quality - 2;
            }
            else if (item.Quality > 3 && item.SellIn < 0)
            {
                item.Quality = item.Quality - 4;
            }
            else
            {
                item.Quality = 0;
            }
        }

        private void UpdateBackstage(Item item)
        {
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else if (item.SellIn < 5)
            {
                item.Quality = item.Quality + 3;
            }
            else if (item.SellIn < 10)
            {
                item.Quality = item.Quality + 2;
            }
            else
            {
                item.Quality++;
            }

            if (item.Quality > 50) item.Quality = 50;
        }

        private void UpdateAgedBrie(Item item)
        {
            if (item.SellIn < 0)
            {
                item.Quality = item.Quality + 2;
            }
            else
            {
                item.Quality++;
            }

            if (item.Quality > 50) item.Quality = 50;
        }
    }
}
