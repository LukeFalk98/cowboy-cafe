using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private static uint lastOrderNumber = lastOrderNumber + 1;

        private List<IOrderItem> items = new List<IOrderItem>();

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

        public IEnumerable<IOrderItem> Items
        {
            get
            {
                foreach(IOrderItem item in items)
                {
                    yield return item;
                }
            }
        }

        public uint OrderNumber { get => lastOrderNumber + 1; }

        public void Add(IOrderItem item) 
        { 
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void Remove(IOrderItem item) 
        { 
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
