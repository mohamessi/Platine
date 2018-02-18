using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Platine.Database.BusinessObject;
using Platine.Database.DatabaseInterface;
using Platine.Database.Context;
using Platine.Exceptions;

namespace Platine.Database.DatabaseController
{
    public class UserEntity : IUser
    {
        public void DeleteUserById(Guid id)
        {
           using(var ctx = new PlatineContext())
            {
                User u = ctx.Users.SingleOrDefault(e => e.Id.Equals(id));
                if (u == null)
                    throw new MissingException("User "+id);
                ctx.Users.Remove(u);
                ctx.SaveChanges();
            }
        }

        public List<User> GetAllUsers()
        {
            using (var ctx = new PlatineContext())
            {
                return ctx.Users.ToList();
            }
        }
        public User GetUserById(Guid id)
        {
            using(var ctx = new PlatineContext())
            {
                return ctx.Users.SingleOrDefault(e => e.Id.Equals(id));
            }
        }

        public User GetUserByLogin(string login)
        {
            using (var ctx = new PlatineContext())
            {
                var query = ctx.Users.SingleOrDefault(u => u.Login.Equals(login));

                return query;
            };
        }

        public User GetUserByMail(string Mail)
        {
            using(var ctx = new PlatineContext())
            {
                var query =  ctx.Users.SingleOrDefault(e => e.Mail.Equals(Mail));
                if (query == null)
                    throw new MissingException("Mail "+Mail);
                return query;

            }
        }

        public Tuple<Guid, string> Login(string login, string password)
        {
            //return new Tuple<Guid, string>(new Guid(), "momo");
            using (var ctx = new PlatineContext())
            {
                var query = ctx.Users.SingleOrDefault(u => u.Login.Equals(login));
                if (query == null)
                    throw new LoginIncorrect();
                
                if (!query.Password.Equals(password))
                    throw new PasswordIncorrect();

                return new Tuple<Guid, string>(query.Id, query.Login);
            };
        }

        public void Register(User user)
        {
            using (var ctx = new PlatineContext())
            {
                var query = ctx.Users.SingleOrDefault(u => u.Login.Equals(user.Login));
                if (query != null)
                    throw new AlreadyExistException();
                ctx.Users.Add(user);
                ctx.SaveChanges();
                
            };
        }

        public void UpdateUser(User user)
        {
            using(var ctx = new PlatineContext())
            {
                ctx.Entry(user).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}