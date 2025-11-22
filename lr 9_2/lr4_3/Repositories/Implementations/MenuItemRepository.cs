using lr4_3.Models;
using lr4_3.Repositories.Interfaces;
using System.Xml.Linq;

namespace lr4_3.Repositories.Implementations
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly List<MenuItem> _items = new();

        public IEnumerable<MenuItem> GetAll() => _items;

        public MenuItem? GetById(int id) =>
            _items.FirstOrDefault(i => i.Id == id);

        public void Add(MenuItem item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public void Delete(int id)
        {
            var existing = GetById(id);
            if (existing != null)
                _items.Remove(existing);
        }
    }
}
