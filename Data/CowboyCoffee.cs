// CowboyCoffee.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this class emulates the Coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// this constructer sets the Ice to false
        /// </summary>
        public CowboyCoffee() 
        {
            Ice = false;
        }

        /// <summary>
        /// this gives the price of coffee based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Large):
                        return 1.60;
                    case (Size.Medium):
                        return 1.10;
                    case (Size.Small):
                        return 0.60;
                    default:
                        throw new NotImplementedException("Size Not recognized");
                }
            }
        }

        /// <summary>
        /// this gives the calorie count based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Large):
                        return 7;
                    case (Size.Medium):
                        return 5;
                    case (Size.Small):
                        return 3;
                    default:
                        throw new NotImplementedException("Size Not Recognized");
                }
            }
        }

        /// <summary>
        /// this is whether or not the coffee is decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// this is whether or not there should be room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// this returns a list of the instructions to prepare the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (Decaf) instructions.Add("Decaf");
                if (RoomForCream) instructions.Add("Room For Cream");

                return instructions;
            }
        }
    }
}
