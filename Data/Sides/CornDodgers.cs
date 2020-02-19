// CornDodgers.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// This class emulates the Corn Dodgers side
    /// </summary>
    public class CornDodgers: Side
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
                        return 1.99;
                    case (Size.Medium):
                        return 1.79;
                    case (Size.Small):
                        return 1.59;
                    default:
                        throw new NotImplementedException("Size Not Recognized.");
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
                        return 717;
                    case (Size.Medium):
                        return 685;
                    case (Size.Small):
                        return 512;
                    default:
                        throw new NotImplementedException("Size Not Recognized.");
                }
            }
        }

        /// <summary>
        /// Returns the object as a string
        /// </summary>
        /// <returns>"Corn Dodgers"</returns>
        public override string ToString()
        {
            return "Corn Dodgers";
        }
    }
}
