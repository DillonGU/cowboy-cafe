/*
* Author: Dillon Unruh
* Class name: TexasTriplePropertyTest
* Purpose: Texas Triple Property Change Test class
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
    /// class to test if the Texas Triple property changes work correctly
    /// </summary>
    public class TexasTripleBurgerPropertyChangedTests
    {
        /// <summary>
        /// checks to see that the Texas Triple implemented the change
        /// </summary>
        [Fact]

        public void TexasTripleShouldImplementPropertyChanged()
        {
            var tBurger = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tBurger);
        }
        /// <summary>
        /// test to see if changing bun property works
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChanged()
        {
            var tBurger = new TexasTripleBurger();
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
            var tBurger = new TexasTripleBurger();
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
            var tBurger = new TexasTripleBurger();
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
            var tBurger = new TexasTripleBurger();
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
            var tBurger = new TexasTripleBurger();
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
            var tBurger = new TexasTripleBurger();
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
            var tBurger = new TexasTripleBurger();
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
            var tBurger = new TexasTripleBurger();
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
            var tBurger = new TexasTripleBurger();
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
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Cheese = false;
            });
        }
        /// <summary>
        /// test to see if tomato property is changed 
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChanged()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "Tomato", () =>
            {
                tBurger.Tomato = false;
            });
        }
        /// <summary>
        /// test to see if the special instructions invoke on tomato change
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Tomato = false;
            });
        }
        /// <summary>
        /// test to see if changing lettuce property works
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChanged()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "Lettuce", () =>
            {
                tBurger.Lettuce = false;

            });
        }
        /// <summary>
        /// test to see if special instructions display on lettuce change
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Lettuce = false;
            });
        }
        /// <summary>
        /// test to see if mayo property is changed 
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChanged()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "Mayo", () =>
            {
                tBurger.Mayo = false;
            });
        }
        /// <summary>
        /// test to see if the special instructions invoke on mayo change
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Mayo = false;
            });
        }
        /// <summary>
        /// test to see if changing bacon property works
        /// </summary>
        [Fact]
        public void ChangingBaconShouldInvokePropertyChanged()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "Bacon", () =>
            {
                tBurger.Bacon = false;

            });
        }
        /// <summary>
        /// test to see if special instructions display on bacon change
        /// </summary>
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Bacon = false;
            });
        }
        /// <summary>
        /// test to see if egg property is changed 
        /// </summary>
        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChanged()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "Egg", () =>
            {
                tBurger.Egg = false;
            });
        }
        /// <summary>
        /// test to see if the special instructions invoke on egg change
        /// </summary>
        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Egg = false;
            });
        }
    }
}
