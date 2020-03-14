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
                    switch (button.Content)
                    {
                        case "Cowpoke Chili":
                            var chiliItem = new CowpokeChili();
                            var chiliScreen = new CowpokeChiliCustomization();
                            chiliScreen.DataContext = chiliItem;
                            order.Add(chiliItem);
                            orderControl?.SwapScreen(chiliScreen);
                            break;
                        case "Angry Chicken":
                            var chickenItem = new AngryChicken();
                            var chickenScreen = new AngryChickenCustomization();
                            chickenScreen.DataContext = chickenItem;
                            order.Add(chickenItem);
                            orderControl?.SwapScreen(chickenScreen);
                            break;
                        case "Dakota Double Burger":
                            var doubleItem = new DakotaDoubleBurger();
                            var doubleScreen = new DakotaDoubleBurgerCustomization();
                            doubleScreen.DataContext = doubleItem;
                            order.Add(doubleItem);
                            orderControl?.SwapScreen(doubleScreen);
                            break;
                        case "Pecos Pulled Pork":
                            var pecosItem = new PecosPulledPork();
                            var pecosScreen = new PecosPulledPorkCustomization();
                            pecosScreen.DataContext = pecosItem;
                            order.Add(pecosItem);
                            orderControl?.SwapScreen(pecosScreen);
                            break;
                        case "Rustler's Ribs":
                            var ribsItem = new RustlersRibs();
                            var ribsScreen = new RustlersRibsCustomization();
                            ribsScreen.DataContext = ribsItem;
                            order.Add(ribsItem);
                            orderControl?.SwapScreen(ribsScreen);
                            break;
                        case "Texas Triple Burger":
                            var tripleItem = new TexasTripleBurger();
                            var tripleScreen = new TexasTripleBurgerCustomization();
                            tripleScreen.DataContext = tripleItem;
                            order.Add(tripleItem);
                            orderControl?.SwapScreen(tripleScreen);
                            break;
                        case "Trail Burger":
                            var burgerItem = new TrailBurger();
                            var burgerScreen = new TrailBurgerCustomization();
                            burgerScreen.DataContext = burgerItem;
                            order.Add(burgerItem);
                            orderControl?.SwapScreen(burgerScreen);
                            break;
                        case "Baked Beans":
                            var beansItem = new BakedBeans();
                            var beansScreen = new SideCustomization();
                            beansScreen.DataContext = beansItem;
                            order.Add(beansItem);
                            orderControl?.SwapScreen(beansScreen);
                            break;
                        case "Chili Cheese Fries":
                        case "Corn Dodgers":
                        case "Pan de Campo":
                            break;
                        case "Cowboy Coffee":
                        case "Jerked Soda":
                        case "Texas Tea":
                        case "Water":
                            break;
                    }
                }
            }
        }
    }
}
