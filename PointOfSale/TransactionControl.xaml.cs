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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        private CashDrawer drawer;
        private ReceiptPrinter printer = new ReceiptPrinter();

        public TransactionControl()
        {
            InitializeComponent();
        }

        public TransactionControl(CashDrawer cash)
        {
            InitializeComponent();
            drawer = cash;
        }

        /// <summary>
        /// sets the datacontext of this usercontrol, also gets the total price after tax
        /// </summary>
        /// <param name="obj">the object to set as the data context</param>
        public void setDataContext(object obj)
        {
            this.DataContext = obj;
            if (obj is Order order)
            {
                Total.Text = Math.Round((order.Subtotal * 1.16), 2, MidpointRounding.AwayFromZero).ToString();
            }
        }

        /// <summary>
        /// event handler for choosing to pay via credit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCreditPay(object sender, RoutedEventArgs e)
        {
            CardTerminal terminal = new CardTerminal();
            ResultCode result = terminal.ProcessTransaction(double.Parse(Total.Text));
            switch (result)
            {
                case ResultCode.CancelledCard:
                    MessageBox.Show("Card Cancelled", "Transaction Failed");
                    break;
                case ResultCode.InsufficentFunds:
                    MessageBox.Show("Insufficient Funds", "Transaction Failed");
                    break;
                case ResultCode.ReadError:
                    MessageBox.Show("Card Read Error!", "Error");
                    break;
                case ResultCode.Success:
                    PrintReceipt(true, 0, 0);
                    var main = this.FindAncestor<MainWindow>();
                    OrderControl orderControl = new OrderControl(drawer);
                    main.Display(orderControl);
                    break;
                case ResultCode.UnknownErrror:
                    MessageBox.Show("Unknown Error!", "Error");
                    break;
            }
        }

        /// <summary>
        /// event handler for choosing to pay via cash
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCashPay(object sender, RoutedEventArgs e)
        {
            DrawerControl control = new DrawerControl();
            control.Price = double.Parse(Total.Text);
            control.drawer = drawer;
            SwapLeftScreen(control);
        }

        /// <summary>
        /// event handler for choosing to cancel the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCancelOrder(object sender, RoutedEventArgs e)
        {
            var main = this.FindAncestor<MainWindow>();
            OrderControl orderControl = new OrderControl(drawer);
            orderControl.DataContext = new Order();
            main.Display(orderControl);
        }

        /// <summary>
        /// prints the receipt into a text file
        /// </summary>
        /// <param name="isCredit">whether or not the transaction was payed with credit</param>
        /// <param name="amountPaid">the amount paid</param>
        /// <param name="change">the change given back</param>
        public void PrintReceipt(bool isCredit, double amountPaid, double change)
        {
            printer.Print("          Cowboy Cafe Receipt         \n");
            printer.Print("--------------------------------------\n");
            printer.Print(DateTime.Now.ToString() + "\n");
            if (this.DataContext is Order order)
            {
                foreach (IOrderItem item in order.Items)
                {
                    string itemName = item.ToString();
                    int spacers = 32 - itemName.Length;
                    while(spacers > 0)
                    {
                        itemName = itemName + ' ';
                        spacers--;
                    }
                    itemName = itemName + '$';
                    itemName = itemName + item.Price.ToString();
                    printer.Print(itemName);
                    foreach (string instruction in item.SpecialInstructions)
                    {
                        printer.Print("   - " + instruction);
                    }
                }

                printer.Print("\n           Subtotal : $" + order.Subtotal.ToString() + "\n");
                printer.Print("                   + 16% tax\n");
                printer.Print("               Total : $" + Total.Text + "\n");

                if (isCredit)
                {
                    printer.Print("\nPaid Via Credit\n");
                }
                else
                {
                    printer.Print("\nPaid Via Cash\n");
                    printer.Print("Amount Paid: $" + amountPaid.ToString() + "\n");
                    printer.Print("Amount in Change: $" + change.ToString() + "\n");
                }
            }
        }

        /// <summary>
        /// swaps the left side of the screen
        /// </summary>
        /// <param name="element">the element to go in the left side of the screen</param>
        public void SwapLeftScreen(FrameworkElement element)
        {
            LeftScreen.Child = element;
        }
    }
}
