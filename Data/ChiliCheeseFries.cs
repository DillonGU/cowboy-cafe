/*
* Author: Dillon Unruh
* Class name: Chili Cheese Fries
* Purpose: Side Class
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class that hold the calories and the price depending on size of fries. inherits side class
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// number of calories depending on the size of fries.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 433;
                        
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
                
            }
        }
        /// <summary>
        /// the price of the fries depending on size of fries.
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                        
                }
            }
        }
        /// <summary>
        /// returns the string representation of this object
        /// </summary>
        /// <returns>the string describing the chili cheese fries</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Chili Cheese Fries";

                case Size.Medium:
                    return "Medium Chili Cheese Fries";
                case Size.Large:
                    return "Large Chili Cheese Fries";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
