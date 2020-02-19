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
        public OrderControl()
        {
            InitializeComponent();
            AddCowpokeChiliButton.Click += OnAddCowPokeChiliButtonClicked;
            AddTrailBurgerButton.Click += OnAddTrailBurgerButtonClicked;
            AddAngryChickenButton.Click += OnAddAddAngryChickenButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerButtonClicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButtonClicked;
            AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkButtonClicked;
            AddRustlerRibsButton.Click += OnAddRustlerRibsButtonClicked;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClicked;
        }

        void OnAddCowPokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowpokeChili());
        }

        void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TrailBurger());
        }

        void OnAddAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new AngryChicken());
        }

        void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new DakotaDoubleBurger());
        }

        void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTripleBurger());
        }

        void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PecosPulledPork());
        }

        void OnAddRustlerRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs());
        }

        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new BakedBeans());
        }
    }
}
