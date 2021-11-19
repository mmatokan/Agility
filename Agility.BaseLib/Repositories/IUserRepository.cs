using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.BaseLib.Repositories
{
    public interface IUserRepository
    { 
        User SignUpUser(User user);

        User LoginUser(string email, string password);

        IList<User> GetAllUsers();

        IList<Project> GetUserProjects(User user);

        IList<Task> GetUserTasks(User user);

    }
}
