// IOrderItem.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this interface allows order items to have a price, special instructions, and other attributes
    /// </summary>
    public interface IOrderItem
    {
        double Price { get; }

        string DisplayName { get; }

        uint Calories { get; }

        List<string> SpecialInstructions { get; }
    }
}
