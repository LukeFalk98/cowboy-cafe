using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.Linq;
using Xunit.Sdk;

namespace CowboyCafe.DataTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldGetEntrees()
        {
            Assert.Collection(Menu.Entrees(),
                item => Assert.IsAssignableFrom<AngryChicken>(item),
                item => Assert.IsAssignableFrom<CowpokeChili>(item),
                item => Assert.IsAssignableFrom<DakotaDoubleBurger>(item),
                item => Assert.IsAssignableFrom<PecosPulledPork>(item),
                item => Assert.IsAssignableFrom<RustlersRibs>(item),
                item => Assert.IsAssignableFrom<TexasTripleBurger>(item),
                item => Assert.IsAssignableFrom<TrailBurger>(item));
        }

        [Fact]
        public void ShouldGetSides()
        {
            Assert.Collection(Menu.Sides(),
                item => Assert.IsAssignableFrom<BakedBeans>(item),
                item => Assert.IsAssignableFrom<BakedBeans>(item),
                item => Assert.IsAssignableFrom<BakedBeans>(item),
                item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
                item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
                item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
                item => Assert.IsAssignableFrom<CornDodgers>(item),
                item => Assert.IsAssignableFrom<CornDodgers>(item),
                item => Assert.IsAssignableFrom<CornDodgers>(item),
                item => Assert.IsAssignableFrom<PanDeCampo>(item),
                item => Assert.IsAssignableFrom<PanDeCampo>(item),
                item => Assert.IsAssignableFrom<PanDeCampo>(item));
        }

        [Fact]
        public void ShouldGetDrinks()
        {
            Assert.Collection(Menu.Drinks(),
                item => Assert.IsAssignableFrom<CowboyCoffee>(item),
                item => Assert.IsAssignableFrom<CowboyCoffee>(item),
                item => Assert.IsAssignableFrom<CowboyCoffee>(item),
                item => Assert.IsAssignableFrom<JerkedSoda>(item),
                item => Assert.IsAssignableFrom<JerkedSoda>(item),
                item => Assert.IsAssignableFrom<JerkedSoda>(item),
                item => Assert.IsAssignableFrom<TexasTea>(item),
                item => Assert.IsAssignableFrom<TexasTea>(item),
                item => Assert.IsAssignableFrom<TexasTea>(item),
                item => Assert.IsAssignableFrom<Water>(item),
                item => Assert.IsAssignableFrom<Water>(item),
                item => Assert.IsAssignableFrom<Water>(item));
        }

        [Fact]
        public void ShouldGetAll()
        {
            Assert.Collection(Menu.CompleteMenu(),
                item => Assert.IsAssignableFrom<AngryChicken>(item),
                item => Assert.IsAssignableFrom<CowpokeChili>(item),
                item => Assert.IsAssignableFrom<DakotaDoubleBurger>(item),
                item => Assert.IsAssignableFrom<PecosPulledPork>(item),
                item => Assert.IsAssignableFrom<RustlersRibs>(item),
                item => Assert.IsAssignableFrom<TexasTripleBurger>(item),
                item => Assert.IsAssignableFrom<TrailBurger>(item),
                item => Assert.IsAssignableFrom<BakedBeans>(item),
                item => Assert.IsAssignableFrom<BakedBeans>(item),
                item => Assert.IsAssignableFrom<BakedBeans>(item),
                item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
                item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
                item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
                item => Assert.IsAssignableFrom<CornDodgers>(item),
                item => Assert.IsAssignableFrom<CornDodgers>(item),
                item => Assert.IsAssignableFrom<CornDodgers>(item),
                item => Assert.IsAssignableFrom<PanDeCampo>(item),
                item => Assert.IsAssignableFrom<PanDeCampo>(item),
                item => Assert.IsAssignableFrom<PanDeCampo>(item),
                item => Assert.IsAssignableFrom<CowboyCoffee>(item),
                item => Assert.IsAssignableFrom<CowboyCoffee>(item),
                item => Assert.IsAssignableFrom<CowboyCoffee>(item),
                item => Assert.IsAssignableFrom<JerkedSoda>(item),
                item => Assert.IsAssignableFrom<JerkedSoda>(item),
                item => Assert.IsAssignableFrom<JerkedSoda>(item),
                item => Assert.IsAssignableFrom<TexasTea>(item),
                item => Assert.IsAssignableFrom<TexasTea>(item),
                item => Assert.IsAssignableFrom<TexasTea>(item),
                item => Assert.IsAssignableFrom<Water>(item),
                item => Assert.IsAssignableFrom<Water>(item),
                item => Assert.IsAssignableFrom<Water>(item));
        }

        [Theory]
        [InlineData("Texas")]
        [InlineData("e")]
        [InlineData("E")]
        [InlineData("asdf")]
        public void SearchGetsSubstrings(string searchArgs)
        {
            var results = Menu.Search(searchArgs);
            foreach (IOrderItem item in results)
            {
                Assert.Contains(searchArgs, item.DisplayName, StringComparison.InvariantCultureIgnoreCase);
            }
        }

        [Fact]
        public void NullSearchReturnsFullList()
        {
            var results = Menu.Search(null);
            Assert.Collection(results,
                item => Assert.IsAssignableFrom<AngryChicken>(item),
                item => Assert.IsAssignableFrom<CowpokeChili>(item),
                item => Assert.IsAssignableFrom<DakotaDoubleBurger>(item),
                item => Assert.IsAssignableFrom<PecosPulledPork>(item),
                item => Assert.IsAssignableFrom<RustlersRibs>(item),
                item => Assert.IsAssignableFrom<TexasTripleBurger>(item),
                item => Assert.IsAssignableFrom<TrailBurger>(item),
                item => Assert.IsAssignableFrom<BakedBeans>(item),
                item => Assert.IsAssignableFrom<BakedBeans>(item),
                item => Assert.IsAssignableFrom<BakedBeans>(item),
                item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
                item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
                item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
                item => Assert.IsAssignableFrom<CornDodgers>(item),
                item => Assert.IsAssignableFrom<CornDodgers>(item),
                item => Assert.IsAssignableFrom<CornDodgers>(item),
                item => Assert.IsAssignableFrom<PanDeCampo>(item),
                item => Assert.IsAssignableFrom<PanDeCampo>(item),
                item => Assert.IsAssignableFrom<PanDeCampo>(item),
                item => Assert.IsAssignableFrom<CowboyCoffee>(item),
                item => Assert.IsAssignableFrom<CowboyCoffee>(item),
                item => Assert.IsAssignableFrom<CowboyCoffee>(item),
                item => Assert.IsAssignableFrom<JerkedSoda>(item),
                item => Assert.IsAssignableFrom<JerkedSoda>(item),
                item => Assert.IsAssignableFrom<JerkedSoda>(item),
                item => Assert.IsAssignableFrom<TexasTea>(item),
                item => Assert.IsAssignableFrom<TexasTea>(item),
                item => Assert.IsAssignableFrom<TexasTea>(item),
                item => Assert.IsAssignableFrom<Water>(item),
                item => Assert.IsAssignableFrom<Water>(item),
                item => Assert.IsAssignableFrom<Water>(item));
        }

        [Fact]
        public void NullCategoryDoesNotChangeList()
        {
            var results = Menu.FilterByCategory(Menu.CompleteMenu(), new List<string>());
            Assert.Collection(results,
               item => Assert.IsAssignableFrom<AngryChicken>(item),
               item => Assert.IsAssignableFrom<CowpokeChili>(item),
               item => Assert.IsAssignableFrom<DakotaDoubleBurger>(item),
               item => Assert.IsAssignableFrom<PecosPulledPork>(item),
               item => Assert.IsAssignableFrom<RustlersRibs>(item),
               item => Assert.IsAssignableFrom<TexasTripleBurger>(item),
               item => Assert.IsAssignableFrom<TrailBurger>(item),
               item => Assert.IsAssignableFrom<BakedBeans>(item),
               item => Assert.IsAssignableFrom<BakedBeans>(item),
               item => Assert.IsAssignableFrom<BakedBeans>(item),
               item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
               item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
               item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
               item => Assert.IsAssignableFrom<CornDodgers>(item),
               item => Assert.IsAssignableFrom<CornDodgers>(item),
               item => Assert.IsAssignableFrom<CornDodgers>(item),
               item => Assert.IsAssignableFrom<PanDeCampo>(item),
               item => Assert.IsAssignableFrom<PanDeCampo>(item),
               item => Assert.IsAssignableFrom<PanDeCampo>(item),
               item => Assert.IsAssignableFrom<CowboyCoffee>(item),
               item => Assert.IsAssignableFrom<CowboyCoffee>(item),
               item => Assert.IsAssignableFrom<CowboyCoffee>(item),
               item => Assert.IsAssignableFrom<JerkedSoda>(item),
               item => Assert.IsAssignableFrom<JerkedSoda>(item),
               item => Assert.IsAssignableFrom<JerkedSoda>(item),
               item => Assert.IsAssignableFrom<TexasTea>(item),
               item => Assert.IsAssignableFrom<TexasTea>(item),
               item => Assert.IsAssignableFrom<TexasTea>(item),
               item => Assert.IsAssignableFrom<Water>(item),
               item => Assert.IsAssignableFrom<Water>(item),
               item => Assert.IsAssignableFrom<Water>(item));
        }

        [Theory]
        [InlineData(true, false, false)]
        [InlineData(false, true, false)]
        [InlineData(false, false, true)]
        [InlineData(true, true, false)]
        [InlineData(true, false, true)]
        [InlineData(false, true, true)]
        [InlineData(true, true, true)]
        public void CategoryFiltersListCorrectly(bool hasEntree, bool hasSide, bool hasDrink)
        {
            var itemTypes = new string[3];
            if (hasEntree) itemTypes[0] = "Entree";
            if (hasSide) itemTypes[1] = "Side";
            if (hasDrink) itemTypes[2] = "Drink";
            var result = Menu.FilterByCategory(Menu.CompleteMenu(), itemTypes);
            foreach(IOrderItem item in result)
            {
                Assert.True(IsA(itemTypes, item));
            }
        }

        [Fact]
        public void NullInputDoesNotChangeListCalories()
        {
            var result = Menu.FilterByCalories(Menu.CompleteMenu(), null, null);
            Assert.Collection(result,
               item => Assert.IsAssignableFrom<AngryChicken>(item),
               item => Assert.IsAssignableFrom<CowpokeChili>(item),
               item => Assert.IsAssignableFrom<DakotaDoubleBurger>(item),
               item => Assert.IsAssignableFrom<PecosPulledPork>(item),
               item => Assert.IsAssignableFrom<RustlersRibs>(item),
               item => Assert.IsAssignableFrom<TexasTripleBurger>(item),
               item => Assert.IsAssignableFrom<TrailBurger>(item),
               item => Assert.IsAssignableFrom<BakedBeans>(item),
               item => Assert.IsAssignableFrom<BakedBeans>(item),
               item => Assert.IsAssignableFrom<BakedBeans>(item),
               item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
               item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
               item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
               item => Assert.IsAssignableFrom<CornDodgers>(item),
               item => Assert.IsAssignableFrom<CornDodgers>(item),
               item => Assert.IsAssignableFrom<CornDodgers>(item),
               item => Assert.IsAssignableFrom<PanDeCampo>(item),
               item => Assert.IsAssignableFrom<PanDeCampo>(item),
               item => Assert.IsAssignableFrom<PanDeCampo>(item),
               item => Assert.IsAssignableFrom<CowboyCoffee>(item),
               item => Assert.IsAssignableFrom<CowboyCoffee>(item),
               item => Assert.IsAssignableFrom<CowboyCoffee>(item),
               item => Assert.IsAssignableFrom<JerkedSoda>(item),
               item => Assert.IsAssignableFrom<JerkedSoda>(item),
               item => Assert.IsAssignableFrom<JerkedSoda>(item),
               item => Assert.IsAssignableFrom<TexasTea>(item),
               item => Assert.IsAssignableFrom<TexasTea>(item),
               item => Assert.IsAssignableFrom<TexasTea>(item),
               item => Assert.IsAssignableFrom<Water>(item),
               item => Assert.IsAssignableFrom<Water>(item),
               item => Assert.IsAssignableFrom<Water>(item));
        }

        [Theory]
        [InlineData(0, 999, false, false)]
        [InlineData(10, 10, false, false)]
        [InlineData(1, 0, false, false)]
        [InlineData(100, 300, false, false)]
        [InlineData(100, 0, false, true)]
        [InlineData(0, 300, true, false)]
        public void CalorieFiltersListCorrectly(int preMin, int preMax, bool one, bool two)
        {
            uint? min = (uint?)preMin;
            uint? max = (uint?)preMax;
            if (one) min = null;
            if (two) max = null;
            var result = Menu.FilterByCalories(Menu.CompleteMenu(), min, max);
            if (min != null)
            {
                foreach (IOrderItem item in result)
                {
                    Assert.True(item.Calories >= min);
                }
            }
            if (max != null)
            {
                foreach(IOrderItem item in result)
                {
                    Assert.True(item.Calories <= max);
                }
            }
        }

        [Fact]
        public void NullInputDoesNotChangeListPrice()
        {
            var result = Menu.FilterByPrice(Menu.CompleteMenu(), null, null);
            Assert.Collection(result,
               item => Assert.IsAssignableFrom<AngryChicken>(item),
               item => Assert.IsAssignableFrom<CowpokeChili>(item),
               item => Assert.IsAssignableFrom<DakotaDoubleBurger>(item),
               item => Assert.IsAssignableFrom<PecosPulledPork>(item),
               item => Assert.IsAssignableFrom<RustlersRibs>(item),
               item => Assert.IsAssignableFrom<TexasTripleBurger>(item),
               item => Assert.IsAssignableFrom<TrailBurger>(item),
               item => Assert.IsAssignableFrom<BakedBeans>(item),
               item => Assert.IsAssignableFrom<BakedBeans>(item),
               item => Assert.IsAssignableFrom<BakedBeans>(item),
               item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
               item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
               item => Assert.IsAssignableFrom<ChiliCheeseFries>(item),
               item => Assert.IsAssignableFrom<CornDodgers>(item),
               item => Assert.IsAssignableFrom<CornDodgers>(item),
               item => Assert.IsAssignableFrom<CornDodgers>(item),
               item => Assert.IsAssignableFrom<PanDeCampo>(item),
               item => Assert.IsAssignableFrom<PanDeCampo>(item),
               item => Assert.IsAssignableFrom<PanDeCampo>(item),
               item => Assert.IsAssignableFrom<CowboyCoffee>(item),
               item => Assert.IsAssignableFrom<CowboyCoffee>(item),
               item => Assert.IsAssignableFrom<CowboyCoffee>(item),
               item => Assert.IsAssignableFrom<JerkedSoda>(item),
               item => Assert.IsAssignableFrom<JerkedSoda>(item),
               item => Assert.IsAssignableFrom<JerkedSoda>(item),
               item => Assert.IsAssignableFrom<TexasTea>(item),
               item => Assert.IsAssignableFrom<TexasTea>(item),
               item => Assert.IsAssignableFrom<TexasTea>(item),
               item => Assert.IsAssignableFrom<Water>(item),
               item => Assert.IsAssignableFrom<Water>(item),
               item => Assert.IsAssignableFrom<Water>(item));
        }

        [Theory]
        [InlineData(0.00, 9999.0)]
        [InlineData(10.0, 10.0)]
        [InlineData(1.0, 0.0)]
        [InlineData(0, 3)]
        [InlineData(1, null)]
        [InlineData(null, 3)]
        [InlineData(-1, -5)]
        public void PriceFiltersListCorrectly(double? min, double? max)
        {
            var result = Menu.FilterByPrice(Menu.CompleteMenu(), min, max);
            if (min != null)
            {
                foreach (IOrderItem item in result)
                {
                    Assert.True(item.Price >= min);
                }
            }
            if (max != null)
            {
                foreach (IOrderItem item in result)
                {
                    Assert.True(item.Price <= max);
                }
            }
        }
        public static bool IsA(string[] itemTypes, object obj)
        {
            if (itemTypes.Contains("Entree"))
            {
                if (obj is Entree) return true;
            }
            if (itemTypes.Contains("Side"))
            {
                if (obj is Side) return true;
            }
            if (itemTypes.Contains("Drink"))
            {
                if (obj is Drink) return true;
            }
            return false;
        }
    }
}
