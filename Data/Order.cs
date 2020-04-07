/*
* Author: Dillon Unruh
* Class name: Order Class
* Purpose: Class that holds the underlying functions of an order.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// order class 
    /// </summary>
    public class Order :  INotifyPropertyChanged
    {
        
        private List<IOrderItems> items = new List<IOrderItems>();
        /// <summary>
        /// items property that gets items into an array to be processed
        /// </summary>
        public IEnumerable<IOrderItems>Items => items.ToArray();

        /// <summary>
        /// subtotal property that calculates the subtotal
        /// </summary>
        public double Subtotal 
        { 
            get 
            {
                double result = 0;
                foreach(IOrderItems item in Items)
                {
                    result += item.Price;
                }
                return result ; 
            }  
        }

        public double Total
        {
            get
            {
                double total = 0; //Math.Round(orders.Total * 100f) / 100f
                total = Math.Round(((Subtotal * 0.16) + Subtotal)* 100f) /100;
                return total;
            }
        }

        
        private static uint number = 0;
        /// <summary>
        /// order number property that increments the order number after an order is complete or cancelled
        /// </summary>
        public uint OrderNumber { get { return number++; } }

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// adds an item to the list
        /// </summary>
        /// <param name="item">selected item</param>
        public void Add(IOrderItems item) 
        {
            if(item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnItemPropertyChanged;
            }
            
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));



            
            
        }
        /// <summary>
        /// removes an item from the list
        /// </summary>
        /// <param name="item">selected item</param>
        public void Remove(IOrderItems item) 
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged -= OnItemPropertyChanged;
            }
            
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));


            
            
        }
        /// <summary>
        ///  event handler method that changes the items property
        /// </summary>
        /// <param name="sender">??</param>
        /// <param name="e">???</param>
        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }
        /// <summary>
        /// invokes a new item adn subtotal on the event of a property changed.
        /// </summary>
        public void Notify()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
           
        }

        
    }
}
