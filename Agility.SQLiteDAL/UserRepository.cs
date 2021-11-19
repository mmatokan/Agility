using System;
using System.Collections.Generic;

using NHibernate;
using Agility.DomainModel;
using Agility.BaseLib.Repositories;

namespace Agility.SQLiteDAL
{
    public class UserRepository : IUserRepository
    {
        private static UserRepository _instance;

        public static UserRepository getInstance()
        {
            return _instance ?? (_instance = new UserRepository());
        }

        public IList<User> GetAllUsers()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IList<User> users = session.QueryOver<User>()
                    .List<User>();
                return users;
            }
        }

        public IList<Project> GetUserProjects(User user)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IList<Project> projects = session.QueryOver<Project>()
                    .JoinQueryOver<User>(x => x.Members)
                    .Where(x => x.UserId == user.UserId)
                    .List<Project>();
                return projects;
            }
        }

        public IList<Task> GetUserTasks(User user)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IList<Task> tasks = session.QueryOver<Task>()
                    .Inner.JoinQueryOver<User>(x => x.MemberWorking)
                    .Where(x => x.UserId == user.UserId)
                    .List<Task>();
                return tasks;
            }
        }

        public User LoginUser(string email, string password)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IList<User> users = session.QueryOver<User>()
                    .Where(x => x.Email == email)
                    .And(x => x.Password == password)
                    .List<User>();
                if(users.Count == 1)
                {
                    return users[0];
                }
                else
                {
                    throw new NoSuchUserException(email);
                }
            }
        }

        public User SignUpUser(User user)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        var id = session.Save(user);
                        user.UserId = (long)id;
                        transaction.Commit();
                    }
                }
                return user;
            }
            catch
            {
                throw new UserExistsException(user.Email);
            }          
        }
    }
}
