// PecosPulledPork.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this class emulates the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork: Entree
    {
        /// <summary>
        /// basic constructor, initializes Price and Calories
        /// </summary>
        public PecosPulledPork()
        {
            Price = 5.88;
            Calories = 528;
        }

        private bool bread = true;
        /// <summary>
        /// boolean representing if the entree has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// boolean representing if the entree has a pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// a list of all the special instructions needed to prepare this entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the object as a string
        /// </summary>
        /// <returns>"Peco's Pulled Pork"</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
