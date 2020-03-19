using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order :  INotifyPropertyChanged
    {
        
        private List<IOrderItems> items = new List<IOrderItems>();
        public IEnumerable<IOrderItems>Items => items.ToArray();

        
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


        private static uint number = 0;
        public uint OrderNumber { get { return number++; } }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(IOrderItems item) 
        {
            if(item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnItemPropertyChanged;
            }
            //item += OnItemPropertyChanged;
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));



            
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void Remove(IOrderItems item) 
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged -= OnItemPropertyChanged;
            }
            
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));


            
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }

        public void Notify()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
           // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SodaFlavor"));
        }

        
    }
}
