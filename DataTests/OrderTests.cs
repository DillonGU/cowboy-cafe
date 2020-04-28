using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.Linq;

namespace CowboyCafe.DataTests
{
   class MocKOrderItem :IOrderItems
    {
        public double Price { get; set; }

        public uint Calories { get; set; }

        public List<string> SpecialInstructions { get; set; }
    }
    public class OrderTests
    {
        //adding something to the order should have it appaear in the Items Property
        [Fact]
        public void AddedIOrderItemsAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MocKOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }
        [Fact]
        public void RemovedIOrderItemsDoesNotAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MocKOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }
        [Theory]
        [InlineData(new double[] {  })]
        [InlineData(new double[] { 0 })]
        [InlineData(new double[] { 10, 15, 18 })]
        [InlineData(new double[] { 20, -4, 3.6, 8 })]
        [InlineData(new double[] { -100, -5 })]
        public void SubtotalShouldBeTheSumOfAllAddedItems(double[] prices)
        {
            double total = 0;
            var order = new Order();
            foreach(var price in prices)
            {
                total += price;
                order.Add(new MocKOrderItem()
                {
                    Price = price
                });
            }
            Assert.Equal(total, order.Subtotal);
        }

        

        [Fact]
        //[InlineData(new MockOrderItem[] { new MockOrderItem(), new MockOrderItem})]
        public void ItemsShouldContainOnlyAddedItems()
        {
            var order = new Order();
            var items = new IOrderItems[]
            {
                new MocKOrderItem() {Price = 3},
                new MocKOrderItem() {Price = 4},
                new MocKOrderItem() {Price = 7},

            };

            foreach (var item in items)
            {
                
                order.Add(item);
               
            }
            Assert.Equal(items.Length, order.Items.Count());
            foreach (var item in items)
            {

               Assert.Contains(item, order.Items);

            }
        }

        //removing something from the order should have it removed from the Items property

        //Get the price-needs to be right
        //(for tthe items weve added)


    }
}
