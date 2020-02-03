﻿// RustlersRibs.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this class simulates the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs: Entree
    {
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
    }
}
