/*
* Author: Dillon Unruh
* Class name: cowboy coffee property test
* Purpose: cowboy coffee property test Class
*/
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.UnitTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        /// <summary>
        /// test to see if  changing the size changes thee size calories and price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Size", () =>
            {
                coffee.Size = Size.Small;
            });


            Assert.PropertyChanged(coffee, "Calories", () =>
            {
                coffee.Size = Size.Small;
            });


            Assert.PropertyChanged(coffee, "Price", () =>
            {
                coffee.Size = Size.Small;
            });
        }
        

        /// <summary>
        /// checks to see that the coffee implemented the change
        /// </summary>
        [Fact]

        public void CoffeeShouldImplementPropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);
        }
        /// <summary>
        /// test to see if changing ice property works
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Ice", () =>
            {
                coffee.Ice = true;

            });
        }
        /// <summary>
        /// test to see if special instructions display on ice change
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Ice = true;
            });
        }

        /// <summary>
        /// test to see if changing room for cream property works
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "RoomForCream", () =>
            {
                coffee.RoomForCream = true;

            });
        }
        /// <summary>
        /// test to see if special instructions display on room for cream change
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.RoomForCream = true;
            });
        }

        /// <summary>
        /// test to see if changing decaf property works
        /// </summary>
        [Fact]
        public void ChangingDecafShouldInvokePropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Decaf", () =>
            {
                coffee.Decaf = true;

            });
        }
        /// <summary>
        /// test to see if special instructions display on decaf change
        /// </summary>
        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Decaf = true;
            });
        }
    }
}
