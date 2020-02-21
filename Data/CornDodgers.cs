/*
* Author: Dillon Unruh
* Class name: Corn Dodgers
* Purpose: Side Class
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class that holds the calories and price depending on size of dodgers
    /// inherits from side class.
    /// </summary>
    public class CornDodgers : Side
    {
        /// <summary>
        /// number of calories in the dodgers depending on the size of dodgers
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;

                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
                    default:
                        throw new NotImplementedException();
                }

            }
        }
        /// <summary>
        /// the price of the dodgers depending on size of dodgers.
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
        /// <returns>the string describing the corn dodgers</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Corn Dodgers";

                case Size.Medium:
                    return "Medium Corn Dodgers";
                case Size.Large:
                    return "Large Corn Dodgers";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
