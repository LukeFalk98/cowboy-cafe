// TexasTea.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this emulates the Tea Drink
    /// </summary>
    public class TexasTea: Drink
    {
        /// <summary>
        /// this is a bool whether or not the tea is sweet
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// this is whether or not there is a lemon
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// this returns the price of the drink based off size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Large):
                        return 2.00;
                    case (Size.Medium):
                        return 1.50;
                    case (Size.Small):
                        return 1.00;
                    default:
                        throw new NotImplementedException("Size Not recognized");
                }
            }
        }

        /// <summary>
        /// this gives the calorie count based of size and whether or not it's sweetened
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {
                        case (Size.Large):
                            return 36;
                        case (Size.Medium):
                            return 22;
                        case (Size.Small):
                            return 10;
                        default:
                            throw new NotImplementedException("Size Not Recognized");
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case (Size.Large):
                            return 18;
                        case (Size.Medium):
                            return 11;
                        case (Size.Small):
                            return 5;
                        default:
                            throw new NotImplementedException("Size Not Recognized");
                    }
                }
            }
        }

        /// <summary>
        /// This gives the special instructions to prepare this drink
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
        /// <returns>'Size' Texas 'Type' Tea</returns>
        public override string ToString()
        {
            if (Sweet)
            {
                return ($"{Size} Texas Sweet Tea");
            }
            return ($"{Size} Texas Plain Tea");
        }
    }
}
