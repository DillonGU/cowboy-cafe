﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOrderItems
    {
        /// <summary>
        /// price of this order item
        /// </summary>
        double Price { get; }
        /// <summary>
        /// special instructions for this order item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}