using lr4_3.Models;

namespace lr4_3.Repositories.Interfaces
{
    public interface IMenuItemRepository
    {
        IEnumerable<MenuItem> GetAll();
        MenuItem? GetById(int id);
        void Add(MenuItem item);
        void Delete(int id);
    }
}
