using OdeToFoodCore21.Models;
using System.ComponentModel.DataAnnotations;

namespace OdeToFoodCore21.ViewModels
{
    public class RestaurantEditModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
