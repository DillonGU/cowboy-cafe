/*
* Author: Dillon Unruh
* Class name: PanDeCampo
* Purpose: Side Class
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class that holds the calories and the price of the pan de campo
    /// inherits from side class.
    /// </summary>
    public class PanDeCampo : Side
    {
        /// <summary>
        /// number of calories in the de Campo depending on the size of de Campo
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 227;

                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
                    default:
                        throw new NotImplementedException();
                }

            }
        }
        /// <summary>
        /// the price of the de Campo depending on size of de Campo.
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
    }
}

