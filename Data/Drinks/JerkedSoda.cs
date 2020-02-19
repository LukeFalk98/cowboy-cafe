using System;
// JerkedSoda.cs
// Author: Luke Falk

using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this class represents the Soda Drink
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// this returns the price based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Large):
                        return 2.59;
                    case (Size.Medium):
                        return 2.10;
                    case (Size.Small):
                        return 1.59;
                    default:
                        throw new NotImplementedException("Size Not Recognized");
                }
            }
        }

        /// <summary>
        /// this returns the calorie count based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Large):
                        return 198;
                    case (Size.Medium):
                        return 146;
                    case (Size.Small):
                        return 110;
                    default:
                        throw new NotImplementedException("Size Not Recognized");
                }
            }
        }

        /// <summary>
        /// this is the flavor of soda
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// this gives the instructions for serving
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }
    }
}
