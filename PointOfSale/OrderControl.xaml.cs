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
        }

        private void AngryChicken_Click(object sender, RoutedEventArgs e)
        {
            AngryChicken temp = new AngryChicken();
            OrderBox.Items.Add(temp);
        }

        private void CowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            CowpokeChili temp = new CowpokeChili();
            OrderBox.Items.Add(temp);
        }

        private void DakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            DakotaDoubleBurger temp = new DakotaDoubleBurger();
            OrderBox.Items.Add(temp);
        }

        private void PecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            PecosPulledPork temp = new PecosPulledPork();
            OrderBox.Items.Add(temp);
        }

        private void BakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            BakedBeans temp = new BakedBeans();
            OrderBox.Items.Add(temp);
        }
    }
}
