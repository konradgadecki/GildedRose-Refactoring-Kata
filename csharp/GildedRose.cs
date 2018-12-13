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
                item.UpdateQuality();
            }
        }
    }
}
