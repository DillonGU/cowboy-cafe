
/*
* Author: Dillon Unruh
* Class name: Menu
* Purpose: Menu Class
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// static class that holds lists of entrees, drinks, sides
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// makes a lsit of entrees
        /// </summary>
        /// <returns>list of entrees</returns>
        public static IEnumerable<IOrderItems> Entrees()
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
    /// <summary>
    /// makes a list of sides
    /// </summary>
    /// <returns>list of sides</returns>
        public static IEnumerable<IOrderItems> Sides()
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
        /// <summary>
        /// makes list of drinks
        /// </summary>
        /// <returns>list of drinks</returns>
        public static IEnumerable<IOrderItems> Drinks()
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
        /// <summary>
        /// makes list of the complete menu
        /// </summary>
        /// <returns>returns the complete menu list</returns>
        public static IEnumerable<IOrderItems> CompleteMenu()
        {
            var entrees = Entrees();
            var sides = Sides();
            var drinks = Drinks();
            List<IOrderItems> menu = new List<IOrderItems>();
            foreach(IOrderItems item in entrees)
            {
                menu.Add(item);
            }
            foreach(IOrderItems item in sides)
            {
                menu.Add(item);
            }
            foreach(IOrderItems item in drinks)
            {
                menu.Add(item);
            }
            return menu;
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

    }
}


