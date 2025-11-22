using lr4_3.Models;

namespace lr4_3.Services.Interfaces
{
    public interface IMenuItemService
    {
        IEnumerable<MenuItem> GetAll();
        MenuItem? GetById(int id);
        MenuItem Create(MenuItem item);
        bool Delete(int id);
    }
}