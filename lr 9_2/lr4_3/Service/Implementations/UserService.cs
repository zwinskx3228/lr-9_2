using lr4_3.Models;
using lr4_3.Repositories.Interfaces;
using lr4_3.Services.Interfaces;

namespace lr4_3.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<User> GetAll() => _repository.GetAll();
        public User? GetById(int id) => _repository.GetById(id);

        public User Create(User user)
        {
            _repository.Add(user);
            return user;
        }

        public bool Delete(int id)
        {
            if (_repository.GetById(id) == null) return false;
            _repository.Delete(id);
            return true;
        }
    }
}