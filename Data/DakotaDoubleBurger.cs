// DakotaDoubleBurger.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this class emulates the Dakota Double Burger entree
    /// </summary>
    public class DakotaDoubleBurger
    {
        /// <summary>
        /// boolean representing if the entree has a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// boolean representing if the entree has ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// boolean representing if the entree has mustard
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
        /// boolean representing if the entree has tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// boolean representing if the entree has lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// boolean representing if the entree has mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// a double representing the price of the entree
        /// </summary>
        public double Price
        {
            get { return 5.20; }
        }

        /// <summary>
        /// a uint representing the calorie count of the entree
        /// </summary>
        public uint Calories
        {
            get { return 464; }
        }

        /// <summary>
        /// a list of all the special instructions needed to prepare the entree
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
                if (!Tomato) instructions.Add("hold tomato");
                if (!Lettuce) instructions.Add("hold lettuce");
                if (!Mayo) instructions.Add("hold mayo");

                return instructions;
            }
        }
    }
}
