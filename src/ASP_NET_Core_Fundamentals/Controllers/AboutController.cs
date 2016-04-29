using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP_NET_Core_Fundamentals.Controllers
{
   
    public class AboutController : Controller
    {
        // GET: /<controller>/
        public IActionResult Phone()
        {
            return Content("+31 6 53446722");
        }

        public string Country()
        {
            return "Netherlands";
        }

    }
}
