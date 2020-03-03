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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public Order OrderList = new Order();
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            //CancelOrder.Click += OnCancelOrderButtonClicked;
            this.DataContext = OrderList;
            AddCowpokeChiliButton.Click += OnAddCowPokeChiliButtonClicked;
            AddTrailBurgerButton.Click += OnAddTrailBurgerButtonClicked;
            AddAngryChickenButton.Click += OnAddAddAngryChickenButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerButtonClicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButtonClicked;
            AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkButtonClicked;
            AddRustlerRibsButton.Click += OnAddRustlerRibsButtonClicked;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClicked;
            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClicked;
            AddCornDodgersButton.Click += OnAddCornDodgersButtonClicked;
            AddPanDeCampoButton.Click += OnAddPanDeCampoButtonClicked;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClicked;
            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClicked;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClicked;
            AddWaterButton.Click += OnAddWaterButtonClicked;

        }
        /// <summary>
        /// executes a new cowpoke chili to the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnAddCowPokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new CowpokeChili());
        }
        /// <summary>
        /// executes a new trail burger to the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new TrailBurger());
        }
        /// <summary>
        /// executes a new angry chicken to the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnAddAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new AngryChicken());
        }
        /// <summary>
        /// executes a new dakota double burger to the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new DakotaDoubleBurger());
        }
        /// <summary>
        /// executes a new triple burger to the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new TexasTripleBurger());
        }
        /// <summary>
        /// executes a new pulled pork to the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new PecosPulledPork());
        }
        /// <summary>
        /// executes a new rustlers ribs to the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnAddRustlerRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new RustlersRibs());
        }
        /// <summary>
        /// executes a new baked beans to the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new BakedBeans());
        }
        /// <summary>
        /// executes a new chili cheese fries to the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new ChiliCheeseFries());
        }
        /// <summary>
        /// executes a new corn dodgers to the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new CornDodgers());
        }
        /// <summary>
        /// executes a new pan de campo to the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new PanDeCampo());
        }
        /// <summary>
        /// executes a new cowboy coffee to the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new CowboyCoffee());
        }
        /// <summary>
        /// executes a new jerked soda to the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new JerkedSoda());
        }
        /// <summary>
        /// executes a new texas tea to the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new TexasTea());
        }
        /// <summary>
        /// executes a new water to the list
        /// </summary>
        /// <param name="sender">?????????</param>
        /// <param name="e">??????????/</param>
        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new Water());
        }

        void OnCancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        void OnOrderCompleteButtonClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

    }
}
