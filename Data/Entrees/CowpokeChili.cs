﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowpoke Chili entree
    /// </summary>
    public class CowpokeChili: Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Basic Constructer, sets Price and Calories
        /// </summary>
        public CowpokeChili()
        {
            Price = 6.10;
            Calories = 171;
        }

        private bool cheese = true;
        /// <summary>
        /// If the chili is topped with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { 
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool sourCream = true;
        /// <summary>
        /// If the chili is topped with sour cream
        /// </summary>
        public bool SourCream
        {
            get { return sourCream; }
            set { 
                sourCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SourCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool greenOnions = true;
        /// <summary>
        /// If the chili is topped with green onions
        /// </summary>
        public bool GreenOnions
        {
            get { return greenOnions; }
            set { 
                greenOnions = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GreenOnions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool tortillaStrips = true;
        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool TortillaStrips
        {
            get { return tortillaStrips; }
            set { 
                tortillaStrips = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TortillaStrips"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chili
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!cheese) instructions.Add("hold cheese");
                if (!sourCream) instructions.Add("hold sour cream");
                if (!greenOnions) instructions.Add("hold green onions");
                if (!tortillaStrips) instructions.Add("hold tortilla strips");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the object as a string
        /// </summary>
        /// <returns>"Cowpoke Chili"</returns>
        public override string ToString()
        {
            return "Cowpoke Chili";
        }

        /// <summary>
        /// gives the standard name of item
        /// </summary>
        public override string DisplayName
        {
            get => "Cowpoke Chili";
        }
    }
}

