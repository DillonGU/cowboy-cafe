/*
* Author: Dillon Unruh
* Edited by: Nathan Bean
* Class name: Side
* Purpose: Side Class
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItems, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Size size = Size.Small;
        /// <summary>
        /// Size of type Size that will get and set the size of the side
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
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// special instructions here because of inheritance
        /// </summary>
        public List<string> SpecialInstructions { get; }

        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            

        }
    }
}
