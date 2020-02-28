/*
* Author: Dillon Unruh
* Class name: Drink
* Purpose: Drink Class
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// public abstract drink base class that holds drink properties.
    /// </summary>
    public abstract class Drink : IOrderItems
    {
        /// <summary>
        /// abstract price property that gets price
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// abstract calories property that gets number of calories
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// abstract list that hold the special instructions for the entrees.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
        /// <summary>
        /// Size of type Size that will get and set the size of the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;
        /// <summary>
        /// a boolean property that gets and sets whether the customer wants ice.
        /// </summary>
        protected bool ice = true;
        /// <summary>
        /// a boolean property that gets and sets whether the customer wants ice.
        /// </summary>
        public virtual bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
    }
}
