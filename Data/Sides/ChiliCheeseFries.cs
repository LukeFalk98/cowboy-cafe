// ChiliCheeseFries.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this class emulates a side of Chili Cheese Fries
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// this gives the price dependent of the size of the side
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Large):
                        return 3.99;
                    case (Size.Medium):
                        return 2.99;
                    case (Size.Small):
                        return 1.99;
                    default:
                        throw new NotImplementedException("Size Not Recognized");
                }
            }
        }

        /// <summary>
        /// this gives the calorie count dependent of the size of the side
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Large):
                        return 610;
                    case (Size.Medium):
                        return 524;
                    case (Size.Small):
                        return 433;
                    default:
                        throw new NotImplementedException("Size Not Recognized.");
                }
            }
        }

        /// <summary>
        /// Returns the object as a string
        /// </summary>
        /// <returns>"Chili Cheese Fries"</returns>
        public override string ToString()
        {
            return "Chili Cheese Fries";
        }
    }
}
