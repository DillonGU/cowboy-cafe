/*
* Author: Dillon Unruh
* Class name: Order Control Class
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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        
        /// <summary>
        /// Order control control
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            var order = new Order();
            this.DataContext = order;
            CancelOrder.Click += OnCancelOrderButtonClicked;
            CompleteOrder.Click += OnOrderCompleteButtonClicked;
            ItemSelection.Click += OnItemSelectionButtonClicked;



        }

        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }


        /// <summary>
        /// executes a new cowpoke chili to the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        

        void OnCancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        void OnOrderCompleteButtonClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        void OnItemSelectionButtonClicked(object sender, RoutedEventArgs e)
        {
            //this.DataContext = new Order();
        }


    }
}
