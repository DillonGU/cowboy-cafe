/*
* Author: Dillon Unruh
* Class name: Jerked Soda
* Purpose: Jerked Soda order Class
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Jerked soda class that inherits from  the drink base class
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// price of the jerked soda depending on the size of drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// calories of the jerked soda depending on the size of drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// property for the soda flavor get and sets the soda flavor.
        /// </summary>
        public SodaFlavor Flavor { get; set; }
        /// <summary>
        /// special instructions with the jerked soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ice) instructions.Add("Hold Ice");
                

                return instructions;
            }
        }
        /// <summary>
        /// returns the string representation of this object
        /// </summary>
        /// <returns>the string describing the jerked soda</returns>
        public override string ToString()
        {
            if (Size == Size.Small && Flavor == SodaFlavor.CreamSoda)
                return "Small Cream Soda Jerked Soda";
            if (Size == Size.Small && Flavor == SodaFlavor.BirchBeer)
                return "Small Birch Beer Jerked Soda";
            if (Size == Size.Small && Flavor == SodaFlavor.OrangeSoda)
                return "Small Orange Soda Jerked Soda";
            if (Size == Size.Small && Flavor == SodaFlavor.RootBeer)
                return "Small Root Beer Jerked Soda";
            if (Size == Size.Small && Flavor == SodaFlavor.Sarsparilla)
                return "Small Sarsparilla Jerked Soda";
            if (Size == Size.Medium && Flavor == SodaFlavor.CreamSoda)
                return "Medium Cream Soda Jerked Soda";
            if (Size == Size.Medium && Flavor == SodaFlavor.BirchBeer)
                return "Medium Birch Beer Jerked Soda";
            if (Size == Size.Medium && Flavor == SodaFlavor.OrangeSoda)
                return "Medium Orange Soda Jerked Soda";
            if (Size == Size.Medium && Flavor == SodaFlavor.RootBeer)
                return "Medium Root Beer Jerked Soda";
            if (Size == Size.Medium && Flavor == SodaFlavor.Sarsparilla)
                return "Medium Sarsparilla Jerked Soda";
            if (Size == Size.Large && Flavor == SodaFlavor.CreamSoda)
                return "Large Cream Soda Jerked Soda";
            if (Size == Size.Large && Flavor == SodaFlavor.BirchBeer)
                return "Large Birch Beer Jerked Soda";
            if (Size == Size.Large && Flavor == SodaFlavor.OrangeSoda)
                return "Large Orange Soda Jerked Soda";
            if (Size == Size.Large && Flavor == SodaFlavor.RootBeer)
                return "Large Root Beer Jerked Soda";
            if (Size == Size.Large && Flavor == SodaFlavor.Sarsparilla)
                return "Large Sarsparilla Jerked Soda";
            else
                throw new NotImplementedException();

        }

    }
}
