using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platine.Database.BusinessObject;

namespace Platine.Database.DatabaseInterface
{
    public interface IUser
    {
        Tuple<Guid, string> Login(String login, String password);

        void Register(User user);

        User GetUserByLogin(string login);
        
        User GetUserById(Guid id);

        User GetUserByMail(string Mail);

        void UpdateUser(User user);

        void DeleteUserById(Guid id);

        List<User> GetAllUsers();

       

    }
}
