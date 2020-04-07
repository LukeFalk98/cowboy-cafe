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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrawerControl.xaml
    /// </summary>
    public partial class DrawerControl : UserControl
    {
        public double Price { get; set; }
        public CashDrawer drawer { private get; set; }

        public DrawerControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for attempting to pay with cash input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double moneyGiven = 0;
            moneyGiven += (.01 * Penny.Quantity);
            moneyGiven += (.10 * Dime.Quantity);
            moneyGiven += (.05 * Nickel.Quantity);
            moneyGiven += (.25 * Quarter.Quantity);
            moneyGiven += (.5 * HalfDollar.Quantity);
            moneyGiven += (Dollar.Quantity);
            moneyGiven += (One.Quantity);
            moneyGiven += (2 * Two.Quantity);
            moneyGiven += (5 * Five.Quantity);
            moneyGiven += (10 * Ten.Quantity);
            moneyGiven += (20 * Twenty.Quantity);
            moneyGiven += (50 * Fifty.Quantity);
            moneyGiven += (100 * Hundred.Quantity);
            if (moneyGiven >= Price)
            {
                double change = moneyGiven - Price;
                drawer.AddCoin(Coins.Penny, Penny.Quantity);
                drawer.AddCoin(Coins.Dime, Dime.Quantity);
                drawer.AddCoin(Coins.Nickel, Nickel.Quantity);
                drawer.AddCoin(Coins.Quarter, Quarter.Quantity);
                drawer.AddCoin(Coins.HalfDollar, HalfDollar.Quantity);
                drawer.AddCoin(Coins.Dollar, Dollar.Quantity);
                drawer.AddBill(Bills.One, One.Quantity);
                drawer.AddBill(Bills.Two, Two.Quantity);
                drawer.AddBill(Bills.Five, Five.Quantity);
                drawer.AddBill(Bills.Ten, Ten.Quantity);
                drawer.AddBill(Bills.Twenty, Twenty.Quantity);
                drawer.AddBill(Bills.Fifty, Fifty.Quantity);
                drawer.AddBill(Bills.Hundred, Hundred.Quantity);
                if (change != 0)
                {
                    GetChange(change);
                }
                var ancestor = this.FindAncestor<TransactionControl>();
                ancestor.PrintReceipt(false, moneyGiven, change);
                var main = ancestor.FindAncestor<MainWindow>();
                OrderControl orderControl = new OrderControl(drawer);
                main.Display(orderControl);
            }
            else
            {
                MessageBox.Show("Not Enough Money!", "Error");
            }
        }

        /// <summary>
        /// gets and displays what to give back as change
        /// </summary>
        /// <param name="change"></param>
        private void GetChange(double change)
        {
            double counter = 0;
            int pennies = 0;
            int nickels = 0;
            int dimes = 0;
            int quarters = 0;
            int halfDollars = 0;
            int dollars = 0;
            int ones = 0;
            int twos = 0;
            int fives = 0;
            int tens = 0;
            int twenties = 0;
            int fifties = 0;
            int hundreds = 0;
            bool unsuccessful = false;
            while (counter != change)
            {
                if (drawer.Hundreds != hundreds && change - counter >= 100)
                {
                    hundreds++;
                    counter += 100;
                }
                else if (drawer.Fifties != fifties && change - counter >= 50)
                {
                    fifties++;
                    counter += 50;
                }
                else if (drawer.Twenties != twenties && change - counter >= 20)
                {
                    twenties++;
                    counter += 20;
                }
                else if (drawer.Tens != tens && change - counter >= 10)
                {
                    tens++;
                    counter += 10;
                }
                else if (drawer.Fives != fives && change - counter >= 5)
                {
                    fives++;
                    counter += 5;
                }
                else if (drawer.Twos != twos && change - counter >= 2)
                {
                    twos++;
                    counter += 2;
                }
                else if (drawer.Ones != ones && change - counter >= 1)
                {
                    ones++;
                    counter += 1;
                }
                else if (drawer.Dollars != dollars && change - counter >= 1)
                {
                    dollars++;
                    counter += 1;
                }
                else if (drawer.HalfDollars != halfDollars && change - counter >= .5)
                {
                    halfDollars++;
                    counter += .5;
                }
                else if (drawer.Quarters != quarters && change - counter >= .25)
                {
                    quarters++;
                    counter += .25;
                }
                else if (drawer.Dimes != dimes && change - counter >= .1)
                {
                    dimes++;
                    counter += .1;
                }
                else if (drawer.Nickels != nickels && change - counter >= .05)
                {
                    nickels++;
                    counter += .05;
                }
                else if (drawer.Pennies != pennies && change - counter >= .01)
                {
                    pennies++;
                    counter += .01;
                }
                else
                {
                    unsuccessful = true;
                    break;
                }
            }
            if (unsuccessful)
            {
                MessageBox.Show("Exact Change Cannot be Met!", "Change Failure!");
            }
            else
            {
                string result = "Give back: \n";
                if (hundreds != 0)
                {
                    drawer.RemoveBill(Bills.Hundred, hundreds);
                    result = result + (hundreds + " hundreds\n");
                }
                if (fifties != 0)
                {
                    drawer.RemoveBill(Bills.Fifty, fifties);
                    result = result + (fifties + " fifties\n");
                }
                if (twenties != 0)
                {
                    drawer.RemoveBill(Bills.Twenty, twenties);
                    result = result + (twenties + " twenties\n");
                }
                if (tens != 0)
                {
                    drawer.RemoveBill(Bills.Ten, tens);
                    result = result + (tens + " tens\n");
                }
                if (fives != 0)
                {
                    drawer.RemoveBill(Bills.Five, fives);
                    result = result + (fives + " fives\n");
                }
                if (twos != 0)
                {
                    drawer.RemoveBill(Bills.Two, twos);
                    result = result + (twos + " twos\n");
                }
                if (ones != 0)
                {
                    drawer.RemoveBill(Bills.One, ones);
                    result = result + (ones + " ones\n");
                }
                if (dollars != 0)
                {
                    drawer.RemoveCoin(Coins.Dollar, dollars);
                    result = result + (dollars + " dollars\n");
                }
                if (halfDollars != 0)
                {
                    drawer.RemoveCoin(Coins.HalfDollar, halfDollars);
                    result = result + (halfDollars + " halfdollars");
                }
                if (quarters != 0)
                {
                    drawer.RemoveCoin(Coins.Quarter, quarters);
                    result = result + (quarters + " quarters\n");
                }
                if (dimes != 0)
                {
                    drawer.RemoveCoin(Coins.Dime, dimes);
                    result = result + (dimes + " dimes\n");
                }
                if (nickels != 0)
                {
                    drawer.RemoveCoin(Coins.Nickel, nickels);
                    result = result + (nickels + " nickels\n");
                }
                if (pennies != 0)
                {
                    drawer.RemoveCoin(Coins.Penny, pennies);
                    result = result + (pennies + " pennies\n");
                }
                MessageBox.Show(result, "Change");
            }
        }
    }
}
