using ASP_NET_Core_Fundamentals.Entities;
using System.Collections.Generic;

namespace ASP_NET_Core_Fundamentals.ViewModels
{
    public class HomePageVM
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentGreeting { get; set; }

    }
}
