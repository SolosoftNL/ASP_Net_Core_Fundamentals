using ASP_NET_Core_Fundamentals.Models;
using ASP_NET_Core_Fundamentals.Services;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP_NET_Core_Fundamentals.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }


        // GET: /<controller>/
        public ViewResult Index()
        {
            //var model = new Restaurant { Id = 1, Name = "The Bakery" };
            var model = _restaurantData;

            return View("Index", model.GetAll());
        }
    }
}
