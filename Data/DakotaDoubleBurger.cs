/*
* Author: Dillon Unruh
* Class name: Dakota Double Burger
* Purpose: Entree Class
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class that represents the Dakota Double Burger entree.
    /// </summary>
    public class DakotaDoubleBurger : Entree
    {
        /// <summary>
        /// gets price of the Dakota Double Burger.
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }
        /// <summary>
        /// gets the calories of the double burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// if the double burger has ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { 
                ketchup = value;
                NotifyOfPropertyChange("Ketchup");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// if the double burger has mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set {
                mustard = value;
                NotifyOfPropertyChange("Mustard");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// if customer wants pickle with the double burger
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set {
                pickle = value;
                NotifyOfPropertyChange("Pickle");
            }
        }

        private bool cheese = true;
        /// <summary>
        /// if customer wants cheese with double burger.
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set {
                cheese = value;
                NotifyOfPropertyChange("Cheese");
            }
        }

        private bool tomato = true;
        /// <summary>
        /// if customer wants tomato with double burger.
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set {
                tomato = value;
                NotifyOfPropertyChange("Tomato");
            }
        }

        private bool lettuce = true;
        /// <summary>
        /// if customer wants lettuce with double burger.
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { 
                lettuce = value;
                NotifyOfPropertyChange("Lettuce");
            }
        }

        private bool mayo = true;
        /// <summary>
        /// if customer wants mayo with double burger.
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set {
                mayo = value;
                NotifyOfPropertyChange("Mayo");
            }
        }

        private bool bun = true;
        /// <summary>
        /// allows bun on burger
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set {
                bun = value;
                NotifyOfPropertyChange("Bun");
            }
        }
        /// <summary>
        /// special instructions for preparing the doubleburger.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");
                if (!bun) instructions.Add("hold bun");

                return instructions;
            }
        }

        /// <summary>
        /// returns the string representation of this object
        /// </summary>
        /// <returns>the string describing the dakota double</returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
