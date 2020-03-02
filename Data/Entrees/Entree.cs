// Entree.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this class gives the basic properties all entrees have
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// this returns the price of the entree
        /// </summary>
        public double Price { get; protected set; }

        /// <summary>
        /// this returns the calorie count of the entree
        /// </summary>
        public uint Calories { get; protected set; }

        /// <summary>
        /// this provides a base case for special instructions
        /// </summary>
        public virtual List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }
    }
}
