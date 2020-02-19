// Drink.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this is the base class for all drinks
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// this is the size of the drink
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// this is the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// this is the calorie count of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// this is whether or not the drink has ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// this is a list of instructions for preparing the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
