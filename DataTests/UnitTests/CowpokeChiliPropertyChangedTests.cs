/*
* Author: Dillon Unruh
* Class name: cowpokechiliPropertyTest
* Purpose: Cowpoke Chili Property Change Test class
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
    /// class to test if the cowpoke chili property changes work correctly
    /// </summary>
    public class CowpokeChiliPropertyChangedTests
    {
        /// <summary>
        /// checks to see that the cowpoke chili implemented the change
        /// </summary>
        [Fact]

        public void CowpokeChiliShouldImplementPropertyChanged()
        {
            var chili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chili);
        }
        
        /// <summary>
        /// test to see if changing cheese property works
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChanged()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "Cheese", () =>
            {
                chili.Cheese = false;

            });
        }
        /// <summary>
        /// test to see if special instructions display on cheese change
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.Cheese = false;
            });
        }
        /// <summary>
        /// test to see if sour cream property is changed 
        /// </summary>
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChanged()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SourCream", () =>
            {
                chili.SourCream = false;
            });
        }
        /// <summary>
        /// test to see if the special instructions invoke on sour cream change
        /// </summary>
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.SourCream = false;
            });
        }
        /// <summary>
        /// test to see if changing Green onions property works
        /// </summary>
        [Fact]
        public void ChangingGreenOnionShouldInvokePropertyChanged()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "GreenOnions", () =>
            {
                chili.GreenOnions = false;

            });
        }
        /// <summary>
        /// test to see if special instructions display on green onion change
        /// </summary>
        [Fact]
        public void ChangingGreenOnionShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.GreenOnions = false;
            });
        }
        /// <summary>
        /// test to see if tortilla strips property is changed 
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChanged()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "TortillaStrips", () =>
            {
                chili.TortillaStrips = false;
            });
        }
        /// <summary>
        /// test to see if the special instructions invoke on tortilla strips change
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.TortillaStrips = false;
            });
        }
    }
}
