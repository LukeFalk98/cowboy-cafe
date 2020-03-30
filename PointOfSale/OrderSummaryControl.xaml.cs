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
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if (button.DataContext is IOrderItem item)
                {
                    if (OrderList.DataContext is Order order)
                    {
                        order.Remove(item);
                    }
                }
            }
        }

        private void OrderList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (sender is ListBox lb)
            {
                if (lb.SelectedItem is IOrderItem item)
                {
                    if (item.ToString().Contains("Angry Chicken"))
                    {
                        var chickenScreen = new AngryChickenCustomization();
                        chickenScreen.DataContext = item;
                        orderControl?.SwapScreen(chickenScreen);
                    }
                    else if (item.ToString().Contains("Cowpoke Chili"))
                    {
                        var chiliScreen = new CowpokeChiliCustomization();
                        chiliScreen.DataContext = item;
                        orderControl?.SwapScreen(chiliScreen);
                    }
                    else if (item.ToString().Contains("Dakota Double Burger"))
                    {
                        var doubleScreen = new DakotaDoubleBurgerCustomization();
                        doubleScreen.DataContext = item;
                        orderControl?.SwapScreen(doubleScreen);
                    }
                    else if (item.ToString().Contains("Pecos Pulled Pork"))
                    {
                        var pecosScreen = new PecosPulledPorkCustomization();
                        pecosScreen.DataContext = item;
                        orderControl?.SwapScreen(pecosScreen);
                    }
                    else if (item.ToString().Contains("Rustler's Ribs"))
                    {
                        var ribsScreen = new RustlersRibsCustomization();
                        ribsScreen.DataContext = item;
                        orderControl?.SwapScreen(ribsScreen);
                    }
                    else if (item.ToString().Contains("Texas Triple Burger"))
                    {
                        var tripleScreen = new TexasTripleBurgerCustomization();
                        tripleScreen.DataContext = item;
                        orderControl?.SwapScreen(tripleScreen);
                    }
                    else if (item.ToString().Contains("Trail Burger"))
                    {
                        var burgerScreen = new TrailBurgerCustomization();
                        burgerScreen.DataContext = item;
                        orderControl?.SwapScreen(burgerScreen);
                    }
                    else if (item.ToString().Contains("Baked Beans"))
                    {
                        var beansScreen = new SideCustomization(item as Side);
                        orderControl?.SwapScreen(beansScreen);
                    }
                    else if (item.ToString().Contains("Chili Cheese Fries"))
                    {
                        var friesScreen = new SideCustomization(item as Side);
                        orderControl?.SwapScreen(friesScreen);
                    }
                    else if (item.ToString().Contains("Corn Dodgers"))
                    {
                        var cornScreen = new SideCustomization(item as Side);
                        orderControl?.SwapScreen(cornScreen);
                    }
                    else if (item.ToString().Contains("Pan de Campo"))
                    {
                        var panScreen = new SideCustomization(item as Side);
                        orderControl?.SwapScreen(panScreen);
                    }
                    else if (item.ToString().Contains("Cowboy Coffee"))
                    {
                        var coffeeScreen = new CowboyCoffeeCustomization(item as CowboyCoffee);
                        orderControl?.SwapScreen(coffeeScreen);
                    }
                    else if (item.ToString().Contains("Jerked Soda"))
                    {
                        var sodaScreen = new JerkedSodaCustomization(item as JerkedSoda);
                        orderControl?.SwapScreen(sodaScreen);
                    }
                    else if (item.ToString().Contains("Texas Tea"))
                    {
                        var teaScreen = new TexasTeaCustomization(item as TexasTea);
                        orderControl?.SwapScreen(teaScreen);
                    }
                    else if (item.ToString().Contains("Water"))
                    {
                        var waterScreen = new WaterCustomization(item as Water);
                        orderControl?.SwapScreen(waterScreen);
                    }
                }
            }
        }
    }
}
