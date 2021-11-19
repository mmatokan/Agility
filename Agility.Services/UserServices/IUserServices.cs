using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agility.Services
{
    public interface IUserServices
    {
        User SignUpUser(User user);

        User LoginUser(string email, string password);

        List<User> GetAllUsers();

        List<User> GetAllSelectableUsers(User currentUser);

        List<Project> GetUserProjects(User user);

        List<Task> GetUserTasks(User user);
    }
}
