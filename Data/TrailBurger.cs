// TrailBurger.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// This class represents the Trail Burger entree.
    /// </summary>
    public class TrailBurger
    {
        /// <summary>
        /// boolean representing if the entree has a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// boolean representing if the entree has Ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// boolean representing if the entree has Mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// boolean representing if the entree has a pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// boolean representing if the entree has cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// A double that is the price of the entree
        /// </summary>
        public double Price
        {
            get { return 4.50; }
        }

        /// <summary>
        /// a uint that is the calories of the entree
        /// </summary>
        public uint Calories
        {
            get { return 288; }
        }

        /// <summary>
        /// a list of all the special instructions to prepare the entree
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bun) instructions.Add("hold bun");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Cheese) instructions.Add("hold cheese");

                return instructions;
            }
        }
    }
}
