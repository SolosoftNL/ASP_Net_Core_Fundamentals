using ASP_NET_Core_Fundamentals.Models;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP_NET_Core_Fundamentals.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public ObjectResult Index()
        {
            var model = new Restaurant { Id = 1, Name = "The Bakery" };
            return new ObjectResult(model);
        }
    }
}
