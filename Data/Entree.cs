/*
* Author: Dillon Unruh
* Class name: Entree
* Purpose: Entree Class
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// abstract base class of entree
    /// </summary>
    public abstract class Entree : IOrderItems, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
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
        /// helper method that notifies the property that the user has changed its value
        /// </summary>
        /// <param name="propertyName">the property that is being changed</param>
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
