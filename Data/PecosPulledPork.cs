using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class representing the Pecos Pulled Pork entree.
    /// </summary>
    public class PecosPulledPork
    {
        /// <summary>
        /// price of the pecos pulled pork
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }
        /// <summary>
        /// gets the calories of pecos pulled pork.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
            }
        }

        private bool bread = true;
        /// <summary>
        /// if they want bread with the pork.
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// if customer wants pickle with the pork
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        /// <summary>
        /// special instructions for preparing the pork.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
    }
}
