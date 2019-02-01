using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFoodCore21.Services;

namespace OdeToFoodCore21.Pages
{
    public class GreetingModel : PageModel
    {
        private IGreeter _greeter;

        public string CurrentGreeting { get; set; }

        public GreetingModel(IGreeter greeter)
        {
            _greeter = greeter;
        }

        //ett namn måste läggas till efter ../Greeting/, ex ../Greeting/HAK
        public void OnGet(string name)
        {
            CurrentGreeting = $"{name}: {_greeter.GetMessageOfTheDay()}";
        }
    }
}