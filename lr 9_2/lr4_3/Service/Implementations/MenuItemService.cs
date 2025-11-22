using lr4_3.Models;
using lr4_3.Repositories.Interfaces;
using lr4_3.Services.Interfaces;

namespace lr4_3.Services.Implementations
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IMenuItemRepository _repository;

        public MenuItemService(IMenuItemRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<MenuItem> GetAll() => _repository.GetAll();

        public MenuItem? GetById(int id) => _repository.GetById(id);

        public MenuItem Create(MenuItem item)
        {
            _repository.Add(item);
            return item;
        }

        public bool Delete(int id)
        {
            if (_repository.GetById(id) == null) return false;
            _repository.Delete(id);
            return true;
        }
    }
}