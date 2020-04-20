// Menu.cs
// Author: Luke Falk

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
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
            items.Add(new ChiliCheeseFries());
            items.Add(new CornDodgers());
            items.Add(new PanDeCampo());
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
            items.Add(new JerkedSoda());
            items.Add(new TexasTea());
            items.Add(new Water());
            return items;
        }

        /// <summary>
        /// gives an Enumerable list of all items served
        /// </summary>
        /// <returns>a list of all items to iterate through</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new AngryChicken());
            items.Add(new CowpokeChili());
            items.Add(new DakotaDoubleBurger());
            items.Add(new PecosPulledPork());
            items.Add(new RustlersRibs());
            items.Add(new TexasTripleBurger());
            items.Add(new TrailBurger());
            items.Add(new BakedBeans());
            items.Add(new ChiliCheeseFries());
            items.Add(new CornDodgers());
            items.Add(new PanDeCampo());
            items.Add(new CowboyCoffee());
            items.Add(new JerkedSoda());
            items.Add(new TexasTea());
            items.Add(new Water());
            return items;
        }
    }
}
