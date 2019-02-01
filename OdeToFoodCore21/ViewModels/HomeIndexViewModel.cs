using OdeToFoodCore21.Models;
using System.Collections.Generic;

namespace OdeToFoodCore21.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }
    }
}
