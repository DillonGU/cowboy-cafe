using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests
{
    public class MenuTests
    {
        /// <summary>
        /// test to see if the entrees returned in menu entrees has all entree types
        /// </summary>
        /// <param name="type">type of side</param>
        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(RustlersRibs))]
        public void MenuEntreeConatinsAllEntrees(Type type)
        {

            var listType = new List<Type>();
            foreach (IOrderItems item in Menu.Entrees)
            {
                listType.Add(item.GetType());
            }
            Assert.Contains(type, listType);

        }


        /// <summary>
        /// makes sure the entrees only have seven items
        /// </summary>
        [Fact]
        public void EntreesShouldOnlyHaveSevenItems()
        {
            Assert.Equal(7, Menu.Entrees.Count());
        }
        /// <summary>
        /// test to see if the sides returned in menu sides has all sides of type side
        /// </summary>
        /// <param name="type">type of side</param>
        [Theory]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(PanDeCampo))]
        public void MenuSideConatinsAllSides(Type type)
        {

            var listType = new List<Type>();
            foreach(IOrderItems item in Menu.Sides)
            {
                listType.Add(item.GetType());
            }
            Assert.Contains(type, listType);

        }
        /// <summary>
        /// makes sure the sides only have four items
        /// </summary>
        [Fact]
        public void SidesShouldOnlyHaveFourItems()
        {
            Assert.Equal(4, Menu.Sides.Count());
        }

        /// <summary>
        /// test to see if the drinks returned in menu drinks has all drinks type
        /// </summary>
        /// <param name="type">type of drink</param>
        [Theory]
        [InlineData(typeof(Water))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(CowboyCoffee))]
        public void MenuDrinksConatinsAllDrinks(Type type)
        {

            var listType = new List<Type>();
            foreach (IOrderItems item in Menu.Drinks)
            {
                listType.Add(item.GetType());
            }
            Assert.Contains(type, listType);

        }
        /// <summary>
        /// makes sure the drinks only have four items
        /// </summary>
        [Fact]
        public void DrinsShouldOnlyHaveFourItems()
        {
            Assert.Equal(4, Menu.Drinks.Count());
        }

        /// <summary>
        /// test to see if all items in menu return
        /// </summary>
        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(Water))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(CowboyCoffee))]
        public void CompleteMenuReturned(Type type)
        {
            var listType = new List<Type>();
            foreach (IOrderItems item in Menu.CompleteMenu)
            {
                listType.Add(item.GetType());
            }
            Assert.Contains(type, listType);

        }
        /// <summary>
        /// test to see if menu count is 15
        /// </summary>
        [Fact]
        public void MenuShouldOnlyHaveFifteenItems()
        {
            Assert.Equal(15, Menu.CompleteMenu.Count());
        }
        /// <summary>
        /// method to help the search method
        /// </summary>
        /// <param name="search">input string</param>
        /// <returns></returns>
        private bool HelperSearch(string search)
        {
            bool found = false;
            foreach(var item in Menu.Search(Menu.CompleteMenu, search))
            {
                if (item.ToString() == search)
                {
                    found = true;
                }
                else
                    found = false;
            }
            return found;
        }
            /// <summary>
            /// test the search function of the menu
            /// </summary>
            /// <param name="search">the term to be searched in the filter</param>
        [Theory]
        [InlineData("Cowpoke Chili")]
        [InlineData("Angry Chicken")]
        [InlineData("Small Baked Beans")]
        [InlineData("Small Chili Cheese Fries")]
        [InlineData("Small Corn Dodgers")]
        [InlineData("Small Cowboy Coffee")]
        [InlineData("Dakota Double Burger")]
        [InlineData("Trail Burger")]
        [InlineData("Small Cream Soda Jerked Soda")]
        [InlineData("Small Pan de Campo")]
        [InlineData("Pecos Pulled Pork")]
        [InlineData("Rustler's Ribs")]
        [InlineData("Texas Triple Burger")]
        [InlineData("Small Texas Sweet Tea")]
        [InlineData("Small Water")]
        
        public void SearchTest(string str) ///////////not for sure about this one
        {
            
            Assert.True(HelperSearch(str));

          
            
        }


       /// <summary>
       /// checks to see if the category filter is working correctly
       /// </summary>
       /// <param name="category">category strings that are passed in/param>

        [Theory]
        [InlineData( "Drink", "Side", "Entree")]
        [InlineData(null, "Side", "Entree")]
        [InlineData("Drink", null, "Entree")] 
        [InlineData("Drink", "Side", null)]
        [InlineData(null, null, null)]
        public void FilterByCategoryWorks(params string[] category)
        {
            string[] name = { "Entree", "Drink", "Side", null };
            IEnumerable<IOrderItems> menu = Menu.CompleteMenu;
            IEnumerable<IOrderItems> itemFilter = Menu.FilterByCategory(menu, category);
            foreach (IOrderItems item in itemFilter)
            {
                if(item is Entree)
                {
                    Assert.IsAssignableFrom<Entree>(item);
                }
                else if (item is Side)
                {
                    Assert.IsAssignableFrom<Side>(item);
                }
                else if (item is Drink)
                {
                    Assert.IsAssignableFrom<Drink>(item);
                }

            }
            
        }

        /// <summary>
        /// check to see if price filter operates correctly
        /// </summary>
        /// <param name="max">maxium price</param>
        /// <param name="min">minimum price</param>
        [Theory]
        [InlineData(4.0, 1.0)]
        [InlineData(null, 1.0)]             
        [InlineData(4.0, null)]
        [InlineData(null, null)]
        public void FilterByPriceWorks(double? max, double? min)
        {

            IEnumerable<IOrderItems> menu = Menu.CompleteMenu;
            IEnumerable<IOrderItems> itemFilter = Menu.FilterByPrice(menu, max, min);
            foreach (IOrderItems item in itemFilter)
            {
                if (max == null && min == null)
                    Assert.Contains(item, menu);
                else if (max == null)
                    Assert.True(item.Price >= min, "item price not in bounds");
                else if (min == null)
                    Assert.True(item.Price <= max, "item price not in bounds");
                else
                    Assert.True(item.Price <= max && item.Price >= min, "Item price not in bounds");


            }
        }

        /// <summary>
        /// checks to see if the calories filter in menu fuctions correctly
        /// </summary>
        /// <param name="max"> max calories</param>
        /// <param name="min">minimum calories</param>
        [Theory]
        [InlineData(200, 100)]
        [InlineData(null, 100)]
        [InlineData(200, null)]                
        [InlineData(null, null)]
        public void FilterByCaloriesWorks(int? max, int? min)
        {

            IEnumerable<IOrderItems> menu = Menu.CompleteMenu;
            IEnumerable<IOrderItems> itemFilter = Menu.FilterByCalories(menu, max, min);
            foreach (IOrderItems item in itemFilter)
            {
                if (max == null && min == null)
                    Assert.Contains(item, menu);
                else if (max == null)
                    Assert.True(item.Calories >= min, "item calories not in bounds");
                else if (min == null)
                    Assert.True(item.Calories <= max, "item calories not in bounds");
                else
                    Assert.True(item.Calories <= max && item.Calories >= min, "Item calories not in bounds");


            }
        }
    }
}
