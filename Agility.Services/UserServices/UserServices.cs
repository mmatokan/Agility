using Agility.BaseLib.Repositories;
using Agility.DomainModel;
using Agility.SQLiteDAL;
using System;
using System.Collections.Generic;

namespace Agility.Services
{
    public class UserServices : IUserServices
    {
        private IUserRepository _userRepository;

        public UserServices(IUserRepository inUserRepository)
        {
            _userRepository = inUserRepository;
        }


        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers() as List<User>;
        }


        public List<User> GetAllSelectableUsers(User currentUser)
        {
            List<User> allUsers = GetAllUsers() as List<User>;
            if (allUsers.Contains(currentUser))
            {
                allUsers.Remove(currentUser);
            }
            return allUsers;
        }

        public List<Project> GetUserProjects(User user)
        {
            if(user == null)
            {
                throw new NullReferenceException();
            }

            return _userRepository.GetUserProjects(user) as List<Project>;
        }

        public List<Task> GetUserTasks(User user)
        {
            if (user == null)
            {
                throw new NullReferenceException();
            }

            return _userRepository.GetUserTasks(user) as List<Task>;
        }

        public User LoginUser(string email, string password)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new EmptyLoginFieldException("Email");
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new EmptyLoginFieldException("Password");
            }

            return _userRepository.LoginUser(email, password);
        }

        public User SignUpUser(User user)
        {
            if (string.IsNullOrEmpty(user.Name))
            {
                throw new EmptySignUpFieldException("name");
            }
            if (string.IsNullOrEmpty(user.Surname))
            {
                throw new EmptySignUpFieldException("surname");
            }
            if (string.IsNullOrEmpty(user.Email))
            {
                throw new EmptySignUpFieldException("email");
            }
            if (string.IsNullOrEmpty(user.Password))
            {
                throw new EmptySignUpFieldException("password");
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(user.Email);
            }
            catch
            {
                throw new InvalidEmailAddressException(user.Email);
            }

            return _userRepository.SignUpUser(user);
        }
    }
}
