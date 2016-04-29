using ASP_NET_Core_Fundamentals.Entities;
using System.Collections.Generic;
using System;
using System.Linq;

namespace ASP_NET_Core_Fundamentals.Services
{

    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _listOfRestaurants;

        public InMemoryRestaurantData()
        {
            _listOfRestaurants = new List<Restaurant>() {
                new Restaurant { Id = 1, Name ="RestaurantName1" },
                new Restaurant { Id =2, Name = "RestaurantName2" },
                new Restaurant { Id =3, Name = "RestaurantName3" },
                new Restaurant { Id =4, Name = "RestaurantName4" },
                new Restaurant { Id =5, Name = "RestaurantName5" },
                };
        }


        public IEnumerable<Restaurant> GetAll()
        {
            return _listOfRestaurants;
        }

        public Restaurant GetById(int id)
        {
            return _listOfRestaurants.Where(r => r.Id == id).FirstOrDefault();
        }
    }
}
