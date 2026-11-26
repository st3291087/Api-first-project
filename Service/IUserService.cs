using Entity;
using Entity.Models;

namespace Service
{
    public interface IUserService
    {
        Task<User> Get(int id);
        Task<User> Post(loguser loginDetails);
        Task<User> Post(User user);
        Task Put(int id, User userToUpdate);
    }
}