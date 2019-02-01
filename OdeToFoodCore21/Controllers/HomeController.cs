using Microsoft.AspNetCore.Mvc;
using OdeToFoodCore21.Models;
using OdeToFoodCore21.Services;
using OdeToFoodCore21.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFoodCore21.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        private IGreeter _greeter;

        public HomeController(IRestaurantData restaurantData,
                                IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentMessage = _greeter.GetMessageOfTheDay();
            
            return View(model);

            //returnerar hela objektet som Json-text till broswern
            //return new ObjectResult(model);
        }

        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index)); //bättre om man ev. ändrar namnet på Index
                //return RedirectToAction("Index"); Action i samma controller
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RestaurantEditModel model)
        {
            if (ModelState.IsValid)
            {
                var newRestaurant = new Restaurant();
                newRestaurant.Name = model.Name;
                newRestaurant.Cuisine = model.Cuisine;

                newRestaurant = _restaurantData.Add(newRestaurant);

                //return View("Details", newRestaurant); riskerar dubbla post om användaren trycker pil bak på webbläsaren
                return RedirectToAction(nameof(Details), new { id = newRestaurant.Id }); //fler variabler, ex foo="bar" kan sändas med
            }
            else
            {
                return View();
            }
        }
    }
}
