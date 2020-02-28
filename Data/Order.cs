using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order : IOrderItems, INotifyPropertyChanged
    {
        private List<IOrderItems> items = new List<IOrderItems>();
        public IEnumerable<IOrderItems>Items => items.ToArray();

        public double Subtotal 
        { 
            get
            {
                Price += Price;
                return Price;
            }
        }

        public uint OrderNumber { get; }

        public double Price { get; set; }

        public List<string> SpecialInstructions { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(IOrderItems item) 
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public void Remove(IOrderItems item) 
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        
    }
}
