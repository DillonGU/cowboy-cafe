using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class representing the Trailburger entree.
    /// </summary>
    public class TrailBurger
    {
        /// <summary>
        /// gets price of the trailburger
        /// </summary>
        public double Price
        {
            get
            {
                return 4.50;
            }
        }
        /// <summary>
        /// gets the calories of the trailburger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 288;
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// if the trailburger has ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        private bool mustard = true;
        /// <summary>
        /// if the trailburger has mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// if customer wants pickle with the trailburger
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        private bool cheese = true;
        /// <summary>
        /// if customer wants cheese with trailburger.
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        private bool bun = true;
        /// <summary>
        /// allows bun on burger
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }
        /// <summary>
        /// special instructions for preparing the trailburger.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                if (!bun) instructions.Add("hold bun");

                return instructions;
            }
        }
    }
}
