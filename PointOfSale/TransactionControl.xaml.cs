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
using CashRegister;
using CowboyCafe.Data;
using CowboyCafe.Extensions;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        public void SwapToDrawer(UIElement element)
        {
            Transaction.Child = element;
        }

        public void SwapToInput(UIElement element)
        {
            Container.Child = element;
        }


        private Order orders;
        public TransactionControl(Order order)
        {
            InitializeComponent();
            this.DataContext = order;
            orders = order;
        }
        
        void CreditPayment(object sender, RoutedEventArgs e)
        {
            CardTerminal terminal = new CardTerminal();
            if(DataContext is Order order)
            {
                ResultCode result = terminal.ProcessTransaction(order.Total);
                
                
                switch(result)
                {
                    case ResultCode.Success:
                        

                        PrintReceipt();
                        
                        MessageBox.Show("Transaction Complete");
                        
                        SwapScreenToOrderControl();
                        break;
                    default:
                        MessageBox.Show(result.ToString());
                        break;
                }
            }
             //put the right amount in the parameters//////////////////
            //result code success case to get receipt///////////////
            //print receipt./////////////////
            //return to order screen./////////////
        }

        void CashPayment(object sender, RoutedEventArgs e)
        {
            var cashScreen = new CashRegisterControl(DataContext as Order);
           // var inputScreen = new UserCashInput(DataContext as Order);
            //new control to handle user input and then 
            //SwapToInput(inputScreen);
            SwapToDrawer(cashScreen);
            //how to implement the rest with add bill and add coin methods//////////////////
            //what do i do and where do i do the cash drawer instace///////////////////
            //SwapScreenToOrderControl();
            
        }

        void CancelTransaction(object sender, RoutedEventArgs e)
        {
            SwapScreenToOrderControl();
        }

        private void SwapScreenToOrderControl()
        {
            OrderControl orderControl = new OrderControl();
            //how to make it clear the old window with the order items.////////////
            var main = this.FindAncestor<MainWindow>();
            if (main == null) return;
            main.ScreenSwap(orderControl);
        }
        private void PrintReceipt()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach( IOrderItems item in orders.Items)
            {
                stringBuilder.Append(item);
                stringBuilder.Append("\n");
            }
            ReceiptPrinter print = new ReceiptPrinter();
            print.Print(DateTime.Now + "Your Order # " + orders.OrderNumber + "\n" + "Items Ordered \n" + stringBuilder.ToString() + "\nSubtotal " + orders.Subtotal
               + "\nTotal " + orders.Total + "\nMethod of Payment Credit Card"); ;
        }

    }
}
