/*
* Author: Dillon Unruh
* Class name: BakedBeans
* Purpose: Side Class
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class that hold the price and calories of Baked Beans depending on the size of 
    /// Baked Beans
    /// inherits from side class.
    /// </summary>
    public class BakedBeans : Side
    {
        /// <summary>
        /// number of calories in the Baked Beans depending on the size of Baked Beans
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        
                        return 312;
                    case Size.Medium:
                        
                        return 378;
                    case Size.Large:
                        
                        return 410;
                    default:
                        throw new NotImplementedException();
                }

            }
        }
        /// <summary>
        /// the price of the Baked Beans depending on size of Baked Beans.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        
                        return 1.59;
                    case Size.Medium:
                        
                        return 1.79;
                    case Size.Large:
                        
                        return 1.99;
                    default:
                        throw new NotImplementedException();

                }
            }
            
        }

        /// <summary>
        /// returns the string representation of this object
        /// </summary>
        /// <returns>the string describing the baked beans</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Baked Beans";

                case Size.Medium:
                    return "Medium Baked Beans";
                case Size.Large:
                    return "Large Baked Beans";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
