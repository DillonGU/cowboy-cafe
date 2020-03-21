/*
* Author: Dillon Unruh
* Class name: CustomizeCowboyCoffee.xaml Class
* Purpose: Controls the commands of user input.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCowboyCoffee.xaml
    /// </summary>
    public partial class CustomizeCowboyCoffee : UserControl
    {
        /// <summary>
        /// constructor
        /// </summary>
        public CustomizeCowboyCoffee()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When the button is clicked it changes the properties of the selected item
        /// </summary>
        /// <param name="sender">???????</param>
        /// <param name="e">?????????</param>
        private void ButtonClicked(object sender, EventArgs e)
        {
            var customize = this.FindAncestor<OrderControl>();
            if (customize is OrderControl)
            {
                customize.ItemChanged();
            }
        }
    }
}
