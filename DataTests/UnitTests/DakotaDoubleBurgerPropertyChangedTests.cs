/*
* Author: Dillon Unruh
* Class name: DakotaDoubleePropertyTest
* Purpose: Dakota Double Property Change Test class
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
    /// class to test if the dakota double property changes work correctly
    /// </summary>
    public class DakotaDoubleBurgerPropertyChangedTests
    {
        /// <summary>
        /// checks to see that the dakota double implemented the change
        /// </summary>
        [Fact]

        public void DakotaDoubleShouldImplementPropertyChanged()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dBurger);
        }
        /// <summary>
        /// test to see if changing bun property works
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChanged()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "Bun", () =>
            {
                dBurger.Bun = false;

            });
        }
        /// <summary>
        /// test to see if special instructions display on bun change
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "SpecialInstructions", () =>
            {
                dBurger.Bun = false;
            });
        }
        /// <summary>
        /// test to see if pickle property is changed 
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChanged()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "Pickle", () =>
            {
                dBurger.Pickle = false;
            });
        }
        /// <summary>
        /// test to see if the special instructions invoke on pickle change
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "SpecialInstructions", () =>
            {
                dBurger.Pickle = false;
            });
        }
        /// <summary>
        /// test to see if changing Ketchup property works
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChanged()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "Ketchup", () =>
            {
                dBurger.Ketchup = false;

            });
        }
        /// <summary>
        /// test to see if special instructions display on ketchup change
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "SpecialInstructions", () =>
            {
                dBurger.Ketchup = false;
            });
        }
        /// <summary>
        /// test to see if mustard property is changed 
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChanged()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "Mustard", () =>
            {
                dBurger.Mustard = false;
            });
        }
        /// <summary>
        /// test to see if the special instructions invoke on mustard change
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "SpecialInstructions", () =>
            {
                dBurger.Mustard = false;
            });
        }
        /// <summary>
        /// test to see if changing cheese property works
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChanged()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "Cheese", () =>
            {
                dBurger.Cheese = false;

            });
        }
        /// <summary>
        /// test to see if special instructions display on cheese change
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "SpecialInstructions", () =>
            {
                dBurger.Cheese = false;
            });
        }
        /// <summary>
        /// test to see if tomato property is changed 
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChanged()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "Tomato", () =>
            {
                dBurger.Tomato = false;
            });
        }
        /// <summary>
        /// test to see if the special instructions invoke on tomato change
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "SpecialInstructions", () =>
            {
                dBurger.Tomato = false;
            });
        }
        /// <summary>
        /// test to see if changing lettuce property works
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChanged()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "Lettuce", () =>
            {
                dBurger.Lettuce = false;

            });
        }
        /// <summary>
        /// test to see if special instructions display on lettuce change
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "SpecialInstructions", () =>
            {
                dBurger.Lettuce = false;
            });
        }
        /// <summary>
        /// test to see if mayo property is changed 
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChanged()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "Mayo", () =>
            {
                dBurger.Mayo = false;
            });
        }
        /// <summary>
        /// test to see if the special instructions invoke on mayo change
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "SpecialInstructions", () =>
            {
                dBurger.Mayo = false;
            });
        }
        
    }
}
