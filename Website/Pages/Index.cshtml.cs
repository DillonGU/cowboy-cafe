using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    
    public class IndexModel : PageModel
    {
        
        private readonly ILogger<IndexModel> _logger;
        /// <summary>
        /// property that gets the drinks from menu drinks
        /// </summary>
        public IEnumerable<IOrderItems> ItemsDrinks { get; protected set; } = Menu.Drinks;

        /// <summary>
        /// property that gets the sides from menu sides
        /// </summary>
        public IEnumerable<IOrderItems> ItemsSides { get; protected set; } = Menu.Sides;
        /// <summary>
        /// property that gets the entrees from menu sides.
        /// </summary>
        public IEnumerable<IOrderItems> ItemsEntrees { get; protected set; } = Menu.Entrees;



        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; }
        /// <summary>
        /// runs when the website opens
        /// </summary>
        public void OnPost()
        {
            
            ItemsDrinks = Menu.Search(ItemsDrinks, SearchTerms);
            ItemsSides = Menu.Search(ItemsSides, SearchTerms);
            ItemsEntrees = Menu.Search(ItemsEntrees, SearchTerms);
            ItemsDrinks = Menu.FilterByCalories(ItemsDrinks, CaloriesMax, CaloriesMin);
            ItemsEntrees = Menu.FilterByCalories(ItemsEntrees, CaloriesMax, CaloriesMin);
            ItemsSides = Menu.FilterByCalories(ItemsSides, CaloriesMax, CaloriesMin);
            ItemsDrinks = Menu.FilterByPrice(ItemsDrinks, PriceMax, PriceMin);
            ItemsSides = Menu.FilterByPrice(ItemsSides, PriceMax, PriceMin);
            ItemsEntrees = Menu.FilterByPrice(ItemsEntrees, PriceMax, PriceMin);
            ItemsEntrees = Menu.FilterByCategory(ItemsEntrees, Category);
            ItemsSides = Menu.FilterByCategory(ItemsSides, Category);
            ItemsDrinks = Menu.FilterByCategory(ItemsDrinks, Category);
        }

        /// <summary>
        /// The filtered Categories
        /// </summary>
        /// 
        [BindProperty]
        public string[] Category { get; set; }

        /// <summary>
        /// The minimum Price
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// The maximum Price
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        /// <summary>
        /// The minimum Calories
        /// </summary>
        [BindProperty]
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// The maximum calories
        /// </summary>
        [BindProperty]
        public int? CaloriesMax { get; set; }
    }
}
