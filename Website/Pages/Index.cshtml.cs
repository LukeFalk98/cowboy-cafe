using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CowboyCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// the list of all the Order Items
        /// </summary>
        [BindProperty]
        public IEnumerable<IOrderItem> Items { get; protected set; } = Menu.CompleteMenu();

        /// <summary>
        /// the current search terms
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// the filtered item types
        /// </summary>
        [BindProperty]
        public string[] ItemTypes { get; set; }

        /// <summary>
        /// the minimum calories
        /// </summary>
        [BindProperty]
        public uint? CalorieMin { get; set; }

        /// <summary>
        /// the maximum calories
        /// </summary>
        [BindProperty]
        public uint? CalorieMax { get; set; }

        /// <summary>
        /// the minimum price
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// the maximum price
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string SearchTerms, string[] ItemTypes, uint? CalorieMin, uint? CalorieMax, double? PriceMin, double? PriceMax)
        {
            this.SearchTerms = SearchTerms;
            this.ItemTypes = ItemTypes;
            this.CalorieMin = CalorieMin;
            this.CalorieMax = CalorieMax;
            this.PriceMax = PriceMax;
            this.PriceMin = PriceMin;
            Items = Menu.CompleteMenu();
            if (SearchTerms != null)
            {
                Items = from item in Items
                        where item.DisplayName.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)
                        select item;
            }
            if (ItemTypes != null && ItemTypes.Length != 0)
            {
                Items = Items.Where(item =>
                    (item is Entree && ItemTypes.Contains("Entree")) ||
                    (item is Side && ItemTypes.Contains("Side")) ||
                    (item is Drink && ItemTypes.Contains("Drink"))
                    );
            }
            if (CalorieMin != null)
            {
                Items = Items.Where(item =>
                    CalorieMin <= item.Calories
                    );
            }
            if (CalorieMax != null)
            {
                Items = Items.Where(item =>
                    item.Calories <= CalorieMax
                    );
            }
            if (PriceMax != null)
            {
                Items = Items.Where(item =>
                    item.Price <= PriceMax
                    );
            }
            if (PriceMin != null)
            {
                Items = Items.Where(item =>
                    PriceMin <= item.Price
                    );
            }
        }
    }
}
