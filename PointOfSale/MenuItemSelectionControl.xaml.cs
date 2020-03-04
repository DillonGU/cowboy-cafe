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
                            var entree = new CowpokeChili();
                            var screen = new CustomizeCowpokeChili();
                            screen.DataContext = entree;
                            order.Add(new CowpokeChili());
                            orderControl.SwapScreen(screen);
                            break;
                        case "TrailBurger":
                            order.Add(new TrailBurger());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "AngryChicken":
                            order.Add(new AngryChicken());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "DakotaDouble":
                            order.Add(new DakotaDoubleBurger());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "TexasTriple":
                            order.Add(new TexasTripleBurger());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "PecosPork":
                            order.Add(new PecosPulledPork());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
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

        

        

