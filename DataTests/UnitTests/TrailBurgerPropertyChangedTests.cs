/*
* Author: Dillon Unruh
* Class name: TrailBurgerPropertyTest
* Purpose: Trail Burger Property Change Test class
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
    /// class to test if the Trail Burger property changes work correctly
    /// </summary>
    public class TrailBurgerPropertyChangedTests
    {
        /// <summary>
        /// checks to see that the Trail Burger implemented the change
        /// </summary>
        [Fact]

        public void TrailBurgerShouldImplementPropertyChanged()
        {
            var tBurger = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tBurger);
        }
        /// <summary>
        /// test to see if changing bun property works
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChanged()
        {
            var tBurger = new TrailBurger();
            Assert.PropertyChanged(tBurger, "Bun", () =>
            {
                tBurger.Bun = false;

            });
        }
        /// <summary>
        /// test to see if special instructions display on bun change
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TrailBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Bun = false;
            });
        }
        /// <summary>
        /// test to see if pickle property is changed 
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChanged()
        {
            var tBurger = new TrailBurger();
            Assert.PropertyChanged(tBurger, "Pickle", () =>
            {
                tBurger.Pickle = false;
            });
        }
        /// <summary>
        /// test to see if the special instructions invoke on pickle change
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TrailBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Pickle = false;
            });
        }
        /// <summary>
        /// test to see if changing Ketchup property works
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChanged()
        {
            var tBurger = new TrailBurger();
            Assert.PropertyChanged(tBurger, "Ketchup", () =>
            {
                tBurger.Ketchup = false;

            });
        }
        /// <summary>
        /// test to see if special instructions display on ketchup change
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TrailBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Ketchup = false;
            });
        }
        /// <summary>
        /// test to see if mustard property is changed 
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChanged()
        {
            var tBurger = new TrailBurger();
            Assert.PropertyChanged(tBurger, "Mustard", () =>
            {
                tBurger.Mustard = false;
            });
        }
        /// <summary>
        /// test to see if the special instructions invoke on mustard change
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TrailBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Mustard = false;
            });
        }
        /// <summary>
        /// test to see if changing cheese property works
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChanged()
        {
            var tBurger = new TrailBurger();
            Assert.PropertyChanged(tBurger, "Cheese", () =>
            {
                tBurger.Cheese = false;

            });
        }
        /// <summary>
        /// test to see if special instructions display on cheese change
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TrailBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Cheese = false;
            });
        }
        
    }
}
