using System;
/*
* Author: Dillon Unruh
* Class name: CustomizeCornDodgers.xaml Class
* Purpose: Controls the commands of user input.
*/
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
    /// Interaction logic for CustomizeCornDodgers.xaml
    /// </summary>
    public partial class CustomizeCornDodgers : UserControl
    {
        /// <summary>
        /// constructor
        /// </summary>
        public CustomizeCornDodgers()
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
