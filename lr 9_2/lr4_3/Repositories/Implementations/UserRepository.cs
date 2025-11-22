using lr4_3.Models;
using lr4_3.Repositories.Interfaces;
using System.Xml.Linq;

namespace lr4_3.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new();

        public IEnumerable<User> GetAll() => _users;

        public User? GetById(int id) =>
            _users.FirstOrDefault(u => u.Id == id);

        public void Add(User user)
        {
            user.Id = _users.Count + 1;
            _users.Add(user);
        }

        public void Delete(int id)
        {
            var u = GetById(id);
            if (u != null)
                _users.Remove(u);
        }
    }
}