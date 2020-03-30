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
                            var beansScreen = new SideCustomization(beansItem);
                            order.Add(beansItem);
                            orderControl?.SwapScreen(beansScreen);
                            break;
                        case "Chili Cheese Fries":
                            var friesItem = new ChiliCheeseFries();
                            var friesScreen = new SideCustomization(friesItem);
                            order.Add(friesItem);
                            orderControl?.SwapScreen(friesScreen);
                            break;
                        case "Corn Dodgers":
                            var cornItem = new CornDodgers();
                            var cornScreen = new SideCustomization(cornItem);
                            order.Add(cornItem);
                            orderControl?.SwapScreen(cornScreen);
                            break;
                        case "Pan de Campo":
                            var panItem = new PanDeCampo();
                            var panScreen = new SideCustomization(panItem);
                            order.Add(panItem);
                            orderControl?.SwapScreen(panScreen);
                            break;
                        case "Cowboy Coffee":
                            var coffeeItem = new CowboyCoffee();
                            var coffeeScreen = new CowboyCoffeeCustomization(coffeeItem);
                            order.Add(coffeeItem);
                            orderControl?.SwapScreen(coffeeScreen);
                            break;
                        case "Jerked Soda":
                            var sodaItem = new JerkedSoda();
                            var sodaScreen = new JerkedSodaCustomization(sodaItem);
                            order.Add(sodaItem);
                            orderControl?.SwapScreen(sodaScreen);
                            break;
                        case "Texas Tea":
                            var teaItem = new TexasTea();
                            var teaScreen = new TexasTeaCustomization(teaItem);
                            order.Add(teaItem);
                            orderControl?.SwapScreen(teaScreen);
                            break;
                        case "Water":
                            var waterItem = new Water();
                            var waterScreen = new WaterCustomization(waterItem);
                            order.Add(waterItem);
                            orderControl?.SwapScreen(waterScreen);
                            break;
                    }
                }
            }
        }
    }
}
