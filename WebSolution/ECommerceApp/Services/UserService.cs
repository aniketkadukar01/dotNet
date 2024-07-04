using ECommerceApp.Models;
using ECommerceApp.Repositories;

namespace ECommerceApp.Services
{
    public class UserService : IUserService
    {
        public UserService() { }

        public bool Delete(int id)
        {
            UserRepository.delete(id);
            return true;
        }

        public User GetById(int id)
        {
            User user = null;
            return user;
        }

        public List<User> GetUsers()
        {
            List<User> users = UserRepository.GetAllUsers();
            return users;
        }

        public bool Insert(User user)
        {          
            if(UserRepository.Insert(user) != false)
            {
                return true;
            }
            return false;
        }

        public bool Update(User user)
        {
            return false; 
        }
    }
}
