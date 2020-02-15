/*
* Author: Dillon Unruh
* Class name: Cowboy Coffee
* Purpose: Cowboy Coffee order Class
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Cowboy Coffee class that inherits from the drink base class
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// price of the Cowboy Coffee depending on the size of drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// calories of the Cowboy Coffee depending on the size of drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// public bool property that hold whether coffee will have room for cream.
        /// </summary>
        private bool roomForCream = false;
        /// <summary>
        /// public bool property that hold whether coffee will have room for cream.
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }
        /// <summary>
        /// public bool property that hold whether coffee will be decaf.
        /// </summary>
        private bool decaf = false;
        /// <summary>
        /// public bool property that hold whether coffee will be decaf.
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }
        /// <summary>
        /// new bool to hide the true bool of ice
        /// </summary>
        private new bool ice = false;
        /// <summary>
        /// override of the ice property from drink
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        /// <summary>
        /// special instructions with the Cowboy Coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (ice) instructions.Add("Add Ice"); //how to set ice default to false?
                if (roomForCream) instructions.Add("Room for Cream");
                if (decaf) instructions.Add("Decaf");

                return instructions;
            }
        }
    }
}
