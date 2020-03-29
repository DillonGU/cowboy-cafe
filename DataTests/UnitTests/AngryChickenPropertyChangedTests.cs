/*
* Author: Dillon Unruh
* Class name: AngryChickenPropertyTest
* Purpose: Angry Chicken Property Change Test class
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
    /// class to test if the angry chicken property changes work correctly
    /// </summary>
    public class AngryChickenPropertyChangedTests
    {
        /// <summary>
        /// checks to see that the angry chicken implemented the change
        /// </summary>
        [Fact]
        
        public void AngryChickenShouldImplementPropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        /// <summary>
        /// test to see if changing bread property works
        /// </summary>
        [Fact]
        public void ChangingBreadShouldInvokePropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Bread", () =>
            {
                chicken.Bread = false;
        
            });
        }
        /// <summary>
        /// test to see if special instructions display on bread change
        /// </summary>
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Bread = false;
            });
        }
        /// <summary>
        /// test to see if pickle property is changed 
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Pickle", () =>
            {
                chicken.Pickle = false;
            });
        }
        /// <summary>
        /// test to see if the special instructions invoke on pickle change
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Pickle = false;
            });
        }
    }
}
