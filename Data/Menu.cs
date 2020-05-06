// Menu.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// this static class provides methods for displaying the menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// gives an Enumerable list of all the entrees
        /// </summary>
        /// <returns>a list of entrees to iterate through</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new AngryChicken());
            items.Add(new CowpokeChili());
            items.Add(new DakotaDoubleBurger());
            items.Add(new PecosPulledPork());
            items.Add(new RustlersRibs());
            items.Add(new TexasTripleBurger());
            items.Add(new TrailBurger());
            return items;
        }

        /// <summary>
        /// gives an Enumerable list of all the Sides
        /// </summary>
        /// <returns>a list of sides to iterate through</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new BakedBeans());
            items.Add(new BakedBeans() { Size = Size.Medium });
            items.Add(new BakedBeans() { Size = Size.Large });
            items.Add(new ChiliCheeseFries());
            items.Add(new ChiliCheeseFries() { Size = Size.Medium });
            items.Add(new ChiliCheeseFries() { Size = Size.Large });
            items.Add(new CornDodgers());
            items.Add(new CornDodgers() { Size = Size.Medium });
            items.Add(new CornDodgers() { Size = Size.Large });
            items.Add(new PanDeCampo());
            items.Add(new PanDeCampo() { Size = Size.Medium });
            items.Add(new PanDeCampo() { Size = Size.Large });
            return items;
        }

        /// <summary>
        /// gives an Enumerable list of all the Drinks served
        /// </summary>
        /// <returns>a list of drinks to iterate through</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new CowboyCoffee());
            items.Add(new CowboyCoffee() { Size = Size.Medium });
            items.Add(new CowboyCoffee() { Size = Size.Large });
            items.Add(new JerkedSoda());
            items.Add(new JerkedSoda() { Size = Size.Medium });
            items.Add(new JerkedSoda() { Size = Size.Large });
            items.Add(new TexasTea());
            items.Add(new TexasTea() { Size = Size.Medium });
            items.Add(new TexasTea() { Size = Size.Large });
            items.Add(new Water());
            items.Add(new Water() { Size = Size.Medium });
            items.Add(new Water() { Size = Size.Large });
            return items;
        }

        /// <summary>
        /// gives an Enumerable list of all items served
        /// </summary>
        /// <returns>a list of all items to iterate through</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            var items = new List<IOrderItem>();
            foreach (IOrderItem item in Entrees())
            {
                items.Add(item);
            }
            foreach (IOrderItem item in Sides())
            {
                items.Add(item);
            }
            foreach (IOrderItem item in Drinks())
            {
                items.Add(item);
            }
            return items;
        }

        /// <summary>
        /// gives an Enumerable list of all flavors in strings
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> SodaFlavors()
        {
            var flavors = new List<string>();
            flavors.Add("Cream Soda");
            flavors.Add("Orange Soda");
            flavors.Add("Sarsparilla");
            flavors.Add("Birch Beer");
            flavors.Add("Root Beer");
            return flavors;
        }

        /// <summary>
        /// Filters all order items via provided search terms
        /// </summary>
        /// <param name="terms">search terms</param>
        /// <returns>list of all order items with search terms</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return CompleteMenu();
            foreach (IOrderItem item in CompleteMenu())
            {
                if (item.DisplayName.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the given list of items to items with the given types, IE Entrees, Sides, and Drinks
        /// </summary>
        /// <param name="items">the list of items to filter</param>
        /// <param name="itemTypes">the list of types to filter by</param>
        /// <returns>the list of items filtered</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> itemTypes)
        {
            if (itemTypes.Count() == 0) return items;
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in items)
            {
                bool itemIsType = false;
                foreach (string type in itemTypes)
                {
                    switch (type)
                    {
                        case "Entree":
                            if (item is Entree) itemIsType = true;
                            break;
                        case "Side":
                            if (item is Side) itemIsType = true;
                            break;
                        case "Drink":
                            if (item is Drink) itemIsType = true;
                            break;
                    }
                }
                if (itemIsType)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the given list of items via given min and max calories
        /// </summary>
        /// <param name="items">the list of items to filter</param>
        /// <param name="min">the minimum caloric value</param>
        /// <param name="max">the maximum caloric value</param>
        /// <returns>the list of items filtered</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? min, uint? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the given list of items via given min and max price
        /// </summary>
        /// <param name="items">the list of items to filter</param>
        /// <param name="min">the minimum price</param>
        /// <param name="max">the maximum price</param>
        /// <returns>the list of items filtered</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
