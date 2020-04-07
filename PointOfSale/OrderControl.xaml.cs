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
using System.Windows.Shapes;
using CowboyCafe.Data;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        private CashDrawer drawer = new CashDrawer();
        public OrderControl()
        {
            InitializeComponent();

            var data = new Order();
            this.DataContext = data;
        }

        public OrderControl(CashDrawer cash)
        {
            InitializeComponent();

            var data = new Order();
            this.DataContext = data;
            drawer = cash;
        }

        private void ItemSelectButton_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            var main = this.FindAncestor<MainWindow>();
            TransactionControl transaction = new TransactionControl(drawer);
            transaction.setDataContext(this.DataContext);
            main.Display(transaction);
        }

        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }
    }
}
