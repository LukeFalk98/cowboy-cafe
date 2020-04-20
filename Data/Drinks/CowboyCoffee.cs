// CowboyCoffee.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this class emulates the Coffee drink
    /// </summary>
    public class CowboyCoffee : Drink, INotifyPropertyChanged
    {

        /// <summary>
        /// this constructer sets the Ice to false
        /// </summary>
        public CowboyCoffee() 
        {
            Ice = false;
        }

        /// <summary>
        /// this gives the price of coffee based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Large):
                        return 1.60;
                    case (Size.Medium):
                        return 1.10;
                    case (Size.Small):
                        return 0.60;
                    default:
                        throw new NotImplementedException("Size Not recognized");
                }
            }
        }

        /// <summary>
        /// this gives the calorie count based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Large):
                        return 7;
                    case (Size.Medium):
                        return 5;
                    case (Size.Small):
                        return 3;
                    default:
                        throw new NotImplementedException("Size Not Recognized");
                }
            }
        }

        private bool decaf = false;
        /// <summary>
        /// this is whether or not the coffee is decaf
        /// </summary>
        public bool Decaf
        {
            get => decaf;
            set
            {
                decaf = value;
                OnPropertyChanged(this, new PropertyChangedEventArgs("Decaf"));
                OnPropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool roomForCream = false;
        /// <summary>
        /// this is whether or not there should be room for cream
        /// </summary>
        public bool RoomForCream
        {
            get => roomForCream;
            set
            {
                roomForCream = value;
                OnPropertyChanged(this, new PropertyChangedEventArgs("RoomForCream"));
                OnPropertyChanged(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// this returns a list of the instructions to prepare the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (Decaf) instructions.Add("Decaf");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the object as a string
        /// </summary>
        /// <returns>'Size' 'Decaf' Cowboy Coffee</returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return ($"{Size} Decaf Cowboy Coffee");
            }
            return ($"{Size} Cowboy Coffee");
        }

        /// <summary>
        /// gives the standard name of item
        /// </summary>
        public override string DisplayName
        {
            get => "Cowboy Coffee";
        }
    }
}
