﻿/*
* Author: Dillon Unruh
* Class name: Entree
* Purpose: Entree Class
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// abstract base class of entree
    /// </summary>
    public abstract class Entree
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
    }
}
