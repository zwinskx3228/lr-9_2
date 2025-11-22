using lr4_3.Models;

namespace lr4_3.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll();
        Order? GetById(int id);
        void Add(Order order);
        void Delete(int id);
    }
}