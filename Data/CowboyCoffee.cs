using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        public CowboyCoffee() 
        {
            Ice = false;
        }

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

        public bool Decaf { get; set; } = false;

        public bool RoomForCream { get; set; } = false;

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
