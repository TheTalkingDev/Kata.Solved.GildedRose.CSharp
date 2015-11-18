﻿using NUnit.Framework;
using Kata.GildedRose.CSharp.Console;
using System.Collections.Generic;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Access
{
    [TestFixture]
    public class AndWeSetTheStockItems : WhenTestingTheGildedRoseProgram
    {
        //Override for more local setup
        protected override void Setup()
        {
            ActualSellinValue = 10;
            ActualQualityValue = 10;
            base.Setup();

            //Create stock items to test
            StockItemsUnderTest = new List<Item> { StockItemUnderTest };
            GildedRoseConsole.Items = StockItemsUnderTest;
        }

        [Test]
        public void ItShouldAllowUsToSetAndRetrieveTheItemsCorrectly()
        {
            ArrangeAndAct();
            Assert.AreEqual(StockItemUnderTest, GildedRoseConsole.Items[0]);
        }

        [Test]
        public void ItShouldAllowUsAllowUsToUpdateItemsCorrectly()
        {
            ArrangeAndAct();
            Assert.AreEqual(StockItemUnderTest, GildedRoseConsole.Items[0]);
        }
    }
}
