using lr4_3.Models;

namespace lr4_3.Repositories.Interfaces
{
    public interface IRestaurantRepository
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant? GetById(int id);
        void Add(Restaurant restaurant);
        void Delete(int id);
    }
}