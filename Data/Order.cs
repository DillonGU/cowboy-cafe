using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order
    {
        public IEnumerable<IOrderItems>Items => throw new NotImplementedException();

        public double Subtotal => 0;

        public void Add(IOrderItems item) { }

        public void Remove(IOrderItems item) { }
    }
}
