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
using CowboyCafe.Extensions;

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
        /// <summary>
        /// helper method that swaps the current screen with another one.
        /// </summary>
        /// <param name="element"> screen element</param>
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }


        /// <summary>
        /// executes a new menu item selection and clears the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnCancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            
            this.DataContext = new Order();
            Container.Child = new MenuItemSelectionControl();

        }
        /// <summary>
        /// executes a new menu item selection and clears the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnOrderCompleteButtonClicked(object sender, RoutedEventArgs e)
        {
            
            //var screen = new WindowTransactionControl();
            //screen.DataContext = this.DataContext;
            //screen.Show();
            //this.DataContext = new Order();
            var main = this.FindAncestor<MainWindow>();
            if (main == null) return;
            main.ScreenSwap(new TransactionControl(this.DataContext as Order));
            //Container.Child = new MenuItemSelectionControl();

        }
        /// <summary>
        /// executes a new menu item selection 
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnItemSelectionButtonClicked(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }
        /// <summary>
        /// helper method to notify the order
        /// </summary>
        public void ItemChanged()
        {
            if(DataContext is Order order)
            {
                order.Notify();
            }
        }
    }
}
