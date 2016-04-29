using ASP_NET_Core_Fundamentals.Entities;
using ASP_NET_Core_Fundamentals.Services;
using ASP_NET_Core_Fundamentals.ViewModels;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP_NET_Core_Fundamentals.Controllers
{
    public class HomeController : Controller
    {
        private IGreeter _greeter;
        private IRestaurantData _restaurantData;

        public HomeController(
            IRestaurantData restaurantData,
            IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            //var model = new Restaurant { Id = 1, Name = "The Bakery" };
            var model = new HomePageVM();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentGreeting = _greeter.GetGreeting();

            return View("Index", model);
        }

        public IActionResult Details(int id)
        {
            var model = _restaurantData.GetById(id);

            if (model==null)
            {
                return RedirectToActionPermanent("Index");
            }

            return View(model);
        }
    }
}
