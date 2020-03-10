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

        public MenuItemSelectionControl()
        {
            InitializeComponent();

        }

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
                            var itemCC = new CowpokeChili();
                            var screenCPC = new CustomizeCowpokeChili();
                            AddItemAndOpenCustomizationScreen(itemCC, screenCPC);
                            //screen.DataContext = entree;
                            //order.Add(new CowpokeChili());
                            //orderControl.SwapScreen(screen);
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
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "BakedBeans":
                            order.Add(new BakedBeans());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "ChiliCheeseFries":
                            order.Add(new ChiliCheeseFries());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "CornDodgers":
                            order.Add(new CornDodgers());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "PanDeCampo":
                            order.Add(new PanDeCampo());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "JerkedSoda":
                            order.Add(new JerkedSoda());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "CowboyCoffee":
                            order.Add(new CowboyCoffee());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "TexasTea":
                            order.Add(new TexasTea());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "Water":
                            order.Add(new Water());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                    }
                }
            }
        }
    }
}

        

        

