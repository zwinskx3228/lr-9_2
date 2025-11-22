using lr4_3.Models;
using lr4_3.Repositories.Interfaces;
using lr4_3.Services.Interfaces;

namespace lr4_3.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Order> GetAll() => _repository.GetAll();
        public Order? GetById(int id) => _repository.GetById(id);

        public Order Create(Order order)
        {
            _repository.Add(order);
            return order;
        }

        public bool Delete(int id)
        {
            if (_repository.GetById(id) == null) return false;
            _repository.Delete(id);
            return true;
        }
    }
}