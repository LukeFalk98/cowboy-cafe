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
using PointOfSale.CustomizationScreens;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        private void AngryChicken_Click(object sender, RoutedEventArgs e)
        {
            AngryChicken temp = new AngryChicken();
            if(DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void CowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            CowpokeChili temp = new CowpokeChili();
            if (DataContext is Order order)
            {
                order.Add(temp);
                orderControl.SwapScreen(new CowpokeChiliCustomization());
            }
        }

        private void DakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            DakotaDoubleBurger temp = new DakotaDoubleBurger();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void PecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            PecosPulledPork temp = new PecosPulledPork();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void BakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            BakedBeans temp = new BakedBeans();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void RustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            RustlersRibs temp = new RustlersRibs();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void TexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            TexasTripleBurger temp = new TexasTripleBurger();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void TrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            TrailBurger temp = new TrailBurger();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void ChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            ChiliCheeseFries temp = new ChiliCheeseFries();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void CornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            CornDodgers temp = new CornDodgers();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void PanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            PanDeCampo temp = new PanDeCampo();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void CowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            CowboyCoffee temp = new CowboyCoffee();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void JerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda temp = new JerkedSoda();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void TexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            TexasTea temp = new TexasTea();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void WaterButton_Click(object sender, RoutedEventArgs e)
        {
            Water temp = new Water();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            var item = new CowpokeChili();
                            var screen = new CowpokeChiliCustomization();
                            screen.DataContext = item;
                            order.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                        case "AngryChicken":
                            
                            break;
                    }
                }
            }
        }
    }
}
