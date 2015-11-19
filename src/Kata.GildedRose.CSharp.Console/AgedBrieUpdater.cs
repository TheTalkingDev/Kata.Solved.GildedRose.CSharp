﻿using Kata.GildedRose.CSharp.Domain;

namespace Kata.GildedRose.CSharp.Console
{
    public class AgedBrieUpdater : IStockItemUpdateStrategy
    {
        public void UpdateItem(Item item)
        {
            item.SellIn--;
            if (item.Quality < 50) item.Quality++;
        }
    }
}