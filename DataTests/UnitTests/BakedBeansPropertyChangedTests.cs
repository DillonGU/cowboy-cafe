/*
* Author: Dillon Unruh
* Class name: Baked Beans property test
* Purpose: Baked Beans property test Class
*/
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.UnitTests
{
    public class BakedBeansPropertyChangedTests
    {
        /// <summary>
        /// test to see if  changing the size changes thee size calories and price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Size", () =>
            {
                beans.Size = Size.Small;
            });


            Assert.PropertyChanged(beans, "Calories", () =>
            {
                beans.Size = Size.Small;
            });


            Assert.PropertyChanged(beans, "Price", () =>
            {
                beans.Size = Size.Small;
            });
        }


        /// <summary>
        /// checks to see that the baked beans implemented the change
        /// </summary>
        [Fact]

        public void BakedBeansShouldImplementPropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beans);
        }
      
    }
}
