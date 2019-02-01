using Microsoft.AspNetCore.Mvc;

namespace OdeToFoodCore21.Controllers
{
    [Route("[controller]/[action]")]
    //[Route("company[controller]/[action]")]
    //kräver att url:en är company/about/phone för att kunna acessa
    //Phone-metoden
    public class AboutController
    {
        //[Route("")]
        public string Phone()
        {
            return "1+555+555+5555";
        }

        //[Route("address")]
        public string Address()
        {
            return "USA";
        }
    }
}
