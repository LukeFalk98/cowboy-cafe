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

        private void RustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            RustlersRibs temp = new RustlersRibs();
            OrderBox.Items.Add(temp);
        }

        private void TexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            TexasTripleBurger temp = new TexasTripleBurger();
            OrderBox.Items.Add(temp);
        }

        private void TrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            TrailBurger temp = new TrailBurger();
            OrderBox.Items.Add(temp);
        }

        private void ChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            ChiliCheeseFries temp = new ChiliCheeseFries();
            OrderBox.Items.Add(temp);
        }

        private void CornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            CornDodgers temp = new CornDodgers();
            OrderBox.Items.Add(temp);
        }

        private void PanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            PanDeCampo temp = new PanDeCampo();
            OrderBox.Items.Add(temp);
        }

        private void CowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            CowboyCoffee temp = new CowboyCoffee();
            OrderBox.Items.Add(temp);
        }

        private void JerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda temp = new JerkedSoda();
            OrderBox.Items.Add(temp);
        }

        private void TexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            TexasTea temp = new TexasTea();
            OrderBox.Items.Add(temp);
        }

        private void WaterButton_Click(object sender, RoutedEventArgs e)
        {
            Water temp = new Water();
            OrderBox.Items.Add(temp);
        }
    }
}
