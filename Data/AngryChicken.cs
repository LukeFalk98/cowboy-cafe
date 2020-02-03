// AngryChicken.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this class emulates the Angry Chicken entree
    /// </summary>
    public class AngryChicken: Entree
    {
        /// <summary>
        /// general constructer, initializes price and calories
        /// </summary>
        public AngryChicken()
        {
            Price = 5.99;
            Calories = 190;
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
        /// a list of the special instructions needed to prepare the entree
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
    }
}
