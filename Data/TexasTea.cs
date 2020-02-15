/*
* Author: Dillon Unruh
* Class name: Texas Tea
* Purpose: Texas Tea order Class
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// public class texas tea drink that inherits drink class.
    /// </summary>
    public class TexasTea : Drink
    {
        /// <summary>
        /// public bool property that hold whether tea will be sweet.
        /// </summary>
        private bool sweet = true;
        /// <summary>
        /// public bool property that hold whether tea will be sweet.
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; }
        }
        /// <summary>
        /// price of the Texas Tea depending on the size of drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// calories of the Texas Tea depending on the size of drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small && sweet)
                    return 10;
                else if (Size == Size.Medium && sweet)
                    return 22;
                else if (Size == Size.Large && sweet)
                    return 36;
                else if (Size == Size.Small && !sweet)
                    return 5;
                else if (Size == Size.Medium && !sweet)
                    return 11;
                else if (Size == Size.Large && !sweet)
                    return 18;
                else
                    throw new NotImplementedException();
            }
        }
        /// <summary>
        /// public bool property that hold whether the tea has lemon.
        /// </summary>
        private bool lemon = false;
        /// <summary>
        /// public bool property that hold whether Tea has lemon.
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }
        /// <summary>
        /// special instructions with the Texas Tea
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
    }
}
