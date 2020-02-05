using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the Rustler's Ribs entree.
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// Property that gets the price of the ribs.
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }
        /// <summary>
        /// property that gets the calories of the ribs.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// special instructions for preparing the Rustler Ribs.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }
    }
}
