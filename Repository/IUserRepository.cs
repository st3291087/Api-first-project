using Entity;
using Entity.Models;

namespace Repository
{
    public interface IUserRepository
    {
        Task<User> Get(int id);
        Task<User> Post(loguser loginDetails);
        Task<User> Post(User user);
        Task Put(int id, User userToUpdate);
    }
}