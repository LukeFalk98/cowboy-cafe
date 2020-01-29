// RustlersRibs.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this class simulates the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs
    {
        /// <summary>
        /// This double is the price of the entree
        /// </summary>
        public double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// this uint is the calorie count of the entree
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// this is a list of all the special instructions needed to prepare the entree
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }
    }
}
