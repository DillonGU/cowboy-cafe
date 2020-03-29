/*
* Author: Dillon Unruh
* Class name: Chili Cheese Fries property test
* Purpose: Chili Cheese Fries property test Class
*/
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.UnitTests
{
    public class ChiliCheeseFriesPropertyChangedTests
    {
        /// <summary>
        /// test to see if  changing the size changes thee size calories and price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChanged()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Size", () =>
            {
                fries.Size = Size.Small;
            });


            Assert.PropertyChanged(fries, "Calories", () =>
            {
                fries.Size = Size.Small;
            });


            Assert.PropertyChanged(fries, "Price", () =>
            {
                fries.Size = Size.Small;
            });
        }


        /// <summary>
        /// checks to see that the cheese fries implemented the change
        /// </summary>
        [Fact]

        public void CheeseFriesShouldImplementPropertyChanged()
        {
            var fries = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fries);
        }

    }
}
