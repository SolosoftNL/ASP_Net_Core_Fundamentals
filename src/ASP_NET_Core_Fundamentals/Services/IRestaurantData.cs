using System.Collections.Generic;
using ASP_NET_Core_Fundamentals.Entities;

namespace ASP_NET_Core_Fundamentals.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}