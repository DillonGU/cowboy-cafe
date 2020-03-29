/*
* Author: Dillon Unruh
* Class name: Jerked Soda property test
* Purpose: Jerked Soda property test Class
*/
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.UnitTests
{
    public class JerkedSodaPropertyChangedTests
    {
        /// <summary>
        /// test to see if  changing the size changes thee size calories and price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Small;
            });


            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Small;
            });


            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Small;
            });
        }
        /*[Fact]
        public void ChangingFlavorPropertyShouldInvokePropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.CreamSoda;
            });
        }*/

        /// <summary>
        /// checks to see that the jerked soda implemented the change
        /// </summary>
        [Fact]

        public void JerkedSodaShouldImplementPropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);
        }
        /// <summary>
        /// test to see if changing ice property works
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Ice", () =>
            {
                soda.Ice = false;

            });
        }
        /// <summary>
        /// test to see if special instructions display on ice change
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Ice = false;
            });
        }
    }
}
