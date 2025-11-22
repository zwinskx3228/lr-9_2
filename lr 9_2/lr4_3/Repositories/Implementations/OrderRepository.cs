using lr4_3.Models;
using lr4_3.Repositories.Interfaces;
using System.Xml.Linq;

namespace lr4_3.Repositories.Implementations
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new();

        public IEnumerable<Order> GetAll() => _orders;

        public Order? GetById(int id) =>
            _orders.FirstOrDefault(o => o.Id == id);

        public void Add(Order order)
        {
            order.Id = _orders.Count + 1;
            _orders.Add(order);
        }

        public void Delete(int id)
        {
            var existing = GetById(id);
            if (existing != null)
                _orders.Remove(existing);
        }
    }
}
