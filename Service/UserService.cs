
using Entity;
using Entity.Models;
using Repository;
using System.Text.Json;


namespace Service
{
    public class UserService : IUserService
    {
        //UserRepository repository = new UserRepository();
        IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<User> Get(int id)
        {

            return await userRepository.Get(id);
        }

        public async Task<User> Post(User user)
        {
            return await userRepository.Post(user);
        }
        public async Task<User> Post(loguser loginDetails)
        {
            return await userRepository.Post(loginDetails);
        }
        public async Task Put(int id, User userToUpdate)
        {
            await userRepository.Put(id, userToUpdate);
        }
    }
}