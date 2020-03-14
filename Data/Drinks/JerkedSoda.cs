using System;
// JerkedSoda.cs
// Author: Luke Falk

using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this class represents the Soda Drink
    /// </summary>
    public class JerkedSoda : Drink, INotifyPropertyChanged
    {

        /// <summary>
        /// this returns the price based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Large):
                        return 2.59;
                    case (Size.Medium):
                        return 2.10;
                    case (Size.Small):
                        return 1.59;
                    default:
                        throw new NotImplementedException("Size Not Recognized");
                }
            }
        }

        /// <summary>
        /// this returns the calorie count based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Large):
                        return 198;
                    case (Size.Medium):
                        return 146;
                    case (Size.Small):
                        return 110;
                    default:
                        throw new NotImplementedException("Size Not Recognized");
                }
            }
        }

        private SodaFlavor flavor;
        /// <summary>
        /// this is the flavor of soda
        /// </summary>
        public SodaFlavor Flavor
        {
            get => flavor;
            set
            {
                flavor = value;
                OnPropertyChanged(this, new PropertyChangedEventArgs("Flavor"));
            }
        }

        /// <summary>
        /// this gives the instructions for serving
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the object as a string
        /// </summary>
        /// <returns>'Size' 'Flavor' Jerked Soda</returns>
        public override string ToString()
        {
            switch (Flavor)
            {
                case SodaFlavor.BirchBeer:
                    return ($"{Size} Birch Beer Jerked Soda");
                case SodaFlavor.CreamSoda:
                    return ($"{Size} Cream Soda Jerked Soda");
                case SodaFlavor.OrangeSoda:
                    return ($"{Size} Orange Soda Jerked Soda");
                case SodaFlavor.RootBeer:
                    return ($"{Size} Root Beer Jerked Soda");
                case SodaFlavor.Sarsparilla:
                    return ($"{Size} Sarsparilla Jerked Soda");
                default:
                    throw new NotImplementedException("Flavor Not Implemented");
            }
        }
    }
}
