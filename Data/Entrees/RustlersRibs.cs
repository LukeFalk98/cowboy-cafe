// RustlersRibs.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this class simulates the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs: Entree, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// basic constructor, initializes the Price and Calories
        /// </summary>
        public RustlersRibs()
        {
            Price = 7.50;
            Calories = 894;
        }

        /// <summary>
        /// this is a list of all the special instructions needed to prepare the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>"Rustler's Ribs"</returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }

        /// <summary>
        /// gives the standard name of item
        /// </summary>
        public override string DisplayName
        {
            get => "Rustler's Ribs";
        }
    }
}
