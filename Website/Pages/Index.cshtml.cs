using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CowboyCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

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
            Items = Menu.Search(SearchTerms);
            Items = Menu.FilterByCategory(Items, ItemTypes);
            Items = Menu.FilterByCalories(Items, CalorieMin, CalorieMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        }
    }
}
