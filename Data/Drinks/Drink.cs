// Drink.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this is the base class for all drinks
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private Size size;
        /// <summary>
        /// this is the size of the drink
        /// </summary>
        public Size Size
        {
            get => size;
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// this is the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// this is the calorie count of the drink
        /// </summary>
        public abstract uint Calories { get; }

        private bool ice = true;
        /// <summary>
        /// this is whether or not the drink has ice
        /// </summary>
        public bool Ice
        {
            get => ice;
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// this is a list of instructions for preparing the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// This allows derived classes to raise events to the propertychanged event handler
        /// </summary>
        /// <param name="sender">the object creating the event</param>
        /// <param name="e">the property changed</param>
        protected void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(sender, e);
        }
    }
}
