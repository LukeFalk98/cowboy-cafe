// TexasTripleBurger.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class that represents the Texas Triple Burger entree
    /// </summary>
    public class TexasTripleBurger
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
        /// boolean representing if the entree has bacon
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// boolean representing if the entree has egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// double that is the price of the entree
        /// </summary>
        public double Price
        {
            get { return 6.45; }
        }

        /// <summary>
        /// uint that is the calorie count of the entree
        /// </summary>
        public uint Calories
        {
            get { return 698; }
        }

        /// <summary>
        /// a List of all the special instructions needed to build this entree
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
                if (!Bacon) instructions.Add("hold bacon");
                if (!Egg) instructions.Add("hold egg");

                return instructions;
            }
        }
    }
}
