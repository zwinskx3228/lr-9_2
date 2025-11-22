using lr4_3.Models;

namespace lr4_3.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User? GetById(int id);
        User Create(User user);
        bool Delete(int id);
    }
}