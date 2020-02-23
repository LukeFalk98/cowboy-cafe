// Water.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this class emulates the water drink
    /// </summary>
    public class Water: Drink
    {
        /// <summary>
        /// this gives the price of water
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }

        /// <summary>
        /// this gives the calories of water
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// this states if there is a lemon for the drink
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// this gives special instructions for preparing the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var inst = new List<string>();

                if (!Ice) inst.Add("Hold Ice");
                if (Lemon) inst.Add("Add Lemon");

                return inst;
            }
        }

        /// <summary>
        /// Returns the object as a string
        /// </summary>
        /// <returns>'Size' Water</returns>
        public override string ToString()
        {
            return ($"{Size} Water");
        }
    }
}
