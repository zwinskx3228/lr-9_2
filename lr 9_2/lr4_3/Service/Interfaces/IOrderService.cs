using lr4_3.Models;

namespace lr4_3.Services.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAll();
        Order? GetById(int id);
        Order Create(Order order);
        bool Delete(int id);
    }
}