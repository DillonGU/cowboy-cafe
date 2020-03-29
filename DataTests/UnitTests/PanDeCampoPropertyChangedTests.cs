/*
* Author: Dillon Unruh
* Class name: PanDeCampo property test
* Purpose: PanDeCampo property test Class
*/
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.UnitTests
{
    public class PanDeCampoPropertyChangedTests
    {
        /// <summary>
        /// test to see if  changing the size changes thee size calories and price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChanged()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Size", () =>
            {
                campo.Size = Size.Small;
            });


            Assert.PropertyChanged(campo, "Calories", () =>
            {
                campo.Size = Size.Small;
            });


            Assert.PropertyChanged(campo, "Price", () =>
            {
                campo.Size = Size.Small;
            });
        }


        /// <summary>
        /// checks to see that the pan de campo implemented the change
        /// </summary>
        [Fact]

        public void PanDeCampoShouldImplementPropertyChanged()
        {
            var campo = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(campo);
        }

    }
}
