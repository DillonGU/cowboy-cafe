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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {
        
        private Order orders;
        public CashRegisterControl(Order order)
        {
            InitializeComponent();
            orders = order;

        }


        
        
        /// <summary>
        /// adds the user input to bill
        /// </summary>
        public void Add()
        {
            CashDrawer drawer = new CashDrawer();
            PenniesC.Text = drawer.Pennies.ToString();
            NickelsC.Text = drawer.Nickels.ToString();
            DimesC.Text = drawer.Dimes.ToString();
            QuartersC.Text = drawer.Quarters.ToString();
            HalfDollarC.Text = drawer.HalfDollars.ToString();
            DollarsC.Text = drawer.Dollars.ToString();
            OnesC.Text = drawer.Ones.ToString();
            TwosC.Text = drawer.Twos.ToString();
            FivesC.Text = drawer.Fives.ToString();
            TensC.Text = drawer.Tens.ToString();
            TwentiesC.Text = drawer.Twenties.ToString();
            FiftiesC.Text = drawer.Fifties.ToString();
            HundredsC.Text = drawer.Hundreds.ToString();

            double pennies = 0;
            double dimes = 0;
            double nickels = 0;
            double quarters = 0;
            double halfDollar = 0;
            double dollar = 0;
            double one = 0;
            double two = 0;
            double five = 0;
            double ten = 0;
            double twenty = 0;
            double fifty = 0;
            double hundreds = 0;

            pennies += PennyCtrl.Quantity;
            nickels += NickelCtrl.Quantity ;
            dimes += DimeCtrl.Quantity;
            quarters += QarterCtrl.Quantity;
            halfDollar += HDollarCtrl.Quantity;
            dollar += DollarCtrl.Quantity;

            //Get the currency value of the bills entered and the quantites
            one += OneCtrl.Quantity;
            two += TwoCtrl.Quantity;
            five += FiveCtrl.Quantity;
            ten += TenCtrl.Quantity;
            twenty += TwentyCtrl.Quantity;
            fifty += FiftyCtrl.Quantity;
            hundreds += HundredCtrl.Quantity;

            //Set the AmountPayed text box
            
            Pennies.Text = pennies.ToString();
            Nickels.Text = nickels.ToString();
            Dimes.Text = dimes.ToString();
            Quarters.Text = quarters.ToString();
            HalfDollar.Text = halfDollar.ToString();
            Dollars.Text = dollar.ToString();
            Ones.Text = one.ToString();
            Twos.Text = two.ToString();
            Fives.Text = five.ToString();
            Tens.Text = ten.ToString();
            Twenties.Text = twenty.ToString();
            Fifties.Text = fifty.ToString();
            Hundreds.Text = hundreds.ToString();


        }
        /// <summary>
        /// action handler for pay button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PayAmount(object sender, RoutedEventArgs e)
        {
            string pennies = Pennies.Text;
            string nickels = Nickels.Text;
            string dimes = Dimes.Text;
            string quarters = Quarters.Text;
            string halfDollar = HalfDollar.Text;
            string dollar = Dollars.Text;
            string ones = Ones.Text;
            string twos = Twos.Text;
            string fives = Fives.Text;
            string tens = Tens.Text;
            string twenties = Twenties.Text;
            string fifties = Fifties.Text;
            string hundreds = Hundreds.Text;
           try
            {
                double penniesD = Convert.ToInt32(pennies) * .01;
                double nickelsD = Convert.ToInt32(nickels) * .05;
                double dimesD = Convert.ToInt32(dimes) * .1;
                double quartersD = Convert.ToInt32(quarters) * .25;
                double halfDollarD = Convert.ToInt32(halfDollar) * .5;
                double dollarD = Convert.ToInt32(dollar) * 1;
                double onesD = Convert.ToInt32(ones) * 1;
                double twosD = Convert.ToInt32(twos) * 2;
                double fivesD = Convert.ToInt32(fives) * 5;
                double tensD = Convert.ToInt32(tens) * 10;
                double twentiesD = Convert.ToInt32(twenties) * 20;
                double fiftiesD = Convert.ToInt32(fifties) * 50;
                double hundredsD = Convert.ToInt32(hundreds) * 100;

                double ammountPaid = penniesD + nickelsD + dimesD + quartersD + halfDollarD + dollarD + onesD + twosD + fivesD + tensD + twentiesD + fiftiesD + hundredsD;
                double returnAmmount = ammountPaid - orders.Total;
                ///method inside method don't know how I was able to do this.
                void PaidAmountMore() //pull method out of method for recursion to work.
                {
                    
                    int[] change = ChangeReturn(returnAmmount);


                    
                    //algorithm online
                    //into algorithm store in variable how much of each denomination needs to be stored in array indexes

                }

                if (ammountPaid == orders.Total)
                {
                    MessageBox.Show("Transaction Complete");
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (IOrderItems item in orders.Items)
                    {
                        stringBuilder.Append(item);
                        stringBuilder.Append("\n");
                    }
                    ReceiptPrinter print = new ReceiptPrinter();
                    print.Print(DateTime.Now + " Your Order # " + orders.OrderNumber + "\n" + "Items Ordered \n" + stringBuilder.ToString() + 
                        "\nSubtotal " + orders.Subtotal + "\nTotal " + orders.Total + "\nAmount Paid: " + ammountPaid
                       + "\nMethod of Payment Cash"); 

                    OrderControl orderControl = new OrderControl();
                    //how to make it clear the old window with the order items.////////////
                    var main = this.FindAncestor<MainWindow>();
                    if (main == null) return;
                    main.ScreenSwap(orderControl);
                }
                else if (ammountPaid > orders.Total)
                {
                    PaidAmountMore();
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (IOrderItems item in orders.Items)
                    {
                        stringBuilder.Append(item);
                        stringBuilder.Append("\n");
                    }
                    ReceiptPrinter print = new ReceiptPrinter();
                    print.Print(DateTime.Now + " Your Order # " + orders.OrderNumber + "\n" + "Items Ordered \n" + stringBuilder.ToString() 
                        + "\nSubtotal " + orders.Subtotal + "\nTotal " + orders.Total + "\nAmount Paid: " + ammountPaid +
                        "\nAmmount Return: " + returnAmmount + "\nMethod of Payment Cash"); ;

                    OrderControl orderControl = new OrderControl();
                    var main = this.FindAncestor<MainWindow>();
                    if (main == null) return;
                    main.ScreenSwap(orderControl);
                }
                else
                {
                    MessageBox.Show("Enter more money");
                }



            }
            catch
            {
                MessageBox.Show("Please enter an integer number of denomination of currency");
            }
            //all of the text boxes text convert to numbers.

            //sum into amount customer paid
            //didnt paid enough -method
            //paid right amount
            //overpaid -method
            //display how much of each denomination to give back as change.
            //compare if sum equals orders.total.
            
        }

        /// <summary>
        /// get the change returned
        /// </summary>
        /// <param name="returnedAmmount"> change to process</param>
        /// <returns></returns>
        static int[] ChangeReturn(double returnedAmmount)
        {
            double[] denominations = { 0.01, 0.05, 0.1, 0.25, 0.5, 1, 2, 5, 10, 20, 50, 100 };
            int denomLength = denominations.Length;

            int[] result = new int[12]; //loop through backwards to get top dollars back.

            for (int i = denomLength - 1; i >= 0; i--)
            {
                while (returnedAmmount >= denominations[i])
                {
                    returnedAmmount = returnedAmmount - denominations[i];
                    result[i]++;

                }
            }

            StringBuilder sb = new StringBuilder();

            for (int i = result.Length - 1; i >= 0; i--)
            {
                string breakOut = "number of " + denominations[i] + " is " + result[i] + " , \n";

                sb.Append(breakOut);
            }

            MessageBox.Show(sb.ToString());
            return result;




        }
        
    }
}
