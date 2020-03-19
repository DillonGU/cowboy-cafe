/*
* Author: Dillon Unruh
* Class name: Water
* Purpose: Water order Class
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// water drink class inherits from drink
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// price of water
        /// </summary>
        public override double Price { get { return 0.12; } }
        /// <summary>
        /// calories of water
        /// </summary>
        public override uint Calories { get { return 0; } }

        /// <summary>
        /// public bool property that hold whether the water has lemon.
        /// </summary>
        private bool lemon = false;
        /// <summary>
        /// public bool property that hold whether water has lemon.
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                NotifyOfPropertyChange("Lemon");
            }
        }
        /// <summary>
        /// special instructions for water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ice) instructions.Add("Hold Ice");
                if (lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }
        /// <summary>
        /// returns the string representation of this object
        /// </summary>
        /// <returns>the string describing the Water</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Water";

                case Size.Medium:
                    return "Medium Water";
                case Size.Large:
                    return "Large Water";
                default:
                    throw new NotImplementedException();

            }
        }
    }
}
