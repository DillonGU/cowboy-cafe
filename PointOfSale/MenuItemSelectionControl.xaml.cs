/*
* Author: Dillon Unruh
* Class name: MenuItemSelectionControl.xaml Class
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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();

        }
        /// <summary>
        /// this helper method add the item to the list and swaps the screen
        /// </summary>
        /// <param name="item">item user clicked to be added</param>
        /// <param name="screen">sreen to be swapped</param>
        void AddItemAndOpenCustomizationScreen(IOrderItems item, FrameworkElement screen)
        {
            var order = DataContext as Order;
            if (order == null) throw new Exception("Data Context expected to be order instance");
            if(screen!= null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("An ancestor of ordercontrol expected");

                screen.DataContext = item;
                orderControl.SwapScreen(screen);

                
            }
            order.Add(item);
        }
        /// <summary>
        /// Depending on the item the user clicks. This action handler adds the item to list, and displays the swapped screen with the menuitem screen so the user can customize.
        /// </summary>
        /// <param name="sender">??</param>
        /// <param name="e">??</param>
        void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {                                                                                           //Example of Button clicked in one method instead of so many event handlers
                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            var itemCPC = new CowpokeChili();
                            var screenCPC = new CustomizeCowpokeChili();
                            AddItemAndOpenCustomizationScreen(itemCPC, screenCPC);
                            break;
                        case "TrailBurger":
                             var itemTB = new TrailBurger();
                             var screenTB = new CustomizeTrailBurger();
                            AddItemAndOpenCustomizationScreen(itemTB, screenTB);
                            break;
                        case "AngryChicken":
                             var itemAC = new AngryChicken();
                             var screenAC = new CustomizeAngryChicken();
                            AddItemAndOpenCustomizationScreen(itemAC, screenAC);
                            break;
                        case "DakotaDouble":
                            var itemDD = new DakotaDoubleBurger();
                            var screenDD = new CustomizeDakotaDouble();
                            AddItemAndOpenCustomizationScreen(itemDD, screenDD);
                            break;
                        case "TexasTriple":
                            var itemTT = new TexasTripleBurger();
                            var screenTT = new CustomizeTexasTriple();
                            AddItemAndOpenCustomizationScreen(itemTT, screenTT);
                            break;
                        case "PecosPork":
                            var itemPP = new PecosPulledPork();
                            var screenPP = new CustomizePecosPulledPork();
                            AddItemAndOpenCustomizationScreen(itemPP, screenPP);
                            break;
                        case "RustlerRibs":
                            order.Add(new RustlersRibs());
                            break;
                        case "BakedBeans":
                            var itemBB = new BakedBeans();
                            var screenBB = new CustomizeBakedBeans();
                            AddItemAndOpenCustomizationScreen(itemBB, screenBB);
                            break;
                        case "ChiliCheeseFries":
                            var itemCCF = new ChiliCheeseFries();
                            var screenCCF = new CustomizeChiliCheeseFries();
                            AddItemAndOpenCustomizationScreen(itemCCF, screenCCF);
                            break;
                        case "CornDodgers":
                            var itemCD = new CornDodgers();
                            var screenCD = new CustomizeCornDodgers();
                            AddItemAndOpenCustomizationScreen(itemCD, screenCD);
                            break;
                        case "PanDeCampo":
                            var itemPD = new PanDeCampo();
                            var screenPD = new CustomizePanDeCampo();
                            AddItemAndOpenCustomizationScreen(itemPD, screenPD);
                            break;
                        case "JerkedSoda":
                            var itemJS = new JerkedSoda();
                            var screenJS = new CustomizeJerkedSoda();
                            AddItemAndOpenCustomizationScreen(itemJS, screenJS);
                            break;
                        case "CowboyCoffee":
                            var itemCC = new CowboyCoffee();
                            var screenCC = new CustomizeCowboyCoffee();
                            AddItemAndOpenCustomizationScreen(itemCC, screenCC);
                            break;
                        case "TexasTea":
                            var itemTXT = new TexasTea();
                            var screenTXT = new CustomizeTexasTea();
                            AddItemAndOpenCustomizationScreen(itemTXT, screenTXT);
                            break;
                        case "Water":
                            var itemW = new Water();
                            var screenW = new CustomizeWater();
                            AddItemAndOpenCustomizationScreen(itemW, screenW);
                            break;
                    }
                }
            }
        }
    }
}

        

        

