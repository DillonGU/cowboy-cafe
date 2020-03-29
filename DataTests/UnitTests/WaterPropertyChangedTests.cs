/*
* Author: Dillon Unruh
* Class name: Water property test
* Purpose: Water property test Class
*/
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.UnitTests
{
    public class WaterPropertyChangedTests
    {
        /// <summary>
        /// test to see if  changing the size changes thee size calories and price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChanged()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = Size.Small;
            });
        }


        /// <summary>
        /// checks to see that the water implemented the change
        /// </summary>
        [Fact]

        public void WaterShouldImplementPropertyChanged()
        {
            var water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }
        /// <summary>
        /// test to see if changing ice property works
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChanged()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Ice", () =>
            {
                water.Ice = false;

            });
        }
        /// <summary>
        /// test to see if special instructions display on ice change
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Ice = false;
            });
        }

        /// <summary>
        /// test to see if changing lemon property works
        /// </summary>
        [Fact]
        public void ChangingLemonShouldInvokePropertyChanged()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Lemon", () =>
            {
                water.Lemon = true;

            });
        }
        /// <summary>
        /// test to see if special instructions display on lemon change
        /// </summary>
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Lemon = true;
            });
        }


    }
}
