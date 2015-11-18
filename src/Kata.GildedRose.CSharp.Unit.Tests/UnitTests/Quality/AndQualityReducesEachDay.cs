﻿using Kata.GildedRose.CSharp.Common.Testing;
using Kata.GildedRose.CSharp.Console;
using NUnit.Framework;
using System.Collections.Generic;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Quality
{
    [TestFixture]
    public class AndQualityReducesEachDay : WhenTestingTheGildedRoseProgram
    {
        protected override void Setup()
        {
            ActualSellinValue = 10;
            ActualQualityValue = 10;
            base.Setup();

            //Create stock items to test
            StockItemsUnderTest = new List<Item> { StockItemUnderTest };
            GildedRoseConsole.Items = StockItemsUnderTest;

            //Create stock items to test
            StockItemsUnderTest = new List<Item> { StockItemUnderTest };

            //Set items on ItemUnderTest
            GildedRoseConsole.Items = StockItemsUnderTest;
        }

        [Test]
        public void ItShouldReturnALowerValue()
        {
            ArrangeAndAct();

            Assert.Less(GetFirstItemInInventory().Quality, ActualQualityValue);
        }

        [Test]
        public void ItShouldDecreaseByAFactorOfOne()
        {
            ArrangeAndAct();

            var factor = ActualQualityValue - GetFirstItemInInventory().Quality;

            Assert.AreEqual(1, factor);
        }

    }
}
