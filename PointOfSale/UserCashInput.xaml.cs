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
using CashRegister;
using CowboyCafe.Extensions;



namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for UserCashInput.xaml
    /// </summary>
    public partial class UserCashInput : UserControl
    {
        private CashRegisterControl cash;
        private Order orders;
        public UserCashInput(Order order)
        {
            InitializeComponent();
            orders = order;
        }

        public void PayAmount(object sender, RoutedEventArgs e)
        {
            string pennies = Pennies.Text;
            pennies += cash.PennyCtrl.Quantity;
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

                 void PaidAmountMore() //pull method out of method for recursion to work.
                {
                    double returnAmmount = ammountPaid - orders.Total;
                    int[] change = ChangeReturn(returnAmmount);
                    

                    cash.PennyCtrl.Quantity -= change[0];
                    cash.NickelCtrl.Quantity -= change[1];
                    cash.DimeCtrl.Quantity -= change[2];
                    cash.QarterCtrl.Quantity -= change[3];
                    cash.HDollarCtrl.Quantity -= change[4];
                    cash.DollarCtrl.Quantity -= change[5];
                    cash.OneCtrl.Quantity -= change[6];
                    cash.TwoCtrl.Quantity -= change[7];
                    cash.FiveCtrl.Quantity -= change[8];
                    cash.TenCtrl.Quantity -= change[9];
                    cash.TwentyCtrl.Quantity -= change[10];
                    cash.FiftyCtrl.Quantity -= change[11];
                    cash.HundredCtrl.Quantity -= change[12];
                    //algorithm online
                    //into algorithm store in variable how much of each denomination needs to be stored in array indexes

                }

                if (ammountPaid == Math.Round(orders.Total * 100f) / 100f)
                {
                    MessageBox.Show("Transaction Complete");
                    //print reciept
                    //take back to order screen for new order
                }
                else if (ammountPaid > Math.Round(orders.Total * 100f) / 100f)
                {
                    PaidAmountMore();
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

        
        static int[] ChangeReturn(double returnedAmmount)
        {
            double[] denominations = { 0.01, 0.05, 0.1, 0.25, 0.5, 1, 2, 5, 10, 20, 50, 100 };
            int denomLength = denominations.Length;

            int [] result = new int[12]; //loop through backwards to get top dollars back.

            for (int i = denomLength - 1; i >= 0; i--)
            {
                while(returnedAmmount >= denominations[i])
                {
                    returnedAmmount = returnedAmmount - denominations[i];
                    result[i]++; 
                    
                }
            }

            StringBuilder sb = new StringBuilder();
           
            for (int i = result.Length -1; i >=0; i--)
            {
                string breakOut = "number of " + denominations[i] + " is " + result[i] + " , \n";
                
                sb.Append(breakOut);
            }

            MessageBox.Show(sb.ToString());
            return result;




        }




    }
}
