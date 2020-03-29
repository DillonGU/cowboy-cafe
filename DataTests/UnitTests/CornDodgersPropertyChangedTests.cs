/*
* Author: Dillon Unruh
* Class name: Corn Dodgers property test
* Purpose: Corn Dodgers property test Class
*/
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.UnitTests
{
    public class CornDodgersPropertyChangedTests
    {
        /// <summary>
        /// test to see if  changing the size changes thee size calories and price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChanged()
        {
            var dodgers = new CornDodgers();
            Assert.PropertyChanged(dodgers, "Size", () =>
            {
                dodgers.Size = Size.Small;
            });


            Assert.PropertyChanged(dodgers, "Calories", () =>
            {
                dodgers.Size = Size.Small;
            });


            Assert.PropertyChanged(dodgers, "Price", () =>
            {
                dodgers.Size = Size.Small;
            });
        }


        /// <summary>
        /// checks to see that the corn dodgers implemented the change
        /// </summary>
        [Fact]

        public void CornDodgersShouldImplementPropertyChanged()
        {
            var dodgers = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dodgers);
        }

    }
}
