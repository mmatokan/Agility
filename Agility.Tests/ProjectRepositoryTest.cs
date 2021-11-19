using Agility.DomainModel;
using Agility.SQLiteDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Agility.SQLiteDAL.Tests
{
    [TestClass]
    public class ProjectRepositoryTest
    {
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

        private Project GetValidProject()
        {
            List<User> Users = new List<User>();
            Users.Add(GetValidUser());

            Project NewProject = new Project
            {
                Name = "Ime projekta",
                Description = "Opis projekta",
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(30),
                Members = Users
            };

            return NewProject;
        }

        [TestMethod]
        public void AddNewProject()
        {
            Project TestProject = GetValidProject();

            User TestUser = TestProject.Members[0];

            ProjectRepository.getInstance().AddProject(TestProject);

            Assert.AreEqual(1, UserRepository.getInstance().GetUserProjects(TestUser).Count);

        }

        [TestMethod]
        [ExpectedException(typeof(ProjectExistsException))]
        public void AddNewProject_ProjectExists()
        {
            Project TestProject = GetValidProject();
            ProjectRepository.getInstance().AddProject(TestProject);
            ProjectRepository.getInstance().AddProject(TestProject);
        }

        [TestMethod]
        public void UpdateProject()
        {
            Project TestProject = GetValidProject();
            User TestUser = TestProject.Members[0];
            ProjectRepository.getInstance().AddProject(TestProject);

            Project ProjectWithId = UserRepository.getInstance().GetUserProjects(TestUser)[0];
            ProjectWithId.Name = "New name";

            ProjectRepository.getInstance().UpdateProject(ProjectWithId);

            Assert.AreEqual(1, UserRepository.getInstance().GetUserProjects(TestUser).Count);
            Assert.AreEqual("New name", UserRepository.getInstance().GetUserProjects(TestUser)[0].Name);
        }
    }
}
