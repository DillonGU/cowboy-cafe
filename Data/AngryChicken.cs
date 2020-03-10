/*
* Author: Dillon Unruh
* Class name: Angry Chicken
* Purpose: Entree Class
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree.
    /// </summary>
    public class AngryChicken :Entree
    {
        /// <summary>
        /// gets the price of chicken
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }
        /// <summary>
        /// property gets calories of chicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        private bool bread = true;
        /// <summary>
        /// if they want bread with the chicken.
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set {
                bread = value;
                NotifyOfPropertyChange("Bread");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// if customer wants pickle with the chicken
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set {
                pickle = value;
                NotifyOfPropertyChange("Pickle");
            }
        }
        /// <summary>
        /// special instructions for preparing the chicken.
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
        /// <returns>the string describing the Angry Chicken</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
