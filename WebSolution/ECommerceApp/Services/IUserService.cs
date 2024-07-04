using ECommerceApp.Models;

namespace ECommerceApp.Services
{
    public interface IUserService
    {
        List<User> GetUsers();
        User GetById(int id);
        bool Insert(User user);
        bool Update(User user);
        bool Delete(int id);
    }
}
