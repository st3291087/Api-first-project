using Entity;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Text.Json;



namespace Repository
{
    public class UserRepository : IUserRepository
    {
       
        Project_APIContext _dbContext;
        public UserRepository(Project_APIContext dbContext)
        {
            _dbContext=dbContext;
        }
        //public Project_APIContext Get()
        //{
        //    return _dbContext;
        //}

        public async Task<User> Get(int id)
        {

            return await _dbContext.Users.FindAsync(id);
        }

        public async Task<User> Post(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }

        public async Task<User> Post(loguser userlogin)
        {
            return await _dbContext.Users.Where(user => user.Email == userlogin.Email && user.Password == userlogin.Password).FirstOrDefaultAsync();
            

        }
        public async Task Put(int id, User userToUpdate)
        {
            userToUpdate.Id = id;
            _dbContext.Users.Update(userToUpdate);
            await _dbContext.SaveChangesAsync();
        }

    }
}
