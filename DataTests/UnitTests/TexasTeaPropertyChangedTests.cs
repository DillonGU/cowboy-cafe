/*
* Author: Dillon Unruh
* Class name: Texas Tea property test
* Purpose: Texas Tea property test Class
*/
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.UnitTests
{
    public class TexasTeaPropertyChangedTests
    {
        /// <summary>
        /// test to see if  changing the size changes thee size calories and price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChanged()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Small;
            });


            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Small;
            });


            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Small;
            });
        }


        /// <summary>
        /// checks to see that the tea implemented the change
        /// </summary>
        [Fact]

        public void TeaShouldImplementPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tea);
        }
        /// <summary>
        /// test to see if changing ice property works
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChanged()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Ice", () =>
            {
                tea.Ice = false;

            });
        }
        /// <summary>
        /// test to see if special instructions display on ice change
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Ice = false;
            });
        }

        /// <summary>
        /// test to see if changing lemon property works
        /// </summary>
        [Fact]
        public void ChangingLemonShouldInvokePropertyChanged()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Lemon", () =>
            {
                tea.Lemon = true;

            });
        }
        /// <summary>
        /// test to see if special instructions display on lemon change
        /// </summary>
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Lemon = true;
            });
        }

        /// <summary>
        /// test to see if changing sweet property works
        /// </summary>
        [Fact]
        public void ChangingSweetShouldInvokePropertyChanged()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Sweet", () =>
            {
                tea.Sweet = false;
            });
        }
        
    }
}
