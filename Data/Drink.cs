/*
* Author: Dillon Unruh
* Class name: Drink
* Purpose: Drink Class
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// public abstract drink base class that holds drink properties.
    /// </summary>
    public abstract class Drink : IOrderItems, INotifyPropertyChanged
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
        public abstract List<string> SpecialInstructions { get;}

        private Size size = Size.Small;
        /// <summary>
        /// Size of type Size that will get and set the size of the drink
        /// </summary>
        public Size Size 
        {
            get { return size; }
            set
            {
                size = value;
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Price");
            }
        } 
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
            set 
            { 
                ice = value;
                NotifyOfPropertyChange("Ice");
            }
        }
        /// <summary>
        /// a helper method that will notify the property change to the property from the user.
        /// </summary>
        /// <param name="propertyName">the property that is changed</param>
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
