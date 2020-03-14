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

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for JerkedSodaCustomization.xaml
    /// </summary>
    public partial class JerkedSodaCustomization : UserControl
    {
        public JerkedSodaCustomization()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton button)
            {
                if (this.DataContext is Drink drink)
                {
                    switch (button.Name)
                    {
                        case "SmallSize":
                            drink.Size = CowboyCafe.Data.Size.Small;
                            break;
                        case "MediumSize":
                            drink.Size = CowboyCafe.Data.Size.Medium;
                            break;
                        case "LargeSize":
                            drink.Size = CowboyCafe.Data.Size.Large;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void FlavorButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton button)
            {
                if (this.DataContext is JerkedSoda drink)
                {
                    switch (button.Name)
                    {
                        case "CreamSoda":
                            drink.Flavor = SodaFlavor.CreamSoda;
                            break;
                        case "OrangeSoda":
                            drink.Flavor = SodaFlavor.OrangeSoda;
                            break;
                        case "RootBeer":
                            drink.Flavor = SodaFlavor.RootBeer;
                            break;
                        case "Sarsparilla":
                            drink.Flavor = SodaFlavor.Sarsparilla;
                            break;
                        case "BirchBeer":
                            drink.Flavor = SodaFlavor.BirchBeer;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
