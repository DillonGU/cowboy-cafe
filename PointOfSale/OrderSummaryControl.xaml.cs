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
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        /// <summary>
        /// constructor
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();
            
        }

        private OrderControl control;
        /// <summary>
        /// This is an action handler to the xaml so that when the user clicks on the order summary and selects which item to edit
        /// this method fires off and finds which screen and properties to display.
        /// </summary>
        /// <param name="sender">??</param>
        /// <param name="e">??</param>
        public void OnItemClick(object sender, SelectionChangedEventArgs e)
        {
            if(sender is ListBox listBox)
            {
                if (listBox.SelectedItem is IOrderItems listBoxItem)
                {
                    if (listBoxItem is AngryChicken chicken)
                    {
                        var screen = new CustomizeAngryChicken();
                        screen.DataContext = chicken;
                        control = this.FindAncestor<OrderControl>();
                        control.SwapScreen(screen);
                    }
                    if (listBoxItem is CowpokeChili chili)
                    {
                        var screen = new CustomizeCowpokeChili();
                        screen.DataContext = chili;
                        control = this.FindAncestor<OrderControl>();
                        control.SwapScreen(screen);
                    }
                    if (listBoxItem is PecosPulledPork pork)
                    {
                        var screen = new CustomizePecosPulledPork();
                        screen.DataContext = pork;
                        control = this.FindAncestor<OrderControl>();
                        control.SwapScreen(screen);
                    }
                    if (listBoxItem is TrailBurger trailBurger)
                    {
                        var screen = new CustomizeTrailBurger();
                        screen.DataContext = trailBurger;
                        control = this.FindAncestor<OrderControl>();
                        control.SwapScreen(screen);
                    }
                    if (listBoxItem is DakotaDoubleBurger dakotaDouble)
                    {
                        var screen = new CustomizeDakotaDouble();
                        screen.DataContext = dakotaDouble;
                        control = this.FindAncestor<OrderControl>();
                        control.SwapScreen(screen);
                    }
                    if (listBoxItem is TexasTripleBurger texasTriple)
                    {
                        var screen = new CustomizeTexasTriple();
                        screen.DataContext = texasTriple;
                        control = this.FindAncestor<OrderControl>();
                        control.SwapScreen(screen);
                    }
                    if (listBoxItem is BakedBeans baked)
                    {
                        var screen = new CustomizeBakedBeans();
                        screen.DataContext = baked;
                        control = this.FindAncestor<OrderControl>();
                        control.SwapScreen(screen);
                    }
                    if (listBoxItem is ChiliCheeseFries cheeseFries)
                    {
                        var screen = new CustomizeChiliCheeseFries();
                        screen.DataContext = cheeseFries;
                        control = this.FindAncestor<OrderControl>();
                        control.SwapScreen(screen);
                    }
                    if (listBoxItem is CornDodgers dodgers)
                    {
                        var screen = new CustomizeCornDodgers();
                        screen.DataContext = dodgers;
                        control = this.FindAncestor<OrderControl>();
                        control.SwapScreen(screen);
                    }
                    if (listBoxItem is PanDeCampo pan)
                    {
                        var screen = new CustomizePanDeCampo();
                        screen.DataContext = pan;
                        control = this.FindAncestor<OrderControl>();
                        control.SwapScreen(screen);
                    }
                    if (listBoxItem is JerkedSoda soda)
                    {
                        var screen = new CustomizeJerkedSoda();
                        screen.DataContext = soda;
                        control = this.FindAncestor<OrderControl>();
                        control.SwapScreen(screen);
                    }
                    if (listBoxItem is TexasTea tea)
                    {
                        var screen = new CustomizeTexasTea();
                        screen.DataContext = tea;
                        control = this.FindAncestor<OrderControl>();
                        control.SwapScreen(screen);
                    }
                    if (listBoxItem is CowboyCoffee coffee)
                    {
                        var screen = new CustomizeCowboyCoffee();
                        screen.DataContext = coffee;
                        control = this.FindAncestor<OrderControl>();
                        control.SwapScreen(screen);
                    }
                    if (listBoxItem is Water water)
                    {
                        var screen = new CustomizeWater();
                        screen.DataContext = water;
                        control = this.FindAncestor<OrderControl>();
                        control.SwapScreen(screen);
                    }

                }
            }

            
           
        }
        /// <summary>
        /// THis is from the xaml that it is an action handler that removes the selected item from list when red x is pressed.
        /// </summary>
        /// <param name="sender">??</param>
        /// <param name="e">??</param>
        public void RemoveItem(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                if(sender is Button button)
                {
                    if(button.DataContext is IOrderItems item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }
    }
}
