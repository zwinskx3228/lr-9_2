using lr4_3.Models;

namespace lr4_3.Services.Interfaces
{
    public interface IRestaurantService
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant? GetById(int id);
        Restaurant Create(Restaurant restaurant);
        bool Delete(int id);
    }
}