// PanDeCampo.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this class emulates the Pan de Campo side
    /// </summary>
    public class PanDeCampo : Side
    {
        /// <summary>
        /// this gives the price of the side based on size
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
                        throw new NotImplementedException("Size Not Recognized");
                }
            }
        }

        /// <summary>
        /// this gives the calorie count of the side based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Large):
                        return 367;
                    case (Size.Medium):
                        return 269;
                    case (Size.Small):
                        return 227;
                    default:
                        throw new NotImplementedException("Size Not Recognized");
                }
            }
        }
    }
}
