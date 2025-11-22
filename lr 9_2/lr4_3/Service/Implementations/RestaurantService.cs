using lr4_3.Models;
using lr4_3.Repositories.Interfaces;
using lr4_3.Services.Interfaces;

namespace lr4_3.Services.Implementations
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _repository;

        public RestaurantService(IRestaurantRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Restaurant> GetAll() => _repository.GetAll();

        public Restaurant? GetById(int id) => _repository.GetById(id);

        public Restaurant Create(Restaurant restaurant)
        {
            _repository.Add(restaurant);
            return restaurant;
        }

        public bool Delete(int id)
        {
            var existing = _repository.GetById(id);
            if (existing == null)
                return false;

            _repository.Delete(id);
            return true;
        }
    }
}