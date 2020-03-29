/*
* Author: Dillon Unruh
* Class name: PecosPulledPorkPropertyTest
* Purpose: Pecos Pulled Pork Property Change Test class
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests
{
    /// <summary>
    /// class to test if the Pecos Pulled Pork property changes work correctly
    /// </summary>
    public class PecosPulledPorkPropertyChangedTests
    {
        /// <summary>
        /// checks to see that the Pecos Pulled Pork implemented the change
        /// </summary>
        [Fact]

        public void PecosPulledPorkShouldImplementPropertyChanged()
        {
            var pork = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pork);
        }
        /// <summary>
        /// test to see if changing bread property works
        /// </summary>
        [Fact]
        public void ChangingBreadShouldInvokePropertyChanged()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Bread", () =>
            {
                pork.Bread = false;

            });
        }
        /// <summary>
        /// test to see if special instructions display on bread change
        /// </summary>
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Bread = false;
            });
        }
        /// <summary>
        /// test to see if pickle property is changed 
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChanged()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Pickle", () =>
            {
                pork.Pickle = false;
            });
        }
        /// <summary>
        /// test to see if the special instructions invoke on pickle change
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Pickle = false;
            });
        }
    }
}
