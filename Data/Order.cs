// Order.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this represents a single order instance
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// event handler for updated properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// the previous order
        /// </summary>
        private static uint lastOrderNumber = 0;

        /// <summary>
        /// all items in the list
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Constructor that updates the order number
        /// </summary>
        public Order()
        {
            lastOrderNumber++;
        }

        /// <summary>
        /// this gives the total price of the ticket
        /// </summary>
        public double Subtotal
        {
            get
            {
                double result = 0.0;
                foreach (IOrderItem item in Items)
                {
                    result += item.Price;
                }
                return result;
            }
        }

        /// <summary>
        /// this is a list of all the item's prices
        /// </summary>
        public List<double> Price { get; private set; } = new List<double>();

        /// <summary>
        /// this gives the list of items
        /// </summary>
        public IEnumerable<IOrderItem> Items { get => items.ToArray(); }

        /// <summary>
        /// this gives the current order
        /// </summary>
        public uint OrderNumber { get => lastOrderNumber; }

        /// <summary>
        /// this adds an item to the order
        /// </summary>
        /// <param name="item">the menu item to add to the order</param>
        public void Add(IOrderItem item) 
        { 
            items.Add(item);
            if (item is INotifyPropertyChanged pcitem) { pcitem.PropertyChanged += OnItemChanged; }
            Price.Add(item.Price);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        /// <summary>
        /// This removes an item from the order
        /// </summary>
        /// <param name="item">the item to remove</param>
        public void Remove(IOrderItem item) 
        { 
            items.Remove(item);
            if (item is INotifyPropertyChanged pcitem)
            {
                pcitem.PropertyChanged -= OnItemChanged;
            }
            Price.Remove(item.Price);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price") PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
