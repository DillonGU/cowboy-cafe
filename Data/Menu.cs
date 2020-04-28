
/*
* Author: Dillon Unruh
* Class name: Menu
* Purpose: Menu Class
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;



namespace CowboyCafe.Data
{
    /// <summary>
    /// static class that holds lists of entrees, drinks, sides
    /// </summary>
    public static class Menu
    {
        public static string[] Categories 
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }
        /// <summary>
        /// makes a lsit of entrees
        /// </summary>
        /// <returns>list of entrees</returns>
        public static IEnumerable<IOrderItems> Entrees
        {
            get
            {
                List<IOrderItems> entrees = new List<IOrderItems>();
                var cowpoke = new CowpokeChili();
                var chicken = new AngryChicken();
                var doubleBurger = new DakotaDoubleBurger();
                var tripleBurger = new TexasTripleBurger();
                var pork = new PecosPulledPork();
                var trailBurger = new TrailBurger();
                var ribs = new RustlersRibs();
                entrees.Add(cowpoke);
                entrees.Add(chicken);
                entrees.Add(doubleBurger);
                entrees.Add(tripleBurger);
                entrees.Add(pork);
                entrees.Add(trailBurger);
                entrees.Add(ribs);

                return entrees;
            }

            
        }
    /// <summary>
    /// makes a list of sides
    /// </summary>
    /// <returns>list of sides</returns>
        public static IEnumerable<IOrderItems> Sides
        {
            get
            {
                var beans = new BakedBeans();
                var dodgers = new CornDodgers();
                var fries = new ChiliCheeseFries();
                var campo = new PanDeCampo();
                List<IOrderItems> sides = new List<IOrderItems>();
                sides.Add(beans);
                sides.Add(dodgers);
                sides.Add(fries);
                sides.Add(campo);
                return sides;
            }
        }
        /// <summary>
        /// makes list of drinks
        /// </summary>
        /// <returns>list of drinks</returns>
        public static IEnumerable<IOrderItems> Drinks
        {
            get
            {
                var soda = new JerkedSoda();
                var tea = new TexasTea();
                var coffee = new CowboyCoffee();
                var water = new Water();
                List<IOrderItems> drinks = new List<IOrderItems>();
                drinks.Add(soda);
                drinks.Add(tea);
                drinks.Add(coffee);
                drinks.Add(water);
                return drinks;
            }
        }
        /// <summary>
        /// makes list of the complete menu
        /// </summary>
        /// <returns>returns the complete menu list</returns>
        public static IEnumerable<IOrderItems> CompleteMenu
        {
            get
            {
                var entrees = Entrees;
                var sides = Sides;
                var drinks = Drinks;
                List<IOrderItems> menu = new List<IOrderItems>();
                foreach (IOrderItems item in entrees)
                {
                    menu.Add(item);
                }
                foreach (IOrderItems item in sides)
                {
                    menu.Add(item);
                }
                foreach (IOrderItems item in drinks)
                {
                    menu.Add(item);
                }
                return menu;
            }
        }
        /// <summary>
        /// helper method for index.html to take in a side and the size of side and make the sides size equal each other
        /// </summary>
        /// <param name="side">spassed in side</param>
        /// <param name="size">passed in siz</param>
        public static void SideSize(Side side, Size size)
        {
            side.Size = size;

        }
        /// <summary>
        /// helper method for index.html to take in a drink and the size of drink and make the drinks and size equal each other
        /// </summary>
        /// <param name="drink">passed in drinks</param>
        /// <param name="size">passed in size</param>
        public static void DrinkSize(Drink drink, Size size)
        {
            drink.Size = size;

        }
        /// <summary>
        /// searches through the iorderitems looking for a match to input string
        /// </summary>
        /// <param name="items">list of items</param>
        /// <param name="term">inputted string</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItems> Search(IEnumerable<IOrderItems> items, string term)
        {
            List<IOrderItems> results = new List<IOrderItems>();
            // Return all movies if there are no search terms
            if (term == null || term == "") return items;
            // return each movie in the database containing the terms substring
            foreach (IOrderItems item in items)
            {
                if (item != null && item.ToString().Contains(term, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// filters the search by categories
        /// </summary>
        /// <param name="items">items</param>
        /// <param name="category">category to filter by</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItems> FilterByCategory(IEnumerable<IOrderItems> items, IEnumerable<string> category)
        {
            // If no filter is specified, just return the provided collection
            if (category == null || category.Count() == 0) return items;
            // Filter the supplied collection of movies
            List<IOrderItems> results = new List<IOrderItems>();
            foreach (IOrderItems item in items)
            {
                if (item != null && item is Entree && category.Contains("Entree"))
                {
                    results.Add(item);
                }
                if (item != null && item is Side && category.Contains("Side"))
                {
                    results.Add(item);
                }
                if (item != null && item is Drink && category.Contains("Drink"))
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// filters the search by calories
        /// </summary>
        /// <param name="items"> all items</param>
        /// <param name="max">max cal</param>
        /// <param name="min">min cal</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItems> FilterByCalories(IEnumerable<IOrderItems> items, int? max, int? min)
        {
            var results = new List<IOrderItems>();
            if (max == null && min == null) return items;
            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItems item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItems item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItems item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// filters search by price
        /// </summary>
        /// <param name="items">all items</param>
        /// <param name="max">max price</param>
        /// <param name="min">min price</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItems> FilterByPrice(IEnumerable<IOrderItems> items, double? max, double? min)
        {
            var results = new List<IOrderItems>();
            if (max == null && min == null) return items;
            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItems item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItems item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItems item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }


    }
}


