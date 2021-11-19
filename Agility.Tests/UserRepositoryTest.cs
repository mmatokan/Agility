using System;
using System.Collections.Generic;
using Agility.Controller;
using Agility.DomainModel;
using Agility.SQLiteDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;

namespace Agility.SQLiteDAL.Tests
{
    [TestClass]
    public class UserRepositoryTest
    {
        /// <summary>
        /// Using in memory SQLite db that gets cleared between test methods.
        /// </summary>
        [TestInitialize]
        public void SetDatabaseToTesting()
        {
            NHibernateHelper.SetToTesting();
        }

        [TestCleanup]
        public void ResetDatabase()
        {
            NHibernateHelper.ClearSessionFactory();
        }

        private User GetValidUser()
        {
            User NewUser = new User
            {
                Name = "Ime",
                Surname = "Prezime",
                Email = "adresa@email.hr",
                Password = "lozinka"
            };

            return NewUser;
        }


        [TestMethod]
        public void SignUpUserTest()
        {

            UserRepository.getInstance().SignUpUser(GetValidUser());

            Assert.AreEqual(1, UserRepository.getInstance().GetAllUsers().Count);
            
        }


        [TestMethod]
        [ExpectedException(typeof(UserExistsException))]
        public void SignUpUserTest_DuplicateEmail()
        {       
            UserRepository.getInstance().SignUpUser(GetValidUser());
            UserRepository.getInstance().SignUpUser(GetValidUser());
        }

        [TestMethod]
        public void LoginUserTest()
        {
            User TestUser = GetValidUser();

            UserRepository.getInstance().SignUpUser(TestUser);

            User LoggedInUser = UserRepository.getInstance().LoginUser(TestUser.Email, TestUser.Password);

            Assert.AreEqual(LoggedInUser.Name, TestUser.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchUserException))]
        public void LoginUser_NoUser()
        {
            User TestUser = GetValidUser();
            UserRepository.getInstance().LoginUser(TestUser.Email, TestUser.Password);
        }

        
    }
}
