// IOrderItem.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this interface allows order items to have a price and special instructions
    /// </summary>
    public interface IOrderItem
    {
        double Price { get; }

        List<string> SpecialInstructions { get; }
    }
}
