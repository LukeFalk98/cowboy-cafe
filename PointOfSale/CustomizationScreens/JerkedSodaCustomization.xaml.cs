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
        public JerkedSodaCustomization(JerkedSoda soda)
        {
            InitializeComponent();
            this.DataContext = soda;
            switch (soda.Size)
            {
                case CowboyCafe.Data.Size.Small:
                    if (this.FindName("SmallSize") is RadioButton sbutton)
                    {
                        sbutton.IsChecked = true;
                    }
                    break;
                case CowboyCafe.Data.Size.Medium:
                    if (this.FindName("MediumSize") is RadioButton mbutton)
                    {
                        mbutton.IsChecked = true;
                    }
                    break;
                case CowboyCafe.Data.Size.Large:
                    if (this.FindName("LargeSize") is RadioButton lbutton)
                    {
                        lbutton.IsChecked = true;
                    }
                    break;
            }
            switch (soda.Flavor)
            {
                case CowboyCafe.Data.SodaFlavor.Sarsparilla:
                    if (this.FindName("Sarsparilla") is RadioButton sbutton)
                    {
                        sbutton.IsChecked = true;
                    }
                    break;
                case CowboyCafe.Data.SodaFlavor.RootBeer:
                    if (this.FindName("RootBeer") is RadioButton mbutton)
                    {
                        mbutton.IsChecked = true;
                    }
                    break;
                case CowboyCafe.Data.SodaFlavor.OrangeSoda:
                    if (this.FindName("OrangeSoda") is RadioButton lbutton)
                    {
                        lbutton.IsChecked = true;
                    }
                    break;
                case CowboyCafe.Data.SodaFlavor.CreamSoda:
                    if (this.FindName("CreamSoda") is RadioButton cbutton)
                    {
                        cbutton.IsChecked = true;
                    }
                    break;
                case CowboyCafe.Data.SodaFlavor.BirchBeer:
                    if (this.FindName("BirchBeer") is RadioButton bbutton)
                    {
                        bbutton.IsChecked = true;
                    }
                    break;
            }
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
