﻿using System;
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
    /// Interaction logic for SideCustomization.xaml
    /// </summary>
    public partial class SideCustomization : UserControl
    {
        public SideCustomization(Side side)
        {
            InitializeComponent();
            this.DataContext = side;
            switch (side.Size)
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
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton button) {
                if (this.DataContext is Side side)
                {
                    switch (button.Name)
                    {
                        case "SmallSize":
                            side.Size = CowboyCafe.Data.Size.Small;
                            break;
                        case "MediumSize":
                            side.Size = CowboyCafe.Data.Size.Medium;
                            break;
                        case "LargeSize":
                            side.Size = CowboyCafe.Data.Size.Large;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
