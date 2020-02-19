/*
* Author: Dillon Unruh
* Class name: Pecos Pulled Pork
* Purpose: Entree Class
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class representing the Pecos Pulled Pork entree.
    /// </summary>
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// price of the pecos pulled pork
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }
        /// <summary>
        /// gets the calories of pecos pulled pork.
        /// </summary>
        public override uint Calories
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
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// returns the string representation of this object
        /// </summary>
        /// <returns>the string describing the Pecos pork</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
