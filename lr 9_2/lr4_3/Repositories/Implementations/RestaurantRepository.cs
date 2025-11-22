using lr4_3.Models;
using lr4_3.Repositories.Interfaces;
using System.Xml.Linq;

namespace lr4_3.Repositories.Implementations
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly List<Restaurant> _restaurants = new();

        public IEnumerable<Restaurant> GetAll() => _restaurants;

        public Restaurant? GetById(int id) =>
            _restaurants.FirstOrDefault(r => r.Id == id);

        public void Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurants.Count + 1;
            _restaurants.Add(restaurant);
        }

        public void Delete(int id)
        {
            var r = GetById(id);
            if (r != null) _restaurants.Remove(r);
        }
    }
}
