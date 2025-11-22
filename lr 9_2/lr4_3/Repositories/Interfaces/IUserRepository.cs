using lr4_3.Models;

namespace lr4_3.Repositories.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User? GetById(int id);
        void Add(User user);
        void Delete(int id);
    }
}